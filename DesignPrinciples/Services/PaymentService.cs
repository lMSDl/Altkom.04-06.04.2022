using DesignPrinciples.Models;
using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples.Services
{
    public class PaymentService
    {
        public bool Charge(Customer customer, float amount)
        {
            return Charge(customer.PaymentAccount, amount);
        }

        public bool Charge(PaymentAccount paymentAccount, float amount)
        {
            return paymentAccount?.Charge(amount) ?? false;
        }

        public void Fund(PaymentAccount paymentAccount, float amount)
        {
            paymentAccount?.Fund(amount);
        }

    }
}
