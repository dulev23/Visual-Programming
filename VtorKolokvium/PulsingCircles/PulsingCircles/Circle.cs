using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PulsingCircles
{
    [Serializable]
    public class Circle
    {
        public Point Center { get; set; }

        public Color Color { get; set; } = Color.Blue;

        public int OriginalRadius { get; set; } = 30;
        public int PulsingRadius { get; set; }
        int percent;

        public Circle(Point center, Color color)
        {
            Center = center;
            Color = color;
            PulsingRadius = OriginalRadius;
            percent = 0;
        }

        public void Draw(Graphics g) 
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush,Center.X - OriginalRadius,Center.Y - OriginalRadius,2 * OriginalRadius, 2 * OriginalRadius);
            brush.Dispose();
        }

        public void Pulse()
        {
            percent += 10;
            OriginalRadius = PulsingRadius + (int)(PulsingRadius * percent * 0.01);
            if (percent == 100)
            {
                percent = 0;
            }
        }
    }
}
