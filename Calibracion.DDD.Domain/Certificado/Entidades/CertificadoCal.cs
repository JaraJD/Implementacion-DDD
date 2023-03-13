using Calibracion.DDD.Domain.Certificado.Eventos;
using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion;
using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Tecnico;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Certificado.Entidades
{
    public class CertificadoCal : AggregateEvent<CertificadoId>
    {
        public CertificadoId Id { get; init; }

		public CertificadoValoresTec ValoresTecnicos { get; private set; }

        public CertificadoDatosEmision DatosEmision { get; private set; }

        public virtual Tecnico Tecnico { get; private set; }

        public virtual Patron Patron { get; private set; }

        public CertificadoCal(CertificadoId id) : base(id) 
        {
            AppendChange(new CertificadoCreado(id.ToString()));
        }

        public void SetValoresTecnicos(CertificadoValoresTec valores)
        {
			AppendChange(new ValoresTecAdded(valores));

        }

		public void SetTecnicoACertificado(Tecnico tecnico)
		{
			AppendChange(new TecnicoAdded(tecnico));
		}

		public void SetTecnicoDatos(TecnicoDatosPersonales datos)
		{
			AppendChange(new TecnicoDatosAdded(datos));
		}

		public void SetTecnicoAgregado(Tecnico tecnico)
        {
			Tecnico = tecnico;
		}

		public void SetValoresTecnicosAgregado(CertificadoValoresTec valores)
		{
			ValoresTecnicos = valores;

		}

		public void SetPatronAgregado(Patron patron)
        {
            Patron = patron;
        }

		public void SetDatosEmision(CertificadoDatosEmision datos)
		{
			DatosEmision = datos;
		}

	}
}
