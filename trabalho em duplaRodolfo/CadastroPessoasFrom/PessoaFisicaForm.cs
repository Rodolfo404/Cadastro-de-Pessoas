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
    public partial class PessoaFisicaForm : Form
    {
        public PessoaFisicaForm()
        {
            InitializeComponent();
            Carregar();
        }

        private void EventoSalvarPf(object sender, EventArgs e)
        {
            Salvar();
        }

        void Salvar()
        {
            Validacao valida = new Validacao();
            int num = -1;

            try
            {
                num = Convert.ToInt32(txbNumPf.Text);
            }
            catch (Exception)
            {
                num = 0;
                MessageBox.Show("Numero de cadastro inválido!\nPor favor edite seu cadastro!");
            }

            Endereco enderecopf = new Endereco(txbEstadoPf.Text, txbCidadePf.Text, txbBairroPf.Text, txbRuaPf.Text, num, txbCompPf.Text);
            PessoaFisica pf = new PessoaFisica(0, txbNomePf.Text, txbCpf.Text, txbRg.Text, Convert.ToDateTime(txbDatePf.Value.ToShortDateString()), enderecopf);
            PessoaFisica procuraIndex = Form1.pfs.Find(p => p.Cpf == pf.Cpf);
            if (procuraIndex == null)
            {
                pf.ID = ValidaIdPf();
                Form1.pfs.Add(pf);
                MessageBox.Show("Pessoa Física cadastrada com sucesso!");
            }
            else
            {
                pf.ID = Form1.pfs[Form1.pfs.FindIndex(p => p == procuraIndex)].ID;
                Form1.pfs[Form1.pfs.FindIndex(p => p == procuraIndex)] = pf;
                MessageBox.Show("Pessoa Física editada com sucesso!");
                txbNomePf.ReadOnly = false;
                txbCpf.ReadOnly = false;
                txbRg.ReadOnly = false;
                txbDatePf.Enabled = true;
            }
            Carregar();
        }

        void Carregar()
        {
            dgPf.Rows.Clear();
            foreach (var pf in Form1.pfs)
            {
                dgPf.Rows.Add("Edit","Delete",pf.ID, pf.Nome, pf.Cpf, pf.Rg, pf.Endereco.Estado, pf.Endereco.Cidade, pf.Endereco.Bairro, pf.Endereco.Rua, pf.Endereco.Num, pf.Endereco.Complemento);
            }
            Limpar();
        }

        void Limpar()
        {
            dgPf.Refresh();
            txbEstadoPf.Text = String.Empty;
            txbCidadePf.Text = String.Empty;
            txbBairroPf.Text = String.Empty;
            txbRuaPf.Text = String.Empty;
            txbNumPf.Text = String.Empty;
            txbCompPf.Text = String.Empty;
            txbNomePf.Text = String.Empty;
            txbCpf.Text = String.Empty;
            txbRg.Text = String.Empty;
        }

        int ValidaIdPf()
        {
            int id = 0;
            if (Form1.contagemIdPf.Count <= 0)
            {
                id = Form1.contagemIdPf.Count + 1;
                Form1.contagemIdPf.Add(id);
                return id;
            }
            else
            {
                id = Form1.contagemIdPf.Count + 1;
                Form1.contagemIdPf.Add(id);
                return id;
            }
        }

        private void dgPf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //edit
                PessoaFisica pf = Form1.pfs[e.RowIndex];
                CarregarEdit(pf);
            }
            else if (e.ColumnIndex == 1)
            {
                //delete
                PessoaFisica pf = Form1.pfs[e.RowIndex];
                Form1.pfs.Remove(pf);
                Carregar();
            }
        }

        void CarregarEdit(PessoaFisica pf)
        {
            dgPf.Refresh();
            txbEstadoPf.Text = pf.Endereco.Estado;
            txbCidadePf.Text = pf.Endereco.Cidade;
            txbBairroPf.Text = pf.Endereco.Bairro;
            txbDatePf.Value = Convert.ToDateTime(pf.DataNascimento.ToShortDateString());
            txbRuaPf.Text = pf.Endereco.Rua;
            txbNumPf.Text = pf.Endereco.Num.ToString();
            txbCompPf.Text = pf.Endereco.Complemento;
            txbNomePf.Text = pf.Nome;
            txbCpf.Text = pf.Cpf;
            txbRg.Text = pf.Rg;
            txbDatePf.Enabled = false;
            txbNomePf.ReadOnly = true;
            txbCpf.ReadOnly = true;
            txbRg.ReadOnly = true;
        }

        private void CadastroTeste(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '=')
            {
                Limpar();
                dgPf.Refresh();
                txbEstadoPf.Text = "a";
                txbCidadePf.Text = "a";
                txbBairroPf.Text = "a";
                txbRuaPf.Text = "a";
                txbNumPf.Text = "1";
                txbCompPf.Text = "a";
                txbNomePf.Text = "a";
                txbCpf.Text = "11111111111";
                txbRg.Text = "1111111";
            }
        }
    }
}
