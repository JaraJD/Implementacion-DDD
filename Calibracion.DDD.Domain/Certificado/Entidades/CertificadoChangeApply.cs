using Calibracion.DDD.Domain.Certificado.Eventos;
using Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion;
using Calibracion.DDD.Domain.CommonsDDD;

namespace Calibracion.DDD.Domain.Certificado.Entidades
{
	public class CertificadoChangeApply
	{
		public CertificadoCal CreateAggregate(List<DomainEvent> ev, CertificadoId id)
		{
			CertificadoCal certificado = new CertificadoCal(id);
			ev.ForEach(evento =>
			{
				switch (evento)
				{
					case ValoresTecAdded valoresTecAdded:
						certificado.SetValoresTecnicosAgregado(valoresTecAdded.Valores);
						break;

					case DatosEmisionAdded datosEmisionAdded:
						certificado.SetDatosEmisionAgregado(datosEmisionAdded.Datos);
						break;

					case DatosEmisionUpdated datosEmisionUpdated:
						certificado.SetDatosEmisionAgregado(datosEmisionUpdated.Datos);
						break;

					case TecnicoDatosAdded tecnicoDatosAdded:
						certificado.Tecnico.SetDatosPersonales(tecnicoDatosAdded.DatosPersonales);
						break;

					case TecnicoAdded tecnicoAdded:
						certificado.SetTecnicoAgregado(tecnicoAdded.Tecnico);
						break;

					case PatronAdded patronAdded:
						certificado.SetPatronAgregado(patronAdded.Patron);
						break;

					case PatronValorRefAdded patronValorRefAdded:
						certificado.Patron.SetValorRef(patronValorRefAdded.valor);
						break;

					case PatronTrazabilidadAdded patronTrazabilidadAdded:
						certificado.Patron.SetTrazabilidad(patronTrazabilidadAdded.Trazabilidad);
						break;

					case AgregadosIdAdded agregadosIdAdded:
						certificado.SetAgregadosIdAgregado(agregadosIdAdded.AgregadosIds);
						break;
				}

			});
			return certificado;
		}
	}
}
