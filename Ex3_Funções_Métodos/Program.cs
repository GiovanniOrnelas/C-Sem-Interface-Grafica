using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Funções_Métodos
{
    class Program
    {
        static double Media(double n1, double n2, double n3)
        {           
            return (n1 + n2 + n3) / 3;
        }

        static void Main(string[] args)
        {
            double num1, num2, num3, media;
            
            Console.WriteLine("Digite a primeira nota");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite a segunda nota");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n" +
                "Digite a terceira nota");
            num3 = Convert.ToDouble(Console.ReadLine());

            media= (num1 + num2 + num3) / 3;

            Console.WriteLine("\n\nA média do aluno é de: " + Math.Round(Media(num1,num2,num3),2));
            
            
            Console.ReadKey();
        }
    }
}
