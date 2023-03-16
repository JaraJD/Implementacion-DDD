using Calibracion.DDD.Domain.Certificado.Comandos;
using Calibracion.DDD.Domain.Certificado.ObjetosValor.CertificadoCalibracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Pruebas.Builders.Certificado
{
    public class AddTecnicoCommandBuilder
    {
        public string CertificadoId { get; set; }

        public string Nombre { get; set; }

        public string Cargo { get; set; }

        public string Correo { get; set; }

        public AddTecnicoCommandBuilder WithCertificadoId(string certificadoId)
        {
            CertificadoId = certificadoId;
            return this;
        }

        public AddTecnicoCommandBuilder WithNombre(string nombre)
        {
            Nombre = nombre;
            return this;
        }

        public AddTecnicoCommandBuilder WithCargo(string cargo)
        {
            Cargo = cargo;
            return this;
        }

        public AddTecnicoCommandBuilder WithCorreo(string correo)
        {
            Correo = correo;
            return this;
        }
        public AddTecnicoCommand Build()
        {
			return new AddTecnicoCommand(CertificadoId, Nombre, Cargo, Correo);
		}
	}
}
