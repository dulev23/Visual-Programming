using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircles
{
    [Serializable]
    public class Circle
    {
        public int Radius { get; set; }
        public Point CenterPoint {  get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }
        public Circle(Point centerpoint, int radius, Color color) {
            CenterPoint = centerpoint;
            Radius = radius;
            Color = color;
            IsSelected = false;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            if(IsSelected)
            {
                Pen p = new Pen(Color.Red,5);
                g.DrawEllipse(p, CenterPoint.X - Radius, CenterPoint.Y - Radius, 2 * Radius, 2 * Radius);
                p.Dispose();
            }
            g.FillEllipse(b, CenterPoint.X - Radius,CenterPoint.Y - Radius, 2*Radius, 2 * Radius);
            b.Dispose();
        }

        public void Select(Point point)
        {
            if(Distance(point, CenterPoint) <= Radius * Radius)
            {
                IsSelected = !IsSelected;
            }
        }

        public static float Distance(Point point1, Point point2)
        {
            return (point1.X -  point2.X) * (point1.X - point2.X) + (point1.Y - point2.Y) * (point1.Y - point2.Y);
        }
    }
}
