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
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(342, 31);
            label11.Name = "label11";
            label11.Size = new Size(172, 28);
            label11.TabIndex = 53;
            label11.Text = "COBRO DE CUOTA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(212, 371);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 52;
            label10.Text = "Monto :";
            // 
            // txtMonto
            // 
            txtMonto.Enabled = false;
            txtMonto.Location = new Point(353, 371);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(121, 23);
            txtMonto.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 329);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 50;
            label1.Text = "Método de pago :";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.Enabled = false;
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo", "3 cuotas", "6 cuotas" });
            cbMetodoPago.Location = new Point(353, 326);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(121, 23);
            cbMetodoPago.TabIndex = 49;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(212, 110);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(33, 15);
            lblDNI.TabIndex = 54;
            lblDNI.Text = "DNI :";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(353, 107);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(121, 23);
            txtDNI.TabIndex = 55;
            // 
            // rbSocio
            // 
            rbSocio.AutoSize = true;
            rbSocio.Checked = true;
            rbSocio.Location = new Point(212, 74);
            rbSocio.Name = "rbSocio";
            rbSocio.Size = new Size(54, 19);
            rbSocio.TabIndex = 56;
            rbSocio.TabStop = true;
            rbSocio.Text = "Socio";
            rbSocio.UseVisualStyleBackColor = true;
            rbSocio.CheckedChanged += rbSocio_CheckedChanged;
            // 
            // rbNoSocio
            // 
            rbNoSocio.AutoSize = true;
            rbNoSocio.Location = new Point(353, 74);
            rbNoSocio.Name = "rbNoSocio";
            rbNoSocio.Size = new Size(73, 19);
            rbNoSocio.TabIndex = 57;
            rbNoSocio.Text = "No Socio";
            rbNoSocio.UseVisualStyleBackColor = true;
            rbNoSocio.CheckedChanged += rbNoSocio_CheckedChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(519, 107);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 58;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblUltimaCuota
            // 
            lblUltimaCuota.AutoSize = true;
            lblUltimaCuota.Location = new Point(212, 239);
            lblUltimaCuota.Name = "lblUltimaCuota";
            lblUltimaCuota.Size = new Size(110, 15);
            lblUltimaCuota.TabIndex = 59;
            lblUltimaCuota.Text = "Última cuota paga :";
            // 
            // timeUltimaCuota
            // 
            timeUltimaCuota.Enabled = false;
            timeUltimaCuota.Location = new Point(353, 233);
            timeUltimaCuota.Name = "timeUltimaCuota";
            timeUltimaCuota.Size = new Size(241, 23);
            timeUltimaCuota.TabIndex = 60;
            // 
            // timeFechaVencimiento
            // 
            timeFechaVencimiento.Enabled = false;
            timeFechaVencimiento.Location = new Point(353, 279);
            timeFechaVencimiento.Name = "timeFechaVencimiento";
            timeFechaVencimiento.Size = new Size(241, 23);
            timeFechaVencimiento.TabIndex = 62;
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new Point(212, 285);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(129, 15);
            lblFechaVencimiento.TabIndex = 61;
            lblFechaVencimiento.Text = "Fecha de vencimiento :";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(212, 195);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(63, 15);
            lblActividad.TabIndex = 63;
            lblActividad.Text = "Actividad :";
            lblActividad.Visible = false;
            // 
            // txtActividad
            // 
            txtActividad.Enabled = false;
            txtActividad.Location = new Point(353, 192);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(121, 23);
            txtActividad.TabIndex = 64;
            txtActividad.Visible = false;
            // 
            // btnPago
            // 
            btnPago.Enabled = false;
            btnPago.Location = new Point(353, 423);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(139, 23);
            btnPago.TabIndex = 65;
            btnPago.Text = "REGISTRAR PAGO";
            btnPago.UseVisualStyleBackColor = true;
            btnPago.Click += btnPago_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 151);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 66;
            label2.Text = "Nombre :";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(353, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 67;
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(593, 148);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(121, 23);
            txtApellido.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(507, 154);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 68;
            label3.Text = "Apellido :";
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(623, 106);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 70;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // formCobroCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 509);
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
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtMonto);
            Controls.Add(label1);
            Controls.Add(cbMetodoPago);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCobroCuota";
            Text = "CobroCuota";
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
    }
}