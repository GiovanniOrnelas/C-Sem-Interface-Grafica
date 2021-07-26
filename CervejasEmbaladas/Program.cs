using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CervejasEmbaladas
{
    class Program
    {
        static void Main(string[] args)
        {
            int garrafas, total, engradado, sobras;
            Console.WriteLine("Determinar quantas garrafas serão embaladas e quantas sobraram");
            Console.WriteLine("Sabendo que 1 engradado (embalagem) só é aceito com 24 garrafas");
            Console.WriteLine("Digite um número de garrafas");
            garrafas = Convert.ToInt32(Console.ReadLine());
            engradado = garrafas / 24;
            sobras = garrafas % 24;
            if (engradado <= 0){
                Console.WriteLine("Não precisamos de nenhum engradamento, pois você pediu menos que 24 garrafas");
                Console.WriteLine("Sobrando " + garrafas + " garrafas");
            }
            else
            {
                Console.WriteLine("Precisamos de " + engradado + " engradado(s)");
                Console.WriteLine("E restou " + sobras + " garrafas");
            }
            Console.WriteLine("Pressione alguma tecla para parar o programa");
            Console.ReadKey();
            
        }
    }
}
