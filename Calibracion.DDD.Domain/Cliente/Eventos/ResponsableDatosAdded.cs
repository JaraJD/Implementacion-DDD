using Calibracion.DDD.Domain.Cliente.ObjetosValor.Responsable;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.Eventos
{
	public class ResponsableDatosAdded : DomainEvent
	{
		public DatosPersonales Datos { get; set; }

		public ResponsableDatosAdded(DatosPersonales datos) : base("datospersonalesresponsable.agregados")
		{
			Datos = datos;
		}
	}
}
