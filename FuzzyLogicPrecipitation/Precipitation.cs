using System;
using System.Collections.Generic;

namespace FuzzyLogicPrecipitation
{
    class Precipitation
    {
        public double low { get; set; }
        public double mediumLow { get; set; }
        public double medium { get; set; }
        public double mediumHigh { get; set; }
        public double high { get; set; }
        public static readonly double[] maximums = { 0, 5, 10, 15, 20, 25, 30 };

        public Precipitation(){}

        public static string choosePrecipitationName(int value)
        {
            switch (value)
            {
                case 1:
                    return "niskie";
                case 2:
                    return "średnio-niskie";
                case 3:
                    return "średnie";
                case 4:
                    return "średnio-wysokie";
                case 5:
                    return "wysokie";
                default:
                    return "błąd";
            }
        }

        public double[] createTableOfPrecipitationResultValues(Dictionary<int, double> maxOfPrecipitation)
        {
            double[] values = new double[7];
            foreach (KeyValuePair<int, double> keyValuePair in maxOfPrecipitation)
            {
                switch (keyValuePair.Key)
                {
                    case 1:
                        values[0] = keyValuePair.Value;
                        values[1] = keyValuePair.Value;
                        break;
                    case 2:
                        values[2] = keyValuePair.Value;
                        break;
                    case 3:
                        values[3] = keyValuePair.Value;
                        break;
                    case 4:
                        values[4] = keyValuePair.Value;
                        break;
                    case 5:
                        values[5] = keyValuePair.Value;
                        values[6] = keyValuePair.Value;
                        break;
                }
            }
            return values;
        }

        public double calculateCOG(double [] precipitationResultValues)
        {
            double nominator = 0.0;
            double denominator = 0.0;
            for (int i = 0; i < precipitationResultValues.Length; i++)
            {
                if (precipitationResultValues[i] > 0)
                {
                    nominator += precipitationResultValues[i] * maximums[i];
                    denominator += precipitationResultValues[i];
                }
            }
            return Math.Round(nominator /denominator, 2);
        }

        public double calculateMOM(double[] precipitationResultValues)
        {
            double maxValue = 0.0;
            double momValue = 0.0;
            for (int i = 0; i < precipitationResultValues.Length; i++)
            {
                if (precipitationResultValues[i] > maxValue)
                {
                    maxValue = precipitationResultValues[i];
                    momValue = maximums[i];
                }
                else if (precipitationResultValues[i] == maxValue)
                {
                    momValue = (momValue + maximums[i]) / 2;
                }
            }
            return Math.Round(momValue, 2);
        }
    }
}