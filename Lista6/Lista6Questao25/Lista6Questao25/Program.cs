using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao25
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double horasextras, horasfaltas,H;


            //entrada
            Console.WriteLine("Inserir Horas Extras: ");
            horasextras = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserir Horas Faltas: ");
            horasfaltas = double.Parse(Console.ReadLine());

            //calculos
            H = horasextras - 2 / 3 * (horasfaltas);

            if (H>2.400)
            {
                Console.WriteLine("Gratificacao 500,00");
            }
            else if (H >= 1.800 && H < 2.400)
            {
                Console.WriteLine("Gratificacao 400,00");
            }
            else if (H>=1.200 && H<1.800)
            {
                Console.WriteLine("Gratificacao 300,00");
            }
            else if (H >= 600 && H < 1.200)
            {
                Console.WriteLine("Gratificacao 200,00");
            }
            else if (H < 600)
            {
                Console.WriteLine("Gratificacao 100,00");
            }
            Console.ReadKey();
        }
    }
}
