using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6__array_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[10];
            double soma_positivos = 0;
            int contador = 0, qntde_negativos = 0;

            while (contador <= 9)
            {
                Console.WriteLine("Digite um número, tanto faz ser negativo quanto positivo");
                numeros[contador] = Convert.ToDouble(Console.ReadLine());
                contador++;
            }
            contador = 0;
            while (contador <= 9)
            {
                if (numeros[contador] < 0)
                {
                    qntde_negativos++;
                    contador++;
                }

                else if ( numeros[contador] >= 0)
                {
                    soma_positivos += numeros[contador];
                    contador++;
                }
                
            }

            Console.WriteLine("\nA quantidade de números negativos digitados são de: " + qntde_negativos + " números");
            Console.WriteLine("A soma dos números positivos é de: " + soma_positivos);
            Console.ReadKey();
            
        }
    }
}
