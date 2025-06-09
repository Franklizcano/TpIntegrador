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
using TpIntegrador.Entidades;

namespace TpIntegrador
{
    public partial class formSocio : Form
    {
        public formSocio()
        {
            InitializeComponent();
        }

        private void ocultarNombre(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
            }
        }

        private void mostrarNombre(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
            }
        }

        private void ocultarApellido(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
            }
        }

        private void mostrarApellido(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
            }
        }

        private void ocultarDNI(object sender, EventArgs e)
        {
            if (txtDNI.Text == "DNI")
            {
                txtDNI.Text = "";
            }
        }

        private void mostrarDNI(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                txtDNI.Text = "DNI";
            }
        }

        private void ocultarDomicilio(object sender, EventArgs e)
        {
            if (txtDomicilio.Text == "Domicilio")
            {
                txtDomicilio.Text = "";
            }
        }

        private void mostrarDomicilio(object sender, EventArgs e)
        {
            if (txtDomicilio.Text == "")
            {
                txtDomicilio.Text = "Domicilio";
            }
        }

        private void ocultarTelefono(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Text = "";
            }
        }

        private void mostrarTelefono(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono";
            }
        }

        private void ocultarEmail(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
            }
        }

        private void mostrarEmail(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
            }
        }

        private void ocultarMonto(object sender, EventArgs e)
        {
            if (txtMonto.Text == "Monto")
            {
                txtMonto.Text = "";
            }
        }

        private void mostrarMonto(object sender, EventArgs e)
        {
            if (txtMonto.Text == "")
            {
                txtMonto.Text = "Monto";
            }
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "Nombre";
            txtApellido.Text = "Apellido";
            txtDNI.Text = "DNI";
            txtDomicilio.Text = "Domicilio";
            txtTelefono.Text = "Telefono";
            txtEmail.Text = "Email";
            txtMonto.Text = "Monto";
            cbMetodoPago.Text = "";
            checkApto.Checked = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Se valida que ningun textbox esté vacío o tiene el texto default
            if (txtNombre.Text == "Nombre" || txtApellido.Text == "Apellido" || txtDNI.Text == "DNI" || txtDomicilio.Text == "Domicilio" || txtTelefono.Text == "Telefono" || txtEmail.Text == "Email" || txtMonto.Text == "Monto" || cbMetodoPago.Text == "" || checkApto.Checked == false)
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
                    MessageBox.Show("Socio y pago registrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
