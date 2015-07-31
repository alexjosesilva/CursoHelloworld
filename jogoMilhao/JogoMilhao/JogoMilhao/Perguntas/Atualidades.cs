using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMilhao
{
    class Atualidades:Perguntas
    {
        List<Atualidades> atual = new List<Atualidades>();
     
        public Atualidades()
        {
                
        }

        public Atualidades(string pergunta, string alt1, string alt2, string alt3, string alt4, string resp)
        {
            this.Pergunta = pergunta;
            this.Resp = resp;
            this.Alt1 = alt1;
            this.Alt2 = alt2;
            this.Alt3 = alt3;
            this.Alt4 = alt4;     
        }

        public void listaPerguntas()
        {
            atual.Add(new Atualidades("Atual Presidente do Brasil ?","A-Dilma","B-Lula","C-Erasmo Carlos","D-Silio Santos","A"));
            atual.Add(new Atualidades("Atual Governador do Pernambuco ?", "A-Eduardo Campos", "B-Paulo Camara", "C-Erasmo Carlos", "D-Xuxa", "B"));
            atual.Add(new Atualidades("Atual prefeito de  Recife ?", "A-Dilma", "B-Lula", "C-Geraldo Júlio", "D-Xuxa", "C"));
            atual.Add(new Atualidades("Atual ex-Governador do Pernambuco ?", "A-Dilma", "B-Lula", "C-Erasmo Carlos", "D-Eduardo Campos", "D"));

            atual.Add(new Atualidades("Toronto é uma cidade de qual país ?", "A-Canada", "B-Brasil", "C-Argentina", "D-Afeganistao", "A"));
            atual.Add(new Atualidades("Na fronteira de quais países está o Everest, pico mais alto do mundo?", "A-Suíça e Itália", "B-Nepal e China", "C-Chile e Argentina", "D-Brasil e Uruguai", "B"));
            atual.Add(new Atualidades("Qual é a capital do Azerbaijão ?", "A-Tibilissi", "B-Yerevan", "C-Baku", "D-Moscou", "C"));
            atual.Add(new Atualidades("O abacaxi é originário de que país ?", "A-Estados Unidos", "B-Colômbia", "C-Venezuela", "D-Brasl", "D"));

            atual.Add(new Atualidades("As Olimpíadas de 1988 aconteceram em Seul, capital de que país?", "A-Coréia do Sul", "B-Alemanha", "C-Grécia", "D-Países Baixos", "A"));
            atual.Add(new Atualidades("Na fronteira de quais países está o Everest, pico mais alto do mundo?", "A-Suíça e Itália", "B-Nepal e China", "C-Chile e Argentina", "D-Brasil e Uruguai", "B"));
            atual.Add(new Atualidades("Qual é a capital do Azerbaijão ?", "A-Tibilissi", "B-Yerevan", "C-Baku", "D-Moscou", "C"));
            atual.Add(new Atualidades("Qual é a maior cidade da Turquia?", "A-Estados Unidos", "B-Colômbia", "C-Venezuela", "D-Istambul", "D"));

            atual.Add(new Atualidades("Quantas estrelas tem a bandeira da China?", "A-Cinco", "B-Seis", "C-Duas", "D-Três", "A"));
            atual.Add(new Atualidades("Quais são as cinco grandes regiões em que o Brasil se divide?", "A-Ocidental e Oriental", "B-Norte, Nordeste, Sudeste, Sul e Centro-Oeste","C-Inglaterra, País de Gales, Escócia e Irlanda do Norte" ,"D-Pampa, Chaco e Patagônia", "B"));
            atual.Add(new Atualidades("Qual é o maior arquipélago do mundo?", "A-Ilhas Canárias", "B-Ilhas Salomão", "C-Ilhas da Insulíndia", "D-Grandes Antílhas", "C"));
            atual.Add(new Atualidades("Que nome é dado às maiores elevações da superfície da Terra?", "A-Planícies", "B-Planaltos", "C-Vales", "D-Montanhas", "D"));
        }

    }
}


