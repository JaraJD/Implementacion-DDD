
using Calibracion.DDD.Domain.Instrumento.Comandos;

namespace Calibracion.DDD.UseCase.Gateways
{
	public interface IInstrumentoUseCase
	{
		Task CreateInstrumento(CreateInstrumentoCommand command);

		Task AddEstadoAInstrumento(AddEstadoCommand command);

		//Task AddProcedimientoAInstrumento(AddProcedimientoCommand command);
	}
}
