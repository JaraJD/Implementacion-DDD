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

        public PatronValorRef(double value)
        {
            Value = value;
        }

        public static PatronValorRef Create(double value)
        {
            validate(value);
            return new PatronValorRef(value);
        }

        public static void validate(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("El valor no puede ser 0 o menor a 0");
            }
        }
    }
}
