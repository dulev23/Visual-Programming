using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBall
{
    public class Holes
    {
        public Point Center { get; set; }
        public static int RADIUS { get; set; } = 30;
        public int Count { get; set; }

        public Holes(Point center)
        {
            Center = center;
            Count = 0;
        }

        public void Draw(Graphics g, Font font)
        {
            Brush brush = new SolidBrush(Color.Black);
            Brush stringBrush = new SolidBrush(Color.White);
            g.FillEllipse(brush, Center.X - RADIUS, Center.Y - RADIUS,2*RADIUS,2*RADIUS);
            g.DrawString(string.Format("{0}", Count), font, stringBrush, Center.X - RADIUS / 2, Center.Y - RADIUS / 2);
            brush.Dispose();
            stringBrush.Dispose();
        }

        public bool Touches(int x, int y)
        {
            return Math.Pow(x - Center.X, 2) + Math.Pow(y - Center.Y, 2) <= RADIUS * RADIUS * 2;
        }
    }
}
