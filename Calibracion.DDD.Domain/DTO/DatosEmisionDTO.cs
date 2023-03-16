using Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion;

namespace Calibracion.DDD.Domain.DTO
{
	public class DatosEmisionDTO
	{
		public CertificadoId Id { get; private set; }

		public CertificadoDatosEmision Datos { get; private set; }

		public DatosEmisionDTO(CertificadoId id)
		{
			Id = id;
		}

		public void SetDatos(CertificadoDatosEmision datos)
		{
			Datos = datos;

		}
	}
}
