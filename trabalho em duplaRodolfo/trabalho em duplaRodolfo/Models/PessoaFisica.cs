using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo.Models
{
    public class PessoaFisica : Pessoas
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public int id { get; set; }

        public PessoaFisica()
        {
            this.createOperation = Create;
            this.readOperation = Read;
        }

        public void Create()
        {
            Validacao valida = new Validacao();
            string resp;
            do
	        {
                Console.Clear();
                PessoaFisica cadastro = new PessoaFisica();

                cadastro.ID = valida.IID(id);
                Console.WriteLine("-------Cadastrando Pessoa Fisica-------");
                Console.Write("Nome: ");
                cadastro.Nome = Validacao.ValidaStringBranco();
                Console.Write("CPF com 11 Digitos:");
                cadastro.Cpf = Validacao.CPF();
                Console.Write("RG com 7 Digitos: ");
                cadastro.Rg = Validacao.Rg();
                Console.Write("Data de nascimento(dd/mm/aa): ");
                cadastro.DataNascimento = Validacao.ValidaData();
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
                cadastro.Endereco =new Endereco(estado, cidade, bairro, rua, num, complemento);
                Menu.Pf.Add(cadastro);
                Console.WriteLine("Deseja realizar mais um cadastro? S/N");
                resp = Console.ReadLine().ToLower();
            } while (resp =="s");
            Console.Clear();
        }

        public void Read()
        {

            Console.Clear();
            if (Menu.Pf.Count <= 0)
            {
                Console.WriteLine("\nLista de Pessoas Físicas vazia!");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n------------- Lista de Pessoas Físicas -------------");
                foreach (var item in Menu.Pf)
                {
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("---------------------------------------------------");
                    Console.ResetColor();
                    Console.WriteLine($"Id: {item.ID}\nNome: {item.Nome}\nData de nascimento: {item.DataNascimento}\nCpf: {item.Cpf}\nRg: {item.Rg}\n---------Endereço--------{item.Endereco}");
                }
                Console.ReadLine();
            }
        }
    }
}
