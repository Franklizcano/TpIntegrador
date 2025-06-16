using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpIntegrador.Entidades
{
    public abstract class Persona
    {
        public int? Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public long Telefono { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public Persona(int? id, string nombre, string apellido, int dni, long telefono, string domicilio, string email, DateTime fechaNacimiento)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Domicilio = domicilio;
            Email = email;
        }
    }
}
