using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Tecnico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Entidades
{
    public class Tecnico
    {
        public Guid Id { get; init; }

        public TecnicoDatosPersonales DatosPersonales { get; private set; }

        internal Tecnico(Guid id)
        {
            Id = id;
        }

        public void SetDatosPersonales(TecnicoDatosPersonales datos)
        {
            DatosPersonales = datos;
        }
    }
}
