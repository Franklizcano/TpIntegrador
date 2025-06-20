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
            panel1 = new Panel();
            label13 = new Label();
            label12 = new Label();
            btnCerrar = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F);
            label8.Location = new Point(364, 234);
            label8.Name = "label8";
            label8.Size = new Size(64, 21);
            label8.TabIndex = 41;
            label8.Text = "E-Mail :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.Location = new Point(44, 234);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 40;
            label7.Text = "Teléfono :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F);
            label6.Location = new Point(44, 196);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 39;
            label6.Text = "Domicilio : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.Location = new Point(44, 157);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 38;
            label5.Text = "DNI :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(44, 122);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 37;
            label4.Text = "Apellido :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(44, 87);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 36;
            label3.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(247, 152, 52);
            label2.Location = new Point(44, 22);
            label2.Name = "label2";
            label2.Size = new Size(295, 36);
            label2.TabIndex = 35;
            label2.Text = "ALTA DE NO SOCIOS";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(55, 53, 54);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(44, 440);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(167, 56);
            btnRegistrar.TabIndex = 37;
            btnRegistrar.Text = "Registrar alta";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 12F);
            txtEmail.Location = new Point(434, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 27);
            txtEmail.TabIndex = 29;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Century Gothic", 12F);
            txtTelefono.Location = new Point(143, 228);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(178, 27);
            txtTelefono.TabIndex = 28;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtDomicilio
            // 
            txtDomicilio.CharacterCasing = CharacterCasing.Upper;
            txtDomicilio.Font = new Font("Century Gothic", 12F);
            txtDomicilio.Location = new Point(143, 189);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(399, 27);
            txtDomicilio.TabIndex = 27;
            // 
            // lblFechaDeNac
            // 
            lblFechaDeNac.AutoSize = true;
            lblFechaDeNac.Font = new Font("Century Gothic", 12F);
            lblFechaDeNac.Location = new Point(309, 157);
            lblFechaDeNac.Name = "lblFechaDeNac";
            lblFechaDeNac.Size = new Size(185, 21);
            lblFechaDeNac.TabIndex = 26;
            lblFechaDeNac.Text = "Fecha de nacimiento :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 12F);
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(500, 152);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(321, 27);
            dateTimePicker1.TabIndex = 25;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Century Gothic", 12F);
            txtDNI.Location = new Point(143, 151);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(134, 27);
            txtDNI.TabIndex = 24;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Font = new Font("Century Gothic", 12F);
            txtApellido.Location = new Point(143, 115);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(399, 27);
            txtApellido.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Font = new Font("Century Gothic", 12F);
            txtNombre.Location = new Point(143, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(399, 27);
            txtNombre.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F);
            label9.Location = new Point(44, 275);
            label9.Name = "label9";
            label9.Size = new Size(93, 21);
            label9.TabIndex = 43;
            label9.Text = "Actividad:";
            // 
            // txtActividad
            // 
            txtActividad.CharacterCasing = CharacterCasing.Upper;
            txtActividad.Font = new Font("Century Gothic", 12F);
            txtActividad.Location = new Point(143, 269);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(178, 27);
            txtActividad.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(41, 324);
            label11.Name = "label11";
            label11.Size = new Size(149, 19);
            label11.TabIndex = 48;
            label11.Text = "Pago cuota diaria";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F);
            label10.Location = new Point(44, 402);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 47;
            label10.Text = "Monto :";
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Century Gothic", 12F);
            txtMonto.Location = new Point(203, 397);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(121, 27);
            txtMonto.TabIndex = 46;
            txtMonto.KeyPress += txtMonto_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(44, 360);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 45;
            label1.Text = "Método de pago :";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.Font = new Font("Century Gothic", 12F);
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo", "3 cuotas", "6 cuotas" });
            cbMetodoPago.Location = new Point(203, 352);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(121, 29);
            cbMetodoPago.TabIndex = 44;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 74);
            panel1.TabIndex = 49;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Cursor = Cursors.Hand;
            label13.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(887, 18);
            label13.Name = "label13";
            label13.Size = new Size(41, 47);
            label13.TabIndex = 36;
            label13.Text = "X";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(2383, 13);
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
            btnCerrar.Location = new Point(1625, 14);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 47);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "X";
            // 
            // formNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 510);
            Controls.Add(panel1);
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
            Load += formNoSocio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label12;
        private Label btnCerrar;
        private Label label13;
    }
}