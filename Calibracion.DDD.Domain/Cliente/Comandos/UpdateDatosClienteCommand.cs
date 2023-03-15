using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.Comandos
{
	public class UpdateDatosClienteCommand
	{
		public string ClienteId { get; init; }

		public string Laboratorio { get; init; }

		public string Codigo { get; init; }

		public UpdateDatosClienteCommand(string clienteId, string laboratorio, string codigo)
		{
			ClienteId = clienteId;
			Laboratorio = laboratorio;
			Codigo = codigo;
		}
	}
}
