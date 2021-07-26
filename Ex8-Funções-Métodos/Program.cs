using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_Funções_Métodos
{
    class Program
    {

        static void fatorial(int num)
        {
            int inicio = 1, contador = 1;

            while (contador <= num)
            {
                inicio *= contador;
                contador++;               
            }
            Console.WriteLine("\n\nValor fatorial do número " + num + " é de: " + inicio);
        }

        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Digite um número para saber o fatorial do mesmo");
            n1 = Convert.ToInt32(Console.ReadLine());

            fatorial(n1);
            Console.ReadKey();
        }
    }
}
