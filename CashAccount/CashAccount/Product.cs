using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccount
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public Product(int code, string name, float price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1} {2:0.00}", Code, Name, Price);
        }
    }
}
