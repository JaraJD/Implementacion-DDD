using Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.ObjetosValor.EstadoMetrologico
{
	public class IntervaloCalibracion
	{
		public double Oimld10 { get; init; }

		public double ReaccionModificada { get; init; }

		public IntervaloCalibracion(double oimld10, double reaccionModificada)
		{
			Oimld10 = oimld10;
			ReaccionModificada = reaccionModificada;
		}

		public static IntervaloCalibracion Create(double oimld10, double reaccionModificada)
		{
			validate(oimld10, reaccionModificada);
			return new IntervaloCalibracion(oimld10, reaccionModificada);
		}

		public static void validate(double oimld10, double reaccionModificada)
		{
			if (oimld10 <= 0) 
			{
				throw new ArgumentException("El intervalo OIMLD10 debe ser mayor a 0");
			}
			if (reaccionModificada <= 0) 
			{
				throw new ArgumentException("El intervalo reaccion modificada debe ser mayor a 0");
			}
		}
	}
}
