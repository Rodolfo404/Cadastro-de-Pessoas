
namespace CadastroPessoasFrom
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnAPF = new System.Windows.Forms.Button();
            this.btnAPJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(237, 25);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(305, 41);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastro de Pessoas";
            // 
            // btnAPF
            // 
            this.btnAPF.Location = new System.Drawing.Point(255, 107);
            this.btnAPF.Name = "btnAPF";
            this.btnAPF.Size = new System.Drawing.Size(269, 52);
            this.btnAPF.TabIndex = 1;
            this.btnAPF.Text = "Acesso Pessoa Física";
            this.btnAPF.UseVisualStyleBackColor = true;
            this.btnAPF.Click += new System.EventHandler(this.btnAPF_Click);
            // 
            // btnAPJ
            // 
            this.btnAPJ.Location = new System.Drawing.Point(255, 175);
            this.btnAPJ.Name = "btnAPJ";
            this.btnAPJ.Size = new System.Drawing.Size(269, 52);
            this.btnAPJ.TabIndex = 2;
            this.btnAPJ.Text = "Acesso Pessoa Jurídica";
            this.btnAPJ.UseVisualStyleBackColor = true;
            this.btnAPJ.Click += new System.EventHandler(this.btnAPJ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAPJ);
            this.Controls.Add(this.btnAPF);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnAPF;
        private System.Windows.Forms.Button btnAPJ;
    }
}

