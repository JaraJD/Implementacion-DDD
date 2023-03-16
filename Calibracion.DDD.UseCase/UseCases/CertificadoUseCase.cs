using Calibracion.DDD.Domain.Certificado.Comandos;
using Calibracion.DDD.Domain.Certificado.Entidades;
using Calibracion.DDD.Domain.Certificado.Eventos;
using Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion;
using Calibracion.DDD.Domain.Certificado.ObjetosValor.Patron;
using Calibracion.DDD.Domain.Certificado.ObjetosValor.Tecnico;
using Calibracion.DDD.Domain.CommonsDDD;
using Calibracion.DDD.Domain.DTO;
using Calibracion.DDD.Domain.Generics;
using Calibracion.DDD.UseCase.Gateways;
using Newtonsoft.Json;

namespace Calibracion.DDD.UseCase.UseCases
{
	public class CertificadoUseCase : ICertificadoUseCase
	{
		private readonly IStoredEventRepository<StoredEvent> _storedEventRepository;

		public CertificadoUseCase(IStoredEventRepository<StoredEvent> certificadoRepository)
		{
			_storedEventRepository = certificadoRepository;
		}

		public async Task<TecnicoAgregadoDTO> AddTecnicoToCertificado(AddTecnicoCommand command)
		{
			var certificadoCambio = new CertificadoChangeApply();
			var listDomainEvent = await GetEventsByAggregateID(command.CertificadoId);
			var certificadoId = CertificadoId.Of(Guid.Parse(command.CertificadoId));
			var certificadoGenerado = certificadoCambio.CreateAggregate(listDomainEvent, certificadoId);
			var tecnicoAgregado = new TecnicoAgregadoDTO(certificadoId);

			Tecnico newTecnico = new Tecnico(TecnicoId.Of(Guid.NewGuid()));
			var datosPersoanles = TecnicoDatosPersonales.Create(
					   command.Nombre,
					   command.Cargo,
					   command.Correo
					);
			newTecnico.SetDatosPersonales( datosPersoanles );


			certificadoGenerado.SetTecnicoACertificado(newTecnico);
			tecnicoAgregado.SetTecnico(newTecnico);

			List<DomainEvent> listDomain = certificadoGenerado.getUncommittedChanges();
			await SaveEvents(listDomain);
			return tecnicoAgregado;
		}

		public async Task<PatronAgregadoDTO> AddPatronToCertificado(AddPatronCommand command)
		{
			var certificadoCambio = new CertificadoChangeApply();
			var listDomainEvent = await GetEventsByAggregateID(command.CertificadoId);
			var certificadoId = CertificadoId.Of(Guid.Parse(command.CertificadoId));
			var certificadoGenerado = certificadoCambio.CreateAggregate(listDomainEvent, certificadoId);
			var patronAgregado = new PatronAgregadoDTO(certificadoId);

			Patron newPatron = new Patron(PatronId.Of(Guid.NewGuid()));
			var ValorReferencia = PatronValorRef.Create(command.ValorReferencia);
			var Trazabilidad = PatronTrazabilidad.Create(command.NumeroCertificado);

			newPatron.SetValorRef(ValorReferencia);
			newPatron.SetTrazabilidad(Trazabilidad);

			certificadoGenerado.SetPatronACertificado(newPatron);
			patronAgregado.SetPatron(newPatron);

			List<DomainEvent> listDomain = certificadoGenerado.getUncommittedChanges();
			await SaveEvents(listDomain);
			return patronAgregado;
		}

		public async Task<DatosEmisionDTO> UpdateDatosEmision(UpdateDatosEmisionComman command)
		{
			var certificadoCambio = new CertificadoChangeApply();
			var listDomainEvent = await GetEventsByAggregateID(command.CertificadoId);
			var certificadoId = CertificadoId.Of(Guid.Parse(command.CertificadoId));
			var certificadoGenerado = certificadoCambio.CreateAggregate(listDomainEvent, certificadoId);
			var DatosEmisionActualizados = new DatosEmisionDTO(certificadoId);

			var DatosEmision = CertificadoDatosEmision.Create(
				command.NumeroCertificado,
				command.FechaRealizacion,
				command.FechaEmision);


			certificadoGenerado.UpdateDatosEmision(DatosEmision);
			DatosEmisionActualizados.SetDatos(DatosEmision);

			List<DomainEvent> listDomain = certificadoGenerado.getUncommittedChanges();
			await SaveEvents(listDomain);
			return DatosEmisionActualizados;
		}

		public async Task<CertificadoDTO> CrearCertificado(CreateCertificadoCommand command)
		{

			var certificado = new CertificadoCal(CertificadoId.Of(Guid.NewGuid()));
			var certificadoCreado = new CertificadoDTO(certificado.Id);

			var agregadosId = AgregadosIds.Create(
				command.InstrumentoId,
				command.ClienteId
				);
			var valoresTecnicos = CertificadoValoresTec.Create(
				command.ErrorFinal,
				command.Indicacion,
				command.Tolerancia
				);
			var DatosEmision = CertificadoDatosEmision.Create(
				command.NumeroCertificado,
				command.FechaRealizacion,
				command.FechaEmision
				);


			certificado.setCertificado(certificado.Id);
			certificado.SetAgregadosIdACertificado(agregadosId);
			certificado.SetValoresTecnicos(valoresTecnicos);
			certificado.SetDatosEmision(DatosEmision);

			certificadoCreado.SetAgregadosIds(agregadosId);
			certificadoCreado.SetValoresTecnicos(valoresTecnicos);
			certificadoCreado.SetDatosEmision(DatosEmision);

			List<DomainEvent> listDomain = certificado.getUncommittedChanges();
			await SaveEvents(listDomain);
			return certificadoCreado;
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
					case CertificadoCreado certificadoCreado:
						stored.EventBody = JsonConvert.SerializeObject(certificadoCreado);
						break;
					case AgregadosIdAdded agregadosIdAdded:
						stored.EventBody = JsonConvert.SerializeObject(agregadosIdAdded);
						break;
					case ValoresTecAdded valoresTecAdded:
						stored.EventBody = JsonConvert.SerializeObject(valoresTecAdded);
						break;
					case DatosEmisionAdded datosEmisionAdded:
						stored.EventBody = JsonConvert.SerializeObject(datosEmisionAdded);
						break;
					case DatosEmisionUpdated datosEmisionUpdated:
						stored.EventBody = JsonConvert.SerializeObject(datosEmisionUpdated);
						break;
					case TecnicoAdded tecnicoAdded:
						stored.EventBody = JsonConvert.SerializeObject(tecnicoAdded);
						break;
					case TecnicoDatosAdded tecnicoDatosAdded:
						stored.EventBody = JsonConvert.SerializeObject(tecnicoDatosAdded);
						break;
					case PatronAdded patronAdded:
						stored.EventBody = JsonConvert.SerializeObject(patronAdded);
						break;
					case PatronValorRefAdded patronValorRefAdded:
						stored.EventBody = JsonConvert.SerializeObject(patronValorRefAdded);
						break;
					case PatronTrazabilidadAdded patronTrazabilidadAdded:
						stored.EventBody = JsonConvert.SerializeObject(patronTrazabilidadAdded);
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
				string nombre = $"Calibracion.DDD.Domain.Certificado.Eventos.{ev.StoredName}, Calibracion.DDD.Domain";
				Type tipo = Type.GetType(nombre);
				DomainEvent eventoParseado = (DomainEvent)JsonConvert.DeserializeObject(ev.EventBody, tipo);
				return eventoParseado;

			}).ToList();
		}
	}
}
