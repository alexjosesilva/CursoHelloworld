using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//numero de lados de um poligono

namespace Lista3_Questao22
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            N = N * (N - 3) / 2;

            Console.Write("\n Numero Diagonais: {0}",N);
            Console.ReadKey();
        }
    }
}
