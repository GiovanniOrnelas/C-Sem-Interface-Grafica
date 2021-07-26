using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que mostra a área de um terreno");
            double comprimento, largura, area;
            Console.WriteLine("Digite o comprimento do terreno");
            comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a largura do terreno");
            largura = Convert.ToDouble(Console.ReadLine());
            area = largura * comprimento;
            Console.WriteLine("A área do terreno é de: " + area + "m²");
            Console.WriteLine("Pressione alguma tecla parar por fim ao programa");
            Console.ReadKey();
        }
    }
}
