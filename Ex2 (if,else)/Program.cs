using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;
            Console.WriteLine("Programa que determina se o aluno está APROVADO ou REPROVADO");
            Console.WriteLine("Digite sua primeira nota");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua segunda nota");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua teceira nota");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua quarta nota");
            n4 = Convert.ToDouble(Console.ReadLine());
            media = (n1 + n2 + n3 + n4) / 4;
            if (media >=7)
            {
                Console.WriteLine("Você foi APROVADO com uma média de: " + Math.Round(media,2));
            }
            else
            {
                Console.WriteLine("Você foi REPROVADO com uma média de: " + Math.Round(media,2));
            }
            Console.ReadKey();
        }
    }
}
