using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellipse
{
    [Serializable]
    public class Scene
    {
        List<Circle> circles { get; set; }

        public Scene()
        {
            circles = new List<Circle>();
        }

        public void Draw(Graphics g)
        {
            for (int i = 0; i < circles.Count; i++)
            {
                circles[i].Draw(g);
            }
        }

        public void AddCircle(Point point, int width, int height)
        {
            Circle c = new Circle(point,width,height);
            circles.Add(c);
        }

        public void ChangeColor()
        {
            foreach(Circle c in circles)
            {
                c.ChangeColor();
            }
        }
    }
}
