using Calibracion.DDD.Domain.Certificado.Entidades;
using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Eventos
{
	public class ValoresTecAdded : DomainEvent
	{
		public CertificadoValoresTec Valores { get; set; }

		public ValoresTecAdded(CertificadoValoresTec valores) : base("valorestecnicos.agregados")
		{
			Valores = valores;
		}
	}
}
