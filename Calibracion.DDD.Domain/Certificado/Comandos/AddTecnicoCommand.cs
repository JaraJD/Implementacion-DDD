﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Comandos
{
	public class AddTecnicoCommand
	{
		public string CertificadoId { get; init; }

		public string Nombre { get; init; }

		public string Cargo { get; init; }

		public string Correo { get; init; }

		public AddTecnicoCommand(string certificadoId, string nombre, string cargo, string correo)
		{
			CertificadoId = certificadoId;
			Nombre = nombre;
			Cargo = cargo;
			Correo = correo;
		}
	}
}
