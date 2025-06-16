namespace TpIntegrador
{
    partial class formNoSocio
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnRegistrar = new Button();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDomicilio = new TextBox();
            lblFechaDeNac = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label9 = new Label();
            txtActividad = new TextBox();
            label11 = new Label();
            label10 = new Label();
            txtMonto = new TextBox();
            label1 = new Label();
            cbMetodoPago = new ComboBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(118, 272);
            label8.Name = "label8";
            label8.Size = new Size(55, 19);
            label8.TabIndex = 41;
            label8.Text = "E-Mail :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(118, 234);
            label7.Name = "label7";
            label7.Size = new Size(67, 19);
            label7.TabIndex = 40;
            label7.Text = "Teléfono :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 196);
            label6.Name = "label6";
            label6.Size = new Size(76, 19);
            label6.TabIndex = 39;
            label6.Text = "Domicilio : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 157);
            label5.Name = "label5";
            label5.Size = new Size(40, 19);
            label5.TabIndex = 38;
            label5.Text = "DNI :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 122);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 37;
            label4.Text = "Apellido :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 87);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 36;
            label3.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(342, 22);
            label2.Name = "label2";
            label2.Size = new Size(193, 28);
            label2.TabIndex = 35;
            label2.Text = "ALTA DE NO SOCIOS";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(55, 53, 54);
            btnRegistrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(666, 406);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(167, 56);
            btnRegistrar.TabIndex = 37;
            btnRegistrar.Text = "Registrar alta";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(199, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 25);
            txtEmail.TabIndex = 29;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(199, 228);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(178, 25);
            txtTelefono.TabIndex = 28;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(199, 189);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(399, 25);
            txtDomicilio.TabIndex = 27;
            // 
            // lblFechaDeNac
            // 
            lblFechaDeNac.AutoSize = true;
            lblFechaDeNac.Location = new Point(342, 157);
            lblFechaDeNac.Name = "lblFechaDeNac";
            lblFechaDeNac.Size = new Size(141, 19);
            lblFechaDeNac.TabIndex = 26;
            lblFechaDeNac.Text = "Fecha de nacimiento :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(486, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 25);
            dateTimePicker1.TabIndex = 25;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(199, 151);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(134, 25);
            txtDNI.TabIndex = 24;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(199, 115);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(399, 25);
            txtApellido.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(199, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(399, 25);
            txtNombre.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(118, 308);
            label9.Name = "label9";
            label9.Size = new Size(68, 19);
            label9.TabIndex = 43;
            label9.Text = "Actividad:";
            // 
            // txtActividad
            // 
            txtActividad.Location = new Point(199, 301);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(178, 25);
            txtActividad.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F);
            label11.Location = new Point(318, 338);
            label11.Name = "label11";
            label11.Size = new Size(192, 25);
            label11.TabIndex = 48;
            label11.Text = "Pago de primera cuota";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(115, 438);
            label10.Name = "label10";
            label10.Size = new Size(58, 19);
            label10.TabIndex = 47;
            label10.Text = "Monto :";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(256, 438);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(121, 25);
            txtMonto.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 396);
            label1.Name = "label1";
            label1.Size = new Size(119, 19);
            label1.TabIndex = 45;
            label1.Text = "Método de pago :";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo", "3 cuotas", "6 cuotas" });
            cbMetodoPago.Location = new Point(256, 393);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(121, 25);
            cbMetodoPago.TabIndex = 44;
            // 
            // formNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 510);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtMonto);
            Controls.Add(label1);
            Controls.Add(cbMetodoPago);
            Controls.Add(label9);
            Controls.Add(txtActividad);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegistrar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDomicilio);
            Controls.Add(lblFechaDeNac);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formNoSocio";
            Text = "RegistrarNoSocio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnRegistrar;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDomicilio;
        private Label lblFechaDeNac;
        private DateTimePicker dateTimePicker1;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label9;
        private TextBox txtActividad;
        private Label label11;
        private Label label10;
        private TextBox txtMonto;
        private Label label1;
        private ComboBox cbMetodoPago;
    }
}