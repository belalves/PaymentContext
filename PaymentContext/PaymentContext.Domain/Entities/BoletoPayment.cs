﻿using PaymentContext.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string 
            barCode,
            string boletoNumber,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid, 
            Address address, 
            string payer,
            Document document,
            Email email)
            : base (
                  paidDate, 
                  expireDate, 
                  total,  
                  totalPaid, 
                  address, 
                  payer, 
                  document,
                  email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
    }
}
