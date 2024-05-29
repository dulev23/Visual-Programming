using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePayments
{
    public class Student
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<Payment> payments { get; set; }

        public Student(string id, string name)
        {
            Id = id;
            Name = name;
            payments = new List<Payment>();
        }
        public override string ToString()
        {
            return $"{Id} {Name}";
        }

        public void addPayment(Payment payment)
        {
            payments.Add(payment);
        }

        public decimal TotalPaymentAmount()
        {
            decimal totalAmount = 0;
            for (int i = 0; i < payments.Count; i++)
            {
                totalAmount += payments[i].Amount;
            }
            return totalAmount;
        }

        public decimal TotalFee()
        {
            decimal totalFee = 0;
            for (int i = 0; i < payments.Count; i++)
            {
                totalFee += payments[i].Fee();
            }
            return totalFee;
        }

        public string Details()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString()).Append("\n");
            decimal sumPayments = 0m;
            decimal sumFee = 0m;
            for (int i = 0; i < payments.Count; i++)
            {
                sb.Append(i+1).Append(". ").Append(payments[i].ToString()).Append("\n");
                sumPayments += payments[i].Amount;
                sumFee += Math.Round(payments[i].Amount * 0.0114m);
            }
            sb.Append($"Вкупно уплати: {TotalPaymentAmount()}").Append("\n");
            sb.Append($"Вкупно провизија: {TotalFee()}").Append("\n");

            return sb.ToString();
        }
    }
}
