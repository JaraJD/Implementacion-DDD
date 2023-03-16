using Calibracion.DDD.Domain.Cliente.ObjetosValor.Solicitud;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Cliente.ObjetosValor.Responsable
{
	public class ResponsableId : Identity
	{
		public ResponsableId(Guid id) : base(id)
		{
		}

		public static ResponsableId Of(Guid id)
		{
			return new ResponsableId(id);
		}
	}
}
