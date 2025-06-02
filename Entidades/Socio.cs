using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpIntegrador.Entidades
{
    public class Socio : Persona
    {
        public bool AptoFisico { get; set; } = true;
        public DateTime FechaAlta { get; set; } = DateTime.Now;
        public Socio(
            string nombre,
            string apellido,
            int dni,
            long telefono,
            string domicilio,
            string email,
            DateTime fechaNacimiento
        ) : base(nombre, apellido, dni, telefono, domicilio, email, fechaNacimiento)
        {

        }
    }
}
