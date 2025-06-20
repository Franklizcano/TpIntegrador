using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpIntegrador.Datos;
using TpIntegrador.Entidades;

namespace TpIntegrador
{
    public partial class formSocio : Form
    {
        public formSocio()
        {
            InitializeComponent();
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtMonto.Text = "";
            cbMetodoPago.Text = "";
            checkApto.Checked = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Se valida que ningun textbox esté vacío o tiene el texto default
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDNI.Text == "" || txtDomicilio.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || txtMonto.Text == "" || cbMetodoPago.Text == "" || checkApto.Checked == false)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Socios socios = new Socios();
            if (socios.ExisteSocio(Convert.ToInt32(txtDNI.Text)) > 0)
            {
                MessageBox.Show("El DNI ingresado ya está registrado como socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Socio socio = new Socio(
                        null, // El ID se asigna automáticamente en la base de datos
                        txtNombre.Text,
                        txtApellido.Text,
                        Convert.ToInt32(txtDNI.Text),
                        Convert.ToInt64(txtTelefono.Text),
                        txtDomicilio.Text,
                        txtEmail.Text,
                        dateTimePicker1.Value.Date
                    );


                    int idSocio = socios.RegistrarSocio(socio);
                    PagoSocio pagoSocio = new PagoSocio(float.Parse(txtMonto.Text), cbMetodoPago.Text, idSocio);

                    PagoSocios pagoSocios = new PagoSocios();
                    pagoSocios.RegistrarPagoSocio(pagoSocio);

                    frmFactura factura = new frmFactura
                    {
                        NombrePersona = txtNombre.Text + " " + txtApellido.Text,
                        Actividad = "Cuota Mensual",
                        Monto = float.Parse(txtMonto.Text),
                        FormaPago = cbMetodoPago.Text
                    };
                    factura.ShowDialog();


                    MessageBox.Show("Socio y Pago Registrado Con Éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error durante el guardado de datos. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formSocio_Load(object sender, EventArgs e)
        {

        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtener el separador decimal de la configuración regional actual
            char decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            // 1. Permitir dígitos (0-9)
            // 2. Permitir teclas de control (como Backspace, Delete, flechas, etc.)
            // 3. Permitir el separador decimal (punto o coma, según la cultura)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != decimalSeparator)
            {
                e.Handled = true; // Si no es un dígito, control o el separador decimal, ignorar la pulsación de tecla.
            }

            // 4. Permitir solo un separador decimal
            // Si la tecla presionada es el separador decimal Y el TextBox ya contiene un separador decimal
            if (e.KeyChar == decimalSeparator && ((TextBox)sender).Text.Contains(decimalSeparator))
            {
                e.Handled = true; // Ignorar la pulsación del separador decimal.
            }
        }
    }
}
