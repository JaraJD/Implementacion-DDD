
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Cliente.ObjetosValor.Cliente
{
    public class ClienteId : Identity
    {

        public ClienteId(Guid id) : base (id)
        {
        }

        public static ClienteId Of(Guid id)
        {
            return new ClienteId(id);
        }
    }
}
