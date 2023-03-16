using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CommonsDDD
{
	public class DomainEvent
	{

		public string Type;
		private string AggregateId;
		private string Aggregate;

		public DomainEvent(string type)
		{
			this.Type = type;
		}

		public string GetAggregateId() => AggregateId;

		public string GetAggregate() => Aggregate;

		public void SetAggregateId(string aggregateId) => AggregateId = aggregateId;

		public void SetAggregate(string aggregate) => Aggregate = aggregate;

	}
}
