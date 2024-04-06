using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace Buses
{
    public class Bus
    {
        public string Registration {  get; set; }

        public string Name { get; set; }

        public bool IsLocal { get; set; }

        public List<DestinationLines> Lines;

        public Bus(string registration, string name, bool isLocal)
        {
            this.Registration = registration;
            this.Name = name;
            this.IsLocal = isLocal;
            Lines = new List<DestinationLines>();
        }

        public void AddDestination(DestinationLines line)
        {
            Lines.Add(line);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Name, Registration, IsLocal ? "L" : "M");
        }
    }
}
