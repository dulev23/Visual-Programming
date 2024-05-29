using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{
    [Serializable]
    public class Ball
    {
        public static int RADIUS = 25;
        public Point Center { get; set; }
        public Color Color { get; set; }
        public bool IsInHole { get; set; }

        public double Velocity { get; set; }
        public double Angle { get; set; }

        public float velocityX;
        public float velocityY;

        public Ball(Point Center, Color Color)
        {
            this.Center = Center;
            this.Color = Color;
            IsInHole = false;

            Velocity = 10;
            Random r = new Random();
            Angle = r.NextDouble() * 2 * Math.PI;
            velocityX = (float)(Math.Cos(Angle) * Velocity);
            velocityY = (float)(Math.Sin(Angle) * Velocity);

        }        

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b,Center.X -  RADIUS, Center.Y - RADIUS, 2*RADIUS, 2*RADIUS);
            b.Dispose();
        }

        public void Move(int left, int top, int width, int height)
        {
            int nextX = (int)(Center.X + velocityX);
            int nextY = (int)(Center.Y + velocityY);
            int moveLeft = left + RADIUS;
            int moveRight = left + width - RADIUS;
            int moveTop = top + RADIUS;
            int moveBottom = top + height - RADIUS;

            if(nextX <= moveLeft)
            {
                nextX = moveLeft + (moveLeft - nextX);
                velocityX = -velocityX;
            }
            if (nextX >= moveRight)
            {
                nextX = moveRight - (nextX - moveRight);
                velocityX = -velocityX;
            }
            if(nextY <= moveTop)
            {
                nextY = moveTop + (moveTop - nextY);
                velocityY = -velocityY;
            }
            if(nextY >= moveBottom)
            {
                nextY = moveBottom - (nextY - moveBottom);
                velocityY = -velocityY;
            }
            Center = new Point(nextX, nextY);
        }

        public bool InHole(Hole hole)
        {
            double d = Math.Pow(Center.X - hole.Center.X, 2) + Math.Pow(Center.Y - hole.Center.Y,2);
            return d <= Math.Pow(RADIUS, 2);
        }
    }
}
