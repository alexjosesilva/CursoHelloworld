using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            double pnota, snota, media;

            pnota = Convert.ToDouble(Console.ReadLine());
            snota = Convert.ToDouble(Console.ReadLine());

            media = (pnota * 2 + snota * 3) / 2;

            Console.Out.WriteLine("media: " + media);
            Console.ReadKey();

        }
    }
}
