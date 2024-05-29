using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    public class DestinationLines
    {
        public string destination {  get; set; }

        public int hour { get; set; }

        public int minute { get; set; }

        public int price { get; set; }

        public DestinationLines(string destination, int hour, int minute, int price)
        {
            this.destination = destination;
            this.hour = hour;
            this.minute = minute;
            this.price = price;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1:00} - {2} - {3} Ден.", hour, minute, destination, price);
        }
    }
}
