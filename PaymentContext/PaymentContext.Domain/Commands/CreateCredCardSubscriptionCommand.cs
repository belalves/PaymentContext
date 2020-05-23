using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.Commands
{
  public class CreateCredCardSubscriptionCommand : Notifiable, ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
        public string PaymentNumber { get; set; }
        public string payerEmail { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Payer { get; set; }
        public string PayerDocument { get; set; }
        public EDocumentType PayerDocumentType { get; set; }

        public void Validate()
        {
            // aqui podemos colocar nossas validações, não regra de negocio
            //Fail Fast Validations ( Validação falha rapida)
            // Mas já tenho validação nos meus objetos basicos, pq colocar aqui tbm?
            // se chegou um request da api com informações invalidas, nem chega no dominio, já volta o erro, reduzir o request no banco.
            // Recebeu um commando, verificar se é valido ou não, se não for não darei sequencia na minha requisição.

            AddNotifications(new Contract()
              .Requires()
              .HasMinLen(FirstName, 3, nameof(FirstName), "O Nome deve conter pelo menos 3 caracteres")
              .HasMinLen(LastName, 3, nameof(LastName), "O sobrenome deve conter pelo menos 3 caracteres")
              .HasMaxLen(FirstName, 40, nameof(FirstName), "O Nome deve conter até 40 caracteres"));
        }
    }
}
