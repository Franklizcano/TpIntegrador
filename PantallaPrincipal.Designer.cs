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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            btnRegister = new Button();
            btnCarnet = new Button();
            btnInstallment = new Button();
            btnList = new Button();
            lbl_title = new Label();
            btn_salir = new Button();
            MenuVertical = new Panel();
            logoChico = new PictureBox();
            logoGrande = new PictureBox();
            BarraTitulo = new Panel();
            iconminimizar = new PictureBox();
            iconrestaurar = new PictureBox();
            iconmaximizar = new PictureBox();
            iconcerrar = new PictureBox();
            btnslide = new PictureBox();
            panelContenedor = new Panel();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoChico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoGrande).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnslide).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.AutoSize = true;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 152, 52);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 11.25F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegister.Location = new Point(3, 178);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(250, 56);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Registro";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btn_register_Click;
            // 
            // btnCarnet
            // 
            btnCarnet.AutoSize = true;
            btnCarnet.FlatAppearance.BorderSize = 0;
            btnCarnet.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 152, 52);
            btnCarnet.FlatStyle = FlatStyle.Flat;
            btnCarnet.Font = new Font("Century Gothic", 11.25F);
            btnCarnet.ForeColor = Color.White;
            btnCarnet.Image = (Image)resources.GetObject("btnCarnet.Image");
            btnCarnet.ImageAlign = ContentAlignment.MiddleLeft;
            btnCarnet.Location = new Point(3, 240);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(250, 56);
            btnCarnet.TabIndex = 1;
            btnCarnet.Text = "Entregar Carnet";
            btnCarnet.UseVisualStyleBackColor = true;
            // 
            // btnInstallment
            // 
            btnInstallment.AutoSize = true;
            btnInstallment.FlatAppearance.BorderSize = 0;
            btnInstallment.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 152, 52);
            btnInstallment.FlatStyle = FlatStyle.Flat;
            btnInstallment.Font = new Font("Century Gothic", 11.25F);
            btnInstallment.ForeColor = Color.White;
            btnInstallment.Image = (Image)resources.GetObject("btnInstallment.Image");
            btnInstallment.ImageAlign = ContentAlignment.MiddleLeft;
            btnInstallment.Location = new Point(3, 302);
            btnInstallment.Name = "btnInstallment";
            btnInstallment.Size = new Size(250, 56);
            btnInstallment.TabIndex = 2;
            btnInstallment.Text = "Cobrar Cuota";
            btnInstallment.UseVisualStyleBackColor = true;
            btnInstallment.Click += btnInstallment_Click;
            // 
            // btnList
            // 
            btnList.AutoSize = true;
            btnList.FlatAppearance.BorderSize = 0;
            btnList.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 152, 52);
            btnList.FlatStyle = FlatStyle.Flat;
            btnList.Font = new Font("Century Gothic", 11.25F);
            btnList.ForeColor = Color.White;
            btnList.Image = (Image)resources.GetObject("btnList.Image");
            btnList.ImageAlign = ContentAlignment.MiddleLeft;
            btnList.Location = new Point(3, 364);
            btnList.Name = "btnList";
            btnList.Size = new Size(250, 56);
            btnList.TabIndex = 3;
            btnList.Text = "Cuotas Vencidas";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(314, 9);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(209, 15);
            lbl_title.TabIndex = 4;
            lbl_title.Text = "Sistema de Gestión del Club Deportivo";
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 152, 52);
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Century Gothic", 11.25F);
            btn_salir.ForeColor = Color.White;
            btn_salir.Image = (Image)resources.GetObject("btn_salir.Image");
            btn_salir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salir.Location = new Point(3, 564);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(250, 45);
            btn_salir.TabIndex = 5;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(55, 53, 54);
            MenuVertical.Controls.Add(logoChico);
            MenuVertical.Controls.Add(logoGrande);
            MenuVertical.Controls.Add(btn_salir);
            MenuVertical.Controls.Add(btnCarnet);
            MenuVertical.Controls.Add(btnList);
            MenuVertical.Controls.Add(btnRegister);
            MenuVertical.Controls.Add(btnInstallment);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(250, 650);
            MenuVertical.TabIndex = 6;
            // 
            // logoChico
            // 
            logoChico.Image = (Image)resources.GetObject("logoChico.Image");
            logoChico.Location = new Point(3, 0);
            logoChico.Name = "logoChico";
            logoChico.Size = new Size(66, 66);
            logoChico.SizeMode = PictureBoxSizeMode.Zoom;
            logoChico.TabIndex = 7;
            logoChico.TabStop = false;
            logoChico.Visible = false;
            logoChico.MouseDown += logoChico_MouseDown;
            // 
            // logoGrande
            // 
            logoGrande.Image = (Image)resources.GetObject("logoGrande.Image");
            logoGrande.Location = new Point(0, 0);
            logoGrande.Name = "logoGrande";
            logoGrande.Size = new Size(249, 165);
            logoGrande.SizeMode = PictureBoxSizeMode.Zoom;
            logoGrande.TabIndex = 6;
            logoGrande.TabStop = false;
            logoGrande.MouseDown += logoGrande_MouseDown;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.WhiteSmoke;
            BarraTitulo.Controls.Add(iconminimizar);
            BarraTitulo.Controls.Add(iconrestaurar);
            BarraTitulo.Controls.Add(iconmaximizar);
            BarraTitulo.Controls.Add(iconcerrar);
            BarraTitulo.Controls.Add(btnslide);
            BarraTitulo.Controls.Add(lbl_title);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(250, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1050, 50);
            BarraTitulo.TabIndex = 7;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // iconminimizar
            // 
            iconminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconminimizar.Cursor = Cursors.Hand;
            iconminimizar.Image = (Image)resources.GetObject("iconminimizar.Image");
            iconminimizar.Location = new Point(962, 0);
            iconminimizar.Name = "iconminimizar";
            iconminimizar.Size = new Size(20, 20);
            iconminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconminimizar.TabIndex = 9;
            iconminimizar.TabStop = false;
            iconminimizar.Click += iconminimizar_Click;
            // 
            // iconrestaurar
            // 
            iconrestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconrestaurar.Cursor = Cursors.Hand;
            iconrestaurar.Image = (Image)resources.GetObject("iconrestaurar.Image");
            iconrestaurar.Location = new Point(988, 0);
            iconrestaurar.Name = "iconrestaurar";
            iconrestaurar.Size = new Size(20, 20);
            iconrestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            iconrestaurar.TabIndex = 8;
            iconrestaurar.TabStop = false;
            iconrestaurar.Visible = false;
            iconrestaurar.Click += iconrestaurar_Click;
            // 
            // iconmaximizar
            // 
            iconmaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconmaximizar.Cursor = Cursors.Hand;
            iconmaximizar.Image = (Image)resources.GetObject("iconmaximizar.Image");
            iconmaximizar.Location = new Point(987, 0);
            iconmaximizar.Name = "iconmaximizar";
            iconmaximizar.Size = new Size(20, 20);
            iconmaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconmaximizar.TabIndex = 7;
            iconmaximizar.TabStop = false;
            iconmaximizar.Click += iconmaximizar_Click;
            // 
            // iconcerrar
            // 
            iconcerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconcerrar.Cursor = Cursors.Hand;
            iconcerrar.Image = (Image)resources.GetObject("iconcerrar.Image");
            iconcerrar.Location = new Point(1013, 0);
            iconcerrar.Name = "iconcerrar";
            iconcerrar.Size = new Size(20, 20);
            iconcerrar.SizeMode = PictureBoxSizeMode.Zoom;
            iconcerrar.TabIndex = 6;
            iconcerrar.TabStop = false;
            iconcerrar.Click += iconcerrar_Click;
            // 
            // btnslide
            // 
            btnslide.Cursor = Cursors.Hand;
            btnslide.Image = (Image)resources.GetObject("btnslide.Image");
            btnslide.Location = new Point(6, 7);
            btnslide.Name = "btnslide";
            btnslide.Size = new Size(35, 35);
            btnslide.SizeMode = PictureBoxSizeMode.Zoom;
            btnslide.TabIndex = 5;
            btnslide.TabStop = false;
            btnslide.Click += btnslide_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.WhiteSmoke;
            panelContenedor.Location = new Point(250, 48);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1050, 590);
            panelContenedor.TabIndex = 8;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla Principal";
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoChico).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoGrande).EndInit();
            BarraTitulo.ResumeLayout(false);
            BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnslide).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private Button btnCarnet;
        private Button btnInstallment;
        private Button btnList;
        private Label lbl_title;
        private Button btn_salir;
        private Panel MenuVertical;
        private Panel BarraTitulo;
        private Panel panelContenedor;
        private PictureBox btnslide;
        private PictureBox logoGrande;
        private PictureBox logoChico;
        private PictureBox iconmaximizar;
        private PictureBox iconcerrar;
        private PictureBox iconminimizar;
        private PictureBox iconrestaurar;
    }
}