using Calibracion.DDD.Domain.Cliente.ObjetosValor.Cliente;
using Calibracion.DDD.Domain.Cliente.Comandos;
using Calibracion.DDD.Domain.Cliente.Entidades;
using Calibracion.DDD.Domain.Cliente.Eventos;
using Calibracion.DDD.Domain.Cliente.ObjetosValor.Responsable;
using Calibracion.DDD.Domain.CommonsDDD;
using Calibracion.DDD.Domain.Generics;
using Calibracion.DDD.UseCase.Gateways;
using Newtonsoft.Json;
using Calibracion.DDD.Domain.Cliente.ObjetosValor.Solicitud;

namespace Calibracion.DDD.UseCase.UseCases
{
	public class ClienteUseCase :  IClienteUseCase
	{
		private readonly IStoredEventRepository<StoredEvent> _storedEventRepository;

		public ClienteUseCase(IStoredEventRepository<StoredEvent> ClienteRepository)
		{
			_storedEventRepository = ClienteRepository;
		}

		public async Task CreateCliente(CreateClienteCommand command)
		{
			var cliente = new Cliente(ClienteId.Of(Guid.NewGuid()));
			//var clienteCreado = new CertificadoDTO(certificado.Id);
			var datosCliente = DatosdelCliente.Create(
					   command.Laboratorio,
					   command.Codigo
					);

			cliente.SetCliente(cliente.Id);
			cliente.SetDatosdelCliente(datosCliente);

			//certificadoCreado.SetValoresTecnicos(valoresTecnicos);
			//certificadoCreado.SetDatosEmision(DatosEmision);

			List<DomainEvent> listDomain = cliente.getUncommittedChanges();
			await SaveEvents(listDomain);
		}

		public async Task AddResponsableACliente(AddResponsableCommand command)
		{
			var clienteCambio = new ClienteChangeApply();
			var listDomainEvent = await GetEventsByAggregateID(command.ClienteId);
			var clienteId = ClienteId.Of(Guid.Parse(command.ClienteId));
			var clienteGenerado = clienteCambio.CreateAggregate(listDomainEvent, clienteId);
			//var patronAgregado = new PatronAgregadoDTO(certificadoId);

			Responsable newResponsable = new Responsable(ResponsableId.Of(Guid.NewGuid()));
			var DatosResponsable = DatosPersonales.Create(
						command.Nombre,
						command.Cargo,
						command.Correo
					);

			newResponsable.SetDatosPersonales(DatosResponsable);

			clienteGenerado.SetResponsableACliente(newResponsable);
			//patronAgregado.SetPatron(newPatron);

			List<DomainEvent> listDomain = clienteGenerado.getUncommittedChanges();
			await SaveEvents(listDomain);
			//return patronAgregado;
		}


		public async Task AddSolicitudACliente(AddSolicitudCommand command)
		{
			var clienteCambio = new ClienteChangeApply();
			var listDomainEvent = await GetEventsByAggregateID(command.ClienteId);
			var clienteId = ClienteId.Of(Guid.Parse(command.ClienteId));
			var clienteGenerado = clienteCambio.CreateAggregate(listDomainEvent, clienteId);
			//var patronAgregado = new PatronAgregadoDTO(certificadoId);

			Solicitud newSolicitud = new Solicitud(SolicitudId.Of(Guid.NewGuid()));
			var intervencion = Intervencion.Create(
						command.Calibracion
					);

			newSolicitud.SetIntervencion(intervencion);

			clienteGenerado.SetSolicitudACliente(newSolicitud);
			//patronAgregado.SetPatron(newPatron);

			List<DomainEvent> listDomain = clienteGenerado.getUncommittedChanges();
			await SaveEvents(listDomain);
			//return patronAgregado;
		}

		private async Task SaveEvents(List<DomainEvent> list)
		{
			var array = list.ToArray();
			for (var index = 0; index < array.Length; index++)
			{
				var stored = new StoredEvent();
				stored.StoredId = Guid.NewGuid().ToString();
				stored.AggregateId = array[index].GetAggregateId();
				stored.StoredName = array[index].GetAggregate();
				switch (array[index])
				{
					case ClienteCreated clienteCreated:
						stored.EventBody = JsonConvert.SerializeObject(clienteCreated);
						break;
					case DatosClienteAdded datosClienteAdded:
						stored.EventBody = JsonConvert.SerializeObject(datosClienteAdded);
						break;
					case ResponsableAdded responsableAdded:
						stored.EventBody = JsonConvert.SerializeObject(responsableAdded);
						break;
					case ResponsableDatosAdded responsableDatosAdded:
						stored.EventBody = JsonConvert.SerializeObject(responsableDatosAdded);
						break;
					case SolicitudAdded solicitudAdded:
						stored.EventBody = JsonConvert.SerializeObject(solicitudAdded);
						break;
					case SolicitudIntervencionAdded solicitudIntervencionAdded:
						stored.EventBody = JsonConvert.SerializeObject(solicitudIntervencionAdded);
						break;
				}
				await _storedEventRepository.AddAsync(stored);

			}

			await _storedEventRepository.SaveChangesAsync();

		}

		private async Task<List<DomainEvent>> GetEventsByAggregateID(string aggregateId)
		{
			var listadoStoredEvents = await _storedEventRepository.GetEventsByAggregateId(aggregateId);

			if (listadoStoredEvents == null)
				throw new ArgumentException("No existe el Id del agregado en la base de datos");

			return listadoStoredEvents.Select(ev =>
			{
				string nombre = $"Calibracion.DDD.Domain.Cliente.Eventos.{ev.StoredName}, Calibracion.DDD.Domain";
				Type tipo = Type.GetType(nombre);
				DomainEvent eventoParseado = (DomainEvent)JsonConvert.DeserializeObject(ev.EventBody, tipo);
				return eventoParseado;

			}).ToList();
		}

	}
}
