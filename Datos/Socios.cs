using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;
using TpIntegrador.Entidades;

namespace TpIntegrador.Datos
{
    internal class Socios
    {
        public int RegistrarSocio(Socio socio)
        {
            MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(
                            "INSERT INTO socios (nombre, apellido, dni, telefono, email, domicilio, apto_fisico, fecha_alta, fecha_nacimiento) " +
                            "VALUES (@nombre, @apellido, @dni, @telefono, @email, @domicilio, @aptoFisico, @fechaAlta, @fechaNacimiento); " +
                            "SELECT LAST_INSERT_ID();", conexion);
                
                comando.Parameters.AddWithValue("@nombre", socio.Nombre);
                comando.Parameters.AddWithValue("@apellido", socio.Apellido);
                comando.Parameters.AddWithValue("@dni", socio.Dni);
                comando.Parameters.AddWithValue("@telefono", socio.Telefono);
                comando.Parameters.AddWithValue("@email", socio.Email);
                comando.Parameters.AddWithValue("@domicilio", socio.Domicilio);
                comando.Parameters.AddWithValue("@aptoFisico", socio.AptoFisico);
                comando.Parameters.AddWithValue("@fechaNacimiento", socio.FechaNacimiento.Date);
                comando.Parameters.AddWithValue("@fechaAlta", socio.FechaAlta);

                object result = comando.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el socio: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public int ExisteSocio(int DNI)
        {
            MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(
                    "SELECT COUNT(*) FROM socios WHERE dni = @dni", conexion);
                comando.Parameters.AddWithValue("@dni", DNI);
                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar la existencia del socio: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
