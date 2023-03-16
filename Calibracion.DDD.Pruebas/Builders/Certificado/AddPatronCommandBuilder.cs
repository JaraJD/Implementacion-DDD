using Calibracion.DDD.Domain.Certificado.Comandos;
using Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Pruebas.Builders.Certificado
{
	public class AddPatronCommandBuilder
	{
		public string CertificadoId { get; set; }
		public double ValorReferencia { get; set; }

		public string NumeroCertificado { get; set; }

		public AddPatronCommandBuilder WithCertificadoId(string certificadoId)
		{
			CertificadoId = certificadoId;
			return this;
		}

		public AddPatronCommandBuilder WithValorReferencia(double valorReferencia)
		{
			ValorReferencia= valorReferencia;
			return this;
		}

		public AddPatronCommandBuilder WithNumeroCertificado(string numeroCertificado)
		{
			NumeroCertificado = numeroCertificado;
			return this;
		}

		public AddPatronCommand Build()
		{
			return new AddPatronCommand(CertificadoId, ValorReferencia, NumeroCertificado);
		}
	}
}
