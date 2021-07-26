using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Sistema cartesiano ");
            Console.WriteLine("Digite a abcissa (x)");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a ordenada (y)");
            y = Convert.ToDouble(Console.ReadLine());

            if (x>0 && y > 0)
            {
                Console.WriteLine("1º Quadrante");
            }

            if (x < 0 && y > 0)
            {
                Console.WriteLine("2º Quadrante");
            }

            if (x < 0 && y < 0)
            {
                Console.WriteLine("3º Quadrante");
            }

            if (x > 0 && y < 0)
            {
                Console.WriteLine("4º Quadrante");
            }

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Ponto na ORIGEM");
            }

            else if (x == 0 || y == 0)
            {
                Console.WriteLine("Ponto está em UM dos EIXOS ");
            }


            Console.ReadKey();
        }
    }
}
