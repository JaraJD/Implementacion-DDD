﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Comandos
{
	public class UpdateDatosEmisionComman
	{
		public string CertificadoId { get; init; }
		public string NumeroCertificado { get; init; }
		public string FechaRealizacion { get; init; }
		public string FechaEmision { get; init; }

		public UpdateDatosEmisionComman(string certificadoId, string numeroCertificado, string fechaRealizacion, string fechaEmision)
		{
			CertificadoId = certificadoId;
			NumeroCertificado = numeroCertificado;
			FechaRealizacion = fechaRealizacion;
			FechaEmision = fechaEmision;
		}
	}
}
