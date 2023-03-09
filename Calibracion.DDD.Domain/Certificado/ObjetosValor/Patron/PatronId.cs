using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Patron
{
    internal class PatronId
    {
        public Guid Id { get; set; }

        internal PatronId(Guid id)
        {
            Id = id;
        }

        public static PatronId Create(Guid id)
        {
            return new PatronId(id);
        }

        public static implicit operator Guid(PatronId patronId)
        {
            return patronId.Id;
        }
    }
}
