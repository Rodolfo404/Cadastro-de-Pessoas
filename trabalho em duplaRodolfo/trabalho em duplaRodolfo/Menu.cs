using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalho_em_duplaRodolfo.Models;

namespace trabalho_em_duplaRodolfo
{
    public delegate void TesteDelegate();
    class Menu
    {

        public static List<int> contagemIdPf = new List<int>();
        public static List<int> contagemIdPj = new List<int>();
        public static List<PessoaFisica> pfs = new List<PessoaFisica>();
        public static List<PessoaJuridica> pjs = new List<PessoaJuridica>();
        public void Main()
        {
            Console.WriteLine("-------Bem vindo-------");
            Console.WriteLine("1 - Cadastro pessoa Juridica\n2 - Cadastro pessoa fisica\n3 - Mostrar lista de pessoas juridicas\n4 - Mostrar lista de pessoas Físicas\n0 - Sair");
            Console.WriteLine("Escolha uma das opções acima: ");
            
        }
        public void opcoes()
        {
            int resposta = 0;
            do
            {
                Console.Clear();
                Main();
                PessoaFisica pf = new PessoaFisica();
                PessoaJuridica pj = new PessoaJuridica();
                TesteDelegate tdel;
                resposta = Validacao.ValidaInt();
                switch (resposta)
                {
                    case 0:
                        break;
                    case 1:
                        tdel = pj.Create;
                        tdel();
                        break;
                    case 2:
                        tdel = pf.Create;
                        tdel();
                        break;
                    case 3:
                        tdel = pj.Read;
                        tdel();
                        break;
                    case 4:
                        tdel = pf.Read;
                        tdel();
                        break;
                    case 5:
                        new Validacao().Remove();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nOpção inválida!\nPressione qualquer tecla para voltar ao menu!");
                        Console.ReadLine();
                        break;
                }
            }
            while (resposta != 0);
        }
    }
}
