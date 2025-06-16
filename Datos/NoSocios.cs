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
    internal class NoSocios
    {
        public int RegistrarNoSocio(NoSocio noSocio)
        {
            MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(
                            "INSERT INTO nosocios (nombre, apellido, dni, telefono, email, domicilio, fecha_nacimiento) " +
                            "VALUES (@nombre, @apellido, @dni, @telefono, @email, @domicilio, @fechaNacimiento); " +
                            "SELECT LAST_INSERT_ID();", conexion);
                
                comando.Parameters.AddWithValue("@nombre", noSocio.Nombre);
                comando.Parameters.AddWithValue("@apellido", noSocio.Apellido);
                comando.Parameters.AddWithValue("@dni", noSocio.Dni);
                comando.Parameters.AddWithValue("@telefono", noSocio.Telefono);
                comando.Parameters.AddWithValue("@email", noSocio.Email);
                comando.Parameters.AddWithValue("@domicilio", noSocio.Domicilio);
                comando.Parameters.AddWithValue("@fechaNacimiento", noSocio.FechaNacimiento.Date);
                //comando.Parameters.AddWithValue("@fechaAlta", socio.FechaAlta);

                object result = comando.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el no socio: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public int ExisteNoSocio(int DNI)
        {
            MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(
                    "SELECT COUNT(*) FROM nosocios WHERE dni = @dni", conexion);
                comando.Parameters.AddWithValue("@dni", DNI);
                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar la existencia del no socio: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public NoSocio ObtenerNoSocio(int DNI)
        {
            MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(
                    "SELECT * FROM nosocios WHERE dni = @dni", conexion);
                comando.Parameters.AddWithValue("@dni", DNI);

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        NoSocio noSocio = new NoSocio(
                            Convert.ToInt32(reader["id"]),
                            reader["nombre"].ToString(),
                            reader["apellido"].ToString(),
                            Convert.ToInt32(reader["dni"]),
                            Convert.ToInt64(reader["telefono"]),
                            reader["domicilio"].ToString(),
                            reader["email"].ToString(),
                            Convert.ToDateTime(reader["fecha_nacimiento"])
                    );
                        return noSocio;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el socio: " + ex.Message);
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
