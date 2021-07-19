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
            this.Estado = estado;
            this.Cidade = cidade;
            this.Bairro = bairro;
            this.Rua = rua;
            this.Num = num;
            this.Complemento = complemento;
        }
        public override string ToString()
        {
            return $"\nEstado: {this.Estado}\nCidade: {this.Cidade}\n" +
                $"Bairro: {this.Bairro}\nRua: {this.Rua}\nNúmero: {this.Num}\nComplemento: {this.Complemento}";
        }
    }
}
