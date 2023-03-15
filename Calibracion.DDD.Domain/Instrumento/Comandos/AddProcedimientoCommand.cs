using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.Comandos
{
	public class AddProcedimientoCommand
	{
		public string InstrumentoId { get; init; }

		public string NumeroRepeticiones { get; init; }

		public string TiempoEstabilizacion { get; init; }

		public AddProcedimientoCommand(string instrumentoId, string numeroRepeticiones, string tiempoEstabilizacion)
		{
			InstrumentoId = instrumentoId;
			NumeroRepeticiones = numeroRepeticiones;
			TiempoEstabilizacion = tiempoEstabilizacion;
		}
	}
}
