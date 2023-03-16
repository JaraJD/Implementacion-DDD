using Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Certificado.Eventos
{
	public class DatosEmisionUpdated : DomainEvent
	{
		public CertificadoDatosEmision Datos { get; set; }

		public DatosEmisionUpdated(CertificadoDatosEmision datos) : base("datosemision.actualizados")
		{
			Datos = datos;
		}
	}
}
