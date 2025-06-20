namespace TpIntegrador
{
    partial class frmFactura
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblPersona;
        private Label lblActividad;
        private Label lblMonto;
        private Label lblFecha;
        private Label lblForma;
        private Button btnImprimir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblPersona = new Label();
            lblActividad = new Label();
            lblMonto = new Label();
            lblFecha = new Label();
            lblForma = new Label();
            btnImprimir = new Button();
            label1 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1 = new Panel();
            label12 = new Label();
            btnCerrar = new Label();
            btnSalir = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Font = new Font("Century Gothic", 12F);
            lblPersona.Location = new Point(44, 122);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(75, 21);
            lblPersona.TabIndex = 0;
            lblPersona.Text = "Persona:";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Century Gothic", 12F);
            lblActividad.Location = new Point(44, 161);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(93, 21);
            lblActividad.TabIndex = 1;
            lblActividad.Text = "Actividad:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Century Gothic", 12F);
            lblMonto.Location = new Point(44, 235);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(66, 21);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Century Gothic", 12F);
            lblFecha.Location = new Point(44, 86);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(63, 21);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha:";
            // 
            // lblForma
            // 
            lblForma.AutoSize = true;
            lblForma.Font = new Font("Century Gothic", 12F);
            lblForma.Location = new Point(44, 198);
            lblForma.Name = "lblForma";
            lblForma.Size = new Size(135, 21);
            lblForma.TabIndex = 4;
            lblForma.Text = "Forma de pago:";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(55, 53, 54);
            btnImprimir.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(44, 274);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(150, 55);
            btnImprimir.TabIndex = 5;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 23);
            label1.Name = "label1";
            label1.Size = new Size(412, 38);
            label1.TabIndex = 6;
            label1.Text = "COMPROBANTE DE PAGO";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 53, 54);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 74);
            panel1.TabIndex = 25;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(1932, 13);
            label12.Name = "label12";
            label12.Size = new Size(41, 47);
            label12.TabIndex = 15;
            label12.Text = "X";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.AutoSize = true;
            btnCerrar.BackColor = Color.White;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(1174, 14);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 47);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "X";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(55, 53, 54);
            btnSalir.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(297, 274);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 55);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(489, 341);
            Controls.Add(btnSalir);
            Controls.Add(panel1);
            Controls.Add(lblPersona);
            Controls.Add(lblActividad);
            Controls.Add(lblMonto);
            Controls.Add(lblFecha);
            Controls.Add(lblForma);
            Controls.Add(btnImprimir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante de Pago";
            Load += frmFactura_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel panel1;
        private Label label12;
        private Label btnCerrar;
        private Button btnSalir;
    }
}
