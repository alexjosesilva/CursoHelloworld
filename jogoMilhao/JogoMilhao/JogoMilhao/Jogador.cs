using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoMilhao
{
    class Jogador
    {
       //atributos da classe
        private string nome;
        private double pontos;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        

        public double Pontos
        {
            get { return pontos; }
            set { pontos = value; }
        }

        //construtor padrao
        public Jogador()
        {

        }

        public Jogador(string nome, Int32 pontos)
        {
            this.nome = nome;
            this.pontos = pontos;
        }

        //metodo pontuacao
        public double pontuar()
        {
            return pontos++;
        }

    }
}
