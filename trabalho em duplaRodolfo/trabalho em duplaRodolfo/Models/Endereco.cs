using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo.Models
{
    public class Endereco
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
        public Endereco()
        {

        }
        public override string ToString()
        {
            return $"\nEstado: {this.Estado}\nCidade: {this.Cidade}\n" +
                $"Bairro: {this.Bairro}\nRua: {this.Rua}\nNúmero: {this.Num}\nComplemento: {this.Complemento}";
        }

        public Endereco Create()
        {
            Console.Write("-------Cadastro de endereço-------");
            Console.Write("\nEstado: ");
            string estado = Validacao.ValidaStringBranco();
            Console.Write("Cidade:");
            string cidade = Validacao.ValidaStringBranco();
            Console.Write("Bairro: ");
            string bairro = Validacao.ValidaStringBranco();
            Console.Write("Rua: ");
            string rua = Validacao.ValidaStringBranco();
            Console.Write("Número:");
            int num = Validacao.ValidaInt();
            Console.Write("Complemento: ");
            string complemento = Validacao.ValidaStringBranco();
            Endereco endereco = new Endereco(estado, cidade, bairro, rua, num, complemento);
            return endereco;
        }
    }
}
