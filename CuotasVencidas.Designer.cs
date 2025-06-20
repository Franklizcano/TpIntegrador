namespace TpIntegrador
{
    partial class formCuotasVencidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCuotasVencidas));
            label2 = new Label();
            dataGridView1 = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            btnImprimir = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label12 = new Label();
            btnCerrar = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(247, 152, 52);
            label2.Location = new Point(361, 21);
            label2.Name = "label2";
            label2.Size = new Size(280, 36);
            label2.TabIndex = 14;
            label2.Text = "CUOTAS VENCIDAS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 25;
            dataGridView1.Location = new Point(101, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 20;
            dataGridView1.Size = new Size(784, 346);
            dataGridView1.TabIndex = 15;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(55, 53, 54);
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(409, 444);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(182, 56);
            btnImprimir.TabIndex = 16;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 74);
            panel1.TabIndex = 72;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1602, 9);
            label4.Name = "label4";
            label4.Size = new Size(41, 47);
            label4.TabIndex = 54;
            label4.Text = "X";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(3098, 13);
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
            btnCerrar.Location = new Point(2340, 14);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(41, 47);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "X";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(927, 10);
            label1.Name = "label1";
            label1.Size = new Size(41, 47);
            label1.TabIndex = 73;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // formCuotasVencidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 549);
            Controls.Add(panel1);
            Controls.Add(btnImprimir);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCuotasVencidas";
            Text = "CuotasVencidas";
            Load += formCuotasVencidas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
        private Button btnImprimir;
        private Panel panel1;
        private Label label4;
        private Label label12;
        private Label btnCerrar;
        private Label label1;
    }
}