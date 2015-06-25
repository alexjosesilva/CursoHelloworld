using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;

            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            numero3 = Convert.ToInt32(Console.ReadLine());

            Console.Out.WriteLine("(n1 + n2) / n3: "+( (numero1+numero2)/numero3 ));
            Console.ReadKey();
        }
    }
}
