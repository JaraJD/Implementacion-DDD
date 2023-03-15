using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.ObjetosValor.ProcedimientoCalibracion
{
	public class ProcedimientoId : Identity
	{
		public Guid Id { get; init; }

		public ProcedimientoId(Guid id) : base(id)
		{
			Id = id;
		}

		public static ProcedimientoId Create(Guid id)
		{
			return new ProcedimientoId(id);
		}
	}
}
