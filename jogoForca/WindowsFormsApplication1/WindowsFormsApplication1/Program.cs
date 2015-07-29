
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public class frm_forca
{

    // Variável que receberá as 40 palavras
    string[] pal = new string[41];
    // Variável que mostrará o índice do vetor (pal) começando por 0
    short indice;
    // Variável que irá contar o total de letras da palavra (Length)
    string varch;
    // Variável que irá sortear (aleatoriamente) uma palavra
    Random rand = new Random();
    // Variável que verifica se o jogador acertou a palavra oculta
    short acerto;


    private void frm_forca_Load(System.Object sender, System.EventArgs e)
    {
        //Cidades - de 0 a 9
        pal(0) = "seattle";
        pal(1) = "campinas";
        pal(2) = "anapolis";
        pal(3) = "sergipe";
        pal(4) = "mirassol";
        pal(5) = "madrid";
        pal(6) = "jales";
        pal(7) = "angra";
        pal(8) = "santos";
        pal(9) = "fortaleza";

        //Flores - de 10 a 19
        pal(10) = "narciso";
        pal(11) = "margarida";
        pal(12) = "orquidea";
        pal(13) = "tulipa";
        pal(14) = "girassol";
        pal(15) = "alecrim";
        pal(16) = "violeta";
        pal(17) = "cravo";
        pal(18) = "gardenia";
        pal(19) = "gravata";

        //Animais - de 20 a 29
        pal(20) = "cachorro";
        pal(21) = "macaco";
        pal(22) = "guepardo";
        pal(23) = "cobra";
        pal(24) = "mosca";
        pal(25) = "cavalo";
        pal(26) = "minhoca";
        pal(27) = "tartaruga";
        pal(28) = "abelha";
        pal(29) = "mariposa";

        //Veículos - de 30 a 39
        pal(30) = "vectra";
        pal(31) = "astra";
        pal(32) = "corsa";
        pal(33) = "opala";
        pal(34) = "brasilia";
        pal(35) = "variant";
        pal(36) = "omega";
        pal(37) = "megane";
        pal(38) = "comodoro";
        pal(39) = "sentra";

        //Elementos à serem ocultos durante o carregamento do jogo (Load)
        txt_letra.Visible = false;
        btn_testa.Visible = false;
        lbl_digiteletra.Visible = false;
        lbl_b.Visible = false;
        txt_banco.Visible = false;

        lbl_1.Visible = false;
        lbl_2.Visible = false;
        lbl_3.Visible = false;
        lbl_4.Visible = false;
        lbl_5.Visible = false;
        lbl_6.Visible = false;
        lbl_7.Visible = false;
        lbl_8.Visible = false;
        lbl_9.Visible = false;
        lbl_10.Visible = false;
        lbl_11.Visible = false;
        lbl_12.Visible = false;

        //Este ficará visivel, pois é uma instrução de como começar o jogo
        Label1.Visible = true;
    }

    private void btn_novapal_Click(System.Object sender, System.EventArgs e)
    {
        //Quando o botão "Nova Palavra" é pressionado, alguns controles ficam ocultos, outros se tornam visíveis
        Label1.Visible = false;

        btn_novapal.Enabled = false;
        txt_letra.Visible = true;
        btn_testa.Visible = true;
        txt_letra.Focus();
        lbl_b.Visible = true;
        lbl_digiteletra.Visible = true;
        txt_banco.Visible = true;
        txt_banco.Text = "";
        PictureBox1.Visible = true;
        PictureBox2.Visible = true;
        PictureBox3.Visible = true;
        PictureBox4.Visible = true;
        PictureBox5.Visible = true;
        PictureBox6.Visible = true;
        PictureBox7.Visible = true;
        lbl_dica.Visible = true;
        lbl_dica.Text = "";

        indice = rand.Next(40);
        //Aqui ocorre o sorteio da palavra
        varch = pal(indice);
        //Aqui fica o índice e o total de letras dessa palavra

        lbl_1.Visible = true;
        lbl_2.Visible = true;
        lbl_3.Visible = true;
        lbl_4.Visible = true;
        lbl_5.Visible = true;

        int cont = varch.Length;
        if (cont > 5)
        {
            lbl_6.Visible = true;
            if (cont > 6)
            {
                lbl_7.Visible = true;
                if (cont > 7)
                {
                    lbl_8.Visible = true;
                    if (cont > 8)
                    {
                        lbl_9.Visible = true;
                        if (cont > 9)
                        {
                            lbl_10.Visible = true;
                            if (cont > 10)
                            {
                                lbl_11.Visible = true;
                                if (cont > 11)
                                {
                                    lbl_12.Visible = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    public void Limpar()
    {
        //Função que irá limpar o vetor e as variáveis a cada vitoria ou derrota

        lbl_1.Text = "";
        lbl_2.Text = "";
        lbl_3.Text = "";
        lbl_4.Text = "";
        lbl_5.Text = "";
        lbl_6.Text = "";
        lbl_7.Text = "";
        lbl_8.Text = "";
        lbl_9.Text = "";
        lbl_10.Text = "";
        lbl_11.Text = "";
        lbl_12.Text = "";
        txt_letra.Text = "";
        txt_banco.Text = "";
        varch = 0;
        acerto = 0;
        indice = 0;

    }


    private void btn_testa_Click(System.Object sender, System.EventArgs e)
    {
        short numero = 0;
        char palpite = txt_letra.Text;
        bool flag = false;

        //Contador para saber se o palpite do jogador está correto ou não
        for (int cont = 0; cont <= varch.Length - 1; cont++)
        {
            if (palpite == varch.Chars(cont))
            {
                flag = true;
                switch (cont + 1)
                {
                    case 1:
                        lbl_1.Text = palpite;
                        numero += 1;
                        break;
                    case 2:
                        lbl_2.Text = palpite;
                        numero += 1;
                        break;
                    case 3:
                        lbl_3.Text = palpite;
                        numero += 1;
                        break;
                    case 4:
                        lbl_4.Text = palpite;
                        numero += 1;
                        break;
                    case 5:
                        lbl_5.Text = palpite;
                        numero += 1;
                        break;
                    case 6:
                        lbl_6.Text = palpite;
                        numero += 1;
                        break;
                    case 7:
                        lbl_7.Text = palpite;
                        numero += 1;
                        break;
                    case 8:
                        lbl_8.Text = palpite;
                        numero += 1;
                        break;
                    case 9:
                        lbl_9.Text = palpite;
                        numero += 1;
                        break;
                    case 10:
                        lbl_10.Text = palpite;
                        numero += 1;
                        break;
                    case 11:
                        lbl_11.Text = palpite;
                        numero += 1;
                        break;
                    case 12:
                        lbl_12.Text = palpite;
                        numero += 1;
                        break;
                }
            }
        }

        acerto += numero;

        if (acerto == varch.Length)
        {
            MessageBox.Show("Você Venceu!", "Forca Versão Beta", MessageBoxButtons.OK);
            btn_testa.Visible = false;
            txt_letra.Visible = false;
            lbl_digiteletra.Visible = false;
            txt_banco.Visible = false;
            lbl_dica.Visible = false;
            Label1.Visible = false;
            btn_novapal.Enabled = true;
            lbl_b.Visible = false;
            PictureBox1.Visible = false;
            lbl_1.Visible = false;
            lbl_2.Visible = false;
            lbl_3.Visible = false;
            lbl_4.Visible = false;
            lbl_5.Visible = false;
            lbl_6.Visible = false;
            lbl_7.Visible = false;
            lbl_8.Visible = false;
            lbl_9.Visible = false;
            lbl_10.Visible = false;
            lbl_11.Visible = false;
            lbl_12.Visible = false;
            Limpar();
            Label1.Visible = true;
            Label1.Text = "Para recomeçar, clique no botão 'Nova Palavra'";
        }
        else
        {
            if (flag == false)
            {
                if (txt_banco.Text.Contains(txt_letra.Text))
                {
                    Interaction.MsgBox("Digite uma letra valida/Sem repetições.");

                }
                else
                {
                    for (int lose = 0; lose <= Strings.Len(txt_banco.Text); lose++)
                    {
                        switch (lose + 1)
                        {
                            case 1:
                                PictureBox7.Visible = false;
                                PictureBox6.Visible = true;
                                break;
                            case 2:
                                PictureBox6.Visible = false;
                                PictureBox5.Visible = true;
                                break;
                            case 3:
                                //Após 3 erros, o jogador receberá uma dica
                                if (indice >= 0 & indice <= 9)
                                {
                                    lbl_dica.Text = "É uma cidade!!";
                                }
                                else if (indice >= 10 & indice <= 19)
                                {
                                    lbl_dica.Text = "É uma flor!!";
                                }
                                else if (indice >= 20 & indice <= 29)
                                {
                                    lbl_dica.Text = "É um animal!!";
                                }
                                else if (indice >= 30 & indice <= 39)
                                {
                                    lbl_dica.Text = "É um veículo!!";
                                }
                                PictureBox5.Visible = false;
                                PictureBox4.Visible = true;
                                break;
                            case 4:
                                PictureBox4.Visible = false;
                                PictureBox3.Visible = true;
                                break;
                            case 5:
                                PictureBox3.Visible = false;
                                PictureBox2.Visible = true;
                                break;
                            case 6:
                                PictureBox2.Visible = false;
                                PictureBox1.Visible = true;
                                //Apos errar 6 vezes, o jogador é enforcado!
                                MessageBox.Show("Você foi enforcado!!!", "LOSER!");
                                btn_testa.Visible = false;
                                txt_letra.Visible = false;
                                lbl_digiteletra.Visible = false;
                                txt_banco.Visible = false;
                                lbl_dica.Visible = false;
                                Label1.Visible = false;
                                btn_novapal.Enabled = true;
                                lbl_b.Visible = false;
                                PictureBox1.Visible = false;
                                lbl_1.Visible = false;
                                lbl_2.Visible = false;
                                lbl_3.Visible = false;
                                lbl_4.Visible = false;
                                lbl_5.Visible = false;
                                lbl_6.Visible = false;
                                lbl_7.Visible = false;
                                lbl_8.Visible = false;
                                lbl_9.Visible = false;
                                lbl_10.Visible = false;
                                lbl_11.Visible = false;
                                lbl_12.Visible = false;
                                Limpar();
                                Label1.Visible = true;
                                Label1.Text = "Para recomeçar, clique no botão 'Nova Palavra'";
                                break;
                        }
                    }
                    txt_banco.Text = txt_banco.Text + txt_letra.Text;
                }

                //---------------------------------------------------
                if (txt_banco.Text.Length == 0)
                {
                    txt_banco.Text += txt_letra.Text;
                }

            }
        }

        txt_letra.Text = "";
        txt_letra.Focus();


    }

    private void btn_sair_Click(System.Object sender, System.EventArgs e)
    {
        System.Environment.Exit(0);
    }


    private void txt_letra_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
    {
        //Função para permitir somente a entrada de letras na TextBox "txt_banco"
        //Não serão permitidos acentos, números, caracteres especiais, virgulas, pontos nem operadores aritimeticos.
        if ((Strings.Asc(e.KeyChar) >= 97 & Strings.Asc(e.KeyChar) <= 122) | Strings.Asc(e.KeyChar) == 8)
        {
            e.Handled = false;
        }
        else
        {
            e.Handled = true;
        }
    }
    public frm_forca()
    {
        Load += frm_forca_Load;
    }
}

//=======================================================
//MIC ETEPAM 2015.2
//CDURSO HELLOWORLD
//Twitter: @alexjosesilva
//Facebook: facebook.com/alex.jose.silva
//=======================================================
