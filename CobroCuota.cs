﻿using System;
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
    public partial class formCobroCuota : Form
    {
        public formCobroCuota()
        {
            InitializeComponent();
        }

        private void rbNoSocio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoSocio.Checked == true)
            {
                rbSocio.Checked = false;
                lblActividad.Visible = true;
                txtActividad.Visible = true;
                lblUltimaCuota.Visible = false;
                timeUltimaCuota.Visible = false;
                lblFechaVencimiento.Visible = false;
                timeFechaVencimiento.Visible = false;
            }
        }

        private void rbSocio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSocio.Checked == true)
            {
                rbNoSocio.Checked = false;
                lblActividad.Visible = false;
                txtActividad.Visible = false;
                lblUltimaCuota.Visible = true;
                timeUltimaCuota.Visible = true;
                lblFechaVencimiento.Visible = true;
                timeFechaVencimiento.Visible = true;
            }
        }

        private void reiniciarForm()
        {
            txtDNI.Enabled = true;
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtActividad.Text = "";
            txtApellido.Text = "";
            txtActividad.Enabled = false;
            rbSocio.Enabled = true;
            rbNoSocio.Enabled = true;
            txtMonto.Text = "";
            timeUltimaCuota.Value = DateTime.Now;
            timeFechaVencimiento.Value = DateTime.Now;
            cbMetodoPago.Text = "";
            idSocioONoSocio = 0;
            btnPago.Enabled = false;
            txtMonto.Enabled = false;
            cbMetodoPago.Enabled = false;
            btnCancelar.Enabled = false;
        }

        int? idSocioONoSocio = 0;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un DNI antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbSocio.Checked == true)
            {
                Socios socios = new Socios();
                PagoSocios pagoSocios = new PagoSocios();
                if (socios.ExisteSocio(Convert.ToInt32(txtDNI.Text)) > 0)
                {
                    Socio socio = socios.ObtenerSocio(Convert.ToInt32(txtDNI.Text));
                    PagoSocio ultimoPagoSocio = pagoSocios.ObtenerUltimoPagoSocio(socio.Id);
                    idSocioONoSocio = socio.Id;
                    txtNombre.Text = socio.Nombre;
                    txtApellido.Text = socio.Apellido;
                    timeFechaVencimiento.Value = ultimoPagoSocio.FechaVencimiento; //TERMINAR
                    txtDNI.Enabled = false;
                    rbNoSocio.Enabled = false;
                    rbSocio.Enabled = false;
                    txtMonto.Enabled = true;
                    cbMetodoPago.Enabled = true;
                    btnPago.Enabled = true;
                    btnCancelar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El DNI que ingresaste es de un socio que no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                NoSocios noSocios = new NoSocios();
                if (noSocios.ExisteNoSocio(Convert.ToInt32(txtDNI.Text)) > 0)
                {
                    NoSocio noSocio = noSocios.ObtenerNoSocio(Convert.ToInt32(txtDNI.Text));
                    idSocioONoSocio = noSocio.Id;
                    txtNombre.Text = noSocio.Nombre;
                    txtApellido.Text = noSocio.Apellido;
                    txtDNI.Enabled = false;
                    rbNoSocio.Enabled = false;
                    rbSocio.Enabled = false;
                    txtActividad.Enabled = true;
                    txtMonto.Enabled = true;
                    cbMetodoPago.Enabled = true;
                    btnPago.Enabled = true;
                    btnCancelar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El DNI que ingresaste es de un no socio que no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reiniciarForm();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtMonto.Text == "" || cbMetodoPago.Text == "" || idSocioONoSocio == 0)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de realizar el pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbSocio.Checked == true)
            {
                PagoSocios pagoSocios = new PagoSocios();
                PagoSocio pagoSocio = new PagoSocio(
                    Convert.ToSingle(txtMonto.Text),
                    cbMetodoPago.Text,
                    Convert.ToInt32(idSocioONoSocio.Value)
                )
                {
                    FechaPago = DateTime.Now,
                    FechaVencimiento = timeFechaVencimiento.Value.AddMonths(1)
                };

                try
                {
                    int resultado = pagoSocios.RegistrarPagoSocio(pagoSocio);
                    if (resultado > 0)
                    {
                        frmFactura factura = new frmFactura
                        {
                            NombrePersona = txtNombre.Text + " " + txtApellido.Text,
                            Actividad = "Cuota Societaria",
                            Monto = float.Parse(txtMonto.Text),
                            FormaPago = cbMetodoPago.Text
                        };
                        factura.ShowDialog();
                        reiniciarForm();
                        MessageBox.Show("Pago registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbNoSocio.Checked == true)
            {
                PagoNoSocios pagoNoSocios = new PagoNoSocios();
                PagoNoSocio pagoNoSocio = new PagoNoSocio(
                    Convert.ToSingle(txtMonto.Text),
                    cbMetodoPago.Text,
                    idSocioONoSocio.Value,
                    txtActividad.Text
                );

                try
                {
                    int resultado = pagoNoSocios.RegistrarPagoNoSocio(pagoNoSocio);
                    if (resultado > 0)
                    {
                        frmFactura factura = new frmFactura
                        {
                            NombrePersona = txtNombre.Text + " " + txtApellido.Text,
                            Actividad = txtActividad.Text,
                            Monto = float.Parse(txtMonto.Text),
                            FormaPago = cbMetodoPago.Text
                        };
                        factura.ShowDialog();
                        reiniciarForm();
                        MessageBox.Show("Pago registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
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
