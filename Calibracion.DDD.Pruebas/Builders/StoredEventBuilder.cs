using Calibracion.DDD.Domain.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Pruebas.Builders
{
	public class StoredEventBuilder
	{
		private string _storedId;
		private string _storedName;
		private string _aggregateId;
		private string _eventBody;

		public StoredEventBuilder WithStoredId(string storedId)
		{
			_storedId = storedId;
			return this;
		}

		public StoredEventBuilder WithStoredName(string storedName)
		{
			_storedName = storedName;
			return this;
		}

		public StoredEventBuilder WithAggregateId(string aggregateId)
		{
			_aggregateId = aggregateId;
			return this;
		}

		public StoredEventBuilder WithEventBody(string eventBody)
		{
			_eventBody = eventBody;
			return this;
		}

		public StoredEvent Build()
		{
			return new StoredEvent(_storedId, _storedName, _aggregateId, _eventBody);
		}
	}
}
