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
            cadastro.Nome = Console.ReadLine().Trim();
            Console.WriteLine("digite seu Cnpj:");
            cadastro.Cnpj = Console.ReadLine().Trim();
            Console.WriteLine("digite seu IE: ");
            cadastro.Ie = Console.ReadLine().Trim();
            Console.WriteLine("---Cadastro de endereço---");
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
            Endereco = new Endereco(estado,cidade,bairro,rua,num,complemento);
            Menu.Pj.Add(cadastro);
        }
        
    
    }
}
