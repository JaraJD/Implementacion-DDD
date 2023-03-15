using Calibracion.DDD.Domain.Cliente.ObjetosValor.Cliente;
using Calibracion.DDD.Domain.Cliente.Eventos;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Cliente.Entidades
{
	public class ClienteChangeApply
	{
		public Cliente CreateAggregate(List<DomainEvent> ev, ClienteId id)
		{
			Cliente cliente = new Cliente(id);
			ev.ForEach(evento =>
			{
				switch (evento)
				{
					case DatosClienteAdded datosClienteAdded:
						cliente.SetDatosdelClienteAgregado(datosClienteAdded.Datos);
						break;

					case ResponsableAdded responsableAdded:
						cliente.SetResponsableAgregado(responsableAdded.Responsable);
						break;

					case SolicitudAdded solicitudAdded:
						cliente.SetSolicitudAgregado(solicitudAdded.solicitud);
						break;
				}

			});
			return cliente;
		}
	}
}
