using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Funções_Métodos
{
    class Program
    {
        static void bhaskara (double a, double b, double c)
        {
            double delta,x1,x2;
            delta = (b * b - 4) * a * c;

            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine("\nExistem duas raizes: " + Math.Round(x1,2) + " e " + Math.Round(x2,2));
            }

            else if (delta == 0)
            {
                x1 = -b / 2 * a;

                Console.WriteLine("\nExiste apenas uma raiz:  " + x1);
            }

            else
            {
                Console.WriteLine("\nNão existe nenhuma raiz!!!");
            }
        }

        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite o valor de A");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o valor de B");
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o valor de C");
            c = Convert.ToInt32(Console.ReadLine());

            bhaskara(a, b, c);
            
            Console.ReadKey();
        }
    }
}
