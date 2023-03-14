using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Eventos
{
	public class DatosEmisionUpdated : DomainEvent
	{
		public CertificadoDatosEmision Datos { get; set; }

		public DatosEmisionUpdated(CertificadoDatosEmision datos) : base("datosemision.actualizados")
		{
			Datos = datos;
		}
	}
}
