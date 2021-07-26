using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, yA, yB, distancia;
            Console.WriteLine("Primeira distância (A)");
            xA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segunda distância (B)");
            yA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Terceira distância (A)");
            xB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quarta distância (B)");
            yB = Convert.ToDouble(Console.ReadLine());
            distancia = Math.Sqrt((xB - xA)) * (xB - xA) + ((yB - yA)) * (yB - yA);
            Console.WriteLine("A distância entre os dois pontos A e B é de:" + distancia);
            Console.WriteLine("Pressione alguma tecla para parar o programa");
            Console.ReadKey();
        }
    }
}
