using Calibracion.DDD.Domain.Cliente.ObjetosValor.Cliente;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento
{
	public class InstrumentoId :  Identity
	{
		public Guid Id { get; init; }

		public InstrumentoId(Guid id) :  base (id)
		{
			Id = id;
		}

		public static InstrumentoId Of(Guid id)
		{
			return new InstrumentoId(id);
		}

	}
}
