using Calibracion.DDD.Domain.Certificado.Entidades;
using Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion;

namespace Calibracion.DDD.Domain.DTO
{
	public class PatronAgregadoDTO
	{
		public CertificadoId Id { get; private set; }

		public Patron Patron { get; private set; }

		public PatronAgregadoDTO(CertificadoId id)
		{
			Id = id;
		}

		public void SetPatron(Patron patron)
		{
			Patron = patron;

		}
	}
}
