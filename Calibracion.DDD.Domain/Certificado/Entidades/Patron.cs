
using Calibracion.DDD.Domain.Certificado.ObjetosValor.Patron;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Certificado.Entidades
{
    public class Patron : Entity<PatronId>
    {

        public PatronValorRef ValorRef { get; private set; }

        public PatronTrazabilidad Trazabilidad { get; private set; }

        public Patron(PatronId id) : base(id)
        {
        }

        public void SetValorRef(PatronValorRef valorRef)
        {
            ValorRef = valorRef;
        }

        public void SetTrazabilidad(PatronTrazabilidad datos)
        {
            Trazabilidad = datos;
        }


    }
}
