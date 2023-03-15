using Calibracion.DDD.Domain.Certificado.Entidades;
using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.DTO
{
	public class DatosEmisionDTO
	{
		public CertificadoId Id { get; private set; }

		public CertificadoDatosEmision Datos { get; private set; }

		public DatosEmisionDTO(CertificadoId id)
		{
			Id = id;
		}

		public void SetDatos(CertificadoDatosEmision datos)
		{
			Datos = datos;

		}
	}
}
