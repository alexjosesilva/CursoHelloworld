using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jogo_da_Forca
{
    class Program
    {
        static void Main(string[] args)
        {

            string palavra;
            
            int acertos = 0;
            int erros = 0;
            
            Console.WriteLine("---------------------- Forca - by Lucas e Claudio ---------------------------\n\n");
            Console.WriteLine("Digite uma palavra");
            palavra = Console.ReadLine();

            char[] letras    = palavra.ToCharArray();
            char[] forca     = palavra.ToCharArray();
            char[] digitados = palavra.ToCharArray();

            char digitos;

            for (int i = 0; i < palavra.Length; i++)
            {
                if (letras[i] == ' ')
                {
                    forca[i] = ' ';
                }
                else
                {
                    forca[i] = '_';
                }
            }
            Console.Clear();

            do
            {
                Console.WriteLine("---------------------- Forca - by Lucas e Claudio ---------------------------\n\n");

                Console.Write(" ________\n" +
                                     "|        |\n" +
                                     "|        |\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n\n");




                Console.SetCursorPosition(2, Console.CursorTop - 2);

                for (int i = 0; i < palavra.Length; i++)
                {
                    Console.Write(forca[i] + " ");
                }



                Console.Write("\n\n\nDigite uma letra: ");
                digitos = Convert.ToChar(Console.Read());


                for (int i = 0; i < palavra.Length; i++)
                {

                    if (digitos == forca[i])
                    {
                        Console.WriteLine("\nLetra já digitada -- Aperte Enter");
                        Console.ReadKey();
                    }


                    else if (digitos == letras[i])
                    {
                        forca[i] = digitos;
                        acertos++;
                    }

                    /* else if (digitos != forca[i])
                     {
                         Console.WriteLine("Letra não existe -- Aperte Enter");

                         Console.ReadKey();
                         erros++;

                     }*/
                }

                Console.Clear();


            } while (acertos < palavra.Length);
            Console.Clear();

            Console.WriteLine("---------------------- Forca - by Lucas e Claudio ---------------------------\n\n");
            Console.WriteLine("Você venceu");
            Console.ReadKey();


        }
    }
}
