using Calibracion.DDD.Domain.Certificado.Comandos;
using Calibracion.DDD.Domain.DTO;
using Calibracion.DDD.Domain.Generics;
using Calibracion.DDD.Pruebas.Builders;
using Calibracion.DDD.Pruebas.Builders.Certificado;
using Calibracion.DDD.UseCase.Gateways;
using Calibracion.DDD.UseCase.UseCases;
using Moq;

namespace Calibracion.DDD.Pruebas.UnitTests
{
	public class CertificadoUseCaseTest
	{
		private readonly Mock<IStoredEventRepository<StoredEvent>> _mockRepository;
		public CertificadoUseCaseTest()
		{
			_mockRepository = new();
		}

		[Fact]
		public async Task Create_Certificado()
		{
			//Arrange
			_mockRepository.Setup(repo => repo.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()))
				.ReturnsAsync(GetStoredEvent());

			_mockRepository.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
				.Returns(Task.FromResult<int>(200));

			//Act
			var useCase = new CertificadoUseCase(_mockRepository.Object);

			var res = await useCase.CrearCertificado(GetCertificadoCommand());

			//Assert
			_mockRepository.Verify(r => r.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()), Times.Exactly(4));

			_mockRepository.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));

			Assert.NotNull(res);
			Assert.IsType<CertificadoDTO>(res);
		}

		[Fact]
		public async Task Add_Tecnico_To_Certificado()
		{
			_mockRepository.Setup(repo => repo.GetEventsByAggregateId(It.IsAny<string>()))
				.Returns(Task.FromResult(GetListStoredEvent()));

			_mockRepository.Setup(repo => repo.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()))
				.ReturnsAsync(GetStoredEvent());

			_mockRepository.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
				.Returns(Task.FromResult(200));

			var useCase = new CertificadoUseCase(_mockRepository.Object);

			var res = await useCase.AddTecnicoToCertificado(GetAddTecnicoCommand());

			_mockRepository.Verify(r => r.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()), Times.Exactly(1));

			_mockRepository.Verify(r => r.GetEventsByAggregateId(It.IsAny<string>()), Times.Once);

			_mockRepository.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));

			Assert.NotNull(res);
			Assert.IsType<TecnicoAgregadoDTO>(res);
		}

		[Fact]
		public async Task Add_Patron_To_Certificado()
		{
			_mockRepository.Setup(repo => repo.GetEventsByAggregateId(It.IsAny<string>()))
				.Returns(Task.FromResult(GetListStoredEvent()));

			_mockRepository.Setup(repo => repo.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()))
				.ReturnsAsync(GetStoredEvent());

			_mockRepository.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
				.Returns(Task.FromResult(200));

			var useCase = new CertificadoUseCase(_mockRepository.Object);

			var res = await useCase.AddPatronToCertificado(GetAddPatronCommand());

			_mockRepository.Verify(r => r.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()), Times.Exactly(1));

			_mockRepository.Verify(r => r.GetEventsByAggregateId(It.IsAny<string>()), Times.Once);

			_mockRepository.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));

			Assert.NotNull(res);
			Assert.IsType<PatronAgregadoDTO>(res);
		}


		[Fact]
		public async Task Update_DatosEmision()
		{
			_mockRepository.Setup(repo => repo.GetEventsByAggregateId(It.IsAny<string>()))
				.Returns(Task.FromResult(GetListStoredEvent()));

			_mockRepository.Setup(repo => repo.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()))
				.ReturnsAsync(GetStoredEvent());

			_mockRepository.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
				.Returns(Task.FromResult(200));

			var useCase = new CertificadoUseCase(_mockRepository.Object);

			var res = await useCase.UpdateDatosEmision(GetUpdateDatosEmisionCommand());

			_mockRepository.Verify(r => r.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()), Times.Exactly(1));

			_mockRepository.Verify(r => r.GetEventsByAggregateId(It.IsAny<string>()), Times.Once);

			_mockRepository.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));

			Assert.NotNull(res);
			Assert.IsType<DatosEmisionDTO>(res);
		}


		private CreateCertificadoCommand GetCertificadoCommand() =>
			new CreateCertificadoCommandBuilder()
				.WithErrorFinal(2)
				.WithIndicacion(182)
				.WithTolerancia(5)
				.WithNumeroCertificado("Te-0001-23")
				.WithFechaRealizacion("2023/01/25")
				.WithFechaEmision("2023/01/26")
				.WithInstrumentoId("10d1ea49-4ba8-40a1-b433-195074ad2689")
				.WithClienteId("10d1eu49-4bt8-40a1-b433-195074ad2689")
				.Build();


		private StoredEvent GetStoredEvent() =>
			new StoredEventBuilder()
				.WithStoredId("1")
				.WithStoredName("CertificadoCreado")
				.WithAggregateId("Aggregate1")
				.WithEventBody("{\"Type\":\"datosemision.agregados\",\"DatosEmision\":{\"NumeroCertificado\":\"string\",\"FechaRealizacion\":\"string\",\"FechaEmision\":\"string\"}}")
				.Build();


		private List<StoredEvent> GetListStoredEvent() =>
			new()
			{
				new StoredEventBuilder()
				.WithStoredId("1")
				.WithStoredName("DatosEmisionAdded")
				.WithAggregateId("c11d7c42-10d5-4e77-ac50-f1ec4dc8d388")
				.WithEventBody("{\"Type\":\"datosemision.agregados\",\"DatosEmision\":{\"NumeroCertificado\":\"string\",\"FechaRealizacion\":\"string\",\"FechaEmision\":\"string\"}}")
				.Build(),

				new StoredEventBuilder()
				.WithStoredId("2")
				.WithStoredName("CertificadoCreado")
				.WithAggregateId("012dfccf-ceaf-457a-a0b7-87d6b9b9b3fc")
				.WithEventBody("{\"Type\":\"certificado.creado\",\"CertificadoId\":\"Calibracion.DDD.Domain.Certificado.ValueObjects.CertificadoCalibracion.CertificadoId\"}")
				.Build(),

				new StoredEventBuilder()
				.WithStoredId("3")
				.WithStoredName("TecnicoAdded")
				.WithAggregateId("458tfccf-ceaf-457a-a0b7-87d6eyf9b3fc")
				.WithEventBody("{\"Type\":\"Tecnico.agregado\",\"DatosEmision\":{\"NumeroCertificado\":\"string\",\"FechaRealizacion\":\"string\",\"FechaEmision\":\"string\"}}")
				.Build()
			};


		private AddTecnicoCommand GetAddTecnicoCommand() =>
		new AddTecnicoCommandBuilder()
				.WithCertificadoId("c11d7c42-10d5-4e77-ac50-f1ec4dc8d388")
				.WithNombre("Juan")
				.WithCargo("Metrologo")
				.WithCorreo("juan@metrologia.com")
				.Build();

		private AddPatronCommand GetAddPatronCommand() =>
		new AddPatronCommandBuilder()
				.WithCertificadoId("c11d7c42-10d5-4e77-ac50-f1ec4dc8d388")
				.WithValorReferencia(40)
				.WithNumeroCertificado("CMK-VL-2011")
				.Build();

		private UpdateDatosEmisionComman GetUpdateDatosEmisionCommand() =>
		new UpdateDatosEmisionCommanBuilder()
				.WithCertificadoId("c11d7c42-10d5-4e77-ac50-f1ec4dc8d388")
				.WithNumeroCertificado("TE-0004-23")
				.WithFechaRealizacion("2023/01/26")
				.WithFechaEmision("2023/01/29")
				.Build();
	}
}
