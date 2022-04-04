using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples.Models
{
    public class PaymentAccount : IPayments
    {
        public PaymentAccount(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }
        public float Income { get; private set; }
        public float Outcome { get; private set; }
        public float AllowedDebit { get; set; }
        private float Balance => Income - Outcome;

        public bool Charge(float amount)
        {
            if (Balance + AllowedDebit < amount)
            {
                return false;
            }

            Outcome += amount;
            return true;
        }
        public void Fund(float amount)
        {
            Income += amount;
        }
    }
}
