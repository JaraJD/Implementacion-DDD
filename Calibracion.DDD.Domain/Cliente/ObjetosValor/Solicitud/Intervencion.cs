using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.ObjetosValor.Solicitud
{
	public class Intervencion
	{
		public bool Calibracion { get; init; }

		public Intervencion(bool calibracion)
		{
			Calibracion = calibracion;
		}

		public static Intervencion Create(bool calibracion)
		{
			validate(calibracion);
			return new Intervencion(calibracion);
		}

		public static void validate(bool calibracion)
		{
			if (calibracion == null )
			{
				throw new ArgumentNullException("La intervencion no puede ser null");
			}
		}
	}
}
