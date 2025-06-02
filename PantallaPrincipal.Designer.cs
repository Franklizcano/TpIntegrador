namespace TpIntegrador
{
    partial class formMain
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
            btnRegister = new Button();
            btnCarnet = new Button();
            btnInstallment = new Button();
            btnList = new Button();
            lbl_title = new Label();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.AutoSize = true;
            btnRegister.Location = new Point(137, 161);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(154, 25);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Registrar Socio / No Socio";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btn_register_Click;
            // 
            // btnCarnet
            // 
            btnCarnet.AutoSize = true;
            btnCarnet.Location = new Point(544, 161);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(99, 25);
            btnCarnet.TabIndex = 1;
            btnCarnet.Text = "Entregar Carnet";
            btnCarnet.UseVisualStyleBackColor = true;
            // 
            // btnInstallment
            // 
            btnInstallment.AutoSize = true;
            btnInstallment.Location = new Point(156, 328);
            btnInstallment.Name = "btnInstallment";
            btnInstallment.Size = new Size(88, 25);
            btnInstallment.TabIndex = 2;
            btnInstallment.Text = "Cobrar Cuota";
            btnInstallment.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            btnList.AutoSize = true;
            btnList.Location = new Point(511, 328);
            btnList.Name = "btnList";
            btnList.Size = new Size(160, 25);
            btnList.TabIndex = 3;
            btnList.Text = "Listado de Cuotas Vencidas";
            btnList.UseVisualStyleBackColor = true;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(295, 68);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(209, 15);
            lbl_title.TabIndex = 4;
            lbl_title.Text = "Sistema de Gestión del Club Deportivo";
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(672, 39);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 5;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_salir);
            Controls.Add(lbl_title);
            Controls.Add(btnList);
            Controls.Add(btnInstallment);
            Controls.Add(btnCarnet);
            Controls.Add(btnRegister);
            Name = "formMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Button btnCarnet;
        private Button btnInstallment;
        private Button btnList;
        private Label lbl_title;
        private Button btn_salir;
    }
}