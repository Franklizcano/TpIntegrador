namespace TpIntegrador
{
    partial class formEntregaCarnet
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
            lblDni = new Label();
            btnBuscarSocio = new Button();
            btnEmitirCarnet = new Button();
            txtDni = new TextBox();
            lblNombre = new Label();
            lblEstado = new Label();
            lbEntregaCarnet = new Label();
            panel1 = new Panel();
            btnCerrar = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Century Gothic", 12F);
            lblDni.Location = new Point(44, 110);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(39, 21);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // btnBuscarSocio
            // 
            btnBuscarSocio.Cursor = Cursors.Hand;
            btnBuscarSocio.Font = new Font("Century Gothic", 12F);
            btnBuscarSocio.Location = new Point(240, 106);
            btnBuscarSocio.Name = "btnBuscarSocio";
            btnBuscarSocio.Size = new Size(91, 28);
            btnBuscarSocio.TabIndex = 1;
            btnBuscarSocio.Text = "BUSCAR";
            btnBuscarSocio.UseVisualStyleBackColor = true;
            btnBuscarSocio.Click += btnBuscarSocio_Click;
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.BackColor = Color.FromArgb(55, 53, 54);
            btnEmitirCarnet.Cursor = Cursors.Hand;
            btnEmitirCarnet.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmitirCarnet.ForeColor = Color.White;
            btnEmitirCarnet.Location = new Point(44, 267);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new Size(202, 49);
            btnEmitirCarnet.TabIndex = 2;
            btnEmitirCarnet.Text = "EMITIR CARNET";
            btnEmitirCarnet.UseVisualStyleBackColor = false;
            btnEmitirCarnet.Click += btnEmitirCarnet_Click;
            // 
            // txtDni
            // 
            txtDni.Cursor = Cursors.IBeam;
            txtDni.Font = new Font("Century Gothic", 12F);
            txtDni.Location = new Point(94, 107);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(130, 27);
            txtDni.TabIndex = 3;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 12F);
            lblNombre.Location = new Point(131, 172);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 21);
            lblNombre.TabIndex = 4;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Century Gothic", 12F);
            lblEstado.Location = new Point(131, 207);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 21);
            lblEstado.TabIndex = 5;
            // 
            // lbEntregaCarnet
            // 
            lbEntregaCarnet.AutoSize = true;
            lbEntregaCarnet.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEntregaCarnet.ForeColor = Color.FromArgb(247, 152, 52);
            lbEntregaCarnet.Location = new Point(44, 22);
            lbEntregaCarnet.Name = "lbEntregaCarnet";
            lbEntregaCarnet.Size = new Size(300, 36);
            lbEntregaCarnet.TabIndex = 14;
            lbEntregaCarnet.Text = "ENTREGA DE CARNET";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(lbEntregaCarnet);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 74);
            panel1.TabIndex = 16;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.AutoSize = true;
            btnCerrar.BackColor = Color.White;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(905, 13);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 47);
            btnCerrar.TabIndex = 15;
            btnCerrar.Text = "X";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(44, 172);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 17;
            label1.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(44, 207);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 18;
            label2.Text = "Estado: ";
            // 
            // formEntregaCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 510);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lblEstado);
            Controls.Add(lblNombre);
            Controls.Add(txtDni);
            Controls.Add(btnEmitirCarnet);
            Controls.Add(btnBuscarSocio);
            Controls.Add(lblDni);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formEntregaCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Load += formEntregaCarnet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDni;
        private Button btnBuscarSocio;
        private Button btnEmitirCarnet;
        private TextBox txtDni;
        private Label lblNombre;
        private Label lblEstado;
        private Label lbEntregaCarnet;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label btnCerrar;
    }
}