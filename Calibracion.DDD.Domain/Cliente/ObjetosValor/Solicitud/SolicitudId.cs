using Calibracion.DDD.Domain.AggCliente.ObjetosValor.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.ObjetosValor.Solicitud
{
	public record SolicitudId
	{
		public Guid Id { get; init; }

		internal SolicitudId(Guid id)
		{
			Id = id;
		}

		public static SolicitudId Create(Guid id)
		{
			return new SolicitudId(id);
		}

		public static implicit operator Guid(SolicitudId solicitudId)
		{
			return solicitudId.Id;
		}
	}
}
