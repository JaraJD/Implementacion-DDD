using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.Comandos
{
	public class AddEstadoCommand
	{
		public string InstrumentoId { get; init; }

		public double Oimld10 { get; init; }

		public double ReaccionModificada { get; init; }

		public AddEstadoCommand(string instrumentoId, double oimld10, double reaccionModificada)
		{
			InstrumentoId = instrumentoId;
			Oimld10 = oimld10;
			ReaccionModificada = reaccionModificada;
		}
	}
}
