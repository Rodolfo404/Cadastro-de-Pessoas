using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo
{
    class Menu
    {
        public static List<int> contagem = new List<int>();
        public static List<PessoaFisica> Pf = new List<PessoaFisica>();
        public static List<PessoaJuridica> Pj = new List<PessoaJuridica>();
        public void Main()
        {
            Console.WriteLine("-------Bem vindo-------");
            Console.WriteLine("0 - Sair\n1 - Cadastro pessoa Juridica\n2 - Cadastro pessoa fisica\n3 - Mostrar lista de pessoas juridicas\n4 - Mostrar lista de pessoas Físicas\n5 - apagar pessoa fisica");
            Console.WriteLine("Escolha uma das opções acima: ");
            
        }
        public void opcoes()
        {
            int resposta = 0;
            do
            {
                Console.Clear();
                Main();
                resposta = Validacao.ValidaInt();
                switch (resposta)
                {
                    case 0:
                        break;
                    case 1:
                        new PessoaJuridica().Cadastropj();
                        break;
                    case 2:
                        new PessoaFisica().CadastroPf();
                        break;
                    case 3:
                        new MostrarListapj().mostrarpj();
                        break;
                    case 4:
                        new MostrarListaPF().mostrarpf();
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
