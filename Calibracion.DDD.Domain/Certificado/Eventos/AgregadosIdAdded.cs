using Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Certificado.Eventos
{
	public class AgregadosIdAdded : DomainEvent
	{
		public AgregadosIds AgregadosIds { get; set; }

		public AgregadosIdAdded(AgregadosIds agregadosIds) : base("IdAgregadosRoot.Agregado")
		{
			AgregadosIds = agregadosIds;
		}
	}
}
