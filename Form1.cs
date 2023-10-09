using System.Collections.Generic;

namespace EWMABiasCorrectionResearch
{
    public partial class Form1 : Form
    {
        public const int Padding = 30;
        private List<Color> colors = new()
        {
            Color.DarkRed, Color.DarkBlue, Color.DarkGreen, Color.DarkOrange,
            Color.DarkViolet, Color.DarkCyan, Color.DarkMagenta, Color.DarkGray,
            Color.DarkOliveGreen, Color.DarkGoldenrod, Color.DarkSeaGreen,
            Color.DarkSlateBlue, Color.DarkSlateGray, Color.DarkTurquoise,
            Color.IndianRed, Color.Maroon, Color.Navy, Color.MidnightBlue,
            Color.Chocolate, Color.SaddleBrown, Color.Indigo
        };
        private List<Series> _seriesList;

        public List<Series> SeriesList
        {
            get => _seriesList;
            set
            {
                _seriesList = value;
                pictureBox1.Invalidate();
            }
        }

        public Form1() => InitializeComponent();



        private void CPGenrateBtn_Click(object sender, EventArgs e)
        {
            var MainSeries = SeriesList.FirstOrDefault(s => s.ChartType == ChartType.Scatter);
            if (MainSeries != null)
                SeriesList.Remove(MainSeries);
            SeriesList.Add(PointGenerator.GenerateConstantPoints((float)CPc_NBx.Value,
                (int)CPn_NBx.Value, (float)CPs_NBx.Value));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawGridAndAxis(g);

            if (SeriesList != null)
            {
                foreach (var series in SeriesList)
                {
                    DrawSeries(g, series.Points, series.ChartType, 5, series.Color);
                }
            }

            // Draw the legend in the top-right corner
            for (int i = 0; i < SeriesList.Count; i++)
            {
                Series series = SeriesList[i];
                g.FillEllipse(new SolidBrush(series.Color), new RectangleF(pictureBox1.Width - 100, 30 + i * 20, 10, 10));
                g.DrawString(series.Description, this.Font, Brushes.Black, new PointF(pictureBox1.Width - 85, 30 + i * 20));
            }
        }

        /// <summary>
        /// Draws a series of points.
        /// </summary>
        /// <param name="g">The Graphics object to use for drawing.</param>
        /// <param name="series">The series of points to draw.</param>
        /// <param name="chartType">The type of chart to draw (line or scatter).</param>
        /// <param name="width">The width of the lines or circles to draw.</param>
        /// <param name="color">The color of the lines or circles to draw.</param>
        public void DrawSeries(Graphics g, List<PointF> series, ChartType chartType, float width, Color color)
        {
            int pictureBoxWidth = pictureBox1.Width;
            int pictureBoxHeight = pictureBox1.Height;

            float maxX = series.Max(point => point.X);
            float maxY = 1000;

            using (Pen pen = new Pen(color, width))
            {
                // If it's a line chart, draw lines between the points
                if (chartType == ChartType.Line && series.Count > 1)
                {
                    for (int i = 0; i < series.Count - 1; i++)
                    {
                        PointF pt1 = PointTranslator.TranslatePoint(series[i], maxX, maxY, pictureBoxWidth, pictureBoxHeight);
                        PointF pt2 = PointTranslator.TranslatePoint(series[i + 1], maxX, maxY, pictureBoxWidth, pictureBoxHeight);
                        g.DrawLine(pen, pt1, pt2);
                    }
                }

                // If it's a scatter chart, draw circles at the points
                if (chartType == ChartType.Scatter)
                {
                    foreach (PointF pt in series)
                    {
                        PointF translatedPt = PointTranslator.TranslatePoint(pt, maxX, maxY, pictureBoxWidth, pictureBoxHeight);
                        g.DrawEllipse(pen, translatedPt.X - width / 2, translatedPt.Y + width / 2, width, width);
                    }
                }
            }
        }

