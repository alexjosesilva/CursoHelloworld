using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Questao 9: Calcular a area do Trapezio
 */
namespace Lista3_Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, baseMaior, baseMenor,A;

            altura    = Convert.ToDouble(Console.ReadLine());
            baseMaior = Convert.ToDouble(Console.ReadLine());
            baseMenor = Convert.ToDouble(Console.ReadLine());

            A = ((baseMenor + baseMaior) * altura) / 2;

            Console.Out.WriteLine("Area do Trapezio: " + A);
            Console.ReadKey();
        }
    }
}
