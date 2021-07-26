using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coeficientes
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            Console.WriteLine("Programa de ler os coeficientes de uma equação quadrática");
            Console.WriteLine("Digite um número (A)");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite um número (B)");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite um número (C)");
            c = Convert.ToDouble(Console.ReadLine());
            delta = (b * b - 4 ) * (a * c);
            Console.WriteLine("O delta desta equação é: " + delta);
            Console.WriteLine("Pressione alguma tecla para parar o programa");
            Console.ReadKey();

        }
    }
}
