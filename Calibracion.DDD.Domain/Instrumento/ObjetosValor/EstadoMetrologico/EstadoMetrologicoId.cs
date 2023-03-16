using Calibracion.DDD.Domain.CommonsDDD;
using Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.ObjetosValor.EstadoMetrologico
{
	public class EstadoMetrologicoId : Identity
	{

		public EstadoMetrologicoId(Guid id) : base (id)
		{
		}

		public static EstadoMetrologicoId Of(Guid id)
		{
			return new EstadoMetrologicoId(id);
		}
	}
}