        private void DrawGridAndAxis(Graphics g)
        {
            int arrowSize = 10; // Size of the arrow heads

            int xAxisSize = pictureBox1.Width - 2 * Form1.Padding;
            int yAxisSize = pictureBox1.Height - 2 * Form1.Padding;

            // Adjusted axis
            PointF origin = new PointF(Form1.Padding, pictureBox1.Height - Form1.Padding);
            PointF xEnd = new PointF(Form1.Padding + xAxisSize, pictureBox1.Height - Form1.Padding);
            PointF yEnd = new PointF(Form1.Padding, pictureBox1.Height - Form1.Padding - yAxisSize);

            // Draw axis with padding
            g.DrawLine(Pens.Black, origin, xEnd); // X-axis
            g.DrawLine(Pens.Black, origin, yEnd); // Y-axis

            // Draw arrows
            g.DrawLine(Pens.Black, xEnd, new PointF(xEnd.X - arrowSize, xEnd.Y - arrowSize));
            g.DrawLine(Pens.Black, xEnd, new PointF(xEnd.X - arrowSize, xEnd.Y + arrowSize));
            g.DrawLine(Pens.Black, yEnd, new PointF(yEnd.X - arrowSize, yEnd.Y + arrowSize));
            g.DrawLine(Pens.Black, yEnd, new PointF(yEnd.X + arrowSize, yEnd.Y + arrowSize));

            // Draw gridlines
            Pen gridPen = new Pen(Color.LightGray, 1);
            for (int i = 10; i < 100; i += 10)
            {
                int x = i * xAxisSize / 100 + Form1.Padding;
                int y = pictureBox1.Height - i * yAxisSize / 100 - Form1.Padding;
                g.DrawLine(gridPen, x, pictureBox1.Height - Form1.Padding, x, pictureBox1.Height - Form1.Padding - yAxisSize); // vertical line
                g.DrawLine(gridPen, Form1.Padding, y, Form1.Padding + xAxisSize, y); // horizontal line
            }

            // Draw scale with padding
            for (int i = 0; i <= 100; i += 10)
            {
                int x = i * xAxisSize / 100 + Form1.Padding;
                int y = pictureBox1.Height - i * yAxisSize / 100 - Form1.Padding;
                g.DrawString(i.ToString(), this.Font, Brushes.Black, new PointF(x, pictureBox1.Height - Form1.Padding)); // X-axis scale
                g.DrawString((i * 10).ToString(), this.Font, Brushes.Black, new PointF(Form1.Padding, y)); // Y-axis scale
            }
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (SeriesList.Count == 0)
            {
                return;
            }
            PointF mousePoint = new PointF(e.X, e.Y);

            float maxX = SeriesList.Max(series => series.Points.Max(point => point.X));
            float maxY = 1000;

            // Translate the mouse point to the original coordinate system
            PointF mousePointInOriginalCoordinates = PointTranslator.ReverseTranslatePoint(mousePoint, maxX, maxY, pictureBox1.Width, pictureBox1.Height);

            // Find the point that's closest to the mouse position among all series
            PointF? nearestPoint = null;
            double nearestDistance = double.PositiveInfinity;

            foreach (Series series in SeriesList)
            {
                foreach (PointF point in series.Points)
                {
                    double distance = Math.Sqrt(Math.Pow(point.X - mousePointInOriginalCoordinates.X, 2) + Math.Pow(point.Y - mousePointInOriginalCoordinates.Y, 2));

                    if (distance < nearestDistance)
                    {
                        nearestPoint = point;
                        nearestDistance = distance;
                    }
                }
            }

            // If the nearest point is within a certain threshold, show a tooltip for it
            if (nearestPoint.HasValue && nearestDistance < 10)
            {
                toolTip1.SetToolTip(pictureBox1, $"X: {nearestPoint.Value.X}, Y: {nearestPoint.Value.Y}");
            }
            else
            {
                toolTip1.SetToolTip(pictureBox1, string.Empty);
            }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {

        }
    }

    public enum ChartType
    {
        Line,
        Scatter
    }

    public class Series
    {
        public List<PointF> Points { get; set; }
        public Color Color { get; set; }
        public ChartType ChartType { get; set; }
        public string Description { get; set; }

        public Series(List<PointF> points, Color color, ChartType chartType, string description)
        {
            Points = points;
            Color = color;
            ChartType = chartType;
            Description = description;
        }
    }
}
