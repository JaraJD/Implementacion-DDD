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

		public AddPatronCommand(double valorReferencia, string numeroCertificado)
		{
			ValorReferencia = valorReferencia;
			NumeroCertificado = numeroCertificado;
		}
	}
}
