using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo
{
    public class Validacao
    {
        public  int IID(int id)
        {
                if (Menu.contagem.Count <= 0)
                {
                    id = Menu.contagem.Count + 1;
                    Menu.contagem.Add(id);
                    return id;
                }
                else
                {
                    id = Menu.contagem.Count + 1;
                    Menu.contagem.Add(id);
                    return id;
                }
        }
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
        public static string CPF()
        {
            do
            {
                string cpf = ValidaStringBranco();
                if (cpf.Length == 11)
                {
                    try
                    {
                        return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("coloque um numero besta");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Numero inválido!\nDigite novamente");
                }
            }
            while (true);
        }
        public static string Rg()
        {
            do
            {
                string Rg = Console.ReadLine();
                if (Rg.Length == 7)
                {
                    try
                    {
                        return Convert.ToUInt64(Rg).ToString(@"0\.000\-000");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("coloque um numero besta");
                    }
                }
                else
                {
                    Console.WriteLine("Numero inválido!\nDigite novamente");
                }
            }
            while (true);
        }
        public void Remove()
        {
            Console.Clear();
            new MostrarListaPF().mostrarpf();
            Console.Write("digite um Id que queira deletar:");
            int id = int.Parse(Console.ReadLine());
            foreach (var item in Menu.Pf)
            {
                if (item.ID.Equals(id))
                {
                    Menu.Pf.Remove (item);
                    break;
                }
            }
            Console.WriteLine("apagado");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
