
using Calibracion.DDD.Domain.Certificado.ObjetosValor.Tecnico;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Certificado.Eventos
{
	public class TecnicoDatosAdded : DomainEvent
	{
		public TecnicoDatosPersonales DatosPersonales { get; set; }

		public TecnicoDatosAdded(TecnicoDatosPersonales datosPersonales) : base("datosPersonalestecnico.agregados")
		{
			DatosPersonales = datosPersonales;
		}
	}
}
