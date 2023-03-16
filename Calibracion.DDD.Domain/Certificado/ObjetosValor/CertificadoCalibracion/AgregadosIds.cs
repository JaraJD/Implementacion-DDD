

namespace Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion
{
	public record AgregadosIds
	{
		public string InstrumentoId { get; init; }
		public string ClienteId { get; init; }

		public AgregadosIds(string instrumentoId, string clienteId)
		{
			InstrumentoId = instrumentoId;
			ClienteId = clienteId;
		}

		public static AgregadosIds Create(string instrumentoId, string clienteId)
		{
			validate(instrumentoId, clienteId);
			return new AgregadosIds(instrumentoId, clienteId);
		}

		private static void validate(string instrumentoId, string clienteId)
		{
			if (instrumentoId == null)
			{
				throw new ArgumentNullException("El Id del Instrumento no puede ser nulo");
			}
			if (clienteId == null)
			{
				throw new ArgumentNullException("EL Id del cliente no puede ser nulo");
			}
		}
	}
}
