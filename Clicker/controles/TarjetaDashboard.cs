
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Clicker.Controles
{
    public class TarjetaDashboard : Panel
    {
        private bool hover = false;

        public TarjetaDashboard()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor,
                true
            );

            BackColor = Color.Transparent;
            Size = new Size(282, 130);
            Padding = new Padding(12);
            Cursor = Cursors.Default;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int radi = 10;
            int marge = 7;

            Rectangle tarjeta = new Rectangle(
                marge,
                marge,
                Width - marge * 2 - 1,
                Height - marge * 2 - 1
            );

            int profunditat = hover ? 5 : 2;

            for (int i = profunditat; i >= 1; i--)
            {
                using (GraphicsPath ombra = CrearForma(
                    new Rectangle(
                        tarjeta.X,
                        tarjeta.Y + i,
                        tarjeta.Width,
                        tarjeta.Height
                    ),
                    radi))
                using (Pen pinzell = new Pen(
                    Color.FromArgb(12, 0, 0, 0),
                    i))
                {
                    g.DrawPath(pinzell, ombra);
                }
            }

            using (GraphicsPath forma = CrearForma(tarjeta, radi))
            using (SolidBrush pinzell = new SolidBrush(
                hover
                    ? Color.FromArgb(252, 253, 255)
                    : Color.White))
            {
                g.FillPath(pinzell, forma);
            }
        }

        private GraphicsPath CrearForma(Rectangle rectangle, int radi)
        {
            GraphicsPath path = new GraphicsPath();

            int diametre = radi * 2;

            path.AddArc(
                rectangle.X,
                rectangle.Y,
                diametre,
                diametre,
                180,
                90
            );

            path.AddArc(
                rectangle.Right - diametre,
                rectangle.Y,
                diametre,
                diametre,
                270,
                90
            );

            path.AddArc(
                rectangle.Right - diametre,
                rectangle.Bottom - diametre,
                diametre,
                diametre,
                0,
                90
            );

            path.AddArc(
                rectangle.X,
                rectangle.Bottom - diametre,
                diametre,
                diametre,
                90,
                90
            );

            path.CloseFigure();

            return path;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            hover = true;
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            hover = false;
            Invalidate();
        }
    }
}
