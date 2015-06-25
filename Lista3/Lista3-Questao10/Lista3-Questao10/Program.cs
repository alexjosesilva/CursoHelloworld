using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Questao 10: Calcular a area do Quadrado
 */
namespace Lista3_Questao10
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, lado;

            lado = Convert.ToDouble(Console.ReadLine());
            A = lado * lado;
            Console.WriteLine("Area: " + A);
            Console.ReadKey();
        }
    }
}
