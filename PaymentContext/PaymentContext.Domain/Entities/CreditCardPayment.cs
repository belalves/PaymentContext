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
            string owner,
            string document,
            string address,
            string email) : base(
                paidDate,
                expireDate,
                total,
                totalPaid,
                owner,
                document,
                address,
                email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        //dica não armazenar dados de cartão de crédito
        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get;private set; }
    }
}
