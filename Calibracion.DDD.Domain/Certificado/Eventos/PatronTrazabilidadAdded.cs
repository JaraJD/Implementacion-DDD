using Calibracion.DDD.Domain.Certificado.ObjetosValor.Patron;
using Calibracion.DDD.Domain.CommonsDDD;

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
