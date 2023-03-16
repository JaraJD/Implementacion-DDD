
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
		public async Task Add_Estado_A_Instrumento(AddEstadoCommand command)
		{
			await _useCase.AddEstadoAInstrumento(command);
		}

		[HttpPost("AgregarProcedimiento")]
		public async Task AddProcedimiento_A_Instrumento(AddProcedimientoCommand command)
		{
			await _useCase.AddProcedimientoAInstrumento(command);
		}
	}
}

