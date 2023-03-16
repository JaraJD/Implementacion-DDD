

namespace Calibracion.DDD.Domain.Certificado.Comandos
{
	public class CreateCertificadoCommand
	{
		public double ErrorFinal { get; init; }
		public double Indicacion { get; init; }
		public double Tolerancia { get; init; }
		public string NumeroCertificado { get; init; }
		public string FechaRealizacion { get; init; }
		public string FechaEmision { get; init; }
		public string InstrumentoId { get; init; }
		public string ClienteId { get; init; }

		public CreateCertificadoCommand(double errorFinal, double indicacion, double tolerancia, string numeroCertificado, string fechaRealizacion, string fechaEmision, string instrumentoId, string clienteId)
		{
			ErrorFinal = errorFinal;
			Indicacion = indicacion;
			Tolerancia = tolerancia;
			NumeroCertificado = numeroCertificado;
			FechaRealizacion = fechaRealizacion;
			FechaEmision = fechaEmision;
			InstrumentoId = instrumentoId;
			ClienteId = clienteId;
		}




		//public CreateCertificadoCommand(
		//	double errorFinal,
		//	double indicacion,
		//	double tolerancia,
		//	string numeroCertificado,
		//	string fechaRealizacion,
		//	string fechaEmision)
		//{
		//	ErrorFinal = errorFinal;
		//	Indicacion = indicacion;
		//	Tolerancia = tolerancia;
		//	NumeroCertificado = numeroCertificado;
		//	FechaRealizacion = fechaRealizacion;
		//	FechaEmision = fechaEmision;
		//}
	}
}
