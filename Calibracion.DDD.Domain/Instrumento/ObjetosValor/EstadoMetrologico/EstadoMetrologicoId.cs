using Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.ObjetosValor.EstadoMetrologico
{
	public record EstadoMetrologicoId
	{
		public Guid Id { get; init; }

		internal EstadoMetrologicoId(Guid id)
		{
			Id = id;
		}

		public static EstadoMetrologicoId Create(Guid id)
		{
			return new EstadoMetrologicoId(id);
		}

		public static implicit operator Guid(EstadoMetrologicoId estadoMetrologicoId)
		{
			return estadoMetrologicoId.Id;
		}
	}
}
