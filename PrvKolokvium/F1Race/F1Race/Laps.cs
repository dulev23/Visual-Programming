using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
    public class Laps
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Laps(int minutes, int seconds)
        {
            Minutes = minutes;
            Seconds = seconds;
        }

        public int Time
        {
            get 
            {
                return Minutes * 60 + Seconds;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}",Minutes,Seconds);
        }
    }
}
