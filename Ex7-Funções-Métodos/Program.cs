using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Funções_Métodos
{
    class Program
    {

        static void divisores (int num1)
        {
            int contador = 1;
            Console.WriteLine("\nOs divisores de: " + num1);
            
            while (contador <= num1)
            {
                if (num1 % contador == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }
        }

        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Digite um número para saber os divisores");
            n1 = Convert.ToInt32(Console.ReadLine());

            divisores(n1);

            Console.ReadKey();
        }
    }
}
