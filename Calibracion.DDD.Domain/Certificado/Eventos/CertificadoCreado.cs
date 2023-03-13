using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Certificado.Eventos
{
	public class CertificadoCreado : DomainEvent
	{
		public string CertificadoId { get; init; }


		public CertificadoCreado(string certificadoId) : base("certificado.creado")
		{
			CertificadoId = certificadoId;
		}
	}
}
