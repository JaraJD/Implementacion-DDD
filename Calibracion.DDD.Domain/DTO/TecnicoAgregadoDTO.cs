using Calibracion.DDD.Domain.Certificado.Entidades;
using Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion;

namespace Calibracion.DDD.Domain.DTO
{
	public class TecnicoAgregadoDTO
	{
		public CertificadoId Id { get; private set; }

		public Tecnico Tecnico { get; private set; }

		public TecnicoAgregadoDTO(CertificadoId id)
		{
			Id = id;
		}

		public void SetTecnico(Tecnico tecnico)
		{
			Tecnico = tecnico;

		}
	}
}
