using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Funções_Métodos
{
    class Program
    {
        static int cubo(int num)// num é var local
        {
            return num * num * num;
        }
        static void Main(string[] args)
        {
            int n; // var global
            Console.WriteLine("Cubo de um número inteiro positivo - Usando funções ");
            Console.WriteLine("Digite um número inteiro positivo");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + "elevado ao cubo é igual a: " + cubo(n));
            Console.ReadKey();
        }
    }
}
