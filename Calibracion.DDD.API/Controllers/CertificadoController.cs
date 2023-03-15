using Calibracion.DDD.Domain.Certificado.Comandos;
using Calibracion.DDD.Domain.DTO;
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
		public async Task<CertificadoDTO> Post(CreateCertificadoCommand command)
		{
			return await _useCase.CrearCertificado(command);
		}

		[HttpPost("AgregarTecnico")]
		public async Task<TecnicoAgregadoDTO> Add_Tecnico_To_Certificado(AddTecnicoCommand command)
		{
			return await _useCase.AddTecnicoToCertificado(command);
		}

		[HttpPost("AgregarPatron")]
		public async Task<PatronAgregadoDTO> AddPatron_To_Certificado(AddPatronCommand command)
		{
			return await _useCase.AddPatronToCertificado(command);
		}

		[HttpPut("ActualizarDatosEmision")]
		public async Task<DatosEmisionDTO> Update_Datos_Emision(UpdateDatosEmisionComman command)
		{
			return await _useCase.UpdateDatosEmision(command);
		}
	}
}
