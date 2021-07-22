using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalho_em_duplaRodolfo.Models;

namespace CadastroPessoasFrom
{
    public partial class Form1 : Form
    {
        public static List<int> contagemIdPf;
        public static List<int> contagemIdPj;
        public static List<PessoaFisica> pfs;
        public static List<PessoaJuridica> pjs;

        public Form1()
        {
            InitializeComponent();
            contagemIdPf = new List<int>();
            contagemIdPj = new List<int>();
            pfs = new List<PessoaFisica>();
            pjs = new List<PessoaJuridica>();
        }

        private void btnAPF_Click(object sender, EventArgs e)
        {
            PessoaFisicaForm pff = new PessoaFisicaForm();
            pff.Show();
        }

        private void btnAPJ_Click(object sender, EventArgs e)
        {
            PessoaJuridicaForm pjf = new PessoaJuridicaForm();
            pjf.Show();
        }
    }
}
