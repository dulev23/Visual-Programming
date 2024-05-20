using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes2024
{
    public class Square : Shape
    {
        public Square(Color color, Point location, int size) : base(color, location, size)
        {
        }

        public override void Draw(Graphics g)
        {
            if(IsSelected)
            {
                Pen p = new Pen(Color.Blue, 3);
                g.DrawRectangle(p, this.location.X - size / 2, this.location.Y - size / 2, size, size);
                p.Dispose();
            }

            Brush b = new SolidBrush(this.color);
            g.FillRectangle(b, this.location.X - size / 2, this.location.Y - size / 2, size, size);
            b.Dispose();
        }

        public override bool Hit(Point point)
        {
            Rectangle r = new Rectangle(this.location.X - size/2, this.location.Y - size/2, this.size, this.size);
            return r.Contains(point);
        }
    }
}
