using Calibracion.DDD.Domain.Cliente.ObjetosValor.Responsable;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.Entidades
{
    public class Responsable :  Entity<ResponsableId>
    {
        public ResponsableId Id { get; init; }

        public DatosPersonales DatosPersonales { get; private set; }

        public Responsable(ResponsableId id) : base(id)
        {
            Id = id;
        }

        public void SetDatosPersonales(DatosPersonales datos)
        {
            DatosPersonales = datos;
        }
    }
}
