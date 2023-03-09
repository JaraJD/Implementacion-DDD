using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Patron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Certificado.Entidades
{
    public class Patron
    {
        public Guid Id { get; init; }

        public PatronValorRef ValorRef { get; private set; }

        public PatronTrazabilidad Trazabilidad { get; private set; }

        internal Patron(Guid id)
        {
            Id = id;
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
