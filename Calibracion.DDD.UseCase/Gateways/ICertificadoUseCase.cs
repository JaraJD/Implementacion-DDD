using Calibracion.DDD.Domain.Certificado.Comandos;
using Calibracion.DDD.Domain.Certificado.Entidades;
using Calibracion.DDD.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.UseCase.Gateways
{
	public interface ICertificadoUseCase
	{
		Task<CertificadoDTO> CrearCertificado(CreateCertificadoCommand command);

		Task<TecnicoAgregadoDTO> AddTecnicoToCertificado(AddTecnicoCommand command);

		Task<PatronAgregadoDTO> AddPatronToCertificado(AddPatronCommand command);

		Task<DatosEmisionDTO> UpdateDatosEmision(UpdateDatosEmisionComman command);
	}
}
