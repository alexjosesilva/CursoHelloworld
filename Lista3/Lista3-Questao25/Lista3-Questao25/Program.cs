using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//conversao de hora para minuto e segundo

namespace Lista3_Questao25
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double hora, minuto;

            //entrada de dados
            Console.Write("\n Inserir hora: ");
            hora = double.Parse(Console.ReadLine());
            Console.Write("\n Inserir Minuto: ");
            minuto = double.Parse(Console.ReadLine());

            //calculos
            Console.Write("\n Horas em Minutos: {0}",hora*60);
            Console.Write("\n Horas + Minutos: {0}",(hora*60)+minuto);
            Console.Write("\n Minutos em Segundos: {0}",minuto*60);

            Console.ReadKey();

        }
    }
}
