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


        public void CadastroPf()
        {
            PessoaFisica cadastro = new PessoaFisica();
            Console.WriteLine("-------Cadastrando Pessoa Fisica-------");
            Console.WriteLine("Nome: ");
            cadastro.Nome = Console.ReadLine();
            Console.WriteLine("CPF:");
            cadastro.Cpf = Console.ReadLine();
            Console.WriteLine("RG: ");
            cadastro.Rg = Console.ReadLine();
            Console.WriteLine("Data de nascimento: ");
            cadastro.DataNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("-------Cadastro de endereço-------");
            Console.WriteLine("Estado: ");
            string estado = Console.ReadLine();
            Console.WriteLine("Cidade:");
            string cidade = Console.ReadLine();
            Console.WriteLine("Bairro: ");
            string bairro = Console.ReadLine();
            Console.WriteLine("Rua: ");
            string rua = Console.ReadLine();
            Console.WriteLine("Número:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Complemento: ");
            string complemento = Console.ReadLine();
            Endereco = new Endereco(estado, cidade, bairro, rua, num, complemento);
            Menu.Pf.Add(cadastro);



        }
    }
}
