using Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.ObjetosValor.ProcedimientoCalibracion
{
	public record Instrucciones
	{
		public string NumeroRepeticiones { get; init; }

		public string TiempoEstabilizacion { get; init; }

		internal Instrucciones(string numeroRepeticiones, string tiempoEstabilizacion)
		{
			NumeroRepeticiones = numeroRepeticiones;
			TiempoEstabilizacion = tiempoEstabilizacion;
		}

		public static Instrucciones Create(string numeroRepeticiones, string tiempoEstabilizacion)
		{
			validate(numeroRepeticiones, tiempoEstabilizacion);
			return new Instrucciones(numeroRepeticiones, tiempoEstabilizacion);
		}

		public static void validate(string numeroRepeticiones, string tiempoEstabilizacion)
		{
			if (numeroRepeticiones == null)
			{
				throw new ArgumentNullException("El numero de repeticiones no puede ser null");
			}
			if (tiempoEstabilizacion == null)
			{
				throw new ArgumentNullException("El tiempo de estabilizacion no puede ser nulo");
			}
		}
	}
}
