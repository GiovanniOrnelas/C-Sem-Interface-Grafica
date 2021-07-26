using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_09_06_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double tc, tf;
            Console.WriteLine("Criando um programa que converte Farenheit em Celsius!");
            Console.WriteLine("Digite um número");
            tf = Convert.ToDouble(Console.ReadLine());
            tc = 5 * (tf - 32) / 9;
            Console.WriteLine("A temperatura em Farenheit  digita para Celsius é: " + tc)
            Console.ReadKey();
        }
    }
}
