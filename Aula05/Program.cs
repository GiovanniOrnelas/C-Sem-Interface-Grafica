using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, s, total;
            Console.WriteLine("Informando a quantidade de segundos!");
            Console.WriteLine("Digite um horário em horas");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um horário em minutos");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um horário em segundos");
            s = Convert.ToInt32(Console.ReadLine());
            total = h * 3600 + m * 60 + s;
            Console.WriteLine("O total em segundos é:" + total);
            Console.WriteLine("Pressione alguma tecla para terminar a operação!");
            Console.ReadKey();

        }
    }
}
