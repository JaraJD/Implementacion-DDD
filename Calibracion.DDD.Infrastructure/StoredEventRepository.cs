using Ardalis.Specification.EntityFrameworkCore;
using Calibracion.DDD.Domain.Generics;
using Calibracion.DDD.UseCase.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Infrastructure
{
	public class StoredEventRepository<T> : RepositoryBase<T>, IStoredEventRepository<T> where T : class
	{
		private readonly DataBaseContext dataBaseContext;
		public StoredEventRepository(DataBaseContext dbContext) : base(dbContext)
		{
			dataBaseContext = dbContext;
		}

		public async Task<List<StoredEvent>> GetEventsByAggregateId(string aggregateId)
		{
			return dataBaseContext.StoredEvents.Where(evento => evento.AggregateId == aggregateId).ToList();

		}
	}
}
