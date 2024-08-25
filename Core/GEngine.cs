using System.Drawing.Drawing2D;

namespace GamePlay.Core
{
    internal class GEngine
    {
        private static readonly Lazy<GEngine> instance = new(() => new GEngine());
        private readonly PaintEventHandler paint;

        private GEngine() {
            paint = new(GamePaint);
        }

        public static GEngine GetGEngineInstance()
        {
            return instance.Value;
        }

        private void GamePaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.None;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.PixelOffsetMode = PixelOffsetMode.None;

            g.FillRectangle(Brushes.Red, new Rectangle(50, 50, 100, 100));
        }

        public PaintEventHandler GetPaint
        {
            get { return paint; }
        }
    }
}
