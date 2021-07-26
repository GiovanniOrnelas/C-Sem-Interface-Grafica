using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, contador = 1, fat =1;

            Console.WriteLine("Digite um número para saber o fatorial dele");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 == 0)
            {
                Console.WriteLine("0! = 1");
            }
            else
            {
                Console.WriteLine("Não existe fatorial de número negativo");
            }

            while (contador <= n1)
            {
               fat *=contador ;
                Console.WriteLine(n1 + "! =" + fat);
                contador++;
            }
            Console.ReadKey();
        }
    }
}
