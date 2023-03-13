using Calibracion.DDD.Domain.Certificado.Comandos;
using Calibracion.DDD.UseCase.Gateways;
using Microsoft.AspNetCore.Mvc;

namespace Calibracion.DDD.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CertificadoController : ControllerBase
	{
		private readonly ICertificadoUseCase _useCase;

		public CertificadoController(ICertificadoUseCase createCertificadoUseCase)
		{
			_useCase = createCertificadoUseCase;
		}

		[HttpPost]
		public async Task Post(CreateCertificadoCommand command)
		{
			await _useCase.CrearCertificado(command);
		}

		[HttpPost("addAcount")]
		public async Task Add_Tecnico_To_Certificado(AddTecnicoCommand command)
		{
			await _useCase.AddTecnicoToCertificado(command);
		}
	}
}
