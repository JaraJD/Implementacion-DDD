
using Calibracion.DDD.Domain.CommonsDDD;
using Calibracion.DDD.Domain.Instrumento.Eventos;
using Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento;

namespace Calibracion.DDD.Domain.Instrumento.Entidades
{
	public class InstrumentoChangeApply
	{
		public Instrumento CreateAggregate(List<DomainEvent> ev, InstrumentoId id)
		{
			Instrumento instrumento = new Instrumento(id);
			ev.ForEach(evento =>
			{
				switch (evento)
				{
					case DatosFabricacionAdded datosFabricacionAdded:
						instrumento.SetDatosFabricacionAgregado(datosFabricacionAdded.Datos);
						break;

					case EstadoAdded estadoAdded:
						instrumento.SetEstadoMetAgregado(estadoAdded.Estado);
						break;

					case ProcedimientoAdded procedimientoAdded:
						instrumento.SetProcedimientoAgregado(procedimientoAdded.Procedimiento);
						break;
				}

			});
			return instrumento;
		}
	}
}
