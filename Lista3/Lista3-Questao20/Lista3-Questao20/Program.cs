using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Questao20
{
    class Program
    {
        const double pi = 3.14;

        static void Main(string[] args)
        {
            double angulo, distancia, medida;

            Console.Write("\n Angulo: ");
            angulo = double.Parse(Console.ReadLine());
            Console.Write("\n Medida: ");
            medida = double.Parse(Console.ReadLine());

            distancia = Math.Sin(angulo) * medida;

            Console.Write("\n {0:F} M", Math.Abs(distancia));
            Console.ReadKey();



        }
    }
}
