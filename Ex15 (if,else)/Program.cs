using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            Console.WriteLine("Algoritmo que mostra 3 números em ordem crescente");
            Console.WriteLine("Não coloque números iguais");
            Console.WriteLine("Digite o 1º número");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            n2= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o 3º número");
            n3= Convert.ToDouble(Console.ReadLine());
            //  1     2     2    3
            if (n1 < n2 && n2 < n3)
            {
                Console.WriteLine( n1 + "  " + n2 + "  " + n3);
            }
            //  1    2     2     3
            if (n1 < n3 && n3 < n2)
            {
                Console.WriteLine( n1 + "  " + n3 + "  " + n2);
            }
            //  1    2     2    3
            if (n2 < n1 && n1 < n3)
            {
                Console.WriteLine( n2 + "  " + n1 + "  " + n3);
            }
            //   1    2    2    3
            if (n2 < n3 && n3 < n1)
            {
                Console.WriteLine( n2 + "  " + n3 + "  " + n1);
            }
            //   1    2    2    3
            if (n3 < n1 && n1 < n2)
            {
                Console.WriteLine( n3 + "  " + n1 + "  " + n2);
            }
            //   1    2    2    3
            if (n3 < n2 && n2 < n1)
            {
                Console.WriteLine( n3 + "  " + n2 + "  " + n1);
            }

            if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                Console.WriteLine("Apenas números diferentes");
            }


            Console.ReadKey();
        }
    }
}
