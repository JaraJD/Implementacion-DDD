using Calibracion.DDD.Domain.Cliente.ObjetosValor.Cliente;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.Eventos
{
	public class DatosClienteAdded : DomainEvent
	{
		public DatosdelCliente Datos { get; set; }

		public DatosClienteAdded(DatosdelCliente datos) : base("datoscliente.agregados")
		{
			Datos = datos;
		}
	}
}
