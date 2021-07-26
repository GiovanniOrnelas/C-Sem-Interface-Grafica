using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, minutos, segundos, resto_hora, minutos_calc, resto_minutos ;
            Console.WriteLine("Programa que converte minutos em horas, minutos e segundos");
            Console.WriteLine("Digite quantos minutos demorou o intervalo");
            minutos = Convert.ToInt32(Console.ReadLine());
            horas = minutos / 3600; // hora = 2
            resto_hora = minutos % 3600; // resto_hora = 2799
            minutos_calc = resto_hora / 60; // minutos_calc = 46
            resto_minutos = resto_hora % 60; // 39
            segundos = resto_minutos; //

            Console.WriteLine(horas + " horas " + minutos_calc + " minutos " + segundos + " segundos");

            Console.WriteLine("Pressione alguma tecla para parar o programa");
            Console.ReadKey();
        }
    }
}
