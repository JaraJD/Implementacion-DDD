using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Certificado.ObjetosValor.Tecnico
{
    public class TecnicoId : Identity
    {

        public TecnicoId(Guid id) : base(id)
        {
        }

        public static TecnicoId Of(Guid id)
        {
            return new TecnicoId(id);
        }

    }
}
