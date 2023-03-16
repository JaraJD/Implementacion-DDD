using Calibracion.DDD.Domain.Certificado.Comandos;
using Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Pruebas.Builders.Certificado
{
	public class UpdateDatosEmisionCommanBuilder
	{
		public string CertificadoId { get; set; }
		public string NumeroCertificado { get; set; }
		public string FechaRealizacion { get; set; }
		public string FechaEmision { get; set; }

		public UpdateDatosEmisionCommanBuilder WithCertificadoId(string certificadoId)
		{
			CertificadoId = certificadoId;
			return this;
		}

		public UpdateDatosEmisionCommanBuilder WithNumeroCertificado(string numeroCertificado)
		{
			NumeroCertificado = numeroCertificado;
			return this;
		}

		public UpdateDatosEmisionCommanBuilder WithFechaRealizacion(string fechaRealizacion)
		{
			FechaRealizacion = fechaRealizacion;
			return this;
		}

		public UpdateDatosEmisionCommanBuilder WithFechaEmision(string fechaEmision)
		{
			FechaEmision = fechaEmision;
			return this;
		}

		public UpdateDatosEmisionComman Build()
		{
			return new UpdateDatosEmisionComman(CertificadoId, NumeroCertificado, FechaRealizacion, FechaEmision);
		}
	}
}
