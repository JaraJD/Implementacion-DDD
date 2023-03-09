using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion;

namespace Calibracion.DDD.Domain.Certificado.Entidades
{
    public class CertificadoCal
    {
        public Guid Id { get; init; }

        public Guid ClienteId { get; private set; }

        public Guid InstrumentoId { get; private set; }

        public CertificadoValoresTec ValoresTecnicos { get; private set; }

        public CertificadoDatosEmision DatosEmision { get; private set; }

        public virtual Tecnico Tecnico { get; private set; }

        public virtual Patron Patron { get; private set; }

        public CertificadoCal(Guid id)
        {
            Id = id;
        }

        public void SetValoresTecnicos(CertificadoValoresTec valores)
        {
            ValoresTecnicos = valores;
        }

        public void SetDatosEmision(CertificadoDatosEmision datos)
        {
            DatosEmision = datos;
        }

        public void SetClienteId(Guid clienteId)
        {
            ClienteId = clienteId;
        }

        public void SetInstrumentoId(Guid instrumentoId)
        {
            InstrumentoId = instrumentoId;
        }

        public void SetTecnico(Tecnico tecnico)
        {
            Tecnico = tecnico;
        }

        public void SetPatron(Patron patron)
        {
            Patron = patron;
        }

    }
}
