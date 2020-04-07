namespace FuzzyLogicPrecipitation
{
    class Cloudy
    {
        public double cloudless { get; set; }
        public double small { get; set; }
        public double cloudy { get; set; }
        public double complete { get; set; }
        private double cloudyPercent;
        private double[] maximums = {0, 0.125, 0.25, 0.375, 0.5, 0.625, 0.75, 0.875, 1};

        public Cloudy (double cloudyPercent)
        {
            this.cloudyPercent = cloudyPercent / 100;
            this.cloudless = calculateLeftTrapeze(this.cloudyPercent, 0, 1, maximums);
            this.small = calculateTrapeze(this.cloudyPercent, 2, 4, maximums);
            this.cloudy = calculateTrapeze(this.cloudyPercent, 5, 6, maximums);
            this.complete = calculateRightTrapeze(this.cloudyPercent, 7, 8, maximums);
        }

        public double selectCloudyLevelValue(int cloudyLevel)
        {
            switch (cloudyLevel)
            {
                case 1:
                    return cloudless;
                case 2:
                    return small;
                case 3:
                    return cloudy;
                case 4:
                    return complete;
                default:
                    return 0.0;
            }
        }

        public static string chooseCloudyName(int value)
        {
            switch (value)
            {
                case 1:
                    return "bezchmurno";
                case 2:
                    return "małe";
                case 3:
                    return "pochmurno";
                case 4:
                    return "całkowite";
                default:
                    return "błąd";
            }
        }

        private double calculateLeftTrapeze(double cloudyPercent, int firstMaximumIndex, int lastMaximumIndex, double[] maximums)
        {
            FuzzyFigure fuzzyFigure = new FuzzyLeftTrapeze(cloudyPercent, firstMaximumIndex, lastMaximumIndex, maximums);
            return fuzzyFigure.calculate();
        }

        private double calculateTrapeze(double cloudyPercent, int firstMaximumIndex, int lastMaximumIndex, double[] maximums)
        {
            FuzzyFigure fuzzyFigure = new FuzzyTrapeze(cloudyPercent, firstMaximumIndex, lastMaximumIndex, maximums);
            return fuzzyFigure.calculate();
        }
        
        private double calculateRightTrapeze(double cloudyPercent, int firstMaximumIndex, int lastMaximumIndex, double[] maximums)
        {
            FuzzyFigure fuzzyFigure = new FuzzyRightTrapeze(cloudyPercent, firstMaximumIndex, lastMaximumIndex, maximums);
            return fuzzyFigure.calculate();
        }
    }
}
