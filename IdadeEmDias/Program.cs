using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, meses, dias, total;
            Console.WriteLine("Programa que lê a sua idade e converte em dias e meses");
            Console.WriteLine("Digite sua idade");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite quantos meses se passaram do seu antigo aniversário");
            meses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite qual é o dia de hoje");
            dias = Convert.ToInt32(Console.ReadLine());
            total = idade * 365 + meses * 30 + dias;
            Console.WriteLine("Sua idade em dias é: " + total );
            Console.WriteLine("Pressione alguma tecla para parar o programa");
            Console.ReadKey();
        }
    }
}
