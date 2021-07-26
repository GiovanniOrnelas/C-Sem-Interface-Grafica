using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício8__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício da divisão por 10, 5 e 2.");
            int n1;
            Console.WriteLine("Programa que fala se o número é divisível por 3 ou por 7");
            Console.WriteLine("Digite um número");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 % 10 == 0)
            {
                Console.WriteLine("Esse número é divisível por 10");
            }
            if (n1 % 5 == 0){
                Console.WriteLine("Esse número é divisível por 5");
            }
            if(n1 % 2 == 0){
                Console.WriteLine("Esse número é divisível por 2");
            }
            if (n1 % 10 != 0  && n1 % 5 != 0 && n1 % 2 != 0)
            {
                Console.WriteLine("Número não divisível por 10, nem por 5 e nem por 2");
            }
            Console.ReadKey();
        }
    }
}
