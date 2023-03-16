
using Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Certificado.Eventos
{
	public class ValoresTecAdded : DomainEvent
	{
		public CertificadoValoresTec Valores { get; set; }

		public ValoresTecAdded(CertificadoValoresTec valores) : base("valorestecnicos.agregados")
		{
			Valores = valores;
		}
	}
}
