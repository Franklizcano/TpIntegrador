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
    public partial class formEntregaCarnet : Form
    {
        private Socio socioEncontrado;
        public formEntregaCarnet()
        {
            InitializeComponent();
            btnEmitirCarnet.Enabled = false;
        }

        private void formEntregaCarnet_Load(object sender, EventArgs e)
        {

        }

        private void btnEmitirCarnet_Click(object sender, EventArgs e)
        {
            //if (socioEncontrado == null)
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe buscar primero un socio válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!socioEncontrado.Id.HasValue)
            {
                MessageBox.Show("El ID del socio no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Socios socios = new Socios();
            bool actualizado = socios.MarcarCarnetComoEntregado(socioEncontrado.Id.Value); // método que vas a crear

            if (actualizado)
            {
                MessageBox.Show("Carnet entregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // opcional
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el estado del carnet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            int dni;
            if (!int.TryParse(txtDni.Text, out dni))
            {
                MessageBox.Show("Ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Socios socios = new Socios();
            if (socios.ExisteSocio(dni) == 0)
            {
                MessageBox.Show("No existe un socio con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Socio socio = socios.ObtenerSocio(dni);
            if (socio.CarnetEntregado)
            {
                MessageBox.Show("El carnet ya fue entregado a este socio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEmitirCarnet.Enabled = false;
            }
            else
            {
                lblNombre.Text = socio.Nombre + " " + socio.Apellido;
                lblEstado.Text = "Carnet pendiente de entrega";
                btnEmitirCarnet.Enabled = true;
                socioEncontrado = socio; // guardamos el socio para usar luego
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

