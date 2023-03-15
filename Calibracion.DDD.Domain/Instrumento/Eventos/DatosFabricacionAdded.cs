using Calibracion.DDD.Domain.CommonsDDD;
using Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.Eventos
{
	public class DatosFabricacionAdded : DomainEvent
	{
		public DatosFabricacion Datos { get; set; }

		public DatosFabricacionAdded(DatosFabricacion datos) : base("datosfabricacion.agregados")
		{
			Datos = datos;
		}
	}
}
