using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo
{
    class MostrarListaPF
    {

        public void mostrarpf()
        {

            Console.Clear();
            if (Menu.Pf.Count <= 0)
            {
                Console.WriteLine("\nLista de Pessoas Físicas vazia!");
            }
            else
            {
                Console.WriteLine("\n------------- Lista de Pessoas Físicas -------------");
                foreach (var item in Menu.Pf)
                {
                    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("---------------------------------------------------");
                    Console.ResetColor();
                    Console.WriteLine($"Nome: {item.Nome}\nData de nascimento: {item.DataNascimento}\nCpf: {item.Cpf}\nRg: {item.Rg}\n---------Endereço--------{item.Endereco}");
                }
            }
        }
    }
}
