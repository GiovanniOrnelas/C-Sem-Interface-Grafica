using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Diferente
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, cont=0, soma_digitados = 0, media_digitados=0;
            Console.WriteLine("Lendo vários números ao mesmo tempo");
            Console.WriteLine("Digite um número POSITIVO para o programa continuar, ou de 0 para baixo para parar!");
            n = Convert.ToDouble(Console.ReadLine());
            


            while (n > 0)
            {
                cont++;
                soma_digitados = n + soma_digitados;
                Console.WriteLine("Digite um número");
                n = Convert.ToDouble(Console.ReadLine());

            }

            if (n <= 0)
            {
                Console.WriteLine("Parou");
                Console.WriteLine("Foram digitados " + cont + " números");
                media_digitados = soma_digitados / cont;
                Console.WriteLine("Cálculo de todos os números :" + soma_digitados);
                Console.WriteLine("Média dos números digitados: "+ soma_digitados + " / " + cont + " = " + Math.Round(media_digitados,2));
                Console.ReadKey();
            }

            
        }
    }
}
