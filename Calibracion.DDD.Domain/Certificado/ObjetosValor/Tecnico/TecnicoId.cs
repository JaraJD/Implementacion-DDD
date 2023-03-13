using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Tecnico
{
    public class TecnicoId : Identity
    {

        internal TecnicoId(Guid id) : base(id)
        {
        }

        public static TecnicoId Of(Guid id)
        {
            return new TecnicoId(id);
        }

    }
}
