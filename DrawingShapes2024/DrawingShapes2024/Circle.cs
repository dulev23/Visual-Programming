using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes2024
{
    public class Circle : Shape
    {
        public Circle(Color color, Point location, int size) : base(color, location, size)
        {
        }

        public override void Draw(Graphics g)
        {
            if(IsSelected)
            {
                Pen p = new Pen(Color.Blue, 3);
                g.DrawEllipse(p, this.location.X - this.size, this.location.Y - this.size, 2 * this.size, 2 * this.size);
                p.Dispose();
            }

            Brush b = new SolidBrush(this.color);
            g.FillEllipse(b, this.location.X - this.size, this.location.Y - this.size,2*this.size,2*this.size);
            b.Dispose();
        }

        public override bool Hit(Point point)
        {
            return Math.Sqrt(Math.Pow(this.location.X - point.X, 2) + Math.Pow(this.location.Y - point.Y, 2)) < size;
        }
    }
}
