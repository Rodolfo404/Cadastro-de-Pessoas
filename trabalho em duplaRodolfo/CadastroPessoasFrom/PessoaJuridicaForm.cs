using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalho_em_duplaRodolfo;
using trabalho_em_duplaRodolfo.Models;

namespace CadastroPessoasFrom
{
    public partial class PessoaJuridicaForm : Form
    {
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public PessoaJuridicaForm()
        {
            InitializeComponent();
            Carregar();
        }

        void Salvar()
        {
            Validacao valida = new Validacao();
            int num = -1;

            try
            {
                num = Convert.ToInt32(txbNumPj.Text);
            }
            catch (Exception)
            {
                num = 0;
                MessageBox.Show("Numero de cadastro inválido!\nPor favor edite seu cadastro!");
            }

            Endereco enderecopj = new Endereco(txbEstadoPj.Text, txbCidadePj.Text, txbBairroPj.Text, txbRuaPj.Text, num, txbCompPj.Text);
            PessoaJuridica pj = new PessoaJuridica(0, txbNomePj.Text, txbCnpj.Text, txbIe.Text, Convert.ToDateTime(txbDatePj.Value.ToShortDateString()), enderecopj);
            PessoaJuridica procuraIndex = Form1.pjs.Find(p => p.Cnpj == pj.Cnpj);
            if (procuraIndex == null)
            {
                pj.ID = ValidaIdPj();
                Form1.pjs.Add(pj);
                MessageBox.Show("Pessoa Jurídica cadastrada com sucesso!");
            }
            else
            {
                pj.ID = Form1.pjs[Form1.pjs.FindIndex(p => p == procuraIndex)].ID;
                Form1.pjs[Form1.pjs.FindIndex(p => p == procuraIndex)] = pj;
                MessageBox.Show("Pessoa Jurídica editada com sucesso!");
                txbNomePj.ReadOnly = false;
                txbCnpj.ReadOnly = false;
                txbIe.ReadOnly = false;
                txbDatePj.Enabled = true;
            }
            Carregar();
        }

        void Carregar()
        {
            dgPj.Rows.Clear();
            foreach (var pj in Form1.pjs)
            {
                dgPj.Rows.Add("Edit", "Delete", pj.ID, pj.Nome, pj.Cnpj, pj.Ie, pj.Endereco.Estado, pj.Endereco.Cidade, pj.Endereco.Bairro, pj.Endereco.Rua, pj.Endereco.Num, pj.Endereco.Complemento);
            }
            Limpar();
        }

        void Limpar()
        {
            dgPj.Refresh();
            txbEstadoPj.Text = String.Empty;
            txbCidadePj.Text = String.Empty;
            txbBairroPj.Text = String.Empty;
            txbRuaPj.Text = String.Empty;
            txbNumPj.Text = String.Empty;
            txbCompPj.Text = String.Empty;
            txbNomePj.Text = String.Empty;
            txbCnpj.Text = String.Empty;
            txbIe.Text = String.Empty;
        }

        int ValidaIdPj()
        {
            int id = 0;
            if (Form1.contagemIdPj.Count <= 0)
            {
                id = Form1.contagemIdPj.Count + 1;
                Form1.contagemIdPj.Add(id);
                return id;
            }
            else
            {
                id = Form1.contagemIdPj.Count + 1;
                Form1.contagemIdPj.Add(id);
                return id;
            }
        }

        void CarregarEdit(PessoaJuridica pj)
        {
            dgPj.Refresh();
            txbEstadoPj.Text = pj.Endereco.Estado;
            txbCidadePj.Text = pj.Endereco.Cidade;
            txbBairroPj.Text = pj.Endereco.Bairro;
            txbDatePj.Value = Convert.ToDateTime(pj.DataNascimento.ToShortDateString());
            txbRuaPj.Text = pj.Endereco.Rua;
            txbNumPj.Text = pj.Endereco.Num.ToString();
            txbCompPj.Text = pj.Endereco.Complemento;
            txbNomePj.Text = pj.Nome;
            txbCnpj.Text = pj.Cnpj;
            txbIe.Text = pj.Ie;
            txbDatePj.Enabled = false;
            txbNomePj.ReadOnly = true;
            txbCnpj.ReadOnly = true;
            txbIe.ReadOnly = true;
        }

        private void CadastroTeste(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '=')
            {
                Limpar();
                dgPj.Refresh();
                txbEstadoPj.Text = "a";
                txbCidadePj.Text = "a";
                txbBairroPj.Text = "a";
                txbRuaPj.Text = "a";
                txbNumPj.Text = "1";
                txbCompPj.Text = "a";
                txbNomePj.Text = "a";
                txbCnpj.Text = "11111111111";
                txbIe.Text = "1111111";
            }
        }

        private void Salvar(object sender, EventArgs e)
        {
            Salvar();
        }

        private void dgPj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //edit
                PessoaJuridica pj = Form1.pjs[e.RowIndex];
                CarregarEdit(pj);
            }
            else if (e.ColumnIndex == 1)
            {
                //delete
                PessoaJuridica pj = Form1.pjs[e.RowIndex];
                Form1.pjs.Remove(pj);
                Carregar();
            }
        }
    }
}
