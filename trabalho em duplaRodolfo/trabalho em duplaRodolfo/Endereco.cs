using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo
{
    class Endereco
    {
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int Num { get; set; }
        public string Complemento { get; set; }
        public Endereco(string estado, string cidade, string bairro, string rua, int num, string complemento)
        {
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Num = num;
            Complemento = complemento;
        }
    }
}
