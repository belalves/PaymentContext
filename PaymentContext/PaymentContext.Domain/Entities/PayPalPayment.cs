﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(
            string transactionConde, 
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
            TransactionConde = transactionConde;
        }

        public string TransactionConde { get;private set; }
    }
}