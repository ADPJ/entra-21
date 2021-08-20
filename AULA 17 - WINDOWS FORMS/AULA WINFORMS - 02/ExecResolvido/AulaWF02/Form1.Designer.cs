
namespace AulaWF02
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExec2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExec2
            // 
            this.btnExec2.Location = new System.Drawing.Point(12, 154);
            this.btnExec2.Name = "btnExec2";
            this.btnExec2.Size = new System.Drawing.Size(188, 75);
            this.btnExec2.TabIndex = 0;
            this.btnExec2.Text = "EXEC02";
            this.btnExec2.UseVisualStyleBackColor = true;
            this.btnExec2.Click += new System.EventHandler(this.btnExec2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnExec2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExec2;
    }
}

