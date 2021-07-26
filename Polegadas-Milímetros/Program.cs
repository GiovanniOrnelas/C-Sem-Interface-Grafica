using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polegadas_Milímetros
{
    class Program
    {
        static void Main(string[] args)
        {
            double polegada, milimetros;
            Console.WriteLine("Programa que converte polegadas em milímetros");
            Console.WriteLine("Digite um número para conversão em milímetros");
            polegada = Convert.ToDouble(Console.ReadLine());
            milimetros = polegada * 25.4;
            Console.WriteLine("A conversão do número " + polegada + " polegadas deu: " + milimetros + " em milímetros");
            Console.WriteLine("Pressione alguma tecla para parar o programar");
            Console.ReadKey();
        }
    }
}
