using Calibracion.DDD.Domain.Cliente.Entidades;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.Eventos
{
	public class ResponsableAdded : DomainEvent
	{
		public Responsable Responsable { get; set; }

		public ResponsableAdded(Responsable responsable) : base("Responsable.agregado")
		{
			Responsable = responsable;
		}
	}
}
