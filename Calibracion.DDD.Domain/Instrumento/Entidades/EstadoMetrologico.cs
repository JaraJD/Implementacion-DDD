using Calibracion.DDD.Domain.Instrumento.ObjetosValor.EstadoMetrologico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.Entidades
{
    public class EstadoMetrologico
    {
        public EstadoMetrologicoId Id { get; init; }

        public IntervaloCalibracion IntervaloCalibracion { get; private set; }

        public EstadoMetrologico(EstadoMetrologicoId id)
        {
            Id = id;
        }

        public void SetIntervaloCalibracion(IntervaloCalibracion datos)
        {
            IntervaloCalibracion = datos;
        }
    }
}
