using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Patron;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Eventos
{
	public class PatronValorRefAdded : DomainEvent
	{
		public PatronValorRef valor { get; set; }

		public PatronValorRefAdded(PatronValorRef valor) : base("valorreferenciapatron.agregado")
		{
			this.valor = valor;
		}
	}
}
