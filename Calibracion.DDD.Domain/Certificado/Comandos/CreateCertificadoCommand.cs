using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Comandos
{
	public class CreateCertificadoCommand
	{
		public double ErrorFinal { get; init; }
		public double Indicacion { get; init; }
		public double Tolerancia { get; init; }

		public CreateCertificadoCommand(double errorFinal, double indicacion, double tolerancia)
		{
			ErrorFinal = errorFinal;
			Indicacion = indicacion;
			Tolerancia = tolerancia;
		}
	}
}
