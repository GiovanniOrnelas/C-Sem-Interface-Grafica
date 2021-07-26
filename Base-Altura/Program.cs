using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Altura
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, basee, volume;
            Console.WriteLine("Programa que calcula a base e a altura de uma pirâmide");
            Console.WriteLine("Digite o número da base da pirâmide");
            basee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura da pirâmide");
            altura = Convert.ToDouble(Console.ReadLine());
            volume = (basee * altura) / 3;
            Console.WriteLine("O resultado do cálculo é: " + volume);
            Console.WriteLine("Pressione alguma tecla para parar o programa");
            Console.ReadKey();

        }
    }
}
