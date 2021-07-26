using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, fat;
            Console.WriteLine("Vários Números - Fatorial");
            Console.WriteLine("Digite um número positivo, ou 0 para terminar: ");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                fat = 1;
                for (i = 1; i <= num; i++) { fat *= i; }
                Console.WriteLine(num + "! = " + fat);
                Console.WriteLine("Digite um número positivo, ou 0 para terminar: ");
                
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Pressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}