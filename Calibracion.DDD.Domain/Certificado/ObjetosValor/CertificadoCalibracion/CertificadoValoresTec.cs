using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion
{
    public record CertificadoValoresTec
    {
        public double ErrorFinal { get; init; }
        public double Indicacion { get; init; }
        public double Tolerancia { get; init; }

        internal CertificadoValoresTec(double errorFinal, double indicacion, double tolerancia)
        {
            ErrorFinal = errorFinal;
            Indicacion = indicacion;
            Tolerancia = tolerancia;
        }

        public static CertificadoValoresTec Create(double errorFinal, double indicacion, double tolerancia)
        {
            validate(errorFinal, indicacion, tolerancia);
            return new CertificadoValoresTec(errorFinal, indicacion, tolerancia);
        }

        private static void validate(double errorFinal, double indicacion, double tolerancia)
        {
            if (errorFinal == null)
            {
                throw new ArgumentNullException("El error no puede ser nulo");
            }
            if (indicacion == null)
            {
                throw new ArgumentNullException("La indicacion no puede ser nulo");
            }
            if (tolerancia == null)
            {
                throw new ArgumentNullException("La tolerancia no puede ser nulo");
            }
        }
    }
}
