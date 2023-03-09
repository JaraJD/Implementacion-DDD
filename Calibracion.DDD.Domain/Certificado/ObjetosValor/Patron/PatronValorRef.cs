using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Patron
{
    public record PatronValorRef
    {
        public double Value { get; init; }

        internal PatronValorRef(double value)
        {
            Value = value;
        }

        public static PatronValorRef Create(double value)
        {
            return new PatronValorRef(value);
        }

        public static void validate(double value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("El valor no puede ser nulo");
            }
        }
    }
}
