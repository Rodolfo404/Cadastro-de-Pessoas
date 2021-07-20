using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo
{
    class MostrarListapj
    {
        public void mostrarpj()
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
