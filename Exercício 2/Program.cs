using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que mostra quantas ferraduras precisam para tantos cavalos");
            int cavalo, ferradura;
            Console.WriteLine("Digite a quantidade de cavalos");
            cavalo = Convert.ToInt32(Console.ReadLine());
            ferradura = cavalo * 4;
            Console.WriteLine("Você precisa de " + ferradura + " ferraduras para os " + cavalo + " cavalos");
            Console.WriteLine("Pressione alguma tecla parar por fim ao programa");
            Console.ReadKey();
        }
    }
}
