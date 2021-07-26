using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_com_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, contador = 1, resultado;

            Console.WriteLine("Digite um número para realizar a tabuada");
            n1 = Convert.ToInt32(Console.ReadLine());

            while (contador <= 10)
            {
                resultado = n1 * contador;
                Console.WriteLine(n1 + " X " + contador + " = " + resultado);
                contador++;
            }
            Console.ReadKey();
        }
    }
}
