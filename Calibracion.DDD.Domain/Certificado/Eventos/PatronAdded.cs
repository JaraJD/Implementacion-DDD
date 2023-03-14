using Calibracion.DDD.Domain.Certificado.Entidades;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Eventos
{
	public class PatronAdded : DomainEvent
	{
		public Patron Patron { get; set; }

		public PatronAdded(Patron patron) : base("Patron.agregado")
		{
			Patron = patron;
		}
	}
}
