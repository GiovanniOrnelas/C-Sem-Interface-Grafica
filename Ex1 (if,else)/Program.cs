using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número para saber se ele é par ou impar");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número " + numero + " é par");
            }
            else{
                Console.WriteLine("O número " + numero + " é ímpar");
            }
            Console.ReadKey();
        }
    }
}
