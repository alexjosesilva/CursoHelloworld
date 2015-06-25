using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Questao18
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatura;

            Console.Write("\n Inserir a temperatura Celsius: ");
            temperatura = double.Parse(Console.ReadLine());

            //calculo
            temperatura = 180 * (temperatura + 32) / 100;

            //exibir o resultado
            Console.Write("\n Tempereatura F: {0}", temperatura);
            Console.ReadKey();


        }
    }
}
