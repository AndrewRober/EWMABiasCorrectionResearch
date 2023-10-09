namespace EWMABiasCorrectionResearch
{
    /// <summary>
    /// Static class for generating lists of points that follow various mathematical functions.
    /// </summary>
    public static class PointGenerator
    {
        /// <summary>
        /// Generates a list of points that follow a constant function, plus a random scatter.
        /// </summary>
        /// <param name="constantValue">The constant Y value for all points.</param>
        /// <param name="numPoints">The number of points to generate.</param>
        /// <param name="scatter">The range of the random scatter to add to the Y values. Defaults to 0.</param>
        /// <returns>A list of points that have Y values close to a constant value.</returns>
        /// <example>
        /// Here's how you can use this method:
        /// <code>
        /// var constantSeries = PointGenerator.GenerateConstantPoints(5.0f, 100, 0.5f);
        /// </code>
        /// </example>
        public static List<PointF> GenerateConstantPoints(float constantValue, int numPoints, float scatter = 0.0f)
        {
            var points = new List<PointF>();
            Random rand = new Random();

            for (int i = 0; i < numPoints; i++)
            {
                float y = constantValue + (float)(rand.NextDouble() - 0.5) * 2 * scatter;
                points.Add(new PointF(i, y));
            }

            return points;
        }

        /// <summary>
        /// Generates a list of points that follow a normal distribution (bell curve).
        /// </summary>
        /// <param name="mean">The mean of the normal distribution.</param>
        /// <param name="stdDev">The standard deviation of the normal distribution.</param>
        /// <param name="numPoints">The number of points to generate.</param>
        /// <returns>A list of points that follow a normal distribution.</returns>
        public static List<PointF> GenerateNormalDistributionPoints(float mean, float stdDev, int numPoints)
        {
            var points = new List<PointF>();
            var rand = new Random();
            for (int i = 0; i < numPoints; i++)
                points.Add(new PointF(i,
                    mean + stdDev * (float)(Math.Sqrt(-2.0 * Math.Log((1.0 - rand.NextDouble()))) * Math.Sin(2.0 * Math.PI * (1.0 - rand.NextDouble())))));
            return points;
        }

        /// <summary>
        /// Generates a list of points that follow an exponential function.
        /// </summary>
        /// <param name="baseValue">The base value for the exponential function.</param>
        /// <param name="numPoints">The number of points to generate.</param>
        /// <returns>A list of points that follow an exponential function.</returns>
        public static List<PointF> GenerateExponentialPoints(float baseValue, int numPoints)
        {
            var points = new List<PointF>();
            for (int i = 0; i < numPoints; i++)
                points.Add(new PointF(i, (float)Math.Pow(baseValue, i)));
            return points;
        }

        /// <summary>
        /// Generates a list of points that follow a sigmoid function.
        /// </summary>
        /// <param name="numPoints">The number of points to generate.</param>
        /// <returns>A list of points that follow a sigmoid function.</returns>
        public static List<PointF> GenerateSigmoidPoints(int numPoints)
        {
            var points = new List<PointF>();
            for (int i = 0; i < numPoints; i++)
            {
                float y = (float)(1 / (1 + Math.Exp(-(10f * i / (numPoints - 1) - 5f))));
                points.Add(new PointF(i, y));
            }
            return points;
        }

        /// <summary>
        /// Generates a list of points that follow a polynomial function.
        /// </summary>
        /// <param name="coeffs">The coefficients of the polynomial function, in ascending order of power.</param>
        /// <param name="numPoints">The number of points to generate.</param>
        /// <returns>A list of points that follow a polynomial function.</returns>
        public static List<PointF> GeneratePolynomialPoints(float[] coeffs, int numPoints)
        {
            var points = new List<PointF>();
            for (int i = 0; i < numPoints; i++)
            {
                float y = 0;
                for (int j = 0; j < coeffs.Length; j++)
                    y += coeffs[j] * (float)Math.Pow(i, j);
                points.Add(new PointF(i, y));
            }
            return points;
        }

        /// <summary>
        /// Generates a list of points with random Y values.
        /// </summary>
        /// <param name="numPoints">The number of points to generate.</param>
        /// <returns>A list of points with random Y values.</returns>
        public static List<PointF> GenerateRandomPoints(int numPoints)
        {
            var points = new List<PointF>();
            var rand = new Random();
            for (int i = 0; i < numPoints; i++)
                points.Add(new PointF(i, (float)rand.NextDouble()));
            return points;
        }

        /// <summary>
        /// Generates a list of points that follow a sinusoidal function.
        /// </summary>
        /// <param name="amplitude">The amplitude of the sine wave.</param>
        /// <param name="frequency">The frequency of the sine wave.</param>
        /// <param name="phase">The phase of the sine wave.</param>
        /// <param name="numPoints">The number of points to generate.</param>
        /// <returns>A list of points that follow a sinusoidal function.</returns>
        /// <example>
        /// Here's how you can use this method:
        /// <code>
        /// var sineSeries = PointGenerator.GenerateSineWavePoints(1.0f, 1.0f, 0.0f, 100);
        /// </code>
        /// </example>
        public static List<PointF> GenerateSineWavePoints(float amplitude, float frequency, float phase, int numPoints)
        {
            var points = new List<PointF>();

            for (int i = 0; i < numPoints; i++)
            {
                float x = 2f * (float)Math.PI * i / (numPoints - 1); // Scale i to [0, 2π]
                float y = amplitude * (float)Math.Sin(frequency * x + phase);
                points.Add(new PointF(i, y));
            }

            return points;
        }
    }
}
