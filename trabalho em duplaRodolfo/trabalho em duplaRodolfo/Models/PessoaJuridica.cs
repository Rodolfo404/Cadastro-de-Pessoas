using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo.Models
{
    public class PessoaJuridica : Pessoas
    {

        public string Cnpj { get; set; }
        public string Ie { get; set; }

        public PessoaJuridica(int id, string nome, string cnpj, string ie, DateTime dataNasc, Endereco endereco)
        {
            this.ID = id;
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.Ie = ie;
            this.DataNascimento = dataNasc;
            this.Endereco = endereco;

            this.createOperation = Create;
            this.readOperation = Read;
        }
        public PessoaJuridica()
        {
            this.createOperation = Create;
            this.readOperation = Read;
        }
        public override string ToString()
        {
            return $"ID: {ID} - Nome: {Nome}\n--------";
        }
        void Create()
        {
            Validacao valida = new Validacao();
            string resp;
            do
            {
                Console.Clear();
                Console.WriteLine("-------Cadastrando Pessoa Juridica-------");
                PessoaJuridica cadastro = new PessoaJuridica();
                Console.Write("Digite seu Nome: ");
                cadastro.Nome = Validacao.ValidaStringBranco();
                if (cadastro.Nome == "*")
                {
                    cadastro.ID = valida.ValidaIdPj();
                    cadastro.Cnpj = "11111111111";
                    cadastro.Ie = "1111111";
                    cadastro.DataNascimento = DateTime.Now;
                    cadastro.Endereco = new Endereco("a", "a", "a", "a", 1, "a");
                    Menu.pjs.Add(cadastro);
                    Console.WriteLine("Deseja realizar mais um cadastro? S/N");
                    resp = Console.ReadLine().ToLower();
                }
                else
                {
                    cadastro.ID = valida.ValidaIdPj();
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
                    Menu.pjs.Add(cadastro);
                    Console.WriteLine("Deseja realizar mais um cadastro? S/N");
                    resp = Console.ReadLine().ToLower();
                }
            } while (resp == "s");
            Console.Clear();
        }
        void Read()
        {

            Console.Clear();
            if (Menu.pjs.Count <= 0)
            {
                Console.Clear();
                Console.WriteLine("\nLista de Pessoas Jurídicas vazia!");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n------------- Lista de Pessoa Jurídica -------------");
                foreach (PessoaJuridica item in Menu.pjs)
                {
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("---------------------------------------------------");
                    Console.ResetColor();
                    Console.WriteLine($"Id: {item.ID}\nNome: {item.Nome}\nCnpj: {item.Cnpj}\nIE: {item.Ie}\n---------Endereço-------- {item.Endereco}");
                }
                Console.WriteLine("\n1-Atualizar Cadastro  2-Deletar  0-Voltar");
                string resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "1":
                        Update();
                        break;
                    case "2":
                        Delete();
                        break;
                    default:
                        break;
                }
            }
        }
        void Update()
        {
            int resposta = 0;
            PessoaJuridica editPj = new PessoaJuridica();
            do
            {
                Console.Clear();
                foreach (PessoaJuridica pj in Menu.pjs)
                {
                    Console.WriteLine(pj);
                }
                Console.Write("Digite o Id que deseja alterar: ");
                try
                {
                    resposta = Int32.Parse(Console.ReadLine());
                    editPj = Menu.pjs.Find(x => x.ID.Equals(resposta));
                    if (editPj == null)
                    {
                        Console.WriteLine("Cadastro não encontrado!");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor inválido");
                    Console.ReadLine();
                }
            } while (true);

            Endereco endereco = new Endereco();
            endereco = endereco.Create();
            editPj.Endereco = endereco;
            Console.Clear();
            Console.WriteLine("Endereço atualizado com sucesso!");
        }
        void Delete()
        {
            int resposta = 0;
            PessoaJuridica deletePj = new PessoaJuridica();
            do
            {
                Console.Clear();
                foreach (PessoaJuridica pj in Menu.pjs)
                {
                    Console.WriteLine(pj);
                }
                Console.Write("Digite o Id que deseja deletar: ");
                try
                {
                    resposta = Int32.Parse(Console.ReadLine());
                    deletePj = Menu.pjs.Find(x => x.ID.Equals(resposta));
                    if (deletePj == null)
                    {
                        Console.WriteLine("Cadastro não encontrado!");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor inválido");
                    Console.ReadLine();
                }
            } while (true);
            Menu.pjs.Remove(deletePj);
            Console.Clear();
            Console.WriteLine("Cadastro removido com sucesso!");
        }
    }
}
