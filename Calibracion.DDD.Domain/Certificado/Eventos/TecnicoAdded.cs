using Calibracion.DDD.Domain.Certificado.Entidades;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Eventos
{
	public class TecnicoAdded : DomainEvent
	{
		public Tecnico Tecnico { get; set; }

		public TecnicoAdded(Tecnico tecnico): base("Tecnico.agregado")
		{
			Tecnico = tecnico;
		}
	}
}
