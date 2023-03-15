using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.Comandos
{
	public class AddSolicitudCommand
	{
		public string ClienteId { get; init; }

		public bool Calibracion { get; init; }

		public AddSolicitudCommand(string clienteId, bool calibracion)
		{
			ClienteId = clienteId;
			Calibracion = calibracion;
		}
	}
}
