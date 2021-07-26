using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Funções_Métodos
{
    class Program
    {

        static void Farenheit (double tf)
        {
            double tc;
            tc = 5 * (tf - 32) / 9;
            Console.WriteLine("\n\nA temperatura " + tf + " em Farenheit convertida para Celsius é de: " + tc + "ºC");
        }

        static void Main(string[] args)
        {
            double f;
            Console.WriteLine("Digite um número para ser convertido em Celsius");
            f = Convert.ToDouble(Console.ReadLine());


            Farenheit(f);
            Console.ReadKey();
        }
    }
}
