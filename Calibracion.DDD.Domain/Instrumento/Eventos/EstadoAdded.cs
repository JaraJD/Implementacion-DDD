using Calibracion.DDD.Domain.CommonsDDD;
using Calibracion.DDD.Domain.Instrumento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.Eventos
{
	public class EstadoAdded : DomainEvent
	{
		public EstadoMetrologico Estado { get; set; }


		public EstadoAdded(EstadoMetrologico estado) :  base ("estadometrologico.agregado")
		{
			Estado = estado;
		}
	}
}
