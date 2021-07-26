using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_Menor__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1,n2;
            Console.WriteLine("Digite um número");
            n1 = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Digite um número");
            n2 = Convert.ToDouble(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine(n1 +" é maior que o número " + n2);
            }
            else if (n1 == n2)
            {
                Console.WriteLine(n1 + " é igual ao número " + n2);
            }
            else
            {
                Console.WriteLine(n1 + " é menor que " + n2);
            }
            Console.ReadKey();
        }
    }
}
