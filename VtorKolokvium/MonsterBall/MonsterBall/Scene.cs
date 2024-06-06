using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBall
{
    [Serializable]
    public class Scene
    {
        public List<Ball> balls {  get; set; }
        public List<Holes> holes { get; set; }

        public int height, width;
        Random random;
        public Font font;
        
        public Scene() 
        {
            holes = new List<Holes>();
            balls = new List<Ball>();
            random = new Random();
            font = new Font("Arial", 20);
        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in balls)
            {
                b.Draw(g,font);
            }

            foreach (Holes hole in holes)
            {
                hole.Draw(g,font);
            }
        }

        public void AddBall(Ball ball)
        {
            balls.Add(ball);
        }

        public void MoveBalls(int left, int top, int width, int height)
        {
            foreach (Ball b in balls)
            {
                b.Move(left, top, width, height);
            }
        }

        public void GenerateHoles(int left, int top, int width, int height)
        {
            holes = new List<Holes>();
            GenerateHolesR(left,top,width,height);
        }

        public void GenerateHolesR(int left, int top, int width, int height)
        {
            if(holes.Count == 5)
            {
                return;
            }
            int x = random.Next(left + Holes.RADIUS, (left + width) - Holes.RADIUS);
            int y = random.Next(top +  Holes.RADIUS, (top + height) - Holes.RADIUS);
            bool touches = false;
            foreach (Holes hole in holes)
            {
                touches = hole.Touches(x, y);
                if (touches) break;
            }
            if (!touches)
            {
                Holes h = new Holes(new Point(x, y));
                holes.Add(h);
            }
            GenerateHolesR(left,top,width,height);
        }

        public void CheckColisions()
        {
            for (int i = 0; i < balls.Count; i++)
            {
                for (int j = 0; j < holes.Count; j++)
                {
                    if (balls[i].InHole(holes[j]))
                    {
                        balls[i].IsInHole = true;
                        holes[j].Count++;
                    }
                }
            }
            for (int i = balls.Count - 1; i >= 0; i--)
            {
                if (balls[i].IsInHole)
                {
                    balls.RemoveAt(i);
                }
            }
        }
    }
}
