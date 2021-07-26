using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3__array_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros_inteiros = new int[10];


            int contador = 0, contador_pares=0;

            

            while (contador <= 9)
            {
                Console.WriteLine("Digite a " + contador + "º posisão do vetor" );
                numeros_inteiros[contador] = Convert.ToInt32(Console.ReadLine());         

                contador++;
            }
            Console.Clear();
                    
            contador = 0;

            while (contador <= 9) { 
                Console.WriteLine("Os números digitados são: " + numeros_inteiros[contador]);
                contador++;
            }
            Console.ReadKey();
            Console.Clear();
            contador = 0;
           
            while (contador <= 9)
            {
                if (numeros_inteiros[contador] % 2 == 0)
                {
                    contador_pares++;
                    Console.WriteLine("Os números pares digitados são : " + numeros_inteiros[contador]);
                }
           
                contador++;
            }
            
            if (contador_pares <= 0)
            {
                Console.WriteLine("Não há números pares!!!");
            }

            Console.ReadKey();
        }
    }
}
