using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.Comandos
{
	public class AddResponsableCommand
	{

		public string ClienteId { get; init; }
		public string Nombre { get; init; }

		public string Cargo { get; init; }

		public string Correo { get; init; }

		public AddResponsableCommand(string clienteId, string nombre, string cargo, string correo)
		{
			ClienteId = clienteId;
			Nombre = nombre;
			Cargo = cargo;
			Correo = correo;
		}
	}
}
