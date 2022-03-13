namespace Training_Day_5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDetectSpikeBySsa = new System.Windows.Forms.RadioButton();
            this.rbDetectIidSpike = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfidence = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLocate = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMethodType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.anomalyText = new System.Windows.Forms.RichTextBox();
            this.lblNumOfAnoms = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textPValue = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1504, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anomaly Detection";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textPValue);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtConfidence);
            this.panel2.Controls.Add(this.btnRun);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.btnLocate);
            this.panel2.Controls.Add(this.txtFilePath);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(37, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 402);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDetectSpikeBySsa);
            this.groupBox1.Controls.Add(this.rbDetectIidSpike);
            this.groupBox1.Location = new System.Drawing.Point(9, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 91);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detection Methods";
            // 
            // rbDetectSpikeBySsa
            // 
            this.rbDetectSpikeBySsa.AutoSize = true;
            this.rbDetectSpikeBySsa.Location = new System.Drawing.Point(6, 55);
            this.rbDetectSpikeBySsa.Name = "rbDetectSpikeBySsa";
            this.rbDetectSpikeBySsa.Size = new System.Drawing.Size(142, 20);
            this.rbDetectSpikeBySsa.TabIndex = 2;
            this.rbDetectSpikeBySsa.TabStop = true;
            this.rbDetectSpikeBySsa.Text = "DetectSpikeBySsa";
            this.rbDetectSpikeBySsa.UseVisualStyleBackColor = true;
            // 
            // rbDetectIidSpike
            // 
            this.rbDetectIidSpike.AutoSize = true;
            this.rbDetectIidSpike.Location = new System.Drawing.Point(7, 27);
            this.rbDetectIidSpike.Name = "rbDetectIidSpike";
            this.rbDetectIidSpike.Size = new System.Drawing.Size(116, 20);
            this.rbDetectIidSpike.TabIndex = 1;
            this.rbDetectIidSpike.TabStop = true;
            this.rbDetectIidSpike.Text = "DetectIidSpike";
            this.rbDetectIidSpike.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(108, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "(1 - 100)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confidence:";
            // 
            // txtConfidence
            // 
            this.txtConfidence.Location = new System.Drawing.Point(8, 314);
            this.txtConfidence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfidence.Name = "txtConfidence";
            this.txtConfidence.Size = new System.Drawing.Size(356, 22);
            this.txtConfidence.TabIndex = 8;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(8, 357);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(356, 38);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(9, 71);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Spike Detection";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnLocate
            // 
            this.btnLocate.Location = new System.Drawing.Point(291, 34);
            this.btnLocate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLocate.Name = "btnLocate";
            this.btnLocate.Size = new System.Drawing.Size(75, 32);
            this.btnLocate.TabIndex = 2;
            this.btnLocate.Text = "Locate";
            this.btnLocate.UseVisualStyleBackColor = true;
            this.btnLocate.Click += new System.EventHandler(this.btnLocate_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(9, 38);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(272, 22);
            this.txtFilePath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Table Path:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblMethodType);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.anomalyText);
            this.panel3.Controls.Add(this.lblNumOfAnoms);
            this.panel3.Location = new System.Drawing.Point(436, 89);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1105, 178);
            this.panel3.TabIndex = 2;
            // 
            // lblMethodType
            // 
            this.lblMethodType.AutoSize = true;
            this.lblMethodType.ForeColor = System.Drawing.Color.Red;
            this.lblMethodType.Location = new System.Drawing.Point(238, 13);
            this.lblMethodType.Name = "lblMethodType";
            this.lblMethodType.Size = new System.Drawing.Size(0, 16);
            this.lblMethodType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anomalies Detected:";
            // 
            // anomalyText
            // 
            this.anomalyText.Enabled = false;
            this.anomalyText.Location = new System.Drawing.Point(23, 39);
            this.anomalyText.Margin = new System.Windows.Forms.Padding(4);
            this.anomalyText.Name = "anomalyText";
            this.anomalyText.Size = new System.Drawing.Size(1063, 111);
            this.anomalyText.TabIndex = 4;
            this.anomalyText.Text = "";
            // 
            // lblNumOfAnoms
            // 
            this.lblNumOfAnoms.AutoSize = true;
            this.lblNumOfAnoms.BackColor = System.Drawing.Color.Transparent;
            this.lblNumOfAnoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfAnoms.ForeColor = System.Drawing.Color.Red;
            this.lblNumOfAnoms.Location = new System.Drawing.Point(211, 9);
            this.lblNumOfAnoms.Name = "lblNumOfAnoms";
            this.lblNumOfAnoms.Size = new System.Drawing.Size(0, 24);
            this.lblNumOfAnoms.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(37, 495);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 297);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(363, 254);
            this.dataGridView1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data View Preview:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.graph);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(436, 273);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1105, 519);
            this.panel5.TabIndex = 4;
            // 
            // graph
            // 
            chartArea2.AxisX.Title = "counter";
            chartArea2.AxisY.Maximum = 700D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "number";
            chartArea2.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea2);
            legendItem2.ImageStyle = System.Windows.Forms.DataVisualization.Charting.LegendImageStyle.Marker;
            legendItem2.MarkerBorderColor = System.Drawing.Color.DarkRed;
            legendItem2.MarkerBorderWidth = 0;
            legendItem2.MarkerColor = System.Drawing.Color.DarkRed;
            legendItem2.MarkerSize = 15;
            legendItem2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4;
            legendItem2.Name = "Spike";
            legend2.CustomItems.Add(legendItem2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.graph.Legends.Add(legend2);
            this.graph.Location = new System.Drawing.Point(23, 37);
            this.graph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graph.Name = "graph";
            this.graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.DimGray;
            series3.IsVisibleInLegend = false;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.graph.Series.Add(series3);
            this.graph.Series.Add(series4);
            this.graph.Size = new System.Drawing.Size(1064, 468);
            this.graph.TabIndex = 20;
            this.graph.Text = "graph";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Graph:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "pValueHistory:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(214, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "2 - 100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(128, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "( Size   /  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(280, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = ")";
            // 
            // textPValue
            // 
            this.textPValue.Location = new System.Drawing.Point(9, 255);
            this.textPValue.Name = "textPValue";
            this.textPValue.Size = new System.Drawing.Size(355, 22);
            this.textPValue.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 798);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Anomaly Detection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLocate;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfidence;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.RichTextBox anomalyText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumOfAnoms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDetectSpikeBySsa;
        private System.Windows.Forms.RadioButton rbDetectIidSpike;
        private System.Windows.Forms.Label lblMethodType;
        private System.Windows.Forms.TextBox textPValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}

