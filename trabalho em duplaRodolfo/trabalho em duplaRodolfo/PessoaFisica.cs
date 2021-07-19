using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo
{
    class PessoaFisica : Pessoas
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public int MyProperty { get; set; }


        public void CadastroPf()
        {

            string resp;
            do
	        {
                Console.Clear();
                PessoaFisica cadastro = new PessoaFisica();
                Console.WriteLine("-------Cadastrando Pessoa Fisica-------");
                Console.WriteLine("Nome: ");
                cadastro.Nome = Validacao.ValidaStringBranco();
                Console.WriteLine("CPF com 11 Digitos:");
                cadastro.Cpf = Validacao.CPF();
                Console.WriteLine("RG com 8 Digitos: ");
                cadastro.Rg = Validacao.Rg();
                Console.WriteLine("Data de nascimento(dd/mm/aa): ");
                cadastro.DataNascimento = Validacao.ValidaData();
                Console.WriteLine("-------Cadastro de endereço-------");
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
                cadastro.Endereco =new Endereco(estado, cidade, bairro, rua, num, complemento);
                Menu.Pf.Add(cadastro);
                Console.WriteLine("Deseja realizar mais um cadastro? S/N");
                resp = Console.ReadLine().ToLower();
            } while (resp =="s");
            Console.Clear();
        }
    }
}
