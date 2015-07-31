using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMilhao
{
    class Biologia : Perguntas
    {
        public List<Biologia> bio = new List<Biologia>();

        //construtor....
        public Biologia(string pergunta, string alt1, string alt2, string alt3, string alt4, string resp)
        {
            this.Pergunta = pergunta;
            this.Resp = resp;
            this.Alt1 = alt1;
            this.Alt2 = alt2;
            this.Alt3 = alt3;
            this.Alt4 = alt4;

        }

        public Biologia()
        {

        }
        //Lista de Perguntas
        public void listaPerguntas()
        {
            bio.Add(new Biologia("Se a poluição exceder a capacidade de filtragem do nariz, quais órgãos serão prejudicados?", "A-Pulmões", "B-Rins", "C-Coração", "D-Estomago", "A"));
            bio.Add(new Biologia("Qual é o gás mais importante para nosso organismo?", "A-Hidrogenio", "B-Carbono", "C-Oxigénio", "D-Gases nobres", "C"));
            bio.Add(new Biologia("Qual órgão oxigena e renova o sangue?", "A-Rins", "B-Pulmões", "C-Estomago", "D-Coração", "B"));
            bio.Add(new Biologia("Qual é o nome dado ao percurso do sangue do coração ao corpo e do corpo ao coração?", "A-Sistema circulatório", "B-Sistema Digestivo", "C-Sistema Nervoso", "D-Sistema Cardiovascular", "A"));

            bio.Add(new Biologia("Qual é o órgão que armazena a urina?", "A-Rins", "B-Bexiga", "C-Pulmão", "D-Estomago", "B"));
            bio.Add(new Biologia("Qual é o órgão que filtra o sangue?", "A-Pulmão", "B-Rins", "C-Coração", "D-Estomago", "B"));
            bio.Add(new Biologia("Qual o nome do órgão que conduz a urina até a bexiga?", "A-Ureteres", "B-Bexiga", "C-Rins", "D-Estomago", "A"));
            bio.Add(new Biologia("Qual o maior orgão do corpo humano?", "A-Ossos", "B-Estomago", "C-Cutis(Pele)", "D-Pulmão", "C"));

            bio.Add(new Biologia("Qual o orgão responsavel pelo bombeamento do sangue?", "A-Pulmão", "B-Rins", "C-Coração", "D-Estomago", "C"));
            bio.Add(new Biologia("Qual a forma da água quando esta congelada?", "A-Liquida", "B-Solida", "C-Gasosa", "D-Outra", "B"));
            bio.Add(new Biologia("Como se chama a passagem da água do estado liquido para o estado solido?", "A-Sublimação", "B-Condensação", "C-Solidificação", "D-Liquidação", "C"));
            bio.Add(new Biologia("Como se chama a passagem da água do estado solido para o liquido?", "A-Fusão", "B-Sublimação", "C-Solidificação", "D-Liquidação", "A"));

            bio.Add(new Biologia("Como se chama a passagem da água do estado solido para o gasoso", "A-Fusão", "B-Sublimação", "C-Solidificação", "D-Liquidação", "B"));
            bio.Add(new Biologia("Como se chama a passagem da água do estado gasoso para o liquido", "A-Fusão", "B-Sublimação", "C-Solidificação", "D-Condensação", "D"));
            bio.Add(new Biologia("Como se chama a passagem da água do estado liquido para o gasoso", "A-Fusão", "B-Sublimação", "C-Vaporização", "D-Condensação", "C"));
            bio.Add(new Biologia("Qual o ponto de ebulição da água", "A-50º", "B-90º", "C-360º", "D-100º", "D"));
        }
    }
}