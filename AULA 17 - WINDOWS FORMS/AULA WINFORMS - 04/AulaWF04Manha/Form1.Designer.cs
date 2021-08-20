
namespace AulaWF04Manha
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
            this.rbExec01 = new System.Windows.Forms.RadioButton();
            this.rbExec02 = new System.Windows.Forms.RadioButton();
            this.btnInicia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbExec01
            // 
            this.rbExec01.AutoSize = true;
            this.rbExec01.Location = new System.Drawing.Point(12, 35);
            this.rbExec01.Name = "rbExec01";
            this.rbExec01.Size = new System.Drawing.Size(151, 43);
            this.rbExec01.TabIndex = 0;
            this.rbExec01.TabStop = true;
            this.rbExec01.Text = "Exec01";
            this.rbExec01.UseVisualStyleBackColor = true;
            // 
            // rbExec02
            // 
            this.rbExec02.AutoSize = true;
            this.rbExec02.Location = new System.Drawing.Point(12, 108);
            this.rbExec02.Name = "rbExec02";
            this.rbExec02.Size = new System.Drawing.Size(151, 43);
            this.rbExec02.TabIndex = 1;
            this.rbExec02.TabStop = true;
            this.rbExec02.Text = "Exec02";
            this.rbExec02.UseVisualStyleBackColor = true;
            // 
            // btnInicia
            // 
            this.btnInicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicia.Location = new System.Drawing.Point(12, 333);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(760, 216);
            this.btnInicia.TabIndex = 2;
            this.btnInicia.Text = "INICIA";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnInicia);
            this.Controls.Add(this.rbExec02);
            this.Controls.Add(this.rbExec01);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbExec01;
        private System.Windows.Forms.RadioButton rbExec02;
        private System.Windows.Forms.Button btnInicia;
    }
}

