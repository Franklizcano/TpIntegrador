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

        public PagoSocio ObtenerUltimoPagoSocio(int? idSocio)
        {
            if(idSocio == null)
            {
                MessageBox.Show("idSocio es nulo!. Error: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM pagosocio WHERE id_socio = @idSocio ORDER BY fecha_pago DESC limit 1", conexion);
                comando.Parameters.AddWithValue("@idSocio", idSocio);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        PagoSocio pagoSocio = new PagoSocio(
                            Convert.ToSingle(reader["monto_pago"]),
                            reader["metodo_pago"].ToString(),
                            Convert.ToInt32(reader["id_socio"])
                        );
                        pagoSocio.FechaVencimiento = Convert.ToDateTime(reader["fecha_vencimiento"]);
                        pagoSocio.FechaPago = Convert.ToDateTime(reader["fecha_pago"]);
                        return pagoSocio;
                    }
                    else
                    {
                        return null;
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el último pago del socio: " + ex.Message);
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
