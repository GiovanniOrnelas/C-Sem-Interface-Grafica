using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_retangular
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m1 = 1, m2 = 2, m3 = 3,  t;

            Console.WriteLine("Verificação de números triangulares");
            Console.WriteLine("Quando é o produto de 3 números consecutivos");
            Console.WriteLine("Digite um número para saber se ele é triangular");
            n = Convert.ToInt32(Console.ReadLine());

            t = m1 * m2 * m3;

            while (t < n)
            {
                t = m1 * m2 * m3;
                m1++;
                m2++;
                m3++;
            }

            if ( t == n)
            {
                Console.WriteLine(n + " é triangular");
            }

            else
            {
                Console.WriteLine(n + " NÃO é triangular");
            }

            Console.ReadKey();
        }
    }
}
