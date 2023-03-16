

namespace Calibracion.DDD.Domain.Certificado.ObjetosValor.Patron
{
    public record PatronTrazabilidad
    {
        public string NumeroCertificado { get; init; }

        public PatronTrazabilidad(string numeroCert)
        {
            NumeroCertificado = numeroCert;
        }

        public static PatronTrazabilidad Create(string numeroCert)
        {
            validate(numeroCert);
            return new PatronTrazabilidad(numeroCert);
        }

        public static void validate(string numeroCert)
        {
            if (numeroCert == null)
            {
                throw new ArgumentNullException("El numero de certificado no puede ser nulo");
            }
        }

    }
}
