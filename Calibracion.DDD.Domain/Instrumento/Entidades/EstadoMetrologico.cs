using Calibracion.DDD.Domain.CommonsDDD;
using Calibracion.DDD.Domain.Instrumento.ObjetosValor.EstadoMetrologico;

namespace Calibracion.DDD.Domain.Instrumento.Entidades
{
    public class EstadoMetrologico : Entity<EstadoMetrologicoId>
    {
        public IntervaloCalibracion IntervaloCalibracion { get; private set; }

        public EstadoMetrologico(EstadoMetrologicoId id) : base(id)
        {
        }

        public void SetIntervaloCalibracion(IntervaloCalibracion datos)
        {
            IntervaloCalibracion = datos;
        }
    }
}
