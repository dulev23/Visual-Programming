using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePayments
{
    public class Payment
    {
        public decimal Amount { get; set; }

        public Payment(decimal amount)
        {
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Уплата: {Amount} Провизија: {Fee()} Вкупно: {Amount + Fee()}";
        }

        internal decimal Fee()
        {
            return Math.Round(Amount * 0.0114m);
        }
    }
}
