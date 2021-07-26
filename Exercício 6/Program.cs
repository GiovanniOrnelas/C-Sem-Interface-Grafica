using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O restaurante a quilo Bem-Bão cobra R$12,00 por cada quilo de refeição. Escreva um algoritmo 
            que leia o peso do prato montado pelo cliente (em quilos) e imprima o valor a pagar. Assuma que a 
            balança já desconte o peso do prato
             */
            double quilos, total;
            Console.WriteLine("Bem-vindo ao restaurante Bem-Bão!"); 
            Console.WriteLine("O quilo do prato custa R$12,00");
            Console.WriteLine("Quantos quilos tem o seu prato segundo a balança?");
            quilos = Convert.ToDouble(Console.ReadLine());
            total = quilos * 12.00;
            Console.WriteLine("Total a pagar dos " + quilos + " quilos do seu prato é: R$" + total);
            Console.WriteLine("Pressione alguma tecla para parar o programa");
            Console.ReadKey();
        }
    }
}
