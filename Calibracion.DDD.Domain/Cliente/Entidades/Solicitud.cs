
using Calibracion.DDD.Domain.Cliente.ObjetosValor.Solicitud;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Cliente.Entidades
{
    public class Solicitud : Entity<SolicitudId>
    {
        public SolicitudId Id { get; init; }

        public Intervencion Intervencion { get; private set; }

        public Cliente Cliente { get; private set; }

        public Solicitud(SolicitudId id) :  base(id)
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
