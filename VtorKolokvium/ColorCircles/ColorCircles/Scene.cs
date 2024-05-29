using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircles
{
    [Serializable]
    public class Scene
    {
        public List<Circle> Circles { get; set; }
        public Scene()
        {
            Circles = new List<Circle>();
        }

        public void Draw(Graphics g)
        {
            foreach (Circle c in Circles)
            {
                c.Draw(g);
            }
        }

        public void AddCircle(Point p, int Radius, Color color)
        {
            Circle c = new Circle(p, Radius, color);
            Circles.Add(c);
        }

        public void Select(Point p)
        {
            foreach(Circle c in Circles)
            {
                c.Select(p);
            }
        }

        public void DeleteSelected()
        {
            for (int i = Circles.Count - 1; i >= 0; i--)
            {
                if (Circles[i].IsSelected)
                {
                    Circles.RemoveAt(i);
                }
            }
        }
    }
}
