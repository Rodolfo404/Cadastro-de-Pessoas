
namespace CadastroPessoasFrom
{
    partial class PessoaFisicaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PessoaFisicaForm));
            this.btnSalvarPf = new System.Windows.Forms.Button();
            this.dgPf = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDatePf = new System.Windows.Forms.DateTimePicker();
            this.txbCompPf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbNumPf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbRuaPf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbBairroPf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCidadePf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEstadoPf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbRg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDatePJ = new System.Windows.Forms.Label();
            this.txbNomePf = new System.Windows.Forms.TextBox();
            this.lbNomePJ = new System.Windows.Forms.Label();
            this.lbPJ = new System.Windows.Forms.Label();
            this.clbtneditpf = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clbtndelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clidpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnomepf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clestadopf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcidadepf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbairropf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clruapf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnumpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcomppf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarPf
            // 
            this.btnSalvarPf.Location = new System.Drawing.Point(200, 415);
            this.btnSalvarPf.Name = "btnSalvarPf";
            this.btnSalvarPf.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPf.TabIndex = 49;
            this.btnSalvarPf.Text = "Salvar";
            this.btnSalvarPf.UseVisualStyleBackColor = true;
            this.btnSalvarPf.Click += new System.EventHandler(this.EventoSalvarPf);
            // 
            // dgPf
            // 
            this.dgPf.AllowUserToAddRows = false;
            this.dgPf.AllowUserToDeleteRows = false;
            this.dgPf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clbtneditpf,
            this.clbtndelete,
            this.clidpf,
            this.clnomepf,
            this.clcpf,
            this.clrg,
            this.clestadopf,
            this.clcidadepf,
            this.clbairropf,
            this.clruapf,
            this.clnumpf,
            this.clcomppf});
            this.dgPf.Location = new System.Drawing.Point(307, 70);
            this.dgPf.Name = "dgPf";
            this.dgPf.Size = new System.Drawing.Size(428, 368);
            this.dgPf.TabIndex = 47;
            this.dgPf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPf_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Endereço";
            // 
            // txbDatePf
            // 
            this.txbDatePf.Location = new System.Drawing.Point(128, 105);
            this.txbDatePf.Name = "txbDatePf";
            this.txbDatePf.Size = new System.Drawing.Size(147, 20);
            this.txbDatePf.TabIndex = 45;
            // 
            // txbCompPf
            // 
            this.txbCompPf.Location = new System.Drawing.Point(223, 381);
            this.txbCompPf.Name = "txbCompPf";
            this.txbCompPf.Size = new System.Drawing.Size(52, 20);
            this.txbCompPf.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Complemento:";
            // 
            // txbNumPf
            // 
            this.txbNumPf.Location = new System.Drawing.Point(82, 382);
            this.txbNumPf.Name = "txbNumPf";
            this.txbNumPf.Size = new System.Drawing.Size(43, 20);
            this.txbNumPf.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Numero:";
            // 
            // txbRuaPf
            // 
            this.txbRuaPf.Location = new System.Drawing.Point(82, 345);
            this.txbRuaPf.Name = "txbRuaPf";
            this.txbRuaPf.Size = new System.Drawing.Size(193, 20);
            this.txbRuaPf.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Rua";
            // 
            // txbBairroPf
            // 
            this.txbBairroPf.Location = new System.Drawing.Point(82, 308);
            this.txbBairroPf.Name = "txbBairroPf";
            this.txbBairroPf.Size = new System.Drawing.Size(193, 20);
            this.txbBairroPf.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Bairro";
            // 
            // txbCidadePf
            // 
            this.txbCidadePf.Location = new System.Drawing.Point(82, 271);
            this.txbCidadePf.Name = "txbCidadePf";
            this.txbCidadePf.Size = new System.Drawing.Size(193, 20);
            this.txbCidadePf.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Cidade";
            // 
            // txbEstadoPf
            // 
            this.txbEstadoPf.Location = new System.Drawing.Point(82, 234);
            this.txbEstadoPf.Name = "txbEstadoPf";
            this.txbEstadoPf.Size = new System.Drawing.Size(193, 20);
            this.txbEstadoPf.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Estado:";
            // 
            // txbRg
            // 
            this.txbRg.Location = new System.Drawing.Point(82, 182);
            this.txbRg.Name = "txbRg";
            this.txbRg.Size = new System.Drawing.Size(193, 20);
            this.txbRg.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "RG:";
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(82, 145);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(193, 20);
            this.txbCpf.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "CPF:";
            // 
            // lbDatePJ
            // 
            this.lbDatePJ.AutoSize = true;
            this.lbDatePJ.Location = new System.Drawing.Point(18, 109);
            this.lbDatePJ.Name = "lbDatePJ";
            this.lbDatePJ.Size = new System.Drawing.Size(107, 13);
            this.lbDatePJ.TabIndex = 28;
            this.lbDatePJ.Text = "Data de Nascimento:";
            // 
            // txbNomePf
            // 
            this.txbNomePf.Location = new System.Drawing.Point(82, 71);
            this.txbNomePf.Name = "txbNomePf";
            this.txbNomePf.Size = new System.Drawing.Size(193, 20);
            this.txbNomePf.TabIndex = 27;
            this.txbNomePf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CadastroTeste);
            // 
            // lbNomePJ
            // 
            this.lbNomePJ.AutoSize = true;
            this.lbNomePJ.Location = new System.Drawing.Point(18, 75);
            this.lbNomePJ.Name = "lbNomePJ";
            this.lbNomePJ.Size = new System.Drawing.Size(38, 13);
            this.lbNomePJ.TabIndex = 26;
            this.lbNomePJ.Text = "Nome:";
            // 
            // lbPJ
            // 
            this.lbPJ.AutoSize = true;
            this.lbPJ.BackColor = System.Drawing.Color.Black;
            this.lbPJ.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPJ.ForeColor = System.Drawing.Color.White;
            this.lbPJ.Location = new System.Drawing.Point(259, 9);
            this.lbPJ.Name = "lbPJ";
            this.lbPJ.Size = new System.Drawing.Size(200, 41);
            this.lbPJ.TabIndex = 25;
            this.lbPJ.Text = "Pessoa Física";
            // 
            // clbtneditpf
            // 
            this.clbtneditpf.HeaderText = "Editar";
            this.clbtneditpf.Name = "clbtneditpf";
            this.clbtneditpf.Width = 50;
            // 
            // clbtndelete
            // 
            this.clbtndelete.HeaderText = "Delete";
            this.clbtndelete.Name = "clbtndelete";
            this.clbtndelete.Width = 50;
            // 
            // clidpf
            // 
            this.clidpf.HeaderText = "Id";
            this.clidpf.Name = "clidpf";
            this.clidpf.Width = 50;
            // 
            // clnomepf
            // 
            this.clnomepf.HeaderText = "Nome";
            this.clnomepf.Name = "clnomepf";
            // 
            // clcpf
            // 
            this.clcpf.HeaderText = "CPF";
            this.clcpf.Name = "clcpf";
            // 
            // clrg
            // 
            this.clrg.HeaderText = "RG";
            this.clrg.Name = "clrg";
            // 
            // clestadopf
            // 
            this.clestadopf.HeaderText = "Estado";
            this.clestadopf.Name = "clestadopf";
            // 
            // clcidadepf
            // 
            this.clcidadepf.HeaderText = "Cidade";
            this.clcidadepf.Name = "clcidadepf";
            // 
            // clbairropf
            // 
            this.clbairropf.HeaderText = "Bairro";
            this.clbairropf.Name = "clbairropf";
            // 
            // clruapf
            // 
            this.clruapf.HeaderText = "Rua";
            this.clruapf.Name = "clruapf";
            // 
            // clnumpf
            // 
            this.clnumpf.HeaderText = "Numero";
            this.clnumpf.Name = "clnumpf";
            // 
            // clcomppf
            // 
            this.clcomppf.HeaderText = "Complemento";
            this.clcomppf.Name = "clcomppf";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // PessoaFisicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.btnSalvarPf);
            this.Controls.Add(this.dgPf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDatePf);
            this.Controls.Add(this.txbCompPf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbNumPf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbRuaPf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbBairroPf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbCidadePf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbEstadoPf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbRg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDatePJ);
            this.Controls.Add(this.txbNomePf);
            this.Controls.Add(this.lbNomePJ);
            this.Controls.Add(this.lbPJ);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PessoaFisicaForm";
            this.Text = "Cadastro de pessoas";
            ((System.ComponentModel.ISupportInitialize)(this.dgPf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarPf;
        private System.Windows.Forms.DataGridView dgPf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txbDatePf;
        private System.Windows.Forms.TextBox txbCompPf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbNumPf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbRuaPf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbBairroPf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCidadePf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEstadoPf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbRg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDatePJ;
        private System.Windows.Forms.TextBox txbNomePf;
        private System.Windows.Forms.Label lbNomePJ;
        private System.Windows.Forms.Label lbPJ;
        private System.Windows.Forms.DataGridViewButtonColumn clbtneditpf;
        private System.Windows.Forms.DataGridViewButtonColumn clbtndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnomepf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clestadopf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcidadepf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbairropf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clruapf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnumpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcomppf;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}