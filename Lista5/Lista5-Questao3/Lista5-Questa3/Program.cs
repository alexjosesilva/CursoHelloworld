using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 3) Seu aplicativo receberá três usuários distintos. Eles deverão informar os nomes 
 * e suas 3 notas. O programa deverá calcular a média de cada um deles e, ao final, 
 * exibir por ordem decrescente de média, os dados de cada um deles e suas médias 
 * (Utilizar um array de string e um array de double) 
 */
namespace Lista5_Questa3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double[] media = new double[3];
            string[] nomes = new string[3];
            double pnota, snota, auxM;
            string auxS;

            //entrada de dados
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("\n Nome: ");
                nomes[i]=Console.ReadLine();

                Console.Write("\n 1º nota: ");
                pnota = double.Parse(Console.ReadLine());

                Console.Write("\n 2º nota: ");
                snota = double.Parse(Console.ReadLine());

                //calculo das medias
                media[i] = (pnota + snota) / 2;
            }

            
            // ORDENAÇÃO SELECT SORT
            // inicializacao variavel aux
            auxM = 0;
            auxS = " ";

            
            //Ordenar os vetores segundo o critério: menor para maior média
            for (int i = 0; i < media.Length; i++)
            {
                for (int j = 0; j < media.Length; j++)
                {
                    //selecionar do menor para o maior
                    if (media[i] > media[j])
                    {
                        //momento da troca:
                        //para este problema a troca dos dois vetores ao mesmo tempo
                        //devido o tamanho dos dois vetores serem os mesmos!

                        auxM = media[i];
                        auxS = nomes[i];
                        
                        media[i] = media[j];
                        nomes[i] = nomes[j];

                        media[j] = auxM;
                        nomes[j] = auxS;
                    }
                }
            }

            //Exibir os vetores
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("\n Nome: {0} - Media: {1:F} ",nomes[i],media[i]);
            }
            
            Console.ReadKey();
        }
    }
}
