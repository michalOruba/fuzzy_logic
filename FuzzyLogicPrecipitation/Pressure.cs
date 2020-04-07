namespace FuzzyLogicPrecipitation
{
    class Pressure
    {
        public double low { get; set; }
        public double medium { get; set; }
        public double high { get; set; }
        private int pressure;
        private double[] maximums = { 970, 1000, 1010, 1020, 1050};

        public Pressure(int pressure)
        {
            this.pressure = pressure;
            this.low = calculateLeftTrapeze(this.pressure, 0, 1, maximums);
            this.medium = calculateTriangle(this.pressure, 2, maximums);
            this.high = calculateRightTrapeze(this.pressure, 3, 4, maximums);
        }

        public double selectPressureLevelValue(int pressureLevel)
        {
            switch (pressureLevel)
            {
                case 1:
                    return low;
                case 2:
                    return medium;
                case 3:
                    return high;
                default:
                    return 0.0;
            }
        }

        public static string choosePressureName(int value)
        {
            switch (value)
            {
                case 1:
                    return "niskie";
                case 2:
                    return "umiarkowane";
                case 3:
                    return "wysokie";
                default:
                    return "błąd";
            }
        }

        private double calculateRightTrapeze(int pressure, int firstMaximumIndex, int lastMaximumIndex, double[] maximums)
        {
            FuzzyFigure fuzzyFigure = new FuzzyRightTrapeze(pressure, firstMaximumIndex, lastMaximumIndex, maximums);
            return fuzzyFigure.calculate();
        }

        private double calculateLeftTrapeze(int pressure, int firstMaximumIndex, int lastMaximumIndex, double[] maximums)
        {
            FuzzyFigure fuzzyFigure = new FuzzyLeftTrapeze(pressure, firstMaximumIndex, lastMaximumIndex, maximums);
            return fuzzyFigure.calculate();
        }

        private double calculateTriangle(int pressure, int maximumIndex, double[] maximums)
        {
            FuzzyFigure fuzzyFigure = new FuzzyTriangle(pressure, maximumIndex, maximums);
            return fuzzyFigure.calculate();
        }
    }
}
