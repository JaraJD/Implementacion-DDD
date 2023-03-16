using Calibracion.DDD.Domain.Cliente.ObjetosValor.Responsable;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Cliente.Entidades
{
    public class Responsable :  Entity<ResponsableId>
    {
        public DatosPersonales DatosPersonales { get; private set; }

        public Responsable(ResponsableId id) : base(id)
        {
        }

        public void SetDatosPersonales(DatosPersonales datos)
        {
            DatosPersonales = datos;
        }
    }
}
