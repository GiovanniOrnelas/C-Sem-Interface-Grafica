using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntde_repeticoes, contador = 1, numero, resultado=0;

            Console.WriteLine("Soma de números digitados");
            Console.WriteLine("\nDigite quantas vezes você deseja digitar um número");
            qntde_repeticoes = Convert.ToInt32(Console.ReadLine());

            while (contador <= qntde_repeticoes)
            {
                Console.WriteLine("\nDigite o " + contador + "º número");
                numero = Convert.ToInt32(Console.ReadLine());
                resultado += numero;
                
                contador++;
            }

            Console.WriteLine("\nO resultado da soma total é de: " + resultado);

            Console.ReadKey();
        }
    }
}
