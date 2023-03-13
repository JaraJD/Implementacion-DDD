using Ardalis.Specification;
using Calibracion.DDD.Domain.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.UseCase.Gateways
{
	public interface IStoredEventRepository<T> : IRepositoryBase<T> where T : class
	{
		Task<List<StoredEvent>> GetEventsByAggregateId(string aggregateId);
	}
}
