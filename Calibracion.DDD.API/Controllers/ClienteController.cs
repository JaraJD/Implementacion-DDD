
using Calibracion.DDD.Domain.Cliente.Comandos;
using Calibracion.DDD.UseCase.Gateways;
using Microsoft.AspNetCore.Mvc;

namespace Calibracion.DDD.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ClienteController : ControllerBase
	{

		private readonly IClienteUseCase _useCase;

		public ClienteController(IClienteUseCase clienteUseCase)
		{
			_useCase = clienteUseCase;
		}

		[HttpPost]
		public async Task Post(CreateClienteCommand command)
		{
			 await _useCase.CreateCliente(command);
		}

		[HttpPost("AgregarResponsable")]
		public async Task Add_Responsable_A_Cliente(AddResponsableCommand command)
		{
			 await _useCase.AddResponsableACliente(command);
		}

		//	[HttpPost("AgregarSolicitud")]
		//	public async Task Addsolicitud_A_Cliente(AddResponsableCommand command)
		//	{
		//		return await _useCase.addSolicitudACliente(command);
		//	}
	}
}
