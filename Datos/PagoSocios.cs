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
    internal class PagoSocios
    {
        public int RegistrarPagoSocio(PagoSocio pagoSocio)
        {
            MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO pagosocio (fecha_pago, monto_pago, metodo_pago, fecha_vencimiento, id_socio) VALUES (@fechaPago, @montoPago, @metodoPago, @fechaVencimiento, @idSocio)", conexion);
                comando.Parameters.AddWithValue("@montoPago", pagoSocio.MontoPago);
                comando.Parameters.AddWithValue("@metodoPago", pagoSocio.MetodoPago);
                comando.Parameters.AddWithValue("@fechaVencimiento", pagoSocio.FechaVencimiento);
                comando.Parameters.AddWithValue("@fechaPago", pagoSocio.FechaPago);
                comando.Parameters.AddWithValue("@idSocio", pagoSocio.IdSocio);
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
