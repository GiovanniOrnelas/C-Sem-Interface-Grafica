using System;

namespace while_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, qntdeNumerosDigitados = 0;
            double media = 0, soma=0;

            Console.WriteLine("Digite um número para fazer o looping, exceto o 0, ele irá ser o terminal do programa...");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero != 0)
            {
                Console.WriteLine("Digite um número para fazer o looping, exceto o 0, ele irá ser o terminal do programa...");
                numero = Convert.ToInt32(Console.ReadLine());
                qntdeNumerosDigitados++;
                soma += numero;
                media = soma / qntdeNumerosDigitados;
            }
            
            Console.WriteLine("Foram digitados " + qntdeNumerosDigitados + " números");
            Console.WriteLine("A média dos números digitados é de: " + Math.Round(media,2));
            Console.ReadKey();
        }
    }
}
