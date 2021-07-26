using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeHorasEmSegundos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* sabendo que hora = 3600 segundos, minuto = 60 segundos, faça um cálculo de quantos segundos 
             * um determinado jogador correu em um esporte.*/
            int horas, minutos, segundos, total;
            Console.WriteLine("Determinar quantos segundos um atleta percorreu em sua jornada");
            Console.WriteLine("Quantas horas você correu?");
            horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantos minutos você correu?");
            minutos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantos segundos você correu?");
            segundos = Convert.ToInt32(Console.ReadLine());
            total = horas * 3600 + minutos * 60 + segundos;
            Console.WriteLine("Você correu por " + total + " segundos");
            Console.WriteLine("Pressione alguma tecla para por fim ao programa.");
            Console.ReadKey();
        }
    }
}
