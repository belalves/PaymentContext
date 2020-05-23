using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
               .Requires()
               .HasMinLen(FirstName,3, nameof(Name.FirstName), "O Nome deve conter pelo menos 3 caracteres")
               .HasMinLen(LastName, 3, nameof(Name.LastName), "O sobrenome deve conter pelo menos 3 caracteres")
               .HasMaxLen(FirstName, 40, nameof(Name.FirstName), "O Nome deve conter até 40 caracteres"));
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
