using Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion;

namespace Calibracion.DDD.Domain.DTO
{
	public class CertificadoDTO
	{
		public CertificadoId Id { get; private set; }

		public AgregadosIds AgregadosIds { get; private set; }
		public CertificadoValoresTec ValoresTecnicos { get; private set; }

		public CertificadoDatosEmision DatosEmision { get; private set; }

		public CertificadoDTO(CertificadoId id)
		{
			Id = id;
		}

		public void SetAgregadosIds(AgregadosIds id)
		{
			AgregadosIds = id;

		}

		public void SetValoresTecnicos(CertificadoValoresTec valores)
		{
			ValoresTecnicos = valores;

		}

		public void SetDatosEmision(CertificadoDatosEmision datos)
		{
			DatosEmision = datos;
		}
	}
}
