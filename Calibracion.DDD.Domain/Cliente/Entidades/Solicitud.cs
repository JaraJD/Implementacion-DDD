
using Calibracion.DDD.Domain.Cliente.ObjetosValor.Solicitud;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Cliente.Entidades
{
    public class Solicitud : Entity<SolicitudId>
    {
        public Intervencion Intervencion { get; private set; }

        public Solicitud(SolicitudId id) :  base(id)
        {
		}

        public void SetIntervencion(Intervencion intervencion)
        {
            Intervencion = intervencion;
        }

	}
}
