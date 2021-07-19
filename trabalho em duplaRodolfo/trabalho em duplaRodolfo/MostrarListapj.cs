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
                Console.WriteLine("Lista de produtos vazia!");
            }
            else
            {
                Console.WriteLine("-------------Lista de produtos cadastrados-------------");
                foreach (var item in Menu.Pj)
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine($"Nome: {item.Nome}\nCnpj: {item.Cnpj}\nIE: {item.Ie}\nEndereço: {item.Endereco}");
                }
            }
        }
    }
}
