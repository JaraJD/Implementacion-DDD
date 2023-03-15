using Calibracion.DDD.Domain.Cliente.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.UseCase.Gateways
{
	public interface IClienteUseCase
	{
		Task CreateCliente(CreateClienteCommand command);

		Task AddResponsableACliente(AddResponsableCommand command);

		//Task addSolicitudACliente(AddSolicitudCommand command);

		//Task UpdateDatosCliente(UpdateDatosClienteCommand command);
	}
}
