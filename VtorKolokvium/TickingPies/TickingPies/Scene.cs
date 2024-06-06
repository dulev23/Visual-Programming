using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickingPies
{
    [Serializable]
    public class Scene
    {
        public List<Pie> pies;
        public Scene()
        {
            pies = new List<Pie>();
        }

        public void Draw(Graphics g)
        {
            foreach (Pie pie in pies)
            {
                pie.Draw(g);
            }
        }

        public void AddPie(Point center, Color color)
        {
            Pie p = new Pie(center, color);
            pies.Add(p);
        }

        public void Tick()
        {
            for (int i = pies.Count - 1; i>= 0; i--)
            {
                pies[i].Tick++;
                if (pies[i].Tick == 4)
                {
                    pies.RemoveAt(i);
                }
            }
        }
    }
}
