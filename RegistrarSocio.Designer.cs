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
            label10 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Font = new Font("Century Gothic", 12F);
            txtNombre.Location = new Point(153, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(399, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Font = new Font("Century Gothic", 12F);
            txtApellido.Location = new Point(153, 112);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(399, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Century Gothic", 12F);
            txtDNI.Location = new Point(153, 143);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(134, 27);
            txtDNI.TabIndex = 2;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 12F);
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(497, 144);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(319, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // lblFechaDeNac
            // 
            lblFechaDeNac.AutoSize = true;
            lblFechaDeNac.Font = new Font("Century Gothic", 12F);
            lblFechaDeNac.Location = new Point(306, 149);
            lblFechaDeNac.Name = "lblFechaDeNac";
            lblFechaDeNac.Size = new Size(185, 21);
            lblFechaDeNac.TabIndex = 4;
            lblFechaDeNac.Text = "Fecha de nacimiento :";
            // 
            // txtDomicilio
            // 
            txtDomicilio.CharacterCasing = CharacterCasing.Upper;
            txtDomicilio.Font = new Font("Century Gothic", 12F);
            txtDomicilio.Location = new Point(153, 177);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(399, 27);
            txtDomicilio.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Century Gothic", 12F);
            txtTelefono.Location = new Point(153, 211);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(178, 27);
            txtTelefono.TabIndex = 6;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 12F);
            txtEmail.Location = new Point(431, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 27);
            txtEmail.TabIndex = 7;
            // 
            // checkApto
            // 
            checkApto.AutoSize = true;
            checkApto.Cursor = Cursors.Hand;
            checkApto.FlatStyle = FlatStyle.Flat;
            checkApto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkApto.Location = new Point(151, 259);
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
            btnRegistrar.Location = new Point(45, 458);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(167, 49);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar alta";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.Font = new Font("Century Gothic", 12F);
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo", "3 cuotas", "6 cuotas" });
            cbMetodoPago.Location = new Point(213, 354);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(121, 29);
            cbMetodoPago.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(44, 357);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 11;
            label1.Text = "Método de pago :";
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Century Gothic", 12F);
            txtMonto.Location = new Point(213, 399);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(121, 27);
            txtMonto.TabIndex = 12;
            txtMonto.KeyPress += txtMonto_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(247, 152, 52);
            label2.Location = new Point(44, 22);
            label2.Name = "label2";
            label2.Size = new Size(242, 36);
            label2.TabIndex = 13;
            label2.Text = "ALTA DE SOCIOS";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.AutoSize = true;
            btnCerrar.BackColor = Color.White;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(885, 14);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 47);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "X";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(44, 87);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 15;
            label3.Text = "Nombre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(44, 118);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 16;
            label4.Text = "Apellido :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.Location = new Point(44, 149);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 17;
            label5.Text = "DNI :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F);
            label6.Location = new Point(44, 183);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 18;
            label6.Text = "Domicilio : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.Location = new Point(44, 217);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 19;
            label7.Text = "Teléfono :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F);
            label8.Location = new Point(361, 217);
            label8.Name = "label8";
            label8.Size = new Size(64, 21);
            label8.TabIndex = 20;
            label8.Text = "E-Mail :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F);
            label9.Location = new Point(44, 257);
            label9.Name = "label9";
            label9.Size = new Size(92, 21);
            label9.TabIndex = 21;
            label9.Text = "Apto físico";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F);
            label10.Location = new Point(44, 399);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 22;
            label10.Text = "Monto :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(44, 316);
            label11.Name = "label11";
            label11.Size = new Size(170, 19);
            label11.TabIndex = 23;
            label11.Text = "Pago cuota mensual";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 74);
            panel1.TabIndex = 24;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(1643, 13);
            label12.Name = "label12";
            label12.Size = new Size(41, 47);
            label12.TabIndex = 15;
            label12.Text = "X";
            // 
            // formSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 510);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
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
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += formSocio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label10;
        private Label label11;
        private Panel panel1;
        private Label label12;
    }
}