using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
    public class Racer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool FirstSecond { get; set; }

        public List<Laps> Laps;

        public Racer(string name, int age, bool firstSecond)
        {
            Name = name;
            Age = age;
            FirstSecond = firstSecond;
            Laps = new List<Laps>();
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2}", Name, Age, FirstSecond ? "F" : "S");
        }
    }
}
