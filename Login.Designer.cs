namespace TpIntegrador
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            lbl_title = new Label();
            btn_login = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            linkpass = new LinkLabel();
            btncerrar = new PictureBox();
            btnminimizar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.DimGray;
            lbl_title.Location = new Point(462, 22);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(100, 32);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "LOGIN";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(40, 40, 40);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_login.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.LightGray;
            btn_login.Location = new Point(292, 231);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(440, 40);
            btn_login.TabIndex = 3;
            btn_login.Text = "INICIAR SESIÓN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(292, 84);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(440, 20);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += ocultarUsuario;
            txtUsuario.Leave += mostrarUsuario;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(292, 159);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(440, 20);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "PASSWORD";
            txtPassword.Enter += ocultarPassword;
            txtPassword.Leave += mostrarPassword;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 53, 54);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 6;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 70);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(247, 175);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.DimGray;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(292, 107);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(440, 1);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.BackColor = Color.DimGray;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(292, 182);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(440, 1);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // linkpass
            // 
            linkpass.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkpass.AutoSize = true;
            linkpass.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkpass.LinkColor = Color.DarkGray;
            linkpass.Location = new Point(414, 285);
            linkpass.Name = "linkpass";
            linkpass.Size = new Size(199, 17);
            linkpass.TabIndex = 0;
            linkpass.TabStop = true;
            linkpass.Text = "¿Ha olvidado su contraseña?";
            // 
            // btncerrar
            // 
            btncerrar.Cursor = Cursors.Hand;
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(755, 6);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(15, 15);
            btncerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btncerrar.TabIndex = 10;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.Cursor = Cursors.Hand;
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(734, 6);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(15, 15);
            btnminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimizar.TabIndex = 11;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(linkpass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btn_login);
            Controls.Add(lbl_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de login";
            Load += formLogin_Load;
            MouseDown += formLogin_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private Button btn_login;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private LinkLabel linkpass;
        private PictureBox btncerrar;
        private PictureBox pictureBox3;
        private PictureBox btnminimizar;
    }
}
