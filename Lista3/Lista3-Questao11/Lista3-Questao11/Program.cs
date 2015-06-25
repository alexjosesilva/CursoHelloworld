using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Questao 11: Calcular area do losangulo 
 */
namespace Lista3_Questao11
{
    class Program
    {
        static void Main(string[] args)
        {
            double diaMaior, diaMenor,A;

            diaMenor = Convert.ToDouble(Console.ReadLine());
            diaMaior = Convert.ToDouble(Console.ReadLine());

            A = (diaMaior*diaMenor)/2;
            Console.WriteLine("Area: " + A);
            Console.ReadKey();
        }
    }
}
