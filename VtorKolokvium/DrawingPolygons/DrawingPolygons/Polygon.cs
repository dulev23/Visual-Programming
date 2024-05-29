using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DrawingPolygons
{
    [Serializable]
    public class Polygon
    {
        List<Point> points {  get; set; }
        public bool IsClosed { get; set; } = false;
        public bool IsCloseToStart { get; set; } = false;
        Point cursor { set; get; } = new Point();
        public Polygon() 
        { 
            points = new List<Point>();
        }

        public void AddPoint(Point p)
        {
            IsCloseToStart = NearStart();
            if (IsCloseToStart)
            {
                points.Add(points[0]);
                IsClosed = true;
                IsCloseToStart = false;
            } else
            {
                points.Add(p);
            }
        }

        public void UpdateCursor(Point p)
        {
            cursor = p;
            IsCloseToStart = NearStart();
        }

        bool NearStart()
        {
            if(points.Count < 2)
            {
                return false;
            }

            Point firstPoint = points[0];
            double distance = Math.Sqrt(Math.Pow(firstPoint.X - cursor.X, 2) + Math.Pow(firstPoint.Y - cursor.Y, 2));
            return distance <= 5;
        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black,2); //for the lines
            Pen penDashed = new Pen(Color.Black,2);
            penDashed.DashStyle = DashStyle.Dash; 
            Brush b = new SolidBrush(Color.Blue);
            if(points.Count >= 2)
            {
                g.DrawLines(p, points.ToArray());
                if (IsCloseToStart)
                {
                    Point firstpoint = points[0];
                    g.DrawEllipse(penDashed,firstpoint.X - 5, firstpoint.Y - 5, 10,10);
                }
                if(IsClosed)
                {
                    g.FillPolygon(b, points.ToArray());
                }
            }

            if(points.Count > 0)
            {
                Point lastPoint = points[points.Count - 1];
                g.DrawLine(penDashed, lastPoint, cursor);
            }
           
        }
    }
}
