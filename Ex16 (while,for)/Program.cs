using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16__while_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, soma=0, contador=1;
            Console.WriteLine("Digite um número");
            n = Convert.ToDouble(Console.ReadLine());

           while (contador <= n)
            {
                soma += contador / n;
                n--;
            }
            Console.WriteLine("Soma das fraçoes: " + Math.Round(soma,2));
            Console.ReadKey();

        }
    }
}
