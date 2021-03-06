﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4) Faça um algoritmo que lê um valor N inteiro e positivo e que calcula e escreve o fatorial de N (N!).

namespace Lista4_Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, fat, i;

            numero = int.Parse(Console.ReadLine());
            fat = 1;
            
            if (numero>0)
            {
                //fatoral com FOR
                for (i = numero; i > 0; i--)
                {
                    fat = i * fat;
                }

                //fatoral com WHILE
                i = numero;
                while(i>0){
                     
                     fat = i * fat;
                     i--;
                }

                //fatoral com DO WHILE
                i = numero;
                do{
                    
                    fat = i * fat;
                    i--;
                }while(i!=0);

            }
            else
            {
                Console.WriteLine("Invalido: Numero negativo");
            }

            Console.WriteLine("Resultado: "+fat);
            Console.ReadKey();
        }
    }
}
