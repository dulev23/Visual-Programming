using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingShapes2024
{
    public abstract class Shape
    {
        public Color color {  get; set; }
        
        public Point location { get; set; } //za centarot na objektot

        public int size { get; set; } //circle - radius, square - side

        public bool IsSelected { get; set; } = false;

        public Shape(Color color, Point location, int size)
        {
            this.color = color;
            this.location = location;
            this.size = size;
        }

        public abstract void Draw (Graphics g);
        public abstract bool Hit (Point point);
    }
}
