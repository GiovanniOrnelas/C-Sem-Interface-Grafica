using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raio_Altura
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, raio, volume, area;
            Console.WriteLine("Um programa que calcula a altura e largura de um cilindro");
            Console.WriteLine("Digite um número (raio)");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite um número (altura)");
            altura = Convert.ToDouble(Console.ReadLine());
            area = (2 * Math.PI * raio) * (altura + raio);
            volume = (Math.PI * Math.Pow(raio, 2)) * altura;
            Console.WriteLine("O cálculo da área do cilíndro é:" + Math.Round(area,2) + " o cálculo do volume do cilíndro é" + Math.Round(volume,2));
            Console.WriteLine("Pressione uma tecla para parar o programa");
            Console.ReadKey();
        }
    }
}
