namespace FuzzyLogicPrecipitation
{
    class FuzzyLeftTrapeze : FuzzyFigure
    {
        private double value;
        private int firstMaximumIndex;
        private int lastMaksimumIndex;
        private double[] maximums;

        public FuzzyLeftTrapeze (double value, int firstMaximumIndex, int lastMaksimumIndex, double[] maximums)
        {
            this.value = value;
            this.firstMaximumIndex = firstMaximumIndex;
            this.lastMaksimumIndex = lastMaksimumIndex;
            this.maximums = maximums;
        }
        public double calculate()
        {
            if (value <= maximums[lastMaksimumIndex]) return 1;
            else if (value >= maximums[lastMaksimumIndex + 1]) return 0;
            else
            {
                return ((value - maximums[lastMaksimumIndex + 1]) / (maximums[lastMaksimumIndex] - maximums[lastMaksimumIndex + 1]));
            }
        }
    }
}
