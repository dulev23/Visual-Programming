using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickingPies
{
    [Serializable]
    public class Pie
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public static int RADIUS = 25;
        public int Tick {  get; set; }

        public Pie(Point center, Color color) 
        {
            Center = center;
            Color = color;
            Tick = 0;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillPie(brush,Center.X - RADIUS,Center.Y - RADIUS,RADIUS*2, RADIUS*2,0,(int)((4-Tick)*90));
            brush.Dispose();
        }
    }
}
