namespace TpIntegrador
{
    partial class formCobroCuota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label11 = new Label();
            label10 = new Label();
            txtMonto = new TextBox();
            label1 = new Label();
            cbMetodoPago = new ComboBox();
            lblDNI = new Label();
            txtDNI = new TextBox();
            rbSocio = new RadioButton();
            rbNoSocio = new RadioButton();
            btnBuscar = new Button();
            lblUltimaCuota = new Label();
            timeUltimaCuota = new DateTimePicker();
            timeFechaVencimiento = new DateTimePicker();
            lblFechaVencimiento = new Label();
            lblActividad = new Label();
            txtActividad = new TextBox();
            btnPago = new Button();
            label2 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label3 = new Label();
            btnCancelar = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label12 = new Label();
            btnCerrar = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(247, 152, 52);
            label11.Location = new Point(44, 22);
            label11.Name = "label11";
            label11.Size = new Size(270, 36);
            label11.TabIndex = 53;
            label11.Text = "COBRO DE CUOTA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F);
            label10.Location = new Point(52, 386);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 52;
            label10.Text = "Monto :";
            // 
            // txtMonto
            // 
            txtMonto.Enabled = false;
            txtMonto.Font = new Font("Century Gothic", 12F);
            txtMonto.Location = new Point(251, 386);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(121, 27);
            txtMonto.TabIndex = 51;
            txtMonto.KeyPress += txtMonto_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(52, 344);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 50;
            label1.Text = "Método de pago :";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.Enabled = false;
            cbMetodoPago.Font = new Font("Century Gothic", 12F);
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo", "3 cuotas", "6 cuotas" });
            cbMetodoPago.Location = new Point(251, 341);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(121, 29);
            cbMetodoPago.TabIndex = 49;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Century Gothic", 12F);
            lblDNI.Location = new Point(52, 125);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(47, 21);
            lblDNI.TabIndex = 54;
            lblDNI.Text = "DNI :";
            // 
            // txtDNI
            // 
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Font = new Font("Century Gothic", 12F);
            txtDNI.Location = new Point(251, 122);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(121, 27);
            txtDNI.TabIndex = 55;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // rbSocio
            // 
            rbSocio.AutoSize = true;
            rbSocio.Checked = true;
            rbSocio.Font = new Font("Century Gothic", 12F);
            rbSocio.Location = new Point(52, 89);
            rbSocio.Name = "rbSocio";
            rbSocio.Size = new Size(69, 25);
            rbSocio.TabIndex = 56;
            rbSocio.TabStop = true;
            rbSocio.Text = "Socio";
            rbSocio.UseVisualStyleBackColor = true;
            rbSocio.CheckedChanged += rbSocio_CheckedChanged;
            // 
            // rbNoSocio
            // 
            rbNoSocio.AutoSize = true;
            rbNoSocio.Font = new Font("Century Gothic", 12F);
            rbNoSocio.Location = new Point(193, 89);
            rbNoSocio.Name = "rbNoSocio";
            rbNoSocio.Size = new Size(95, 25);
            rbNoSocio.TabIndex = 57;
            rbNoSocio.Text = "No Socio";
            rbNoSocio.UseVisualStyleBackColor = true;
            rbNoSocio.CheckedChanged += rbNoSocio_CheckedChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Font = new Font("Century Gothic", 12F);
            btnBuscar.Location = new Point(417, 122);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(84, 27);
            btnBuscar.TabIndex = 58;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblUltimaCuota
            // 
            lblUltimaCuota.AutoSize = true;
            lblUltimaCuota.Font = new Font("Century Gothic", 12F);
            lblUltimaCuota.Location = new Point(52, 254);
            lblUltimaCuota.Name = "lblUltimaCuota";
            lblUltimaCuota.Size = new Size(168, 21);
            lblUltimaCuota.TabIndex = 59;
            lblUltimaCuota.Text = "Última cuota paga :";
            // 
            // timeUltimaCuota
            // 
            timeUltimaCuota.Enabled = false;
            timeUltimaCuota.Font = new Font("Century Gothic", 12F);
            timeUltimaCuota.Location = new Point(251, 248);
            timeUltimaCuota.Name = "timeUltimaCuota";
            timeUltimaCuota.Size = new Size(319, 27);
            timeUltimaCuota.TabIndex = 60;
            // 
            // timeFechaVencimiento
            // 
            timeFechaVencimiento.Enabled = false;
            timeFechaVencimiento.Font = new Font("Century Gothic", 12F);
            timeFechaVencimiento.Location = new Point(251, 294);
            timeFechaVencimiento.Name = "timeFechaVencimiento";
            timeFechaVencimiento.Size = new Size(319, 27);
            timeFechaVencimiento.TabIndex = 62;
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Font = new Font("Century Gothic", 12F);
            lblFechaVencimiento.Location = new Point(52, 300);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(194, 21);
            lblFechaVencimiento.TabIndex = 61;
            lblFechaVencimiento.Text = "Fecha de vencimiento :";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Century Gothic", 12F);
            lblActividad.Location = new Point(52, 210);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(97, 21);
            lblActividad.TabIndex = 63;
            lblActividad.Text = "Actividad :";
            lblActividad.Visible = false;
            // 
            // txtActividad
            // 
            txtActividad.Enabled = false;
            txtActividad.Font = new Font("Century Gothic", 12F);
            txtActividad.Location = new Point(251, 207);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(121, 27);
            txtActividad.TabIndex = 64;
            txtActividad.Visible = false;
            // 
            // btnPago
            // 
            btnPago.BackColor = Color.FromArgb(55, 53, 54);
            btnPago.Enabled = false;
            btnPago.Font = new Font("Century Gothic", 12F);
            btnPago.ForeColor = Color.White;
            btnPago.Location = new Point(44, 441);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(196, 56);
            btnPago.TabIndex = 65;
            btnPago.Text = "REGISTRAR PAGO";
            btnPago.UseVisualStyleBackColor = false;
            btnPago.Click += btnPago_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(52, 166);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 66;
            label2.Text = "Nombre :";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Century Gothic", 12F);
            txtNombre.Location = new Point(251, 163);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 27);
            txtNombre.TabIndex = 67;
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Font = new Font("Century Gothic", 12F);
            txtApellido.Location = new Point(491, 163);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(121, 27);
            txtApellido.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(405, 169);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 68;
            label3.Text = "Apellido :";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Century Gothic", 12F);
            btnCancelar.Location = new Point(521, 121);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 27);
            btnCancelar.TabIndex = 70;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 74);
            panel1.TabIndex = 71;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(822, 9);
            label4.Name = "label4";
            label4.Size = new Size(41, 47);
            label4.TabIndex = 54;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(2318, 13);
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
            btnCerrar.Location = new Point(1560, 14);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 47);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "X";
            // 
            // formCobroCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 509);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(btnPago);
            Controls.Add(txtActividad);
            Controls.Add(lblActividad);
            Controls.Add(timeFechaVencimiento);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(timeUltimaCuota);
            Controls.Add(lblUltimaCuota);
            Controls.Add(btnBuscar);
            Controls.Add(rbNoSocio);
            Controls.Add(rbSocio);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Controls.Add(label10);
            Controls.Add(txtMonto);
            Controls.Add(label1);
            Controls.Add(cbMetodoPago);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCobroCuota";
            Text = "CobroCuota";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label10;
        private TextBox txtMonto;
        private Label label1;
        private ComboBox cbMetodoPago;
        private Label lblDNI;
        private TextBox txtDNI;
        private RadioButton rbSocio;
        private RadioButton rbNoSocio;
        private Button btnBuscar;
        private Label lblUltimaCuota;
        private DateTimePicker timeUltimaCuota;
        private DateTimePicker timeFechaVencimiento;
        private Label lblFechaVencimiento;
        private Label lblActividad;
        private TextBox txtActividad;
        private Button btnPago;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label3;
        private Button btnCancelar;
        private Panel panel1;
        private Label label12;
        private Label btnCerrar;
        private Label label4;
    }
}