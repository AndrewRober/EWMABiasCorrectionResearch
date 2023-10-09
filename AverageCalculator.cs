namespace EWMABiasCorrectionResearch
{
    /// <summary>
    /// Static class for calculating the actual averages of a series of points.
    /// </summary>
    public static class AverageCalculator
    {
        /// <summary>
        /// Calculates the actual average for a series of points.
        /// </summary>
        /// <param name="points">A list of points for which to calculate the average.</param>
        /// <returns>A list of points where the Y values are the actual average of the corresponding input points.</returns>
        /// <example>
        /// Here's how you can use this method:
        /// <code>
        /// var averageSeries = AverageCalculator.CalculateSeries(myPoints);
        /// </code>
        /// </example>
        public static List<Point> CalculateSeries(List<Point> points)
        {
            float sum = 0;
            var averages = new List<Point>();

            for (int i = 0; i < points.Count; i++)
            {
                sum += points[i].Y;
                float average = sum / (i + 1);
                averages.Add(new Point(i, average));
            }

            return averages;
        }
    }
}
