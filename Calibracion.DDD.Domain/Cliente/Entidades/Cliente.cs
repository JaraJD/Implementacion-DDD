using Calibracion.DDD.Domain.Cliente.ObjetosValor.Cliente;
using Calibracion.DDD.Domain.Cliente.Eventos;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Cliente.Entidades
{
    public class Cliente : AggregateEvent<ClienteId>
    {
        public ClienteId Id { get; private set; }

        public DatosdelCliente DatosCliente { get; private set; }

        public Solicitud Solicitud { get; private set; }

        public Responsable Responsable { get; private set; }

        public Cliente(ClienteId id) : base(id)
        {
            Id = id;
        }

        public void SetCliente(ClienteId id)
        {
            AppendChange(new ClienteCreated(id.ToString()));
        }

		public void SetDatosdelCliente(DatosdelCliente datos)
		{
			AppendChange(new DatosClienteAdded(datos));
		}

        public void SetSolicitudACliente(Solicitud solicitud)
        {
            AppendChange(new SolicitudAdded(solicitud));
        }

        public void SetResponsableACliente(Responsable responsable)
		{
			AppendChange(new ResponsableAdded(responsable));
		}


		public void SetDatosdelClienteAgregado(DatosdelCliente datos)
        {
            DatosCliente = datos;
        }

        public void SetSolicitudAgregado(Solicitud solicitud)
        {
            Solicitud= solicitud;
        }

        public void SetResponsableAgregado(Responsable responsable)
        {
            Responsable = responsable;
        }

	}
}
