using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisivel_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Algoritmo que fala se o número é divisível por 3 ou por 7");
            Console.WriteLine("Digite um número");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 % 3 == 0)
            {
                Console.WriteLine("Esse número é divisível por 3");
            }
           
            if (n1 % 7 == 0)
            {
                Console.WriteLine("Esse número é divisível por 7");
            }
            
            if (n1 % 3 !=0 && n1 % 7 != 0)
            {
                Console.WriteLine("Esse número não se divide por 3 e nem por 7");
            }

            Console.ReadKey();

            }
        }
    }
