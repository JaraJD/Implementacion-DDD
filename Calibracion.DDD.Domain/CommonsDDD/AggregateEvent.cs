using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CommonsDDD
{
	public abstract class AggregateEvent<T> : Entity<T> where T : Identity
	{
		private ChangeEventSuscriber ChangeEventSuscriber = new();

		protected AggregateEvent(T entityId) : base(entityId) { }

		public List<DomainEvent> getUncommittedChanges() => ChangeEventSuscriber.GetChanges().ToList();


		public void AppendChange(DomainEvent evento)
		{
			string nameClass = evento.GetType().Name;
			evento.SetAggregate(nameClass);
			evento.SetAggregateId(Identity().Uuid.ToString());
			ChangeEventSuscriber.AppendChange(evento);
		}
	}
}
