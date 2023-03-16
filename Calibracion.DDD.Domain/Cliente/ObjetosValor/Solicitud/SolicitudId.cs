
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Cliente.ObjetosValor.Solicitud
{
	public class SolicitudId : Identity
	{

		public SolicitudId(Guid id) : base(id)
		{
		}

		public static SolicitudId Of(Guid id)
		{
			return new SolicitudId(id);
		}
	}
}
