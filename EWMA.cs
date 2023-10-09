namespace EWMABiasCorrectionResearch
{
    /// <summary>
    /// Exponentially Weighted Moving Average (EWMA) class with bias correction.
    /// This class provides methods to compute EWMAs of a series of points.
    /// The bias correction is applied via a user-provided function.
    /// </summary>
    public class EWMAWithBiasCorrection
    {
        private Func<float, float, float, float> biasCorrection;
        private readonly float beta;
        private readonly float vInit;

        /// <summary>
        /// Constructor for the EWMA class.
        /// </summary>
        /// <param name="biasCorrection">A function that applies bias correction to a value.</param>
        public EWMAWithBiasCorrection(Func<float, float, float, float> biasCorrection, float beta, float vInit)
        {
            this.biasCorrection = biasCorrection;
            this.beta = beta;
            this.vInit = vInit;
        }

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
        public List<PointF> CalculateSeries(List<PointF> points)
        {
            List<PointF> result = new List<PointF>();
            float vPrev = this.vInit;

            for (int i = 0; i < points.Count; i++)
            {
                vPrev = (this.beta * vPrev) + ((1 - this.beta) * points[i].Y);
                result.Add(new PointF(points[i].X, biasCorrection(vPrev, this.beta, points[i].X)));
            }

            return result;
        }
    }

    public class EWMAWithoutBiasCorrection
    {
        private readonly float beta;

        public EWMAWithoutBiasCorrection(float beta) => this.beta = beta;

        public List<PointF> CalculateSeries(List<PointF> points)
        {
            List<PointF> result = new List<PointF>();
            float vPrev = 0;

            for (int i = 0; i < points.Count; i++)
            {
                vPrev = (this.beta * vPrev) + ((1 - this.beta) * points[i].Y);
                result.Add(new PointF(points[i].X, vPrev));
            }

            return result;
        }
    }
}
