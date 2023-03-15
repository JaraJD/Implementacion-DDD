using Calibracion.DDD.Domain.Certificado.Entidades;
using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
