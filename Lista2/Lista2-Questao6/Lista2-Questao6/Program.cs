using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;
            
            //obtendo os numeros
            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            numero3 = Convert.ToInt32(Console.ReadLine());

            //testar numero 1
            if (numero1 > 0){
                Console.Out.WriteLine("Raiz Quadrada: "+ Math.Sqrt(numero1));
            }
            else{
                Console.Out.WriteLine("Numero ao Quadrado: " + (numero1^2));
            }

            //testar numero 2
            if((numero2 > 10) && (numero2 <100)){
                Console.Out.WriteLine("Segundo Numero esta entre 10 e 100");
            }

            //testar numero 3
            if (numero3 < numero2)
            {
                Console.Out.WriteLine("Terceiro Numero: " + (numero2 - numero3));
            }
            else
            {
                Console.Out.WriteLine("Terceiro Numero+1:"+(numero3+1));
            }


            Console.ReadKey();
        }
    }
}
