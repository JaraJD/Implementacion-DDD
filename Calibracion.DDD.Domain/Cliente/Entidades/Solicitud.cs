using Calibracion.DDD.Domain.AggCliente.ObjetosValor.Cliente;
using Calibracion.DDD.Domain.Cliente.ObjetosValor.Solicitud;

namespace Calibracion.DDD.Domain.Cliente.Entidades
{
    public class Solicitud
    {
        public Guid Id { get; init; }

        public Intervencion Intervencion { get; private set; }

        public Cliente Cliente { get; private set; }

        internal Solicitud(Guid id)
        {
            Id = id;
		}

        public void SetIntervencion(Intervencion intervencion)
        {
            Intervencion = intervencion;
        }

		public void SetCliente(Cliente cliente)
		{
			Cliente = cliente;
		}
	}
}
