using Calibracion.DDD.Domain.Certificado.ObjetosValor.Patron;
using Calibracion.DDD.Domain.CommonsDDD;

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
