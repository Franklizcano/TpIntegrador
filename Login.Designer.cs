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
            lbl_title = new Label();
            btn_login = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(233, 47);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(87, 15);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Club Deportivo";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(233, 241);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 1;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(198, 112);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(158, 23);
            txtUsuario.TabIndex = 4;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += ocultarUsuario;
            txtUsuario.Leave += mostrarUsuario;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(198, 169);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(158, 23);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "PASSWORD";
            txtPassword.Enter += ocultarPassword;
            txtPassword.Leave += mostrarPassword;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 329);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btn_login);
            Controls.Add(lbl_title);
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private Button btn_login;
        private TextBox txtUsuario;
        private TextBox txtPassword;
    }
}
