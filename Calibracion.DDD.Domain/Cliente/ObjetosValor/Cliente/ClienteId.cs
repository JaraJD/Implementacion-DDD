using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.AggCliente.ObjetosValor.Cliente
{
    public record ClienteId
    {
        public Guid Id { get; init; }

        internal ClienteId(Guid id)
        {
            Id = id;
        }

        public static ClienteId Create(Guid id)
        {
            return new ClienteId(id);
        }

        public static implicit operator Guid(ClienteId clienteId)
        {
            return clienteId.Id;
        }
    }
}
