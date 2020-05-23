using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
//using PaymentContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        private readonly Student _student;
        private readonly Name _name;
        private readonly Document _document;
        private readonly Email _email;
        private readonly Address _address;

        private readonly Subscription _subscription;

        public StudentTests()
        {
             _name = new Name("Isabela", "Alves");
            _document = new Document("14200898821", EDocumentType.CPF);
             _email = new Email("bel.alves@hotmail.com");
             _address = new Address("Rua da alegria", "101", "Bairro da Saudade", "Rio Bonito", "RN", "BR", "21875233");
            _student = new Student(_name, _document, _email);
            _subscription = new Subscription(null);
           
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var payment = new PayPalPayment("1234568", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, _address, "Rita Chita", _document, _email);
            _subscription.AddPayment(payment);

            _student.AddSubscriptions(_subscription);
            _student.AddSubscriptions(_subscription);
            Assert.IsTrue(_student.Invalid);
        }


        [TestMethod]
        public void ShouldReturnErrorWhenHadSubscriptionNoPayment()
        {           
            _student.AddSubscriptions(_subscription);
            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenHadNoActiveSubscription()
        {
            var payment = new PayPalPayment("1234568", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, _address, "Rita Chita", _document, _email);
            _subscription.AddPayment(payment);

            _student.AddSubscriptions(_subscription);
            Assert.IsTrue(_student.Valid);
        }

        [TestMethod]
        public void Teste()
        {

            //var student = new Student("Isabela","Santos","123244222","bel.alves2012@gmail.com");
            var subscription = new Subscription(null); 
            //student.Subscriptions.add

            /**SOLID
            S= Single responsabilidade unica (cada um no sei quadrado)
                -é o que estamos fazendo com as classes, cada uma com sua devida responsabilidade

            O = Open-Closed Principle (Princípio Aberto-Fechado)
                - é o que estamos fazendo com nossas propriedades colocando a propriedade de escrita 
                  (set) como privada, para deixar qualquer alteração ser feita somente atraves de metodos
                - nossa classe tbm está aberta para ser utilizada e fechada para ser modificada.
             
             
            Livro - Cleab Code e Clean Coder (sobre SOLID)
             */
        }

    }
}
