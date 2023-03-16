
using Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Certificado.Eventos
{
	public class DatosEmisionAdded : DomainEvent
	{
		public CertificadoDatosEmision Datos { get; set; }

		public DatosEmisionAdded(CertificadoDatosEmision datos) : base ("datosemision.agregados")
		{
			Datos = datos;
		}
	}
}
