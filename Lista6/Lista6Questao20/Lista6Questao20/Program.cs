using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6Questao20
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            idade = int.Parse(Console.ReadLine());

            if (idade>=5 && idade<=7)
            {
                Console.WriteLine("Infantil");
            }
            else if (idade>=8 && idade<=10)
            {
                Console.WriteLine("Juvenil");
            }
            else if (idade>=11 && idade<=15)
            {
                Console.WriteLine("Adolescente");
            }
            else if (idade>=16 && idade<=30)
            {
                Console.WriteLine("Adulto");
            }
            else if (idade > 30 )
            {
                Console.WriteLine("Senior");
            }
           
        }
    }
}
