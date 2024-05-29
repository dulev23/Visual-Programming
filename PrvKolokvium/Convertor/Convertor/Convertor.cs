using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    public class Convertor
    {
        public string From {  get; set; }
        public string To { get; set; }

        public decimal Multiplier { get; set; }

        public Convertor(string from, string to, decimal multiplier)
        {
            From = from;
            To = to;
            Multiplier = multiplier;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}",From, To);
        }
    }
}
