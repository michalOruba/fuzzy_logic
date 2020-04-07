namespace FuzzyLogicPrecipitation
{
    class FuzzyRightTrapeze : FuzzyFigure
    {
        private double value;
        private int firstMaximumIndex;
        private int lastMaksimumIndex;
        private double[] maximums;

        public FuzzyRightTrapeze(double value, int firstMaximumIndex, int lastMaksimumIndex, double[] maximums)
        {
            this.value = value;
            this.firstMaximumIndex = firstMaximumIndex;
            this.lastMaksimumIndex = lastMaksimumIndex;
            this.maximums = maximums;
        }

        public double calculate()
        {
            if (value <= maximums[firstMaximumIndex - 1]) return 0;
            else if (value >= maximums[firstMaximumIndex]) return 1;
            else
            {
                return ((value - maximums[firstMaximumIndex - 1]) / (maximums[firstMaximumIndex] - maximums[firstMaximumIndex - 1]));
            }
        }
    }
}
