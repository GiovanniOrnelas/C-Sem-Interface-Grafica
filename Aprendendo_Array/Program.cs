using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //     [0]                [1]                  [2]             [3]                 
            string[] pilotos = new string[4] { "Ayrton Senna", "Michael Schumacher", "Lewis Hamilton", "Alain Prost" };
            Console.WriteLine("Os pilotos que ganharam são:");
            Console.WriteLine();
            Console.WriteLine(pilotos[0]);
            Console.WriteLine(pilotos[1]);
            Console.WriteLine(pilotos[2]);
            Console.WriteLine(pilotos[3]);

            Console.WriteLine("\nPressione algum tecla para parar o programa");
            Console.ReadKey();
        }
    }
}
