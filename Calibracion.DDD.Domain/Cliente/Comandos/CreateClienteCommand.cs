using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.Comandos
{
	public class CreateClienteCommand
	{
		public string Laboratorio { get; init; }

		public string Codigo { get; init; }

		public CreateClienteCommand(string laboratorio, string codigo)
		{
			Laboratorio = laboratorio;
			Codigo = codigo;
		}
	}
}
