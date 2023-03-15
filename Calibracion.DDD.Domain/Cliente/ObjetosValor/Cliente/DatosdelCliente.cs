using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.Cliente.ObjetosValor.Cliente
{
    public class DatosdelCliente
    { 
        public string Laboratorio { get; init; }

        public string Codigo { get; init; }

        public DatosdelCliente(string laboratorio, string codigo)
        {
            Laboratorio = laboratorio;
            Codigo = codigo;
        }

        public static DatosdelCliente Create(string laboratorio, string codigo)
        {
            validate(laboratorio, codigo);
            return new DatosdelCliente(laboratorio, codigo);
        }

        public static void validate(string laboratorio, string codigo)
        {
            if (laboratorio == null)
            {
                throw new ArgumentNullException("El laboratorio no puede ser nulo");
            }
			if (codigo == null)
			{
				throw new ArgumentNullException("El codigo no puede ser nulo");
			}
		}
    }
}
