using Calibracion.DDD.Domain.CommonsDDD;
using Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.Eventos
{
	public class InstrumentoCreated : DomainEvent
	{
		public string InstrumentoId { get; set; }

		public InstrumentoCreated(string instrumentoId) :  base("instrumento.creado")
		{
			InstrumentoId = instrumentoId;
		}
	}
}
