using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
 * Lista 3-Questao 19: Receber a medida dos lados de um comodo e calcular o metro quadrado
 * apartir da potencia de uma lampada 18W, calcular a potencia necessária para iluminar o
 * cômodo.
 * :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
 */
namespace Lista3_Questao19
{
    class Program
    {
        //CONSTANTE POTENCIA PW
        const double PW = 18;

        static void Main()
        {
            //VARIAVEIS
            double metros, potencia;
            double medidaA, medidaB;
           
            //ENTRADA DE DADOS
            Console.Write("\n Inserir Valor do lado A:");
            medidaA = double.Parse(Console.ReadLine());

            Console.Write("\n Inserir Valor do lado B:");
            medidaB = double.Parse(Console.ReadLine());

            //CALCULOS
            metros = medidaA * medidaB;
            potencia = metros / PW;

            Console.Write("\n valor em Metros Quadrados: {0} m²", metros);
            Console.Write("\n valor em potencia: {0:F} W", potencia);

            Console.ReadKey();
        }
    }
}
