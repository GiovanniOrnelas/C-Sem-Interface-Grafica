using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class EscritaDeLinhas
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("Digite dois números inteiros");
            Console.WriteLine("Digite o primeiro número");
            // leitura da primeira interatividade
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            // leitura da segunda interatividade
            n2 = Convert.ToInt32(Console.ReadLine());
            soma = n1 + n2;
            if (soma >= 7)
            {
                Console.WriteLine("Você passou de ano com tal nota:" + soma);
            }
            else
            {
                Console.WriteLine("Você repetiu de ano com tal nota:" + soma);

            }
            Console.ReadKey();
        }
    }
}
