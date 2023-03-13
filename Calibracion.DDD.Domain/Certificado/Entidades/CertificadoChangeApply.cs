using Calibracion.DDD.Domain.Certificado.Eventos;
using Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.CertificadoCalibracion;
using Calibracion.DDD.Domain.CommonsDDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

					case TecnicoDatosAdded tecnicoDatosAdded:
						certificado.Tecnico.SetDatosPersonales(tecnicoDatosAdded.DatosPersonales);
						break;

					case TecnicoAdded tecnicoAdded:
						certificado.SetTecnicoAgregado(tecnicoAdded.Tecnico);
						break;
				}

			});
			return certificado;
		}
	}
}
