using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpIntegrador.Datos;

namespace TpIntegrador
{
    public partial class formCuotasVencidas : Form
    {
        public formCuotasVencidas()
        {
            InitializeComponent();
        }

        private void formCuotasVencidas_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(
                    @"SELECT
                        CONCAT(s.nombre, ' ', s.apellido) AS 'Nombre Completo',
                        s.domicilio as 'Domicilio',
                        s.telefono as 'Teléfono',
                        s.email as 'Email',
                        p.fecha_vencimiento as 'Fecha vencimiento',
                        p.fecha_pago as 'Fecha pago',
                        p.monto_pago as 'Monto pago'
                      FROM
                        pagosocio p
                      INNER JOIN (
                          SELECT
                              id_socio,
                              MAX(fecha_pago) AS ultima_fecha_pago
                          FROM
                              pagosocio
                          GROUP BY
                              id_socio
                      ) AS ultimos_pagos
                        ON p.id_socio = ultimos_pagos.id_socio
                        AND p.fecha_pago = ultimos_pagos.ultima_fecha_pago
                      INNER JOIN
                        socios s ON s.id = p.id_socio
                      WHERE
                        p.fecha_vencimiento < CURDATE();",
                    conexion
                );
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("No hay cuotas vencidas para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuotas vencidas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
    }
}
