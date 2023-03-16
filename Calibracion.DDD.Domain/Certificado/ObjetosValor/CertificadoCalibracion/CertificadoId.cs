using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion
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
