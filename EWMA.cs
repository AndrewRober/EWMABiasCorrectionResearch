namespace EWMABiasCorrectionResearch
{
    /// <summary>
    /// Exponentially Weighted Moving Average (EWMA) class with bias correction.
    /// This class provides methods to compute EWMAs of a series of points.
    /// The bias correction is applied via a user-provided function.
    /// </summary>
    public class EWMA
    {
        private Func<float, float> biasCorrection;

        /// <summary>
        /// Constructor for the EWMA class.
        /// </summary>
        /// <param name="biasCorrection">A function that applies bias correction to a value.</param>
        public EWMA(Func<float, float> biasCorrection) => this.biasCorrection = biasCorrection;

        /// <summary>
        /// Calculates the Exponentially Weighted Moving Average (EWMA) of a single point.
        /// </summary>
        /// <param name="vPrev">The previously calculated EWMA value, or the initial value for the first point.</param>
        /// <param name="beta">The decay factor for the EWMA.</param>
        /// <param name="currentY">The Y value of the current point.</param>
        /// <returns>The EWMA of the current point.</returns>
        /// <example>
        /// Here's how you can use this method:
        /// <code>
        /// var ewma = new EWMA(myBiasCorrectionFunction);
        /// float ewmaValue = ewma.Calculate(previousEWMA, 0.9f, currentPoint.Y);
        /// </code>
        /// </example>
        private float Calculate(float vPrev, float beta, float currentY) => biasCorrection((beta * vPrev) + ((1 - beta) * currentY));

        /// <summary>
        /// Calculates the Exponentially Weighted Moving Average (EWMA) for a series of points.
        /// </summary>
        /// <param name="points">A list of points for which to calculate the EWMA.</param>
        /// <param name="beta">The decay factor for the EWMA.</param>
        /// <param name="vInit">The initial value for the first point's EWMA calculation.</param>
        /// <returns>A list of points where the Y values are the EWMA of the corresponding input points.</returns>
        /// <example>
        /// Here's how you can use this method:
        /// <code>
        /// var ewma = new EWMA(myBiasCorrectionFunction);
        /// var ewmaSeries = ewma.CalculateSeries(myPoints, 0.9f, initialValue);
        /// </code>
        /// </example>
        public List<Point> CalculateSeries(List<Point> points, float beta, float vInit = 0.0f)
        {
            List<Point> result = new List<Point>();
            float vPrev = vInit;

            for (int i = 0; i < points.Count; i++)
            {
                vPrev = Calculate(vPrev, beta, points[i].Y);
                result.Add(new Point(points[i].X, vPrev));
            }

            return result;
        }
    }
}
