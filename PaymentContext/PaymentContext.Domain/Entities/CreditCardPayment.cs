using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(
            string cardHolderName, 
            string cardNumber,
            string lastTransactionNumber,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            Address address,
            string payer,
            Document document,
            Email email)
            : base(
                  paidDate,
                  expireDate,
                  total,
                  totalPaid,
                  address,
                  payer,
                  document,
                  email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }

    }
}
