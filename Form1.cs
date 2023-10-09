using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace EWMABiasCorrectionResearch
{
    public partial class Form1 : Form
    {
        #region Properties and fields
        private float trialBeta = 0.80f;
        private int numberOfPoints = 100;
        private float seriesWidth = 5.0f;

        public const int SeriesPadding = 30;
        private List<Series> _seriesList;
        private EWMAWithoutBiasCorrection standardEWMAWithoutBiasCorrection =
            new EWMAWithoutBiasCorrection(0.9f);
        private EWMAWithBiasCorrection standardEWMAHighBetaZeroInitial =
            new EWMAWithBiasCorrection((Vt, Beta, index) => Vt / (1 - (float)Math.Pow(Beta, index + 1)), 0.9f, 0.0f);

        public List<Series> SeriesList
        {
            get => _seriesList;
            set
            {
                _seriesList = value;
                pictureBox1.Invalidate();
            }
        }

        public float TrialBeta
        {
            get => trialBeta; set
            {
                trialBeta = value;
                ReDraw();
            }
        }
        #endregion

        public Form1() => InitializeComponent();

        public void ReDraw()
        {
            standardEWMAWithoutBiasCorrection = new EWMAWithoutBiasCorrection(TrialBeta);
            standardEWMAHighBetaZeroInitial = new EWMAWithBiasCorrection((Vt, Beta, index) => Vt / (1 - (float)Math.Pow(Beta, index + 1)), TrialBeta, 0.0f);
            foreach (var series in SeriesList.ToList())
            {
                if (series.ChartType == ChartType.Line)
                    continue;

                SeriesList.RemoveAll(s => s.SeriesType != series.SeriesType);
                GenerateAverages(series);
            }
            pictureBox1.Invalidate();
        }


        private void GenerateCP(object sender, EventArgs e)
        {
            GenerateInternal(new Series(PointGenerator.GenerateConstantPoints((float)CPc_NBx.Value,
                (int)NumOfPoints_NBx.Value, (float)CPs_NBx.Value), ColorPbx.BackColor,
                ChartType.Scatter, DescTbx.Text, (float)WidthNbx.Value, SeriesType.Constant));
        }

        private void GenerateExp(object sender, EventArgs e)
        {
            GenerateInternal(new Series(PointGenerator.GenerateExponentialPoints((float)ExpB_NBx.Value,
                (int)NumOfPoints_NBx.Value), ColorPbx.BackColor,
                ChartType.Scatter, DescTbx.Text, (float)WidthNbx.Value, SeriesType.NormalDistribution));
        }

        private void GenerateSigmoid(object sender, EventArgs e)
        {
            GenerateInternal(new Series(PointGenerator.GenerateSigmoidPoints((int)NumOfPoints_NBx.Value), ColorPbx.BackColor,
                ChartType.Scatter, DescTbx.Text, (float)WidthNbx.Value, SeriesType.Sigmoid));
        }

        private void GenerateInternal(Series series)
        {
            CleanSeries();
            SeriesList.Add(series);
            GenerateAverages(series);
            pictureBox1.Invalidate();
        }

        private void CleanSeries()
        {
            if (SeriesList != null)
                SeriesList.Clear();
            else
                SeriesList = new List<Series>();
        }

        private void GenerateAverages(Series series)
        {
            SeriesList.Add(GenerateAverageSeries(series));
            SeriesList.Add(new Series(standardEWMAHighBetaZeroInitial.CalculateSeries(series.Points),
                Color.Orange, ChartType.Line, "EWMA Vt/1+β**t, β= 0.90, V₀= 0", 6, SeriesType.EWMAWithBias));
            SeriesList.Add(new Series(standardEWMAWithoutBiasCorrection.CalculateSeries(series.Points),
                Color.Yellow, ChartType.Line, "EWMA no bias, β= 0.90, V₀= 0", 4, SeriesType.EWMAWithoutBias));
        }

        private Series GenerateAverageSeries(Series series) => new Series(AverageCalculator.CalculateSeries(series.Points),
                Color.Green, ChartType.Line, "Actual Average", 4, SeriesType.Average);

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            DrawGrid(g);

            if (SeriesList != null)
                foreach (var series in SeriesList)
                    DrawSeries(g, series);

            // Draw the legend in the top-right corner
            for (int i = 0; i < SeriesList?.Count; i++)
            {
                Series series = SeriesList[i];
                g.FillEllipse(new SolidBrush(series.Color), new RectangleF(pictureBox1.Width - 200, i * 20, 10, 10));
                g.DrawString(series.Description, this.Font, Brushes.Black, new PointF(pictureBox1.Width - 185, i * 20));
            }

            DrawAxis(g);
        }

        /// <summary>
        /// Draws a series of points.
        /// </summary>
        /// <param name="g">The Graphics object to use for drawing.</param>
        /// <param name="series">The series of points to draw.</param>
        public void DrawSeries(Graphics g, Series series)
        {
            int pictureBoxWidth = pictureBox1.Width;
            int pictureBoxHeight = pictureBox1.Height;

            float maxX = 100;
            float maxY = 1000;

            using (Pen pen = new Pen(series.Color, series.Width))
            {
                // If it's a line chart, draw lines between the points
                if (series.ChartType == ChartType.Line && series.Points.Count > 1)
                {
                    for (int i = 0; i < series.Points.Count - 1; i++)
                    {
                        PointF pt1 = PointTranslator.TranslatePoint(series.Points[i], maxX, maxY, pictureBoxWidth, pictureBoxHeight);
                        PointF pt2 = PointTranslator.TranslatePoint(series.Points[i + 1], maxX, maxY, pictureBoxWidth, pictureBoxHeight);
                        g.DrawLine(pen, pt1, pt2);
                    }
                }

                // If it's a scatter chart, draw circles at the points
                if (series.ChartType == ChartType.Scatter)
                {
                    foreach (PointF pt in series.Points)
                    {
                        PointF translatedPt = PointTranslator.TranslatePoint(pt, maxX, maxY, pictureBox1.Width, pictureBox1.Height);
                        g.DrawEllipse(pen, translatedPt.X - series.Width / 2, translatedPt.Y - series.Width / 2, series.Width, series.Width);
                    }
                }
            }
        }

        private void DrawGrid(Graphics g)
        {
            int xAxisSize = pictureBox1.Width - 2 * Form1.SeriesPadding;
            int yAxisSize = pictureBox1.Height - 2 * Form1.SeriesPadding;

            // Draw gridlines
            Pen gridPen = new Pen(Color.LightGray, 1);
            for (int i = 10; i < 100; i += 10)
            {
                int x = i * xAxisSize / 100 + Form1.SeriesPadding;
                int y = pictureBox1.Height - i * yAxisSize / 100 - Form1.SeriesPadding;
                g.DrawLine(gridPen, x, pictureBox1.Height - Form1.SeriesPadding, x, pictureBox1.Height - Form1.SeriesPadding - yAxisSize); // vertical line
                g.DrawLine(gridPen, Form1.SeriesPadding, y, Form1.SeriesPadding + xAxisSize, y); // horizontal line
            }
        }

        private void DrawAxis(Graphics g)
        {
            int arrowSize = 10; // Size of the arrow heads

            int xAxisSize = pictureBox1.Width - 2 * Form1.SeriesPadding;
            int yAxisSize = pictureBox1.Height - 2 * Form1.SeriesPadding;

            // Adjusted axis
            PointF origin = new PointF(Form1.SeriesPadding, pictureBox1.Height - Form1.SeriesPadding);
            PointF xEnd = new PointF(Form1.SeriesPadding + xAxisSize, pictureBox1.Height - Form1.SeriesPadding);
            PointF yEnd = new PointF(Form1.SeriesPadding, pictureBox1.Height - Form1.SeriesPadding - yAxisSize);

            // Draw axis with padding
            g.DrawLine(Pens.Black, origin, xEnd); // X-axis
            g.DrawLine(Pens.Black, origin, yEnd); // Y-axis

            // Draw arrows
            g.DrawLine(Pens.Black, xEnd, new PointF(xEnd.X - arrowSize, xEnd.Y - arrowSize));
            g.DrawLine(Pens.Black, xEnd, new PointF(xEnd.X - arrowSize, xEnd.Y + arrowSize));
            g.DrawLine(Pens.Black, yEnd, new PointF(yEnd.X - arrowSize, yEnd.Y + arrowSize));
            g.DrawLine(Pens.Black, yEnd, new PointF(yEnd.X + arrowSize, yEnd.Y + arrowSize));

            // Draw scale with padding
            Font boldFont = new Font(this.Font, FontStyle.Bold);
            for (int i = 0; i <= 100; i += 10)
            {
                int x = i * xAxisSize / 100 + Form1.SeriesPadding;
                int y = pictureBox1.Height - i * yAxisSize / 100 - Form1.SeriesPadding;
                g.DrawString(i.ToString(), boldFont, Brushes.Black, new PointF(x, pictureBox1.Height - Form1.SeriesPadding)); // X-axis scale
                g.DrawString((i * 10).ToString(), boldFont, Brushes.Black, new PointF(Form1.SeriesPadding, y)); // Y-axis scale
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (SeriesList == null || SeriesList.Count == 0)
                return;

            PointF mousePoint = new PointF(e.X, e.Y);

            float maxX = 100;
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
            if (nearestPoint.HasValue && nearestDistance < 5)
            {
                toolTip1.SetToolTip(pictureBox1, $"X: {nearestPoint.Value.X}, Y: {nearestPoint.Value.Y}");
            }
            else
            {
                toolTip1.SetToolTip(pictureBox1, string.Empty);
            }
        }

        private void ChangeSeriesColor(object sender, EventArgs e)
        {
            var diag = new ColorDialog();
            if (diag.ShowDialog() == DialogResult.OK)
                ((sender as Control).Parent as GroupBox).Controls.OfType<PictureBox>().First().BackColor = diag.Color;
        }

        private void BetaValueChanged(object sender, EventArgs e) => TrialBeta = (float)(sender as NumericUpDown).Value;

        private void NumberOfPointsValueChanged(object sender, EventArgs e) => numberOfPoints = (int)(sender as NumericUpDown).Value;

        private void WidthValueChanged(object sender, EventArgs e) => seriesWidth = (float)(sender as NumericUpDown).Value;

    }
}
