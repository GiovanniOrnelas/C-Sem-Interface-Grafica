using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, contador = 2, media = 0, repetir=0;
            
            Console.WriteLine("Digite a primeira nota");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota");
            nota4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite quantas vezes você deseja fazer essa operação");
            repetir = Convert.ToInt32(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media > 10)
            {
                Console.WriteLine("\nNão existe média acima de 10!!!!");
            }
            else if (media > 7 && media <= 10)
            {
                Console.WriteLine("\nO aluno foi APROVADO com uma média de: " + media);
            }

            else if (media < 7)
            {
                Console.WriteLine("\nO aluno foi REPROVADO com uma média de: " + media);
            }


            while (contador <= repetir )
            {
                contador++;
                Console.WriteLine("\nDigite a primeira nota");
                nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota");
                nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a terceira nota");
                nota3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a quarta nota");
                nota4 = Convert.ToDouble(Console.ReadLine());
                media = (nota1 + nota2 + nota3 + nota4) / 4;

                if (media > 10)
                {
                    Console.WriteLine("\nNão existe média acima de 10!!!!");
                }
                else if (media > 7 && media <= 10)
                {
                    Console.WriteLine("\nO aluno foi APROVADO com uma média de: " + media);
                }

                else if (media < 7)
                {
                    Console.WriteLine("\nO aluno foi REPROVADO com uma média de: " + media);
                }

            }           
            Console.WriteLine("Digite alguma tecla para parar o programa...");
            Console.ReadKey();           
        }
    }
}
