using Calibracion.DDD.Domain.Cliente.Entidades;
using Calibracion.DDD.Domain.Cliente.Eventos;
using Calibracion.DDD.Domain.Cliente.ObjetosValor.Cliente;
using Calibracion.DDD.Domain.Cliente.ObjetosValor.Responsable;
using Calibracion.DDD.Domain.CommonsDDD;
using Calibracion.DDD.Domain.Generics;
using Calibracion.DDD.Domain.Instrumento.Comandos;
using Calibracion.DDD.Domain.Instrumento.Entidades;
using Calibracion.DDD.Domain.Instrumento.Eventos;
using Calibracion.DDD.Domain.Instrumento.ObjetosValor.EstadoMetrologico;
using Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento;
using Calibracion.DDD.Domain.Instrumento.ObjetosValor.ProcedimientoCalibracion;
using Calibracion.DDD.UseCase.Gateways;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.UseCase.UseCases
{
	public class InstrumentoUseCase : IInstrumentoUseCase
	{
		private readonly IStoredEventRepository<StoredEvent> _storedEventRepository;

		public InstrumentoUseCase(IStoredEventRepository<StoredEvent> instrumentoRepository)
		{
			_storedEventRepository = instrumentoRepository;
		}

		public async Task CreateInstrumento(CreateInstrumentoCommand command)
		{
			var instrumento = new Instrumento(InstrumentoId.Of(Guid.NewGuid()));
			var datosFabricacion = DatosFabricacion.Create(
					command.Marca,
					command.Modelo,
					command.Serie
					);

			instrumento.SetInstrumento(instrumento.Id);
			instrumento.SetDatosFabricacion(datosFabricacion);

			List<DomainEvent> listDomain = instrumento.getUncommittedChanges();
			await SaveEvents(listDomain);
		}

		public async Task AddEstadoAInstrumento(AddEstadoCommand command)
		{
			var instrumentoCambio = new InstrumentoChangeApply();
			var listDomainEvent = await GetEventsByAggregateID(command.InstrumentoId);
			var instrumentoId = InstrumentoId.Of(Guid.Parse(command.InstrumentoId));
			var InstrumentoGenerado = instrumentoCambio.CreateAggregate(listDomainEvent, instrumentoId);
			//var patronAgregado = new PatronAgregadoDTO(certificadoId);

			EstadoMetrologico newEstado = new EstadoMetrologico(EstadoMetrologicoId.Of(Guid.NewGuid()));
			var Intervalo = IntervaloCalibracion.Create(
						command.Oimld10,
						command.ReaccionModificada
					);

			newEstado.SetIntervaloCalibracion(Intervalo);

			InstrumentoGenerado.SetEstadoMetAInstrumento(newEstado);
			//patronAgregado.SetPatron(newPatron);

			List<DomainEvent> listDomain = InstrumentoGenerado.getUncommittedChanges();
			await SaveEvents(listDomain);
			//return patronAgregado;
		}

		public async Task AddProcedimientoAInstrumento(AddProcedimientoCommand command)
		{
			var instrumentoCambio = new InstrumentoChangeApply();
			var listDomainEvent = await GetEventsByAggregateID(command.InstrumentoId);
			var instrumentoId = InstrumentoId.Of(Guid.Parse(command.InstrumentoId));
			var InstrumentoGenerado = instrumentoCambio.CreateAggregate(listDomainEvent, instrumentoId);
			//var patronAgregado = new PatronAgregadoDTO(certificadoId);

			ProcedimientoCalibracion newProcedimiento = new ProcedimientoCalibracion(ProcedimientoId.Of(Guid.NewGuid()));
			var instrucciones = Instrucciones.Create(
						command.NumeroRepeticiones,
						command.TiempoEstabilizacion
					);

			newProcedimiento.SetInstrucciones(instrucciones);

			InstrumentoGenerado.SetProcedimientoAInstrumento(newProcedimiento);
			//patronAgregado.SetPatron(newPatron);

			List<DomainEvent> listDomain = InstrumentoGenerado.getUncommittedChanges();
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
					case InstrumentoCreated instrumentoCreated:
						stored.EventBody = JsonConvert.SerializeObject(instrumentoCreated);
						break;
					case DatosFabricacionAdded datosFabricacionAdded:
						stored.EventBody = JsonConvert.SerializeObject(datosFabricacionAdded);
						break;
					case EstadoAdded estadoAdded:
						stored.EventBody = JsonConvert.SerializeObject(estadoAdded);
						break;
					case ProcedimientoAdded procedimientoAdded:
						stored.EventBody = JsonConvert.SerializeObject(procedimientoAdded);
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
				string nombre = $"Calibracion.DDD.Domain.Instrumento.Eventos.{ev.StoredName}, Calibracion.DDD.Domain";
				Type tipo = Type.GetType(nombre);
				DomainEvent eventoParseado = (DomainEvent)JsonConvert.DeserializeObject(ev.EventBody, tipo);
				return eventoParseado;

			}).ToList();
		}
	}
}
