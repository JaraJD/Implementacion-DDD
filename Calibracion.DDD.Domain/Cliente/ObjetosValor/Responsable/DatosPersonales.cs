using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Tecnico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.ObjetosValor.Responsable
{
	public record DatosPersonales
	{
		public string Nombre { get; init; }

		public string Cargo { get; init; }

		public string Correo { get; init; }

		internal DatosPersonales(string nombre, string cargo, string correo)
		{
			Nombre = nombre;
			Cargo = cargo;
			Correo = correo;
		}

		public static DatosPersonales Create(string nombre, string cargo, string correo)
		{
			validate(nombre, cargo, correo);
			return new DatosPersonales(nombre, cargo, correo);
		}

		public static void validate(string nombre, string cargo, string correo)
		{
			if (nombre == null)
			{
				throw new ArgumentNullException("El nombre no puede ser nulo");
			}
			if (cargo == null)
			{
				throw new ArgumentNullException("El cargo no puede ser nulo");
			}
			if (correo == null)
			{
				throw new ArgumentNullException("El correo no puede ser nulo");
			}
		}
	}
}
