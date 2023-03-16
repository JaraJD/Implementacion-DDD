using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Certificado.ObjetosValor.Patron
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
