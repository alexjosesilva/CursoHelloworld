using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, nota4;

            nota1 = Convert.ToInt32(Console.ReadLine());
            nota2 = Convert.ToInt32(Console.ReadLine());
            nota3 = Convert.ToInt32(Console.ReadLine());
            nota4 = Convert.ToInt32(Console.ReadLine());

            Console.Out.WriteLine("Media: "+( (nota1+nota2+nota3+nota4)/4) );
            Console.ReadKey();


        }
    }
}
