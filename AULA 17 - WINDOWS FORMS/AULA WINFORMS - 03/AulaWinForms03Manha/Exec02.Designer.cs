
namespace AulaWinForms03Manha
{
    partial class Exec02
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
            this.btnSair = new System.Windows.Forms.Button();
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExecuta = new System.Windows.Forms.Button();
            this.checkAdd = new System.Windows.Forms.CheckBox();
            this.checkRemove = new System.Windows.Forms.CheckBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkRed;
            this.btnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSair.Location = new System.Drawing.Point(648, 489);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(124, 60);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgProduto
            // 
            this.dgProduto.AllowUserToAddRows = false;
            this.dgProduto.AllowUserToDeleteRows = false;
            this.dgProduto.AllowUserToOrderColumns = true;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.NomeCol,
            this.PrecoCol});
            this.dgProduto.Location = new System.Drawing.Point(12, 12);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.ReadOnly = true;
            this.dgProduto.RowTemplate.Height = 40;
            this.dgProduto.Size = new System.Drawing.Size(760, 281);
            this.dgProduto.TabIndex = 1;
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "ID";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            this.idProduto.Width = 75;
            // 
            // NomeCol
            // 
            this.NomeCol.HeaderText = "Nome";
            this.NomeCol.Name = "NomeCol";
            this.NomeCol.ReadOnly = true;
            this.NomeCol.Width = 300;
            // 
            // PrecoCol
            // 
            this.PrecoCol.HeaderText = "Preco";
            this.PrecoCol.Name = "PrecoCol";
            this.PrecoCol.ReadOnly = true;
            this.PrecoCol.Width = 125;
            // 
            // btnExecuta
            // 
            this.btnExecuta.Location = new System.Drawing.Point(425, 489);
            this.btnExecuta.Name = "btnExecuta";
            this.btnExecuta.Size = new System.Drawing.Size(217, 60);
            this.btnExecuta.TabIndex = 2;
            this.btnExecuta.Text = "EXECUTA";
            this.btnExecuta.UseVisualStyleBackColor = true;
            this.btnExecuta.Click += new System.EventHandler(this.btnExecuta_Click);
            // 
            // checkAdd
            // 
            this.checkAdd.AutoSize = true;
            this.checkAdd.Location = new System.Drawing.Point(12, 457);
            this.checkAdd.Name = "checkAdd";
            this.checkAdd.Size = new System.Drawing.Size(202, 43);
            this.checkAdd.TabIndex = 3;
            this.checkAdd.Text = "ADICIONA";
            this.checkAdd.UseVisualStyleBackColor = true;
            this.checkAdd.CheckedChanged += new System.EventHandler(this.checkAdd_CheckedChanged);
            // 
            // checkRemove
            // 
            this.checkRemove.AutoSize = true;
            this.checkRemove.Location = new System.Drawing.Point(12, 506);
            this.checkRemove.Name = "checkRemove";
            this.checkRemove.Size = new System.Drawing.Size(186, 43);
            this.checkRemove.TabIndex = 4;
            this.checkRemove.Text = "REMOVE";
            this.checkRemove.UseVisualStyleBackColor = true;
            this.checkRemove.CheckedChanged += new System.EventHandler(this.checkRemove_CheckedChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(309, 307);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(110, 39);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(311, 360);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(108, 39);
            this.lblPreco.TabIndex = 6;
            this.lblPreco.Text = "Preco";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(225, 413);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(194, 39);
            this.lblFornecedor.TabIndex = 7;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(425, 299);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 47);
            this.txtNome.TabIndex = 8;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(425, 352);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(347, 47);
            this.txtPreco.TabIndex = 9;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(425, 405);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(347, 47);
            this.txtFornecedor.TabIndex = 10;
            // 
            // Exec02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.checkRemove);
            this.Controls.Add(this.checkAdd);
            this.Controls.Add(this.btnExecuta);
            this.Controls.Add(this.dgProduto);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Exec02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec02";
            this.Load += new System.EventHandler(this.Exec02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCol;
        private System.Windows.Forms.Button btnExecuta;
        private System.Windows.Forms.CheckBox checkAdd;
        private System.Windows.Forms.CheckBox checkRemove;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtFornecedor;
    }
}