namespace FuzzyLogicPrecipitation
{
    class FuzzyTriangle : FuzzyFigure
    {
        private double value;
        private int maximumIndex;
        private double[] maximums;

        public FuzzyTriangle(double value, int maximumIndex,  double[] maximums)
        {
            this.value = value;
            this.maximumIndex = maximumIndex;
            this.maximums = maximums;
        }
        public double calculate()
        {
            if ((value <= maximums[maximumIndex - 1]) || (value >= maximums[maximumIndex + 1])) return 0;
            else if (value == maximums[maximumIndex]) return 1;
            else if ((value > maximums[maximumIndex - 1]) && (value < maximums[maximumIndex]))
            {
                return ((value - maximums[maximumIndex - 1]) / (maximums[maximumIndex] - maximums[maximumIndex - 1]));
            }
            else
            {
                return ((maximums[maximumIndex + 1] - value) / (maximums[maximumIndex + 1] - maximums[maximumIndex]));
            }
        }
    }
}
