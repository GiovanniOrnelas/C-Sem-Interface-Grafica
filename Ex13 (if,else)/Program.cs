using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, p, area;
            Console.WriteLine("Algoritmo que determina se os valores são quais tipos de triângulos");
            Console.WriteLine("Digite o 1º número");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o 3º número");
            c = Convert.ToDouble(Console.ReadLine());

            if (a == b && b == c)
            {
                p = (a + b + c) / 2;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Você pode fazer, com esses números, um : Triângulo equilátero ");
                Console.WriteLine("A área do seu triângulo é de: " + Math.Round(area,2));
            }
            
            if (a == b || b == c || a == c)
            {
                p = (a + b + c) / 2;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Você pode fazer, com esses números, um : Triângulo isósceles ");
                Console.WriteLine("A área do seu triângulo é de: " + Math.Round(area,2));
            }
           
            if (a != b && b != c && a != c)
            {
                p = (a + b + c) / 2;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Você pode fazer, com esses números, um  Triângulo escaleno ");
                Console.WriteLine("A área do seu triângulo é de: " + Math.Round(area,2));
            }
            

            Console.ReadKey();
        }
    }
}
