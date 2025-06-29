﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TpIntegrador.Datos;

namespace TpIntegrador
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //submenuInscripciones.Visible = true;
            submenuInscripciones.Visible = !submenuInscripciones.Visible;
            //DialogResult resultado = MessageBox.Show("¿Quieres registrar un socio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (resultado == DialogResult.Yes)
            //{
            //    AbrirFormInPanel(new formSocio());
            //}
            //else
            //{
            //    AbrirFormInPanel(new formNoSocio());
            //}
        }



        //private void submenuInscripciones_Paint(object sender, PaintEventArgs e)
        //{
        //    submenuInscripciones.Visible = true;
        //}

        private void btnSocios_Click(object sender, EventArgs e)
        {
            submenuInscripciones.Visible = false;
            AbrirFormInPanel(new formSocio());
        }

        private void btnNoSocios_Click(object sender, EventArgs e)
        {
            submenuInscripciones.Visible = false;
            AbrirFormInPanel(new formNoSocio());
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres salir?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 66;
                logoGrande.Visible = false;
                logoChico.Visible = true;
            }
            else
            {
                MenuVertical.Width = 250;
                logoGrande.Visible = true;
                logoChico.Visible = false;
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Seguro que quieres salir?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        int LX, LY;
        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1050, 652);
            this.Location = new Point(LX, LY);
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void logoGrande_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void logoChico_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnInstallment_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new formCobroCuota());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new formCuotasVencidas());
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void lbl_title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new formEntregaCarnet());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void btnNoSocios_Click(object sender, EventArgs e)
        //{

        //}
    }
}
