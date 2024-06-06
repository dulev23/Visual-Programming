using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBall
{
    [Serializable]
    public class Ball
    {
        public static int RADIUS { get; set; } = 25;
        public Point Center { get; set; }
        public int Power { get; set; }

        public double Velocity { get; set; }
        public double Angle { get; set; }

        public bool IsInHole { get; set; }

        public float VelocityX;
        public float VelocityY;

        public Color color { get; set; }

        public Ball(Point p) 
        {
            this.Center = p;
            Power = 0;
            Velocity = 10;
            color = Color.Blue;
            IsInHole = false;
            Random r = new Random();
            Angle = r.NextDouble() * 2 * Math.PI;
            VelocityX = (float)(Math.Cos(Angle) * Velocity);
            VelocityY = (float)(Math.Sin(Angle) * Velocity);
        }

        public void Draw(Graphics g, Font font)
        {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, this.Center.X - RADIUS, this.Center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);
            brush.Dispose();
        }

        public void Move(int left, int top, int width, int height)
        {
            int nextX = (int)(Center.X + VelocityX);
            int nextY = (int)(Center.Y + VelocityY);
            int moveLeft = left + RADIUS;
            int moveRight = left + width - RADIUS;
            int moveTop = top + RADIUS;
            int moveBottom = top + height - RADIUS;

            if (nextX <= moveLeft)
            {
                nextX = moveLeft + (moveLeft - nextX);
                VelocityX = -VelocityX;
            }
            if (nextX >= moveRight)
            {
                nextX = moveRight - (nextX - moveRight);
                VelocityX = -VelocityX;
            }
            if (nextY <= moveTop)
            {
                nextY = moveTop + (moveTop - nextY);
                VelocityY = -VelocityY;
            }
            if (nextY >= moveBottom)
            {
                nextY = moveBottom - (nextY - moveBottom);
                VelocityY = -VelocityY;
            }
            Center = new Point(nextX, nextY);
        }

        public bool InHole(Holes h)
        {
            return (Math.Pow(Center.X - h.Center.X, 2) + Math.Pow(Center.Y - h.Center.Y, 2)) <= Math.Pow(RADIUS,2);
        }
    }
}
