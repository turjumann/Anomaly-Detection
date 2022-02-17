using Microsoft.ML.Data;

namespace Training_Day_5
{
    internal class RealTraficPrediction
    {
        [VectorType(3)]
        public double[] Prediction { get; set; }
    }
}