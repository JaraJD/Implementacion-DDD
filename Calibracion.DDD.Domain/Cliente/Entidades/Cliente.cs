using Calibracion.DDD.Domain.AggCliente.ObjetosValor.Cliente;

namespace Calibracion.DDD.Domain.Cliente.Entidades
{
    public class Cliente
    {
        public Guid Id { get; init; }

        public DatosdelCliente DatosCliente { get; private set; }

        public List<Solicitud> Solicitudes { get; private set; }

        public Responsable Responsable { get; private set; }

        public Cliente(Guid id)
        {
            Id = id;
            Solicitudes = new List<Solicitud>();
        }

        public void SetDatosdelCliente(DatosdelCliente datos)
        {
            DatosCliente = datos;
        }

        public void AddSolicitud(Solicitud solicitud)
        {
            Solicitudes.Add(solicitud);
        }

        public void SetResponsable(Responsable responsable)
        {
            Responsable = responsable;
        }
    }
}
