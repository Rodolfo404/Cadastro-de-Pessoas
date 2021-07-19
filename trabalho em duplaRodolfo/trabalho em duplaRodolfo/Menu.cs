using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo
{
    class Menu
    {
        MostrarListaPF mostrarpf = new MostrarListaPF();
        MostrarListapj mostrarPJ = new MostrarListapj();
        PessoaFisica CadastroPF = new PessoaFisica();
        PessoaJuridica CadastroPJ = new PessoaJuridica();
        public static List<PessoaFisica> Pf = new List<PessoaFisica>();
        public static List<PessoaJuridica> Pj = new List<PessoaJuridica>();
        public void Main()
        {
            Console.WriteLine("-------Bem vindo-------");
            Console.WriteLine("0 - Sair\n1 - Cadastro pessoa Juridica\n2 - Cadastro pessoa fisica\n3 - Mostrar lista de pessoas juridicas\n4 - Mostrar lista de pessoas Físicas");
            Console.WriteLine("Escolha uma das opções acima: ");
            opcoes();
        }
        public void opcoes()
        {
            int resposta = Validacao.ValidaInt();
            switch (resposta)
            {
                case 0:
                    break;
                case 1:
                    CadastroPJ.Cadastropj();
                    Main();
                    break;
                case 2:
                    CadastroPF.CadastroPf();
                    Main();
                    break;
                case 3:
                    mostrarPJ.mostrarpj();
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                    break;
                case 4:
                    mostrarpf.mostrarpf();
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nOpção inválida!\nPressione qualquer tecla para voltar ao menu!");
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                    break;
            }
        }
    }
}
