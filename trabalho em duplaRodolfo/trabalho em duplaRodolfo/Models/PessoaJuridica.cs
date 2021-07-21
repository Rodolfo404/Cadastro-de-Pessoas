using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo.Models
{
    class PessoaJuridica : Pessoas
    {

        public string Cnpj { get; set; }
        public string Ie { get; set; }

        public PessoaJuridica()
        {
            this.createOperation = Create;
            this.readOperation = Read;
        }
        public void Create()
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
                cadastro.Endereco = new Endereco(estado, cidade, bairro, rua, num, complemento);
                Menu.Pj.Add(cadastro);
                Console.WriteLine("Deseja realizar mais um cadastro? S/N");
                resp = Console.ReadLine().ToLower();
            } while (resp == "s");
            Console.Clear();
        }
        public void Read()
        {

            Console.Clear();
            if (Menu.Pj.Count <= 0)
            {
                Console.Clear();
                Console.WriteLine("\nLista de Pessoas Jurídicas vazia!");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n------------- Lista de Pessoa Jurídica -------------");
                foreach (var item in Menu.Pj)
                {
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("---------------------------------------------------");
                    Console.ResetColor();
                    Console.WriteLine($"Nome: {item.Nome}\nCnpj: {item.Cnpj}\nIE: {item.Ie}\n---------Endereço-------- {item.Endereco}");
                    Console.ReadLine();
                }
            }
        }
    }
}
