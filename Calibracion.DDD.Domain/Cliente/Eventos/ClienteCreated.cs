
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.Eventos
{
	public class ClienteCreated : DomainEvent
	{
		public String ClienteId { get; set; }

		public ClienteCreated(string clienteId) : base("cliente.creado")
		{
			ClienteId = clienteId;
		}
	}
}
