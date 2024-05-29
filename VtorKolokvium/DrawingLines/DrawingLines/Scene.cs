using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Data;

namespace DrawingLines
{
    public class Scene
    {
        public List<Line> Lines { get; set; }
        public Point lastPoint { get; set; }
        public Color Color { get; set; } = Color.Red;
        public int Thickness { get; set; } = 1;
        public Point Cursor { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Stack<Line> UndoStack { get; set; }

        public bool Positioner { get; set; }
        public Scene(int width, int height)
        {
            Lines = new List<Line>();
            Color = Color.Red;
            Thickness = 1;
            lastPoint = Point.Empty;
            Positioner = false;
            this.Width = width;
            this.Height = height;
            UndoStack = new Stack<Line>();
        }

        public void AddPoint(Point point)
        { 
            if (!lastPoint.IsEmpty)
            {
                Lines.Add(new Line(lastPoint,point,Color,Thickness));
            }
            lastPoint = point;
        }

        public void Draw(Graphics g)
        {
            foreach (Line line in Lines)
            {
                line.Draw(g);
            }

            if (Positioner)
            {
                Pen p = new Pen(Color.Black);
                p.DashStyle = DashStyle.Dash;
                g.DrawLine(p,new Point(0,Cursor.Y), new Point(Width,Cursor.Y));
                g.DrawLine(p, new Point(Cursor.X,0), new Point (Cursor.X,Height));
                p.Dispose();
            }
        }

        internal void Undo()
        {
            if (Lines.Count > 0)
            {
                Line l = Lines[Lines.Count - 1];
                UndoStack.Push(l);
                Lines.RemoveAt(Lines.Count - 1);
                if (Lines.Count == 0)
                {
                    lastPoint = Point.Empty;
                }
                else
                {
                    lastPoint = Lines[Lines.Count - 1].Right;
                }
            }
        }

        internal void Redo()
        {
            if (UndoStack.Count > 0)
            {
                Line l = UndoStack.Pop();
                Lines.Add(l);
                lastPoint = l.Right;
            }
        }
    }
}
