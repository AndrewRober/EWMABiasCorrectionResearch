namespace EWMABiasCorrectionResearch
{
    /// <summary>
    /// Static class for computing the loss between two series of points.
    /// </summary>
    public static class LossCalculator
    {
        /// <summary>
        /// Calculates the mean squared error (MSE) loss between two series of points.
        /// </summary>
        /// <param name="series1">The first series of points.</param>
        /// <param name="series2">The second series of points.</param>
        /// <returns>The MSE loss between the two input series.</returns>
        /// <example>
        /// Here's how you can use this method:
        /// <code>
        /// float loss = LossCalculator.MeanSquaredError(mySeries1, mySeries2);
        /// </code>
        /// </example>
        public static float MeanSquaredError(List<Point> series1, List<Point> series2)
        {
            if (series1.Count != series2.Count)
                throw new ArgumentException("Series must have the same length");

            if (series1.Count == 0)
                throw new ArgumentException("Series must have at least one point");

            float sumSquaredError = 0;

            for (int i = 0; i < series1.Count; i++)
            {
                float error = series1[i].Y - series2[i].Y;
                sumSquaredError += error * error;
            }

            return sumSquaredError / series1.Count;
        }

        /// <summary>
        /// Calculates the mean absolute error (MAE) loss between two series of points.
        /// </summary>
        /// <param name="series1">The first series of points.</param>
        /// <param name="series2">The second series of points.</param>
        /// <returns>The MAE loss between the two input series.</returns>
        public static float MeanAbsoluteError(List<Point> series1, List<Point> series2)
        {
            if (series1.Count != series2.Count)
                throw new ArgumentException("Series must have the same length");

            if (series1.Count == 0)
                throw new ArgumentException("Series must have at least one point");

            float sumAbsoluteError = 0;

            for (int i = 0; i < series1.Count; i++)
            {
                float error = Math.Abs(series1[i].Y - series2[i].Y);
                sumAbsoluteError += error;
            }

            return sumAbsoluteError / series1.Count;
        }

        /// <summary>
        /// Calculates the root mean squared error (RMSE) loss between two series of points.
        /// </summary>
        /// <param name="series1">The first series of points.</param>
        /// <param name="series2">The second series of points.</param>
        /// <returns>The RMSE loss between the two input series.</returns>
        public static float RootMeanSquaredError(List<Point> series1, List<Point> series2) => (float)Math.Sqrt(MeanSquaredError(series1, series2));

        /// <summary>
        /// Calculates the mean absolute percentage error (MAPE) loss between two series of points.
        /// </summary>
        /// <param name="series1">The first series of points.</param>
        /// <param name="series2">The second series of points.</param>
        /// <returns>The MAPE loss between the two input series.</returns>
        public static float MeanAbsolutePercentageError(List<Point> series1, List<Point> series2)
        {
            if (series1.Count != series2.Count)
                throw new ArgumentException("Series must have the same length");

            if (series1.Count == 0)
                throw new ArgumentException("Series must have at least one point");

            float sumAbsolutePercentageError = 0;

            for (int i = 0; i < series1.Count; i++)
            {
                if (series1[i].Y != 0)
                {
                    float error = Math.Abs((series1[i].Y - series2[i].Y) / series1[i].Y);
                    sumAbsolutePercentageError += error;
                }
            }

            return (sumAbsolutePercentageError / series1.Count) * 100;
        }

        /// <summary>
        /// Calculates all error metrics between two series of points.
        /// </summary>
        /// <param name="series1">The first series of points.</param>
        /// <param name="series2">The second series of points.</param>
        /// <returns>A named tuple containing the MSE, MAE, RMSE, and MAPE between the two input series.</returns>
        /// <exception cref="ArgumentException">Thrown when the two series do not have the same length.</exception>
        /// <example>
        /// Here's how you can use this method:
        /// <code>
        /// var errors = LossCalculator.CalculateAllErrors(mySeries1, mySeries2);
        /// Console.WriteLine($"MSE: {errors.MSE}, MAE: {errors.MAE}, RMSE: {errors.RMSE}, MAPE: {errors.MAPE}");
        /// </code>
        /// </example>
        public static (float MSE, float MAE, float RMSE, float MAPE) CalculateAllErrors(List<Point> series1, List<Point> series2)
        {
            if (series1.Count != series2.Count)
                throw new ArgumentException("Series must have the same length");

            if (series1.Count == 0)
                throw new ArgumentException("Series must have at least one point");

            return (MeanSquaredError(series1, series2), MeanAbsoluteError(series1, series2),
                RootMeanSquaredError(series1, series2), MeanAbsolutePercentageError(series1, series2));
        }
    }
}
