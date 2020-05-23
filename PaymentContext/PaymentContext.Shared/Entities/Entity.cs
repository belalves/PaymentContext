using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        //Isso é o que irá diferenciar um valueObject de uma entidade, uma entidade possui id e VOS não.
        public Guid Id { get; set; }
    }
}
