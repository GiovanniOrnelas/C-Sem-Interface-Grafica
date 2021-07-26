using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, bc, ac, ab;
            Console.WriteLine("Algoritmo que determina se os valores são válidos para ser lados de um triângulo");
            Console.WriteLine("Digite o 1º número");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o 3º número");
            c = Convert.ToDouble(Console.ReadLine());
            bc = b + c;
            ac = a + c;
            ab = a + b;
            if (a < bc && b < ac && c < ab)
            {
                Console.WriteLine("Os números " + a + " , " + b + " e " + c + " FORMAM os lados de um triângulo");
            }
            else
            {
                Console.WriteLine("Os números " + a + " , " + b + " e " + c + "NÃO formam os lados de um triângulo");
            }
            Console.ReadKey();
        }
    }
}
