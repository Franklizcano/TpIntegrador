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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(409, 26);
            label2.Name = "label2";
            label2.Size = new Size(182, 28);
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
            // formCuotasVencidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 549);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCuotasVencidas";
            Text = "CuotasVencidas";
            Load += formCuotasVencidas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
    }
}