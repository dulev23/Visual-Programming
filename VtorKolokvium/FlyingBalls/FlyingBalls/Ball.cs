using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBalls
{
    [Serializable]
    public class Ball
    {
        public static int RADIUS = 40;
        public static Random Random = new Random();
        public Point Center { get; set; }
        // 0 = crveno, 1 = sino, 2 = zeleno, 3 = za brishenje, -1 = nadvor od ekranot
        public int State { get; set; }

        public Ball(Point center)
        {
            this.Center = center;
            //tuka ne se kreira Random object
            State = Random.Next(3); // 0, 1 ili 2
        }

        public void Draw(Graphics g)
        {
            Color color;
            switch (State)
            {
                case 0: color = Color.Red; break;
                case 1: color = Color.Blue; break;
                default: color = Color.Green; break;
            }

            Brush b = new SolidBrush(color);
            g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS,2*RADIUS,2*RADIUS);
            b.Dispose();
            
        }

        public void Move(int dx, int dy)
        {
            Center = new Point(Center.X + dx,Center.Y + dy);
        }

        public bool IsHit(Point p)
        {
            double distance = Math.Sqrt(Math.Pow(Center.X - p.X, 2) + Math.Pow(Center.Y - p.Y, 2));
            if (distance < RADIUS)
            {
                ++State;
                return true;
            }
            else
            {
                return false;
            } 
        }
    }
}
