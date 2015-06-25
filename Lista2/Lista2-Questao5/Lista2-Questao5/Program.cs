using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
           //Declarações de Variaveis
            int maior, menor, meio;
            int numero1,numero2,numero3;

            //entrada de dados
            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            numero3 = Convert.ToInt32(Console.ReadLine());

            //condicional
            if((numero1>numero2) && (numero1>numero3)){
                maior = numero1;
                if(numero2>numero3){
                    meio=numero2;
                    menor=numero3;
                }
                else{
                    meio = numero3;
                    menor = numero2;
                }
            }
            else if(numero2>numero3){
                maior = numero2;

                if (numero1 > numero3)
                {
                    meio = numero1;
                    menor = numero3;
                }
                else
                {
                    meio = numero3;
                    menor = numero1;
                }
            }
            else
            {
                maior = numero3;
                if (numero1 > numero2)
                {
                    meio = numero1;
                    menor = numero2;
                }
                else
                {
                    meio = numero2;
                    menor = numero1;
                }
            }
            Console.Out.WriteLine("Maior["+maior+"] Meio[ "+meio+" ] Menor["+menor+"]");
            Console.ReadKey();
        }
        
    }
    
}
