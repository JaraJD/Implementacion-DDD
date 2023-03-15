
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.ObjetosValor.Solicitud
{
	public class SolicitudId : Identity
	{
		public Guid Id { get; init; }

		internal SolicitudId(Guid id) : base(id)
		{
			Id = id;
		}

		public static SolicitudId Of(Guid id)
		{
			return new SolicitudId(id);
		}
	}
}
