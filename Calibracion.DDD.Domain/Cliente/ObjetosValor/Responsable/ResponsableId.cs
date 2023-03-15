using Calibracion.DDD.Domain.Cliente.ObjetosValor.Solicitud;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.ObjetosValor.Responsable
{
	public class ResponsableId : Identity
	{
		public Guid Id { get; init; }

		public ResponsableId(Guid id) : base(id)
		{
			Id = id;
		}

		public static ResponsableId Of(Guid id)
		{
			return new ResponsableId(id);
		}
	}
}
