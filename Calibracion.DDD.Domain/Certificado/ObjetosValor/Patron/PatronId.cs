using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Patron
{
    public class PatronId : Identity
    {
        public PatronId(Guid id) : base(id) { }

		public static PatronId Of(Guid id)
        {
            return new PatronId(id);
        }
    }
}
