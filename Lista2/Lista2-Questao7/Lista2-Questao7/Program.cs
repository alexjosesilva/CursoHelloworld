using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;

            //obtendo os lados do triangulo
            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            numero3 = Convert.ToInt32(Console.ReadLine());

            //validar os lados do triangulo
            //cada lado menor que a soma dos outros lados
            if (numero1 < (numero2 + numero3))
            {

                if (numero2 < (numero1 + numero3))
                {

                    if (numero3 < (numero1 + numero2))
                    {
                       //tipo de triangulos

                        if((numero1 == numero2) && (numero1==numero3) && (numero2==numero3))
                            Console.Out.WriteLine("Triangulo Equilatero");
                        else
                            if((numero1 == numero2) || (numero1==numero3) || (numero2==numero3))
                                Console.Out.WriteLine("Triangulo Isosceles");
                            else
                                Console.Out.WriteLine("Triangulo Equilatero");
                    }
                    else{
                        Console.Out.WriteLine("Lados não formam um triangiulo!");
                    }
                }
                else{
                    Console.Out.WriteLine("Lados não formam um triangiulo!");
                }
            }
            else{
                Console.Out.WriteLine("Lados não formam um triangiulo!");
            }
            Console.ReadKey();
        }
    }
}
