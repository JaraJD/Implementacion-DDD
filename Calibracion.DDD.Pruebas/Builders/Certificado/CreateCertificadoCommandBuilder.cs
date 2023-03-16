using Calibracion.DDD.Domain.Certificado.Comandos;
using Calibracion.DDD.Domain.Cliente.ObjetosValor.Cliente;
using Calibracion.DDD.Domain.Instrumento.ObjetosValor.Instrumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Pruebas.Builders.Certificado
{
	public class CreateCertificadoCommandBuilder
	{
		public double ErrorFinal { get; set; }
		public double Indicacion { get; set; }
		public double Tolerancia { get; set; }
		public string NumeroCertificado { get; set; }
		public string FechaRealizacion { get; set; }
		public string FechaEmision { get; set; }
		public string InstrumentoId { get; set; }
		public string ClienteId { get; set; }

		public CreateCertificadoCommandBuilder WithErrorFinal(double errorFinal)
		{
			ErrorFinal = errorFinal;
			return this;
		}

		public CreateCertificadoCommandBuilder WithIndicacion(double indicacion)
		{
			Indicacion = indicacion;
			return this;
		}

		public CreateCertificadoCommandBuilder WithTolerancia(double tolerancia)
		{
			Tolerancia = tolerancia;
			return this;
		}

		public CreateCertificadoCommandBuilder WithNumeroCertificado(string numeroCertificado)
		{
			NumeroCertificado = numeroCertificado;
			return this;
		}

		public CreateCertificadoCommandBuilder WithFechaRealizacion(string fechaRealizacion)
		{
			FechaRealizacion = fechaRealizacion;
			return this;
		}

		public CreateCertificadoCommandBuilder WithFechaEmision(string fechaEmision)
		{
			FechaEmision = fechaEmision;
			return this;
		}

		public CreateCertificadoCommandBuilder WithInstrumentoId(string instrumentoId)
		{
			InstrumentoId = instrumentoId;
			return this;
		}

		public CreateCertificadoCommandBuilder WithClienteId(string clienteId)
		{
			ClienteId = clienteId;
			return this;
		}

		public CreateCertificadoCommand Build()
		{
			return new CreateCertificadoCommand(ErrorFinal, Indicacion, Tolerancia, NumeroCertificado, FechaRealizacion, FechaEmision, InstrumentoId, ClienteId);
		}
	}
}
