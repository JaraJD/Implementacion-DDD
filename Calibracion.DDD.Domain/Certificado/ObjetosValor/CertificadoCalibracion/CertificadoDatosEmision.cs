using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion
{
    public record CertificadoDatosEmision
    {
        public string NumeroCertificado { get; set; }

        public string FechaRealizacion { get; set; }

        public string FechaEmision { get; set; }

        public CertificadoDatosEmision(string numeroCertificado, string fechaRealizacion, string fechaEmision)
        {
            NumeroCertificado = numeroCertificado;
            FechaRealizacion = fechaRealizacion;
            FechaEmision = fechaEmision;
        }

        public static CertificadoDatosEmision Create(string numeroCertificado, string fechaRealizacion, string fechaEmision)
        {
            validate(numeroCertificado, fechaRealizacion, fechaEmision);
            return new CertificadoDatosEmision(numeroCertificado, fechaRealizacion, fechaEmision);
        }

        private static void validate(string numeroCertificado, string fechaRealizacion, string fechaEmision)
        {
            if (numeroCertificado == null)
            {
                throw new ArgumentNullException("El numero de certificado no puede ser nulo");
            }
            if (fechaRealizacion == null)
            {
                throw new ArgumentNullException("La fecha de realizacion no puede ser nulo");
            }
            if (fechaEmision == null)
            {
                throw new ArgumentNullException("La fecha de emision no puede ser nulo");
            }
        }
    }
}
