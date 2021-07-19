using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo
{
    class Validacao
    {
        public static string ValidaStringBranco()
        {
            {
                string dado = System.Console.ReadLine().Trim();
                while (String.IsNullOrEmpty(dado))
                {
                    System.Console.WriteLine("Vazio: digite um valor valido");
                    dado = System.Console.ReadLine().Trim();
                }
                return dado;
            }
        }

        public static int ValidaInt()
        {
            do
            {
                try
                {
                    int dado = int.Parse(Console.ReadLine());
                    return dado;

                }
                catch(FormatException)
                {
                    System.Console.WriteLine("Valor Invalido");
                }
            } while(true);
        }

        public static DateTime ValidaData()
        {
            do
            {
                try
                {
                    DateTime dado = Convert.ToDateTime(Console.ReadLine());
                    return dado;
                }
                catch
                {
                    System.Console.WriteLine("Data Invalida");
                }
            } while (true);
        }

    }
}
