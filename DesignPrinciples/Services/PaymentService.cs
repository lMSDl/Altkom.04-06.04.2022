using DesignPrinciples.Models;
using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples.Services
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool DeletePaymentAccount(PaymentAccount paymentAccount)
        {
            return PaymentAccounts.Remove(paymentAccount);
        }

        public PaymentAccount FindByAllowedDebit(float allowedDebit)
        {
            return PaymentAccounts.SingleOrDefault(x => x.AllowedDebit == allowedDebit);
        }

        public bool Charge(int id, float amount)
        {
            var account = PaymentAccounts.SingleOrDefault(x => x.Id == id);
            if (account == null)
            {
                return false;
            }

            if (account.Income - account.Outcome + account.AllowedDebit < amount)
            {
                return false;
            }

            account.Outcome += amount;
            return true;
        }

        public void Fund(int id, float amount)
        {
            var customer = PaymentAccounts.Where(x => x.Id == id).SingleOrDefault();
            if (customer == null)
            {
                return;
            }

            customer.Income += amount;
        }

        public float? GetBalance(int id)
        {
            var account = PaymentAccounts.Where(x => x.Id == id).SingleOrDefault();
            return account?.Income - account?.Outcome;
        }
    }
}
