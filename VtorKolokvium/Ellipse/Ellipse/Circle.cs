using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Ellipse
{
    [Serializable]
    public class Circle
    {
        public Point Center { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Circle(Point p, int width, int height)
        {
            Center = p;
            Height = height;
            Width = width;
            Random r = new Random();
            R = r.Next(256);
            G = r.Next(256);
            B = r.Next(256);
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.FromArgb(R,G,B));
            g.FillEllipse(b, Center.X, Center.Y, Width, Height);
            b.Dispose();
        }

        public void ChangeColor()
        {
            R += 5;
            G += 10;
            B += 15;
            R = R % 256;
            G = G % 256;
            B = B % 256;
        }
    }
}
