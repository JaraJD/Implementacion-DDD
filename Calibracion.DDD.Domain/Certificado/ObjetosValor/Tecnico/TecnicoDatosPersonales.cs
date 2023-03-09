using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CertificadoCalibracion.ObjetosValor.Tecnico
{
    public record TecnicoDatosPersonales
    {
        public string Nombre { get; init; }

        public string Cargo { get; init; }

        public string Correo { get; init; }

        internal TecnicoDatosPersonales(string nombre, string cargo, string correo)
        {
            Nombre = nombre;
            Cargo = cargo;
            Correo = correo;
        }

        public static TecnicoDatosPersonales Create(string nombre, string cargo, string correo)
        {
            validate(nombre, cargo, correo);
            return new TecnicoDatosPersonales(nombre, cargo, correo);
        }

        public static void validate(string nombre, string cargo, string correo)
        {
            if (nombre == null)
            {
                throw new ArgumentNullException("El nombre no puede ser nulo");
            }
            if (cargo == null)
            {
                throw new ArgumentNullException("El cargo no puede ser nulo");
            }
            if (correo == null)
            {
                throw new ArgumentNullException("El correo no puede ser nulo");
            }
        }
    }
}
