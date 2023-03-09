using Calibracion.DDD.Domain.AggCliente.ObjetosValor.Cliente;
using Calibracion.DDD.Domain.Cliente.Entidades;
using Calibracion.DDD.Domain.Cliente.ObjetosValor.Responsable;

namespace Calibracion.DDD.Domain.Cliente.Repositorios
{
    internal interface IClienteRepository
    {
        Task CreateCliente(Cliente.Entidades.Cliente cliente);

        Task AddSolicitud(Solicitud solicitud);

        Task AddResponsable(Responsable responsable);

        Task<Cliente.Entidades.Cliente> GetClienteById(ClienteId Id);

        Task UpdateActualizarDatosPersonales(DatosPersonales datos);
    }
}
