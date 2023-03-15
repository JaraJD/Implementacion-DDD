using Calibracion.DDD.Domain.Cliente.Entidades;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.Eventos
{
	public class SolicitudAdded : DomainEvent
	{
		public Solicitud solicitud { get; set; }

		public SolicitudAdded(Solicitud solicitud) : base("solicitud.agregada")
		{
			this.solicitud = solicitud;
		}
	}
}
