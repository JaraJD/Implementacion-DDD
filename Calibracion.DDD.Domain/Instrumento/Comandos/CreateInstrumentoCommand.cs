using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.Comandos
{
	public class CreateInstrumentoCommand
	{
		public string Marca { get; init; }

		public string Modelo { get; init; }

		public string Serie { get; init; }

		public CreateInstrumentoCommand(string marca, string modelo, string serie)
		{
			Marca = marca;
			Modelo = modelo;
			Serie = serie;
		}
	}
}
