using Calibracion.DDD.Domain.Cliente.ObjetosValor.Solicitud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.ObjetosValor.Responsable
{
	public record ResponsableId
	{
		public Guid Id { get; init; }

		internal ResponsableId(Guid id)
		{
			Id = id;
		}

		public static ResponsableId Create(Guid id)
		{
			return new ResponsableId(id);
		}

		public static implicit operator Guid(ResponsableId responsableId)
		{
			return responsableId.Id;
		}
	}
}
