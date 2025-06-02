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
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(154, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Nombre";
            txtNombre.Enter += ocultarNombre;
            txtNombre.Leave += mostrarNombre;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(295, 63);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(121, 23);
            txtApellido.TabIndex = 1;
            txtApellido.Text = "Apellido";
            txtApellido.Enter += ocultarApellido;
            txtApellido.Leave += mostrarApellido;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(453, 63);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 2;
            txtDNI.Text = "DNI";
            txtDNI.Enter += ocultarDNI;
            txtDNI.Leave += mostrarDNI;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(295, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // lblFechaDeNac
            // 
            lblFechaDeNac.AutoSize = true;
            lblFechaDeNac.Location = new Point(154, 122);
            lblFechaDeNac.Name = "lblFechaDeNac";
            lblFechaDeNac.Size = new Size(117, 15);
            lblFechaDeNac.TabIndex = 4;
            lblFechaDeNac.Text = "Fecha de nacimiento";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(154, 175);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(399, 23);
            txtDomicilio.TabIndex = 5;
            txtDomicilio.Text = "Domicilio";
            txtDomicilio.Enter += ocultarDomicilio;
            txtDomicilio.Leave += mostrarDomicilio;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(154, 228);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 6;
            txtTelefono.Text = "Telefono";
            txtTelefono.Enter += ocultarTelefono;
            txtTelefono.Leave += mostrarTelefono;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(295, 228);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 23);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "Email";
            txtEmail.Enter += ocultarEmail;
            txtEmail.Leave += mostrarEmail;
            // 
            // checkApto
            // 
            checkApto.AutoSize = true;
            checkApto.Location = new Point(470, 232);
            checkApto.Name = "checkApto";
            checkApto.Size = new Size(83, 19);
            checkApto.TabIndex = 8;
            checkApto.Text = "Apto fisico";
            checkApto.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(420, 350);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(133, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar alta";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo", "3 cuotas", "6 cuotas" });
            cbMetodoPago.Location = new Point(295, 286);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(121, 23);
            cbMetodoPago.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 289);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 11;
            label1.Text = "Método de pago";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(453, 286);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 12;
            txtMonto.Text = "Monto";
            txtMonto.Enter += ocultarMonto;
            txtMonto.Leave += mostrarMonto;
            // 
            // formSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 450);
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
    }
}