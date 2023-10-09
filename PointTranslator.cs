namespace EWMABiasCorrectionResearch
{
    public static class PointTranslator
    {
        /// <summary>
        /// Translates a point from its original coordinates to the PictureBox's coordinate system.
        /// </summary>
        /// <param name="originalPoint">The original point.</param>
        /// <param name="maxX">The maximum X value in the original coordinate system.</param>
        /// <param name="maxY">The maximum Y value in the original coordinate system.</param>
        /// <param name="pictureBoxWidth">The width of the PictureBox.</param>
        /// <param name="pictureBoxHeight">The height of the PictureBox.</param>
        /// <returns>The translated point.</returns>
        public static PointF TranslatePoint(PointF originalPoint, float maxX, float maxY, int pictureBoxWidth, int pictureBoxHeight)
        {
            float x = (originalPoint.X / maxX) * (pictureBoxWidth - 2 * Form1.SeriesPadding) + Form1.SeriesPadding;
            float y = (pictureBoxHeight - Form1.SeriesPadding) - (originalPoint.Y / maxY) * (pictureBoxHeight - 2 * Form1.SeriesPadding);

            return new PointF(x, y);
        }

        /// <summary>
        /// Translates a point from the PictureBox's coordinate system to its original coordinates.
        /// </summary>
        /// <param name="translatedPoint">The translated point.</param>
        /// <param name="maxX">The maximum X value in the original coordinate system.</param>
        /// <param name="maxY">The maximum Y value in the original coordinate system.</param>
        /// <param name="pictureBoxWidth">The width of the PictureBox.</param>
        /// <param name="pictureBoxHeight">The height of the PictureBox.</param>
        /// <returns>The original point.</returns>
        public static PointF ReverseTranslatePoint(PointF translatedPoint, float maxX, float maxY, int pictureBoxWidth, int pictureBoxHeight)
        {
            float x = ((translatedPoint.X - Form1.SeriesPadding) / (pictureBoxWidth - 2 * Form1.SeriesPadding)) * maxX;
            float y = ((pictureBoxHeight - Form1.SeriesPadding - translatedPoint.Y) / (pictureBoxHeight - 2 * Form1.SeriesPadding)) * maxY;

            return new PointF(x, y);
        }
    }
}
