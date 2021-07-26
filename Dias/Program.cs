using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dias
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, anos_resto, meses, meses_resto, semanas, semanas_resto, dias, tempo;
            Console.WriteLine("Pegar os dias e falar quantos anos, meses e dias tem esses dias");
            Console.WriteLine("Escreva quantos dias o seu cachorro tem de vida");
            tempo = Convert.ToInt32(Console.ReadLine());
            anos = tempo / 365;
            anos_resto = tempo % 365;
            meses = anos_resto / 30;
            meses_resto = anos_resto % 30;
            semanas = meses_resto / 7;
            semanas_resto = meses_resto % 7;
            dias = semanas_resto;
            Console.WriteLine("O tempo de vida do seu cachorro é de: " + anos + " anos " + meses + " meses " + semanas + " semanas "
            + dias + " dias");
            Console.WriteLine("Pressione alguma tecla para parar o programa");
            Console.ReadKey();

        }
    }
}
