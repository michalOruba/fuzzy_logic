namespace FuzzyLogicPrecipitation
{
    class FuzzyTrapeze : FuzzyFigure
    {
        private double value;
        private int firstMaximumIndex;
        private int lastMaksimumIndex;
        private double[] maximums;

        public FuzzyTrapeze(double value, int firstMaximumIndex, int lastMaksimumIndex, double[] maximums)
        {
            this.value = value;
            this.firstMaximumIndex = firstMaximumIndex;
            this.lastMaksimumIndex = lastMaksimumIndex;
            this.maximums = maximums;
        }
        public double calculate()
        {
            if ((value < maximums[firstMaximumIndex - 1]) || (value > maximums[lastMaksimumIndex + 1])) return 0;
            else if ((value >= maximums[firstMaximumIndex - 1]) && (value <= maximums[firstMaximumIndex]))
            {
                return ((value - maximums[firstMaximumIndex - 1]) / (maximums[firstMaximumIndex] - maximums[firstMaximumIndex - 1]));
            }
            else if ((value >= maximums[lastMaksimumIndex]) && (value <= maximums[lastMaksimumIndex + 1]))
            {
                return ((maximums[lastMaksimumIndex + 1] - value) / (maximums[lastMaksimumIndex + 1] - maximums[lastMaksimumIndex]));
            }
            else
            {
                return 1;
            }
        }
    }
}
