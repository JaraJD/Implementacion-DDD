using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Tecnico
{
    public record TecnicoId
    {
        public Guid Id { get; init; }

        internal TecnicoId(Guid id)
        {
            Id = id;
        }

        public static TecnicoId Create(Guid id)
        {
            return new TecnicoId(id);
        }

        public static implicit operator Guid(TecnicoId tecnicoId)
        {
            return tecnicoId.Id;
        }
    }
}
