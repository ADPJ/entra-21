
namespace AulaWF04Manha
{
    partial class Exec01
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
            this.cbNomes = new System.Windows.Forms.ComboBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.dgNome = new System.Windows.Forms.DataGridView();
            this.IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdadeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgNome)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNomes
            // 
            this.cbNomes.FormattingEnabled = true;
            this.cbNomes.Location = new System.Drawing.Point(153, 290);
            this.cbNomes.Name = "cbNomes";
            this.cbNomes.Size = new System.Drawing.Size(418, 47);
            this.cbNomes.TabIndex = 0;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(257, 473);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(208, 76);
            this.btnBusca.TabIndex = 1;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // dgNome
            // 
            this.dgNome.AllowUserToAddRows = false;
            this.dgNome.AllowUserToDeleteRows = false;
            this.dgNome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCol,
            this.NomeCol,
            this.CpfCol,
            this.IdadeCol});
            this.dgNome.Location = new System.Drawing.Point(12, 12);
            this.dgNome.Name = "dgNome";
            this.dgNome.ReadOnly = true;
            this.dgNome.RowTemplate.Height = 50;
            this.dgNome.Size = new System.Drawing.Size(760, 272);
            this.dgNome.TabIndex = 2;
            // 
            // IDCol
            // 
            this.IDCol.HeaderText = "ID";
            this.IDCol.Name = "IDCol";
            this.IDCol.ReadOnly = true;
            this.IDCol.Width = 70;
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.Name = "NomeCol";
            this.NomeCol.ReadOnly = true;
            this.NomeCol.Width = 280;
            // 
            // CpfCol
            // 
            this.CpfCol.HeaderText = "CPF";
            this.CpfCol.Name = "CpfCol";
            this.CpfCol.ReadOnly = true;
            this.CpfCol.Width = 260;
            // 
            // IdadeCol
            // 
            this.IdadeCol.HeaderText = "Idade";
            this.IdadeCol.Name = "IdadeCol";
            this.IdadeCol.ReadOnly = true;
            this.IdadeCol.Width = 110;
            // 
            // Exec01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgNome);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.cbNomes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Exec01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec01";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exec01_FormClosed);
            this.Load += new System.EventHandler(this.Exec01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNomes;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.DataGridView dgNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdadeCol;
    }
}