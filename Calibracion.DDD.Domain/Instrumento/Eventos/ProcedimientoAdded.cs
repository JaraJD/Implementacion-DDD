using Calibracion.DDD.Domain.CommonsDDD;
using Calibracion.DDD.Domain.Instrumento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.Eventos
{
	public class ProcedimientoAdded :  DomainEvent
	{
		public ProcedimientoCalibracion Procedimiento { get; set; }

		public ProcedimientoAdded(ProcedimientoCalibracion procedimiento) :  base("procedimientocalibracion.agregado")
		{
			Procedimiento = procedimiento;
		}
	}
}
