using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Patron;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
