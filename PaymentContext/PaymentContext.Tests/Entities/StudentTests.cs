using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void Teste()
        {
            //var student = new Student("Isabela","Santos","123244222","bel.alves2012@gmail.com");
            //var subscription = new Subscription(DateTime.Now.Add()); 
            //student.Subscriptions.ad

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
