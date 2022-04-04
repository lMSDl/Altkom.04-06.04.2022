using DesignPrinciples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Services
{
    class CustomersService
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5) };

        private Customer FindById(int id)
        {
            return Customers.SingleOrDefault(x => x.Id == id);
        }
    }
}
