using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TpIntegrador
{
    public partial class frmFactura : Form
    {
        public string NombrePersona { get; set; }
        public string Actividad { get; set; }
        public float Monto { get; set; }
        public string FormaPago { get; set; }

        private PrintDocument printDocument;
        private string contenidoFactura;


        public frmFactura()
        {
            InitializeComponent();
            this.Load += frmFactura_Load;
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            lblPersona.Text = $"Persona: {NombrePersona}";
            lblActividad.Text = $"Concepto: {Actividad}";
            lblMonto.Text = $"Monto: ${Monto:F2}";
            lblFecha.Text = $"Fecha: {DateTime.Now:dd/MM/yyyy}";
            lblForma.Text = $"Forma de pago: {FormaPago}";

            // Contenido que se va a imprimir
            contenidoFactura =
                $"----- COMPROBANTE DE PAGO -----\n\n" +
                $"Persona: {NombrePersona}\n" +
                $"Concepto: {Actividad}\n" +
                $"Monto: ${Monto:F2}\n" +
                $"Forma de Pago: {FormaPago}\n" +
                $"Fecha: {DateTime.Now:dd/MM/yyyy}\n\n" +
                $"-------------------------------";

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintFactura);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
                MessageBox.Show("Factura impresa con éxito.", "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
        }
        private void PrintFactura(object sender, PrintPageEventArgs e)
        {
            Font fuente = new Font("Consolas", 12);
            float yPos = 100;
            int leftMargin = 50;

            e.Graphics.DrawString(contenidoFactura, fuente, Brushes.Black, leftMargin, yPos);
        }

        private void frmFactura_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

