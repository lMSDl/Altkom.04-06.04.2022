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
            PaymentAccount account = FindById(id);
            var balace = GetBalance(id) + account?.AllowedDebit;
            if (!balace.HasValue || balace.Value < amount)
            {
                return false;
            }

            account.Outcome += amount;
            return true;
        }

        private PaymentAccount FindById(int id)
        {
            return PaymentAccounts.SingleOrDefault(x => x.Id == id);
        }

        public void Fund(int id, float amount)
        {
            var account = FindById(id); ;
            if (account == null)
            {
                return;
            }

            account.Income += amount;
        }

        public float? GetBalance(int id)
        {
            var account = FindById(id);
            return account?.Income - account?.Outcome;
        }
    }
}
