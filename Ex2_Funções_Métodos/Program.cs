using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Funções_Métodos
{
    class Program
    {
     
        static void troca (int n1, int n2)
        {
            int aux;
            aux = n1;
            n1 = n2;
            n2 = aux;

            Console.WriteLine("\nVariáveis trocadas: " + n1 + " e " + n2);
        } 
        static void Main(string[] args)
        {
            int num1, num2;
            
            Console.WriteLine("\nTroca de variáveis - Usando funções");
            
            Console.WriteLine("Digite o valor do primeiro número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nValor das variáveis originais: " + num1 + " e " + num2);
            troca(num1, num2);
            
            Console.ReadKey();
        }
    }
}
