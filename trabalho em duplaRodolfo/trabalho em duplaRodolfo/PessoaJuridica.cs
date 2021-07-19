using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo
{
    class PessoaJuridica : Pessoas
    {

        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public void Cadastropj()
        {
            PessoaJuridica cadastro = new PessoaJuridica();
            Console.WriteLine("Digite seu Nome: ");
            cadastro.Nome = Validacao.ValidaStringBranco();
            Console.WriteLine("digite seu Cnpj:");
            cadastro.Cnpj = Validacao.ValidaStringBranco();
            Console.WriteLine("digite seu IE: ");
            cadastro.Ie = Validacao.ValidaStringBranco();
            Console.WriteLine("---Cadastro de endereço---");
            Console.WriteLine("Estado: ");
            string estado = Validacao.ValidaStringBranco();
            Console.WriteLine("Cidade:");
            string cidade = Validacao.ValidaStringBranco();
            Console.WriteLine("Bairro: ");
            string bairro = Validacao.ValidaStringBranco();
            Console.WriteLine("Rua: ");
            string rua = Validacao.ValidaStringBranco();
            Console.WriteLine("Número:");
            int num = Validacao.ValidaInt();
            Console.WriteLine("Complemento: ");
            string complemento = Validacao.ValidaStringBranco();
            cadastro.Endereco = new Endereco(estado, cidade, bairro, rua, num, complemento);
            Menu.Pj.Add(cadastro);
        }
    }
}
