using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Patron
{
    public record PatronTrazabilidad
    {
        public string NumeroCertificado { get; init; }

        public string FechaCalibracion { get; init; }

        public int IntervaloCalibracion { get; init; }

        internal PatronTrazabilidad(string numeroCert, string fechaCal, int intervaloCal)
        {
            NumeroCertificado = numeroCert;
            FechaCalibracion = fechaCal;
            IntervaloCalibracion = intervaloCal;
        }

        public static PatronTrazabilidad Create(string numeroCert, string fechaCal, int intervaloCal)
        {
            validate(numeroCert, fechaCal, intervaloCal);
            return new PatronTrazabilidad(numeroCert, fechaCal, intervaloCal);
        }

        public static void validate(string numeroCert, string fechaCal, int intervaloCal)
        {
            if (numeroCert == null)
            {
                throw new ArgumentNullException("El numero de certificado no puede ser nulo");
            }
            if (fechaCal == null)
            {
                throw new ArgumentNullException("La fecha de Calibracion no puede ser nulo");
            }
            if (intervaloCal == null)
            {
                throw new ArgumentNullException("El Intervalo de calibracion no puede ser nulo");
            }
        }

    }
}
