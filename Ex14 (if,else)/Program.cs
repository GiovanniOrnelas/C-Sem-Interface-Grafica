using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;
            Console.WriteLine("Classificação do aluno");
            Console.WriteLine("Digite sua média");
            media = Convert.ToDouble(Console.ReadLine());

            if (media >= 9 && media <=10) // 9 - 10
            {
                Console.WriteLine("Recomendação : Altamente recomendado");
            }
            
            if (media >= 8 && media <9) // 8 - 8,99
            {
                Console.WriteLine("Recomendação : Fortemente recomendado");
            }

            if (media >=7 && media <8) // 7 - 7,99
            {
                Console.WriteLine("Recomendação : Recomendado");
            }

            if (media >=0 && media <=7) // 0 - 6,99
            {
                Console.WriteLine("Recomendação : Não recomendado");
            }

            if ( media <0 || media > 10)
            {
                Console.WriteLine("Media inexistente");
            }

            Console.ReadKey();
        }
    }
}
