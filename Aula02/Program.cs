using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, mult;
            Console.WriteLine("Multiplicação com 3 números");
            Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundoo número");
            n3 = Convert.ToInt32(Console.ReadLine());
            mult = n1 * n2 * n3;
            Console.WriteLine("Você tem um resultado de:" + mult);
            Console.WriteLine("Aperta qualquer tecla para fechar!");
            Console.ReadKey();
        }
    }
}
