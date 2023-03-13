using Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento;

namespace Calibracion.DDD.Domain.Instrumento.Entidades
{
    public class Instrumento
    {
        public Guid Id { get; init; }

		public Guid EstadoId { get; private set; }

		public Guid ProcedimientoId { get; private set; }

        public DatosFabricacion DatosFabricacion { get; private set; }

		public virtual EstadoMetrologico EstadoMet { get; private set; }

		public virtual ProcedimientoCalibracion Procedimiento { get; private set; }

		internal Instrumento(Guid id)
        {
            Id = id;
        }

        public void SetDatosFabricacion(DatosFabricacion datos)
        {
            DatosFabricacion = datos;
        }

		public void SetEstadoMet(EstadoMetrologico estado)
		{
			EstadoMet = estado;
		}

		public void SetProcedimiento(ProcedimientoCalibracion procedimiento)
		{
			Procedimiento = procedimiento;
		}

		public void SetEstadoId(Guid Id)
		{
			EstadoId = Id;
		}

		public void SetProcedimientoId(Guid Id)
		{
			ProcedimientoId = Id;
		}
	}
}
