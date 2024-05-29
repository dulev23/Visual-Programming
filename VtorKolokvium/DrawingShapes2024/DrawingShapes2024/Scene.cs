using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingShapes2024
{
    public class Scene
    {
        public List<Shape> Shapes { get; set; } = new List<Shape>();
        Shape SelectedShape = null;
        public Scene() {  Shapes = new List<Shape>(); }

        public void AddShape(Shape s)
        {
            Shapes.Add(s);
        }

        public void Draw(Graphics g)
        {
            foreach (var shape in Shapes)
            {
                shape.Draw(g);
            }
        }

        public void Hit(Point location)
        {
            foreach (var shape in Shapes)
            {
                if (shape.Hit(location))
                {
                    if(SelectedShape == null)
                    {
                        SelectedShape = shape;
                        shape.IsSelected = !shape.IsSelected;
                    } else //veke imame selektirano forma
                    {
                        //selektiranata forma da se deselektira
                        SelectedShape.IsSelected = false;
                        SelectedShape = shape;
                        SelectedShape.IsSelected = true;
                    }
                }
            }
        }
    }
}
