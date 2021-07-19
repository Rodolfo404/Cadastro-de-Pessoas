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
                Console.Write("Nome: ");
                cadastro.Nome = Validacao.ValidaStringBranco();
                Console.Write("CPF com 11 Digitos:");
                cadastro.Cpf = Validacao.CPF();
                Console.Write("RG com 8 Digitos: ");
                cadastro.Rg = Validacao.Rg();
                Console.Write("Data de nascimento(dd/mm/aa): ");
                cadastro.DataNascimento = Validacao.ValidaData();
                Console.Write("-------Cadastro de endereço-------");
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
                cadastro.Endereco =new Endereco(estado, cidade, bairro, rua, num, complemento);
                Menu.Pf.Add(cadastro);
                Console.WriteLine("Deseja realizar mais um cadastro? S/N");
                resp = Console.ReadLine().ToLower();
            } while (resp =="s");
            Console.Clear();
        }
    }
}
