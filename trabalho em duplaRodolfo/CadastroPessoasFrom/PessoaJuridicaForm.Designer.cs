
namespace CadastroPessoasFrom
{
    partial class PessoaJuridicaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PessoaJuridicaForm));
            this.lbPJ = new System.Windows.Forms.Label();
            this.lbNomePJ = new System.Windows.Forms.Label();
            this.txbNomePj = new System.Windows.Forms.TextBox();
            this.lbDatePJ = new System.Windows.Forms.Label();
            this.txbCnpj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEstadoPj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCidadePj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbBairroPj = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbRuaPj = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNumPj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbCompPj = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbDatePj = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarPj = new System.Windows.Forms.Button();
            this.dgPj = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgPj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPJ
            // 
            this.lbPJ.AutoSize = true;
            this.lbPJ.BackColor = System.Drawing.Color.Black;
            this.lbPJ.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPJ.ForeColor = System.Drawing.Color.White;
            this.lbPJ.Location = new System.Drawing.Point(245, 9);
            this.lbPJ.Name = "lbPJ";
            this.lbPJ.Size = new System.Drawing.Size(233, 41);
            this.lbPJ.TabIndex = 0;
            this.lbPJ.Text = "Pessoa Jurídica";
            // 
            // lbNomePJ
            // 
            this.lbNomePJ.AutoSize = true;
            this.lbNomePJ.Location = new System.Drawing.Point(12, 75);
            this.lbNomePJ.Name = "lbNomePJ";
            this.lbNomePJ.Size = new System.Drawing.Size(38, 13);
            this.lbNomePJ.TabIndex = 1;
            this.lbNomePJ.Text = "Nome:";
            // 
            // txbNomePj
            // 
            this.txbNomePj.Location = new System.Drawing.Point(76, 71);
            this.txbNomePj.Name = "txbNomePj";
            this.txbNomePj.Size = new System.Drawing.Size(193, 20);
            this.txbNomePj.TabIndex = 2;
            this.txbNomePj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CadastroTeste);
            // 
            // lbDatePJ
            // 
            this.lbDatePJ.AutoSize = true;
            this.lbDatePJ.Location = new System.Drawing.Point(12, 109);
            this.lbDatePJ.Name = "lbDatePJ";
            this.lbDatePJ.Size = new System.Drawing.Size(107, 13);
            this.lbDatePJ.TabIndex = 3;
            this.lbDatePJ.Text = "Data de Nascimento:";
            this.lbDatePJ.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbCnpj
            // 
            this.txbCnpj.Location = new System.Drawing.Point(76, 145);
            this.txbCnpj.Name = "txbCnpj";
            this.txbCnpj.Size = new System.Drawing.Size(193, 20);
            this.txbCnpj.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CNPJ:";
            // 
            // txbIe
            // 
            this.txbIe.Location = new System.Drawing.Point(76, 182);
            this.txbIe.Name = "txbIe";
            this.txbIe.Size = new System.Drawing.Size(193, 20);
            this.txbIe.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "IE:";
            // 
            // txbEstadoPj
            // 
            this.txbEstadoPj.Location = new System.Drawing.Point(76, 234);
            this.txbEstadoPj.Name = "txbEstadoPj";
            this.txbEstadoPj.Size = new System.Drawing.Size(193, 20);
            this.txbEstadoPj.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estado:";
            // 
            // txbCidadePj
            // 
            this.txbCidadePj.Location = new System.Drawing.Point(76, 271);
            this.txbCidadePj.Name = "txbCidadePj";
            this.txbCidadePj.Size = new System.Drawing.Size(193, 20);
            this.txbCidadePj.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cidade";
            // 
            // txbBairroPj
            // 
            this.txbBairroPj.Location = new System.Drawing.Point(76, 308);
            this.txbBairroPj.Name = "txbBairroPj";
            this.txbBairroPj.Size = new System.Drawing.Size(193, 20);
            this.txbBairroPj.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bairro";
            // 
            // txbRuaPj
            // 
            this.txbRuaPj.Location = new System.Drawing.Point(76, 345);
            this.txbRuaPj.Name = "txbRuaPj";
            this.txbRuaPj.Size = new System.Drawing.Size(193, 20);
            this.txbRuaPj.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rua";
            // 
            // txbNumPj
            // 
            this.txbNumPj.Location = new System.Drawing.Point(76, 382);
            this.txbNumPj.Name = "txbNumPj";
            this.txbNumPj.Size = new System.Drawing.Size(43, 20);
            this.txbNumPj.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Numero:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txbCompPj
            // 
            this.txbCompPj.Location = new System.Drawing.Point(217, 381);
            this.txbCompPj.Name = "txbCompPj";
            this.txbCompPj.Size = new System.Drawing.Size(52, 20);
            this.txbCompPj.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Complemento:";
            // 
            // txbDatePj
            // 
            this.txbDatePj.Location = new System.Drawing.Point(122, 105);
            this.txbDatePj.Name = "txbDatePj";
            this.txbDatePj.Size = new System.Drawing.Size(147, 20);
            this.txbDatePj.TabIndex = 21;
            this.txbDatePj.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Endereço";
            // 
            // btnSalvarPj
            // 
            this.btnSalvarPj.Location = new System.Drawing.Point(194, 415);
            this.btnSalvarPj.Name = "btnSalvarPj";
            this.btnSalvarPj.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPj.TabIndex = 24;
            this.btnSalvarPj.Text = "Salvar";
            this.btnSalvarPj.UseVisualStyleBackColor = true;
            this.btnSalvarPj.Click += new System.EventHandler(this.Salvar);
            // 
            // dgPj
            // 
            this.dgPj.AllowUserToAddRows = false;
            this.dgPj.AllowUserToDeleteRows = false;
            this.dgPj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgPj.Location = new System.Drawing.Point(299, 70);
            this.dgPj.Name = "dgPj";
            this.dgPj.Size = new System.Drawing.Size(428, 368);
            this.dgPj.TabIndex = 48;
            this.dgPj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPj_CellContentClick);
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
            this.clcpf.HeaderText = "CNPJ";
            this.clcpf.Name = "clcpf";
            // 
            // clrg
            // 
            this.clrg.HeaderText = "IE";
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
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(745, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // PessoaJuridicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.dgPj);
            this.Controls.Add(this.btnSalvarPj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDatePj);
            this.Controls.Add(this.txbCompPj);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbNumPj);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbRuaPj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbBairroPj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbCidadePj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbEstadoPj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbIe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCnpj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDatePJ);
            this.Controls.Add(this.txbNomePj);
            this.Controls.Add(this.lbNomePJ);
            this.Controls.Add(this.lbPJ);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PessoaJuridicaForm";
            this.Text = "Cadastro de pessoas";
            ((System.ComponentModel.ISupportInitialize)(this.dgPj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPJ;
        private System.Windows.Forms.Label lbNomePJ;
        private System.Windows.Forms.TextBox txbNomePj;
        private System.Windows.Forms.Label lbDatePJ;
        private System.Windows.Forms.TextBox txbCnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEstadoPj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCidadePj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbBairroPj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbRuaPj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbNumPj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbCompPj;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txbDatePj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarPj;
        private System.Windows.Forms.DataGridView dgPj;
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