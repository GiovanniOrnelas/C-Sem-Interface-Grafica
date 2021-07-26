using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            Console.WriteLine("Raízes reais de uma equação do 2º grau");
            Console.WriteLine("Digite o primeiro número");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número");
            c = Convert.ToDouble(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Não existem raizes reais na equação");
            }
            
            if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Existe apenas uma raiz: " + Math.Round(x1,2));
            }

            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("Existe duas raizes na equação: " + Math.Round(x1,2) + " e " + Math.Round(x2,2));
            }
            Console.ReadKey();
        }
    }
}
