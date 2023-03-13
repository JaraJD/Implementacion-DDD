using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Tecnico;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Entidades
{
    public class Tecnico : Entity<TecnicoId>
    {
        public Guid Id { get; init; }

        public TecnicoDatosPersonales DatosPersonales { get; private set; }

        public Tecnico(TecnicoId id): base(id) { }

        public void SetDatosPersonales(TecnicoDatosPersonales datos)
        {
            DatosPersonales = datos;
        }
    }
}
