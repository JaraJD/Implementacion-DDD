using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Generics
{
	public class StoredEvent
	{
		public string StoredId { get; set; }

		public string StoredName { get; set; }

		public string AggregateId { get; set; }

		public string EventBody { get; set; }
	}
}
