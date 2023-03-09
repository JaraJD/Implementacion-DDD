using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion;
using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Tecnico;
using Calibracion.DDD.Domain.Certificado.Entidades;

namespace Calibracion.DDD.Domain.Certificado.Repositorios
{
    public interface ICertificadoRepository
    {
        Task CreateCertificado(CertificadoCal certificadoCalibracion);

        Task AddTecnico(Tecnico tecnico);

        Task AddPatron(Patron patron);

		Task<CertificadoCal> GetCertificadoById(CertificadoId Id);

        Task UpdateDatosPersonalesTecnico(TecnicoDatosPersonales datos);


	}
}
