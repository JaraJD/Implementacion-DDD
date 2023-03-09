using Calibracion.DDD.Domain.Cliente.ObjetosValor.Responsable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.Entidades
{
    public class Responsable
    {
        public Guid Id { get; init; }

        public DatosPersonales DatosPersonales { get; private set; }

        internal Responsable(Guid id)
        {
            Id = id;
        }

        public void SetDatosPersonales(DatosPersonales datos)
        {
            DatosPersonales = datos;
        }
    }
}
