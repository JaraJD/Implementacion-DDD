

namespace Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento
{
	public class DatosFabricacion
	{
		public string Marca { get; init; }

		public string Modelo { get; init; }

		public string Serie { get; init; }

		public DatosFabricacion(string marca, string modelo, string serie)
		{
			Marca = marca;
			Modelo = modelo;
			Serie = serie;
		}

		public static DatosFabricacion Create(string marca, string modelo, string serie)
		{
			validate(marca, modelo, serie);
			return new DatosFabricacion(marca, modelo, serie);
		}

		public static void validate(string marca, string modelo, string serie)
		{
			if (marca == null)
			{
				throw new ArgumentNullException("La marca no puede ser null");
			}
			if (modelo == null)
			{
				throw new ArgumentNullException("El modelo no puede ser nulo");
			}
			if (serie == null)
			{
				throw new ArgumentNullException("La serie no puede ser null");
			}
		}
	}
}
