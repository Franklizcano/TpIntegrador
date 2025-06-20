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
        public bool CarnetEntregado { get; set; }
        public Socio(
            int? id,
            string nombre,
            string apellido,
            int dni,
            long telefono,
            string domicilio,
            string email,
            DateTime fechaNacimiento
        ) : base(id, nombre, apellido, dni, telefono, domicilio, email, fechaNacimiento)
        {

        }
    }
}
