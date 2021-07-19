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

            string resp;
            do
	        {
                Console.Clear();
                Console.WriteLine("-------Cadastrando Pessoa Juridica-------");
                PessoaJuridica cadastro = new PessoaJuridica();
                Console.Write("Digite seu Nome: ");
                cadastro.Nome = Validacao.ValidaStringBranco();
                Console.Write("digite seu Cnpj:");
                cadastro.Cnpj = Validacao.ValidaStringBranco();
                Console.Write("digite seu IE: ");
                cadastro.Ie = Validacao.ValidaStringBranco();
                Console.Write("Data de criação da Empresa(dd/mm/aa): ");
                cadastro.DataNascimento = Validacao.ValidaData();
                Console.WriteLine("---Cadastro de endereço---");
                Console.Write("Estado: ");
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
                cadastro.Endereco = new Endereco(estado, cidade, bairro, rua, num, complemento);
                Menu.Pj.Add(cadastro);
                Console.WriteLine("Deseja realizar mais um cadastro? S/N");
                resp = Console.ReadLine().ToLower();
            } while (resp == "s");
            Console.Clear();
        }
    }
}
