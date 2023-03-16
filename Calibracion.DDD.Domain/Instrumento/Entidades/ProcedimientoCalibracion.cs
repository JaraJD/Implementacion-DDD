using Calibracion.DDD.Domain.Instrumento.ObjetosValor.ProcedimientoCalibracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Instrumento.Entidades
{
    public class ProcedimientoCalibracion
    {
        public ProcedimientoId Id { get; init; }

        public Instrucciones Instrucciones { get; private set; }

        public ProcedimientoCalibracion(ProcedimientoId id)
        {
            Id = id;
        }

        public void SetInstrucciones(Instrucciones instrucciones)
        {
            Instrucciones = instrucciones;
        }
    }
}
