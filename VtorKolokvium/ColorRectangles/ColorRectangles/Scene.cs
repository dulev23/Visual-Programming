using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorRectangles
{
    [Serializable]
    public class Scene
    {
        public List<Rectangle> Rectangles;
        
        public Scene() 
        {
            Rectangles = new List<Rectangle>();
        }

        public void Draw(Graphics g)
        {
            foreach (Rectangle rect in Rectangles)
            {
                rect.Draw(g);
            }
        }

        public void AddRectangle(Point p, int width, int height, Color color)
        {
            Rectangle rect = new Rectangle(p,width,height,color);
            Rectangles.Add(rect);
        }

        public void Select(Point p)
        {
            foreach(Rectangle rect in Rectangles)
            {
                rect.Select(p);
            }
        }

        public void DeleteSelected()
        {
            for (int i = Rectangles.Count - 1; i >= 0; --i)
            {
                if (Rectangles[i].IsSelected)
                {
                    Rectangles.RemoveAt(i);
                }
            }
        }
    }
}
