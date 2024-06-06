using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    [Serializable]
    public class Ball
    {
        public static int RADIUS { get; set; } = 30;
        public Point Center { get; set; }
        public Color Color { get; set; }
        public Ball(Point center, Color color) 
        {
            Center = center;
            Color = color;
        }

        public void Draw(Graphics g)
        { 
            Brush br = new SolidBrush(Color);
            g.FillEllipse(br, Center.X - RADIUS, Center.Y - RADIUS,2*RADIUS,2*RADIUS);
            br.Dispose();
        }

        public bool Touch(Point p)
        {
            return (Math.Pow(Center.X - p.X,2) + Math.Pow(Center.Y - p.Y,2) <=  RADIUS * RADIUS);
        }

        public bool TouchesBall(Ball b)
        {
            return (Math.Pow(Center.X - b.Center.X, 2) + Math.Pow(Center.Y - b.Center.Y, 2)) <= Math.Pow(RADIUS, 2) * 4;
        }

        public bool OutOfBounds(int width, int height)
        {
            if (Center.X + RADIUS < 0 || Center.X - RADIUS > width) return true;
            if (Center.Y + RADIUS < 0 || Center.Y - RADIUS > height) return true;
            return false;
        }
    }
}
