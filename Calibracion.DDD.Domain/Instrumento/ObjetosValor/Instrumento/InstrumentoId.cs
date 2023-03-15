using Calibracion.DDD.Domain.Cliente.ObjetosValor.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento
{
	public record InstrumentoId
	{
		public Guid Id { get; init; }

		internal InstrumentoId(Guid id)
		{
			Id = id;
		}

		public static InstrumentoId Create(Guid id)
		{
			return new InstrumentoId(id);
		}

		public static implicit operator Guid(InstrumentoId instrumentoId)
		{
			return instrumentoId.Id;
		}
	}
}
