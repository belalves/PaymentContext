using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;

        public Student(Name name, Document document, Email email)
        {
            Name = name;           
            Document = document;
            Email = email;

            AddNotifications(name, document, email);

        }

        public Name Name { get; private set; }        
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }
        public Address Address { get; private set; }
        
        public void AddSubscriptions(Subscription subscription)
        {
            //se já tiver uma assinatura ativa, cancela       


            //Cancela todas as outras assinaturas e coloca está como principal

            //foreach (var sub in Subscriptions)
            //{
            //    sub.Activate(false);
            //}
            //_subscriptions.Add(subscription);


            var hasSubscriptionActive = false;

            foreach (var sub in _subscriptions)
            {
                if (sub.Active)
                    hasSubscriptionActive = true;

                AddNotifications(new Contract()
                    .Requires()
                    .IsFalse(hasSubscriptionActive, nameof(Student.Subscriptions), "Você já tem uma assinatura ativa.")
                    .AreEquals(0, subscription.Payments.Count,"Student.Subscriptions.Payment","Está assinatura não possui pagamentos."));


                //outra alternativa

                //if (hasSubscriptionActive)
                //    AddNotification(nameof(Student.Subscriptions), "Você já tem uma assinatura ativa.");
            }

        }
    }
}
