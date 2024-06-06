using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulsingCircles
{
    [Serializable]
    public class Scene
    {
        public List<Circle> circles;
        public Color color {  get; set; }

        public Scene() 
        {
            circles = new List<Circle>();
        }

        public void Draw(Graphics g)
        {
            foreach (Circle circle in circles)
            {
                circle.Draw(g);
            }
        }

        public void AddCircle(Point point, Color color)
        {
            circles.Add(new Circle(point, color));
        }

        public void Pulse()
        {
            foreach (Circle circle in circles)
            {
                circle.Pulse();
            }
        }
    }
}
