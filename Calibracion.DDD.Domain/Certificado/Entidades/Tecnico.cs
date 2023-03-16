using Calibracion.DDD.Domain.Certificado.ObjetosValor.Tecnico;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Certificado.Entidades
{
    public class Tecnico : Entity<TecnicoId>
    {
        public TecnicoDatosPersonales DatosPersonales { get; private set; }

        public Tecnico(TecnicoId id): base(id) { }

        public void SetDatosPersonales(TecnicoDatosPersonales datos)
        {
            DatosPersonales = datos;
        }

	}
}
