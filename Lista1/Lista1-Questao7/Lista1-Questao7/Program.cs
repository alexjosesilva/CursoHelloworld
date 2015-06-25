using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1,  numero2;

            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Out.WriteLine("Resultado: " + (numero1 * numero2));
            Console.ReadKey();
        }
    }
}
