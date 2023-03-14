using Calibracion.DDD.Domain.Certificado.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.UseCase.Gateways
{
	public interface ICertificadoUseCase
	{
		Task CrearCertificado(CreateCertificadoCommand command);

		Task AddTecnicoToCertificado(AddTecnicoCommand command);

		Task AddPatronToCertificado(AddPatronCommand command);

		Task UpdateDatosEmision(UpdateDatosEmisionComman command);
	}
}
