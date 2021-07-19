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
                Console.WriteLine("Lista vazia!");
            }
            else
            {
                Console.WriteLine("-------------Lista de Pessoas Físicas cadastrados-------------");
                foreach (var item in Menu.Pf)
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine($"Nome: {item.Nome}\nData de nascimento: {item.DataNascimento}\nCpf: {item.Cpf}\nRg: {item.Rg}\nEndereço: {item.Endereco}");
                }
            }
        }
    }
}
