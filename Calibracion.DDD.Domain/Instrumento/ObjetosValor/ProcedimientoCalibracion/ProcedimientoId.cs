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

		public ProcedimientoId(Guid id) : base(id)
		{
		}

		public static ProcedimientoId Of(Guid id)
		{
			return new ProcedimientoId(id);
		}
	}
}
