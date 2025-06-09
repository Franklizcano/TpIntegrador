namespace TpIntegrador
{
    partial class formSocio
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lblFechaDeNac = new Label();
            txtDomicilio = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            checkApto = new CheckBox();
            btnRegistrar = new Button();
            cbMetodoPago = new ComboBox();
            label1 = new Label();
            txtMonto = new TextBox();
            label2 = new Label();
            btnCerrar = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(235, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(399, 25);
            txtNombre.TabIndex = 0;
            txtNombre.Enter += ocultarNombre;
            txtNombre.Leave += mostrarNombre;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(235, 92);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(399, 25);
            txtApellido.TabIndex = 1;
            txtApellido.Enter += ocultarApellido;
            txtApellido.Leave += mostrarApellido;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(235, 123);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(134, 25);
            txtDNI.TabIndex = 2;
            txtDNI.Text = "DNI";
            txtDNI.TextChanged += txtDNI_TextChanged;
            txtDNI.Enter += ocultarDNI;
            txtDNI.Leave += mostrarDNI;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(513, 123);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 25);
            dateTimePicker1.TabIndex = 3;
            // 
            // lblFechaDeNac
            // 
            lblFechaDeNac.AutoSize = true;
            lblFechaDeNac.Location = new Point(366, 129);
            lblFechaDeNac.Name = "lblFechaDeNac";
            lblFechaDeNac.Size = new Size(141, 19);
            lblFechaDeNac.TabIndex = 4;
            lblFechaDeNac.Text = "Fecha de nacimiento :";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(235, 157);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(399, 25);
            txtDomicilio.TabIndex = 5;
            txtDomicilio.Enter += ocultarDomicilio;
            txtDomicilio.Leave += mostrarDomicilio;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(235, 191);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(178, 25);
            txtTelefono.TabIndex = 6;
            txtTelefono.Text = "Telefono";
            txtTelefono.Enter += ocultarTelefono;
            txtTelefono.Leave += mostrarTelefono;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(235, 224);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 25);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "Email";
            txtEmail.Enter += ocultarEmail;
            txtEmail.Leave += mostrarEmail;
            // 
            // checkApto
            // 
            checkApto.AutoSize = true;
            checkApto.Cursor = Cursors.Hand;
            checkApto.FlatStyle = FlatStyle.Flat;
            checkApto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkApto.Location = new Point(233, 265);
            checkApto.Name = "checkApto";
            checkApto.Size = new Size(12, 11);
            checkApto.TabIndex = 8;
            checkApto.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(55, 53, 54);
            btnRegistrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(741, 449);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(167, 49);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar alta";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo", "3 cuotas", "6 cuotas" });
            cbMetodoPago.Location = new Point(295, 345);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(121, 25);
            cbMetodoPago.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 348);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 11;
            label1.Text = "Método de pago";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(453, 345);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 25);
            txtMonto.TabIndex = 12;
            txtMonto.Text = "Monto";
            txtMonto.Enter += ocultarMonto;
            txtMonto.Leave += mostrarMonto;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(378, 10);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 13;
            label2.Text = "ALTA DE SOCIOS";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.AutoSize = true;
            btnCerrar.BackColor = Color.WhiteSmoke;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(912, 10);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(17, 19);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "X";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 67);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 15;
            label3.Text = "Nombre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 98);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 16;
            label4.Text = "Apellido :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 129);
            label5.Name = "label5";
            label5.Size = new Size(40, 19);
            label5.TabIndex = 17;
            label5.Text = "DNI :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(154, 163);
            label6.Name = "label6";
            label6.Size = new Size(76, 19);
            label6.TabIndex = 18;
            label6.Text = "Domicilio : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(154, 197);
            label7.Name = "label7";
            label7.Size = new Size(67, 19);
            label7.TabIndex = 19;
            label7.Text = "Teléfono :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(154, 230);
            label8.Name = "label8";
            label8.Size = new Size(55, 19);
            label8.TabIndex = 20;
            label8.Text = "E-Mail :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(154, 263);
            label9.Name = "label9";
            label9.Size = new Size(73, 19);
            label9.TabIndex = 21;
            label9.Text = "Apto físico";
            label9.Click += label9_Click;
            // 
            // formSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 510);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCerrar);
            Controls.Add(label2);
            Controls.Add(txtMonto);
            Controls.Add(label1);
            Controls.Add(cbMetodoPago);
            Controls.Add(btnRegistrar);
            Controls.Add(checkApto);
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
            Name = "formSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private DateTimePicker dateTimePicker1;
        private Label lblFechaDeNac;
        private TextBox txtDomicilio;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private CheckBox checkApto;
        private Button btnRegistrar;
        private ComboBox cbMetodoPago;
        private Label label1;
        private TextBox txtMonto;
        private Label label2;
        private Label btnCerrar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}