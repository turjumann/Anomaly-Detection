using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using Microsoft.ML;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.ML.Transforms.TimeSeries;

namespace Training_Day_5
{
    public partial class Form1 : Form
    {
        private string filePath = "";
        Dictionary<int, Tuple<string, string>> dict = new Dictionary<int, Tuple<string, string>>();
        private DataTable dataTable = null;
        Tuple<string, string> tup = null;

        public int numOfEntries;
        public double confidence;
        public Form1()
        {
            InitializeComponent();
            checkBox1.Checked = true;
        }



        private void btnLocate_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            txtFilePath.Text = ofd.FileName;
            BindDataCSV(txtFilePath.Text);
            var length = System.IO.File.ReadAllLines(ofd.FileName).Length + "";
            var lengthWOHeaders = Int32.Parse(length) - 1;
            numOfEntries = lengthWOHeaders;
            label10.Text = " ( " + numOfEntries.ToString() + "  /  ";


        }

        private void BindDataCSV(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            anomalyText.Enabled = true;
            filePath = txtFilePath.Text;

            if (File.Exists(filePath))
            {
                dict = new Dictionary<int, Tuple<string, string>>();

                if (filePath != "")
                {
                    anomalyText.Text = "";
                    displayDataTableAndGraph();
                }
                else
                {
                    MessageBox.Show("Please input file path.");
                }
            }
            else
            {
                MessageBox.Show("File does not exist. Try finding the file again.");
            }

            if (checkBox1.Checked)
            {
                if (rbDetectIidSpike.Checked && textPValue.Text != "" && txtConfidence.Text != "")
                {
                    detectIidSpike();
                    lblMethodType.Text = " using " + rbDetectIidSpike.Text + " method";
                }
                else if (rbDetectSpikeBySsa.Checked && textPValue.Text != "" && txtConfidence.Text != "")
                {
                    detectSpikeBySsa();
                    lblMethodType.Text = " using " + rbDetectSpikeBySsa.Text + " method";

                }

                else
                {
                    MessageBox.Show("Make sure input fields are not empty and detection method is checked", "Something is missing...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Make sure to click on Spike Detection checkbox.", "Spike Detection...",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


 

        private void detectSpikeBySsa()
        {
            const int SeasonalitySize = 5;
            const int TrainingSeasons = 3;
            const int TrainingSize = SeasonalitySize * TrainingSeasons;

            var mlContext = new MLContext();
            int size = numOfEntries;


            // Load Data
            var dataView = mlContext.Data.LoadFromTextFile<RealTraficData>(txtFilePath.Text, hasHeader: true, separatorChar: ',');
            var travelTimeList = new List<RealTraficData>();
            var emptyDataView = mlContext.Data.LoadFromEnumerable(travelTimeList);
            var outputColumnName = nameof(RealTraficPrediction.Prediction);
            var inputColumnName = nameof(RealTraficData.value);
            confidence = Convert.ToDouble(txtConfidence.Text);

            var pvalueHistoryLength = size / int.Parse(textPValue.Text);


            var estimator = mlContext.Transforms.DetectSpikeBySsa(outputColumnName,
            inputColumnName, confidence, pvalueHistoryLength, TrainingSize, SeasonalitySize + 1);

            var transformedModel = estimator.Fit(emptyDataView);


            var transformData = transformedModel.Transform(dataView);
            var predictions = mlContext.Data.CreateEnumerable<RealTraficPrediction>(transformData, reuseRowObject: false);



            int a = 0;
            var counter = 0;

            foreach (var prediction in predictions)
            {

                if (prediction.Prediction[0] == 1)
                {
                    counter++;
                    var xAxisDate = dict[a].Item1;
                    var yAxisSalesNum = dict[a].Item2;


                    graph.Series["Series1"].Points[a].SetValueXY(a, yAxisSalesNum);
                    graph.Series["Series1"].Points[a].MarkerStyle = MarkerStyle.Star4;
                    graph.Series["Series1"].Points[a].MarkerSize = 10;
                    graph.Series["Series1"].Points[a].MarkerColor = Color.DarkRed;

                    string text = "Spike" + " detected in " + xAxisDate + ": " + yAxisSalesNum + "\n";
                    anomalyText.SelectionColor = Color.Red;
                    anomalyText.AppendText(text);

                    DataGridViewRow row = dataGridView1.Rows[a];
                    row.DefaultCellStyle.BackColor = Color.DarkRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                a++;
            }
            lblNumOfAnoms.Text = counter.ToString();
        }


        private void detectIidSpike()
        {


            // Define Vars
            var mlContext = new MLContext();
            int size = numOfEntries;
            confidence = Convert.ToDouble(txtConfidence.Text);

            // Load Data
            var dataView = mlContext.Data.LoadFromTextFile<RealTraficData>(txtFilePath.Text, hasHeader: true, separatorChar: ',');
            var travelTimeList = new List<RealTraficData>();
            var emptyDataView = mlContext.Data.LoadFromEnumerable(travelTimeList);

            var estimator = mlContext.Transforms.DetectIidSpike(
                outputColumnName: nameof(RealTraficPrediction.Prediction),
                inputColumnName: nameof(RealTraficData.value),
                confidence, pvalueHistoryLength: size / int.Parse(textPValue.Text));
            var transformedModel = estimator.Fit(emptyDataView);


            var transformData = transformedModel.Transform(dataView);

            var predictions = mlContext.Data.CreateEnumerable<RealTraficPrediction>(transformData, reuseRowObject: false);



            int a = 0;
            var counter = 0;

            foreach (var prediction in predictions)
            {

                if (prediction.Prediction[0] == 1)
                {
                    counter++;
                    var xAxisDate = dict[a].Item1;
                    var yAxisSalesNum = dict[a].Item2;


                    graph.Series["Series1"].Points[a].SetValueXY(a, yAxisSalesNum);
                    graph.Series["Series1"].Points[a].MarkerStyle = MarkerStyle.Star4;
                    graph.Series["Series1"].Points[a].MarkerSize = 10;
                    graph.Series["Series1"].Points[a].MarkerColor = Color.DarkRed;

                    string text = "Spike" + " detected in " + xAxisDate + ": " + yAxisSalesNum + "\n";
                    anomalyText.SelectionColor = Color.Red;
                    anomalyText.AppendText(text);

                    DataGridViewRow row = dataGridView1.Rows[a];
                    row.DefaultCellStyle.BackColor = Color.DarkRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                a++;
            }
            lblNumOfAnoms.Text = counter.ToString();
        }
        private void displayDataTableAndGraph()
        {
            dataTable = new DataTable();
            string[] dataCol = null;
            int a = 0;
            string xAxis = "";
            string yAxis = "";

            string[] dataset = File.ReadAllLines(filePath);
            dataCol =  dataset[0].Split(',');

            dataTable.Columns.Add(dataCol[0]);
            dataTable.Columns.Add(dataCol[1]);
            xAxis = dataCol[0];
            yAxis = dataCol[1];

            foreach (string line in dataset.Skip(1))
            {
                // Add next row of data.
                dataCol = line.Split(',');
                dataTable.Rows.Add(dataCol);

                tup = new Tuple<string, string>(dataCol[0], dataCol[1]);
                dict.Add(a, tup);

                a++;
            }

            
            dataGridView1.DataSource = dataTable;

            
            double yMax = Convert.ToDouble(dataTable.Compute($"max([{yAxis}])", string.Empty));
            double yMin = Convert.ToDouble(dataTable.Compute($"min([{yAxis}])", string.Empty));
            Console.WriteLine("yMin: " + yMin + " yMax: " + yMax);


            graph.DataSource = dataTable;

            
            graph.Series["Series1"].ChartType = SeriesChartType.Line;

            graph.Series["Series1"].XValueMember = xAxis;
            graph.Series["Series1"].YValueMembers = yAxis;

            graph.Legends["Legend1"].Enabled = true;

            graph.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            graph.ChartAreas["ChartArea1"].AxisX.Interval = a / 10;

            graph.ChartAreas["ChartArea1"].AxisY.Maximum = yMax;

            graph.ChartAreas["ChartArea1"].AxisY.Minimum = yMin;
            graph.ChartAreas["ChartArea1"].AxisY.Interval = yMax / 10;


            graph.DataBind();

        }


       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
