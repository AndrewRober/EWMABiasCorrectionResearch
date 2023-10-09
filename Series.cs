namespace EWMABiasCorrectionResearch
{
    public class Series
    {
        public List<PointF> Points { get; }
        public Color Color { get; }
        public ChartType ChartType { get; }
        public string Description { get; }
        public float Width { get; }
        public SeriesType SeriesType { get; }

        public Series(List<PointF> points, Color color, ChartType chartType,
            string description, float width, SeriesType seriesType)
        {
            Points = points;
            Color = color;
            ChartType = chartType;
            Description = description;
            Width = width;
            SeriesType = seriesType;
        }
    }
}
