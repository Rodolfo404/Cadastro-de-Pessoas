using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo
{
    class PessoaFisica : Pessoas
    {
        Endereco Endereço { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public int MyProperty { get; set; }
    }
}
