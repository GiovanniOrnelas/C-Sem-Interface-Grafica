using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, IMC;
            Console.WriteLine("Qual é o seu peso?");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual é a sua altura?");
            altura = Convert.ToDouble(Console.ReadLine());
            IMC = peso / (altura * altura);

            if (IMC < 20) // 19 para baixo
            {
                Console.WriteLine("Abaixo do peso");
            }

            else if (IMC <=25) // 20 até 25
            {
                Console.WriteLine("Peso Normal");
            }

            else if (IMC <= 30) // 25 até 30
            {
                Console.WriteLine("Sobre Peso");
            }
            
            else if (IMC <= 40) // 30 até 40
            {
                Console.WriteLine("Obeso");
            }
            
            else if (IMC >= 40) // 40 para cima
            {
                Console.WriteLine("Obeso Mórbido");
            }
            Console.WriteLine("O cálculo do IMC é de: " + Math.Round(IMC,2));
            Console.ReadKey();
        }
    }
}
