using Calibracion.DDD.Domain.Certificado.Comandos;
using Calibracion.DDD.Domain.Certificado.Entidades;
using Calibracion.DDD.Domain.Certificado.Eventos;
using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion;
using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Tecnico;
using Calibracion.DDD.Domain.CommonsDDD;
using Calibracion.DDD.Domain.Generics;
using Calibracion.DDD.UseCase.Gateways;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.UseCase.UseCases
{
	public class CertificadoUseCase : ICertificadoUseCase
	{
		private readonly IStoredEventRepository<StoredEvent> _storedEventRepository;

		public CertificadoUseCase(IStoredEventRepository<StoredEvent> studentRepository)
		{
			_storedEventRepository = studentRepository;
		}

		public async Task AddTecnicoToCertificado(AddTecnicoCommand command)
		{
			var certificadoCambio = new CertificadoChangeApply();
			var listDomainEvent = await GetEventsByAggregateID(command.CertificadoId);
			var certificadoId = CertificadoId.Of(Guid.Parse(command.CertificadoId));
			var certificadoGenerado = certificadoCambio.CreateAggregate(listDomainEvent, certificadoId);

			Tecnico newTecnico = new Tecnico(TecnicoId.Of(Guid.NewGuid()));

			certificadoGenerado.SetTecnicoACertificado(newTecnico);

			List<DomainEvent> listDomain = certificadoGenerado.getUncommittedChanges();
			await SaveEvents(listDomain);

		}

		public async Task CrearCertificado(CreateCertificadoCommand command)
		{

			var certificado = new CertificadoCal(CertificadoId.Of(Guid.NewGuid()));
			var valoresTecnicos = CertificadoValoresTec.Create(
					   command.ErrorFinal,
					   command.Indicacion,
					   command.Tolerancia
					);

			certificado.SetValoresTecnicos(valoresTecnicos);
			List<DomainEvent> listDomain = certificado.getUncommittedChanges();
			await SaveEvents(listDomain);

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
					case ValoresTecAdded valoresTecAdded:
						stored.EventBody = JsonConvert.SerializeObject(valoresTecAdded);
						break;
					case TecnicoAdded tecnicoAdded:
						stored.EventBody = JsonConvert.SerializeObject(tecnicoAdded);
						break;
					case TecnicoDatosAdded tecnicoDatosAdded:
						stored.EventBody = JsonConvert.SerializeObject(tecnicoDatosAdded);
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
