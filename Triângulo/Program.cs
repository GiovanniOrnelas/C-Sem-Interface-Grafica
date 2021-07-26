using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double c1, c2, c3, t, area;
            Console.WriteLine("Este é um programa que lê os comprimentos de um triângulo e a sua área");
            Console.WriteLine("Digite o primeiro comprimento de um lado de um triângulo");
            c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo comprimento de um lado de um triângulo");
            c2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o terceiro comprimento de um lado de um triângulo");
            c3 = Convert.ToDouble(Console.ReadLine());
            t = (c1 + c2 + c3) / 2;
            area = t * (t - c1) * (t - c2) * (t - c3);
            Console.WriteLine("A área do triângulo é: " + area);
            Console.WriteLine("Pressione uma tecla para parar o programa");
            Console.ReadKey();
        }
    }
}
