using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Tecnico;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Eventos
{
	public class TecnicoDatosAdded : DomainEvent
	{
		public TecnicoDatosPersonales DatosPersonales { get; set; }

		public TecnicoDatosAdded(TecnicoDatosPersonales datosPersonales) : base("datosPersonalestecnico.agregados")
		{
			DatosPersonales = datosPersonales;
		}
	}
}
