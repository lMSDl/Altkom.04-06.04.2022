using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Models
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }

        public PaymentAccount PaymentAccount { get; } = new PaymentAccount();
    }
}
