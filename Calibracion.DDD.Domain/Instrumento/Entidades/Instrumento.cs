using Calibracion.DDD.Domain.Cliente.Eventos;
using Calibracion.DDD.Domain.CommonsDDD;
using Calibracion.DDD.Domain.Instrumento.Eventos;
using Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento;

namespace Calibracion.DDD.Domain.Instrumento.Entidades
{
    public class Instrumento :  AggregateEvent<InstrumentoId>
    {
        public InstrumentoId Id { get; init; }

        public DatosFabricacion DatosFabricacion { get; private set; }

		public virtual EstadoMetrologico EstadoMet { get; private set; }

		public virtual ProcedimientoCalibracion Procedimiento { get; private set; }

		public Instrumento(InstrumentoId id) :  base (id)
        {
            Id = id;
        }

		public void SetInstrumento(InstrumentoId id)
		{
			AppendChange(new InstrumentoCreated(id.ToString()));
		}

        public void SetDatosFabricacion(DatosFabricacion datos)
        {
			AppendChange(new DatosFabricacionAdded(datos));
		}

		public void SetEstadoMetAInstrumento(EstadoMetrologico estado)
		{
			AppendChange(new EstadoAdded(estado));
		}

		public void SetProcedimientoAInstrumento(ProcedimientoCalibracion procedimiento)
		{
			AppendChange(new ProcedimientoAdded(procedimiento));
		}



		public void SetDatosFabricacionAgregado(DatosFabricacion datos)
		{
			DatosFabricacion = datos;
		}

		public void SetEstadoMetAgregado(EstadoMetrologico estado)
		{
			EstadoMet = estado;
		}

		public void SetProcedimientoAgregado(ProcedimientoCalibracion procedimiento)
		{
			Procedimiento = procedimiento;
		}
	}
}
