using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    [Serializable]
    public class Scene
    {
        public List<Ball> Balls;
        public static int MOVE_SPEED = 10;
        int Touched;
        int width, height;
        int dx, dy;
        public Scene(int width, int height) 
        {
            Balls = new List<Ball>();
            Touched = -1;
            this.width = width; 
            this.height = height;
            dx = 0;
            dy = 0;
        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in Balls)
            {
                b.Draw(g);
            }
        }

        public void AddBall(Point Center)
        {
            Random r = new Random();
            int colorRandomizer = r.Next(2);
            Ball b = null;
            if(colorRandomizer == 0)
            {
                b = new Ball(Center, Color.Green);
            }
            else if(colorRandomizer == 1)
            {
                b = new Ball(Center, Color.Blue);
            }
            Balls.Add(b);
        }

        public void AddRed(Point Center)
        {
            Ball b = new Ball(Center, Color.Red);
            Balls.Add(b);
        }

        public bool MoveBalls()
        {
            Balls[Touched].Center = new Point(Balls[Touched].Center.X + dx, Balls[Touched].Center.Y + dy);
            for (int i = Balls.Count - 1; i >= 0; --i)
            {
                if (Balls[Touched].TouchesBall(Balls[i]))
                {
                    if (Balls[i].Color.Equals(Color.Green))
                    {
                        Balls.RemoveAt(i);
                        if(i < Touched)
                        {
                            --Touched;
                        }
                    }
                }
            }
            if (Balls[Touched].OutOfBounds(width, height))
            {
                Balls.RemoveAt(Touched);
                Touched = -1;
                dx = 0;
                dy = 0;
                return true;
            }
            return false;
        }

        public bool Click(Point position)
        {
            if (Touched != -1) return false;
            for (int i = 0; i < Balls.Count; ++i)
            {
                if (Balls[i].Touch(position))
                {
                    Touched = i;
                    break;
                }
            }
            if (Touched != -1)
            {
                bool moving = Balls[Touched].Color.Equals(Color.Red);
                if (moving)
                {
                    Random r = new Random();
                    int dir = r.Next(4);
                    if (dir == 0) dx = MOVE_SPEED;
                    else if (dir == 1) dx = -MOVE_SPEED;
                    else if (dir == 2) dy = MOVE_SPEED;
                    else if (dir == 3) dy = -MOVE_SPEED;
                }
                return moving;
            }
            return false;
        }
    }
}
