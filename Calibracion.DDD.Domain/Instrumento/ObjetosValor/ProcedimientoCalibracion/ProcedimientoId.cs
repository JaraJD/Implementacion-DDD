using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.ObjetosValor.ProcedimientoCalibracion
{
	public record ProcedimientoId
	{
		public Guid Id { get; init; }

		internal ProcedimientoId(Guid id)
		{
			Id = id;
		}

		public static ProcedimientoId Create(Guid id)
		{
			return new ProcedimientoId(id);
		}

		public static implicit operator Guid(ProcedimientoId procedimientoId)
		{
			return procedimientoId.Id;
		}
	}
}
