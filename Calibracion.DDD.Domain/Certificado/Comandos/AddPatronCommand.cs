using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Comandos
{
	public class AddPatronCommand
	{
		public string CertificadoId { get; init; }
		public double ValorReferencia { get; init; }

		public string NumeroCertificado { get; init; }

		public AddPatronCommand(string certificadoId, double valorReferencia, string numeroCertificado)
		{
			CertificadoId = certificadoId;
			ValorReferencia = valorReferencia;
			NumeroCertificado = numeroCertificado;
		}
	}
}
