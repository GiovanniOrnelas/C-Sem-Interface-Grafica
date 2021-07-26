using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, soma = 0, contador = 0, media;
            double soma_pares = 0, contador_pares = 0, media_pares;
            double contador_impares = 0, porc_impares;
                     
            Console.WriteLine("Vários Números - Cálculos Diversos");
            Console.WriteLine("Digite um nº positivo, ou 0 para terminar: ");
            num = Double.Parse(Console.ReadLine());
            double menor = num;
            double maior = num;
            while (num > 0)
            {
                if (num % 2 == 0)
                { //num é PAR
                    contador_pares++;
                    soma_pares += num;
                }
                else { contador_impares++; }               
                
                soma += num;
                contador++;//contador = contador + 1;
                Console.WriteLine("Digite um nº positivo, ou 0 para terminar: ");
                num = Double.Parse(Console.ReadLine());
               
                if (num > maior)
                {
                    maior = num;
                }
                else if (num < menor && num > 0)
                {
                    menor = num;
                }
            }
            
            media = soma / contador;          

            Console.WriteLine("A soma dos números digitados foi: " + soma);
            Console.WriteLine("A quantidade de números digitados foi: " + contador);
            Console.WriteLine("A média dos números digitados foi: " + Math.Round(media, 2));
            
            if (contador_pares > 0)
            {
                media_pares = soma_pares / contador_pares;
                Console.WriteLine("A média dos pares vale: " + Math.Round(media_pares,2));
            }
            else { 
            Console.WriteLine("Não foram digitados números pares!"); 
            }
            porc_impares = 100 * contador_impares / contador;
            Console.WriteLine("A porcentagem de ímpares é de: " + Math.Round(porc_impares, 2) + " %");          
            Console.WriteLine("\nMaior número digitado é: " + maior);
            Console.WriteLine("Menor número digitado é: " + menor);
            Console.ReadKey();
        }
    }
}
