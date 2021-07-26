using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayComNumerosInteiros
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] nomes = new string[] {"Giovanni", "Leonardo", "Bruno", "Maurício", "Ricardo", "Gabriel", "Bruno", "Lucas Henrique", "Lucas Machado", "Marta", "José", "Maria"};
            int[] numeros = new int[] { 175,148,237,353,486,535,678,732,862,972,106,111 };
            int i = 0;
            while (i <= 11)
            {
                
                Console.WriteLine("O numero do aluno " + nomes[i] + " dentro da posição é :" + numeros[i]);
                i++;
            }

            Console.WriteLine("\nPressione algum tecla para parar o programa!!!");
            Console.ReadKey();
        }
    }
}
