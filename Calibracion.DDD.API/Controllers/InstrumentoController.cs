
using Calibracion.DDD.Domain.Instrumento.Comandos;
using Calibracion.DDD.UseCase.Gateways;
using Microsoft.AspNetCore.Mvc;

namespace Calibracion.DDD.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class InstrumentoController : ControllerBase
	{
		private readonly IInstrumentoUseCase _useCase;

		public InstrumentoController(IInstrumentoUseCase instrumentoUseCase)
		{
			_useCase = instrumentoUseCase;
		}

		[HttpPost]
		public async Task Post(CreateInstrumentoCommand command)
		{
			await _useCase.CreateInstrumento(command);
		}

		[HttpPost("AgregarEstadoMetrologico")]
		public async Task Add_Responsable_A_Cliente(AddEstadoCommand command)
		{
			await _useCase.AddEstadoAInstrumento(command);
		}

		//	[HttpPost("AgregarSolicitud")]
		//	public async Task Addsolicitud_A_Cliente(AddResponsableCommand command)
		//	{
		//		return await _useCase.addSolicitudACliente(command);
		//	}
	}
}

