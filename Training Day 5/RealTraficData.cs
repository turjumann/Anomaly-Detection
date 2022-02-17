using Microsoft.ML.Data;

namespace Training_Day_5
{
    internal class RealTraficData
    {
        [LoadColumn(0)]
        public string timeStamp { get; set; }

        [LoadColumn(1)]
        public float value { get; set; }
    }
}