using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion
{
    public record CertificadoId
    {
        public Guid Id { get; init; }

        internal CertificadoId(Guid id)
        {
            Id = id;
        }

        public static CertificadoId Create(Guid id)
        {
            return new CertificadoId(id);
        }

        public static implicit operator Guid(CertificadoId certificadoId)
        {
            return certificadoId.Id;
        }
    }
}
