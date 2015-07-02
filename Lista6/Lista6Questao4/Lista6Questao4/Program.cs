using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            int pnumero, snumero, tnumero; 
            

            pnumero = Int32.Parse(Console.ReadLine());
            snumero = Int32.Parse(Console.ReadLine());
            tnumero = Int32.Parse(Console.ReadLine());

            if (pnumero > snumero && pnumero>tnumero)
            {
                Console.Write("\n Maior: {0} ", pnumero);
            }
            else if (snumero > tnumero)
            {
                 Console.Write("\n Maior: {0} ", snumero);
            }
            else
            {
                Console.Write("\n Maior: {0} ", tnumero);
            }

            Console.ReadKey();
        }
    }
}
