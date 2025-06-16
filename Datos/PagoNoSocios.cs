using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TpIntegrador.Entidades;

namespace TpIntegrador.Datos
{
    internal class PagoNoSocios
    {
        public int RegistrarPagoNoSocio(PagoNoSocio pagoNoSocio)
        {
            MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO pagonosocio (fecha_pago, monto_pago, metodo_pago, id_no_socio, actividad) VALUES (@fechaPago, @montoPago, @metodoPago, @idNoSocio, @actividad)", conexion);
                comando.Parameters.AddWithValue("@montoPago", pagoNoSocio.MontoPago);
                comando.Parameters.AddWithValue("@metodoPago", pagoNoSocio.MetodoPago);
                //comando.Parameters.AddWithValue("@fechaVencimiento", pagoNoSocio.FechaVencimiento);
                comando.Parameters.AddWithValue("@fechaPago", pagoNoSocio.FechaPago);
                comando.Parameters.AddWithValue("@idNoSocio", pagoNoSocio.IdNoSocio);
                comando.Parameters.AddWithValue("@actividad", pagoNoSocio.Actividad);
                return comando.ExecuteNonQuery(); // Devuelve el número de filas afectadas
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el pago del socio: " + ex.Message);
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
