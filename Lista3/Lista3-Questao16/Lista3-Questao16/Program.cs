using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Questao16
{
    class Program
    {
        static void Main(string[] args)
        {
            double catetoA, catetoB, hipotenusa;

            Console.Write("CatetoA: ");
            catetoA = double.Parse(Console.ReadLine());

            Console.Write("CatetoB: ");
            catetoB = double.Parse(Console.ReadLine());

            hipotenusa = Math.Sqrt((Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2)));

            Console.WriteLine("Hipotenusa: " + Math.Round(hipotenusa, 2));
            Console.ReadKey();
        }
    }
}
