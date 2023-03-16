using Calibracion.DDD.Domain.Cliente.ObjetosValor.Solicitud;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.Eventos
{
	public class SolicitudIntervencionAdded : DomainEvent
	{
		public Intervencion Intervencion { get; set; }

		public SolicitudIntervencionAdded(Intervencion intervencion) : base ("intervencionsolicitud.agregada")
		{
			Intervencion = intervencion;
		}
	}
}
