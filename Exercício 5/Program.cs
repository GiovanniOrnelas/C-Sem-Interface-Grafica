using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*. Um motorista deseja colocar no seu tanque X reais de gasolina. Escreva um algoritmo para ler o 
            preço do litro da gasolina e o valor do pagamento, e exibir quantos litros ele conseguiu colocar no tanque.
             */
            double dinheiro, litro;
            Console.WriteLine("O litro da gasolina é $3,33");
            Console.WriteLine("Quantos litros você deseja colocar em seu carro?");
            litro = Convert.ToDouble(Console.ReadLine());
            dinheiro = litro * 3.33;
            Console.WriteLine("Você reabasteceu " + litro + " litros " + ". Total a pagar: $" + Math.Round(dinheiro,3));
            Console.WriteLine("Pressione alguma tecla para parar o programa");
            Console.ReadKey();
        }
    }
}
