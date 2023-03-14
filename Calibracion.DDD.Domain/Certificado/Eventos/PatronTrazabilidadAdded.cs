using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Patron;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Eventos
{
	public class PatronTrazabilidadAdded : DomainEvent
	{
		public PatronTrazabilidad Trazabilidad { get; set; }

		public PatronTrazabilidadAdded(PatronTrazabilidad trazabilidad) : base ("trazabilidadpatron.agregada")
		{
			Trazabilidad = trazabilidad;
		}
	}
}
