using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion
{
    public class CertificadoId : Identity
    {

        public CertificadoId(Guid id) : base(id) { }

        public static CertificadoId Of(Guid id)
        {
            return new CertificadoId(id);
        }

    }
}
