using Calibracion.DDD.Domain.Certificado.Entidades;
using Calibracion.DDD.Domain.Certificado.Eventos;
using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion;
using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Tecnico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.DTO
{
	public class CertificadoDTO
	{
		public CertificadoId Id { get; private set; }

		public CertificadoValoresTec ValoresTecnicos { get; private set; }

		public CertificadoDatosEmision DatosEmision { get; private set; }

		public CertificadoDTO(CertificadoId id)
		{
			Id = id;
		}

		public void SetValoresTecnicos(CertificadoValoresTec valores)
		{
			ValoresTecnicos = valores;

		}

		public void SetDatosEmision(CertificadoDatosEmision datos)
		{
			DatosEmision = datos;
		}
	}
}
