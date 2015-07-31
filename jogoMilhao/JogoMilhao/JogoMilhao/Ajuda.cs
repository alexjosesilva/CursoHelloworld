using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDoMilhão
{
    public class Ajuda
    {
        private int placas;
        private int universitario;
        private int cartas;
        private int pulos;

        public int Placas
        {
            get { return placas; }
            set { placas = value; }
        }
        
        public int Universitario
        {
            get { return universitario; }
            set { universitario = value; }
        }


        public int Cartas
        {
            get { return cartas; }
            set { cartas = value; }
        }
        

        public int Pulos
        {
            get { return pulos; }
            set { pulos = value; }
        }

        //Classe contrutora
        public Ajuda(int placas, int universitarios, int cartas, int pulos)
        {
            this.Placas = placas;
            this.Universitario = universitario;
            this.Cartas = cartas;
            this.Pulos = pulos;
        }

        //Classe Construtura default
        public Ajuda()
        {
            
        }

        //Menu Ajuda das Cartas exibido no radope apos as perguntas

        public void MenuAjuda(Random rd)
        {
            char opt;
            Console.Write("\n ----------------------------\n");
            Console.WriteLine("A - PLACAS");
            Console.WriteLine("B - universitarioS");
            Console.WriteLine("C - CARTAS");
            Console.WriteLine("D - PULOS");
            Console.WriteLine("P - PARAR");
            Console.Write("\n ----------------------------\n");

            //leitura da opção 
            opt = char.ToLower(char.Parse(Console.ReadLine()));
            
            switch (opt)
            {
                case 'a':
                    if (Placas == 1)
                    {

                        Console.WriteLine("A plateia mostrou a alternativa: " + rd.Next(1, 4));
                        Placas--;
                    }
                    else
                    {
                        Console.WriteLine("Você não pode mais usar esta opção --- ENTER");
                        Console.ReadKey();
                    }
                    break;
                case 'b':
                    if (Universitario <= 1)
                    {
                        Console.WriteLine("Universsitário 1: " + rd.Next(1, 4));
                        Console.WriteLine("Universsitário 2: " + rd.Next(2, 4));
                        Console.WriteLine("Universsitário 3: " + rd.Next(3, 4));
                        Universitario = 2;

                    }
                    else
                    {
                        Console.WriteLine("Você não pode mais usar esta opção --- ENTER");
                        Console.ReadKey();
                    }
                    break;
                case 'c':
                    if (Cartas <= 1)
                    {
                        int indexAleatorio = rd.Next(0, 4);
                        List<string> valoresDasCartas = new List<string>();
                        valoresDasCartas.Add("Rei");
                        valoresDasCartas.Add("Ás");
                        valoresDasCartas.Add("2");
                        valoresDasCartas.Add("3");
                        List<string> acoes = new List<string>();
                        acoes.Add("Nenhuma alternativa foi eliminada");
                        acoes.Add("A alternativa:" + "a,b,c,d" + "está errada" + "e a alternativa " + " a,b,c,d" + "também");
                        acoes.Add("A alternativa:" + "a,b,c,d" + "está errada" + "e a alternativa " + " a,b,c,d" + "e também a alternativa" + "a,b,c,d");
                        acoes.Add("A alternativa:" + "a,b,c,d" + "está errada" + "e a alternativa " + " a,b,c,d" + "e a alternativa" + "a,b,c,d" + "e também a alternativa " + "a,b,c,d");
                       
                        Console.WriteLine("Escolha:");
                        Console.WriteLine("1ª CARTA");
                        Console.WriteLine("2ª CARTA");
                        Console.WriteLine("3ª CARTA");
                        Console.WriteLine("4ª CARTA");
                        
                        //Menu das cartas
                        char escolhaCarta = char.ToLower(char.Parse(Console.ReadLine()));


                        switch (escolhaCarta)
                        {

                            case '1':
                                Console.WriteLine("Você ganhou: " + valoresDasCartas[indexAleatorio]);
                                Console.WriteLine(acoes[indexAleatorio]);
                                break;
                            case '2':
                                Console.WriteLine("Você ganhou: " + valoresDasCartas[indexAleatorio]);
                                Console.WriteLine(acoes[indexAleatorio]);
                                break;
                            case '3':
                                Console.WriteLine("Você ganhou: " + valoresDasCartas[indexAleatorio]);
                                Console.WriteLine(acoes[indexAleatorio]);
                                break;
                            case '4':
                                Console.WriteLine("Você ganhou: " + valoresDasCartas[indexAleatorio]);
                                Console.WriteLine(acoes[indexAleatorio]);
                                break;
                            default:
                                break;
                        }

                        Cartas = 2;
                    }
                    else
                    {
                        Console.WriteLine("Limite Excedidio!--- ENTER");
                        Console.ReadKey();
                    }
                    break;
                case 'd':
                    if (Pulos > 0 && Pulos <= 3)
                    {

                        Pulos--;
                        break;

                    }

                    else
                    {
                        Console.WriteLine("Limite Excedido! --- ENTER");
                        Console.ReadKey();
                    }
                    break;
                case 'p':

                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    Console.ReadKey();
                    break;
            }

        }


      
    }
}

