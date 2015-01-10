﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Drawing.Imaging;

namespace SGE
{
    public partial class Tela_Senador : Form
    {
        private Senador senador = new Senador();
        private Partido partido = new Partido();
        private List<Label> list_Label = new List<Label>();
        private List<string> list_String_Cand = new List<string>();
        private string string_Conc3;
        private int num_cand_conv;
        public int aux_Converte = 0;
        public Listas listas;                                       //Declara objeto do tipo Lista, que contem todas as listas que serão utilizadas.
        bool achouCandidato = false;                                //Variavel booleana que armazena se o candidato existe ou não.
        string ver;
        Estado uf = new Estado();

        
        public Tela_Senador()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            Insere_label();
            Esconde_Camp();
        }
        public Tela_Senador(string val)
        {
            uf.CadastraEstados();

            foreach (var x in uf.estados)
            {
                if (x.DigVer == val)
                {
                    ver = x.Sigla;
                }
            }
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            Insere_label();
            Esconde_Camp();
        }

        public Senador Senador
        {
            get { return senador; }
            set { senador = value; }
        }

        public Partido Partido
        {
            get { return partido; }
            set { partido = value; }
        }
        
        public List<Label> List_Label
        {
            get { return list_Label; }
            set { list_Label = value; }
        }

        public List<string> List_String_Cand
        {
            get { return list_String_Cand; }
            set { list_String_Cand = value; }
        }

        public string String_Conc3
        {
            get { return string_Conc3; }
            set { string_Conc3 = value; }
        }

        public int Num_Cand_Conv
        {
            get { return num_cand_conv; }
            set { num_cand_conv = value; }
        }
        
        public void Esconde_Camp()
        {
            camp_aperte_tec.Visible = false;
            camp_image.Visible = false;
            camp_laranja_rein.Visible = false;
            camp_nome.Visible = false;
            camp_nome_candid.Visible = false;
            camp_nome_part.Visible = false;
            camp_num.Visible = false;
            camp_nome_1sup.Visible = false;
            camp_nome_2sup.Visible = false;
            camp_1sup.Visible = false;
            camp_2sup.Visible = false;
            camp_num_errado.Visible = false;
            camp_partido.Visible = false;
            camp_seu_voto.Visible = false;
            camp_verde_confir.Visible = false;
            camp_vot_nul.Visible = false;
            camp_voto_branco.Visible = false;
            linha_Div.Visible = false;

        }

        public void Insere_label()
        {
            List_Label.Add(pri_Dig);
            List_Label.Add(sec_Dig);
            List_Label.Add(ter_Dig);
        }

        public void Converte()
        {
            foreach (var x in List_Label)
            {
                if (x.TabIndex == aux_Converte)
                {
                    List_String_Cand.Add(x.Text);
                    aux_Converte++;
                    break;
                }
            }

            String_Conc3 = String.Concat(List_String_Cand);
            Num_Cand_Conv = Convert.ToInt32(String_Conc3);

        }

        public void Mostra()
        {
            listas = new Listas();

            listas.Carrega_Senador();                                             //Carrega a lista de candidatos a Senador

            foreach (var x in listas.List_Senador)                                //Verifica se na lista de Senadores cadastrados existe o número digitado pelo eleitor.
            {
                if ((x.Num == Num_Cand_Conv) && (x.Uf == ver    ))                // Se o candidato estiver na lista de partidos
                {
                    achouCandidato = true;                                        // Variavel "Achou Candidato" recebe true.
                    senador = x;
                }
            }
            if (achouCandidato == false)                                        //Se não encontrar candidato
            {
                //VOTO NULO
                if (((Num_Cand_Conv != Senador.Num) && (List_String_Cand.Count == 3)) || (senador.Nome == null && (List_String_Cand.Count == 3)))
                {
                    timer9.Enabled = false;
                    camp_aperte_tec.Visible = true;
                    camp_laranja_rein.Visible = true;
                    camp_num.Visible = true;
                    camp_num_errado.Visible = true;
                    camp_seu_voto.Visible = true;
                    camp_verde_confir.Visible = true;
                    camp_vot_nul.Visible = true;
                    linha_Div.Visible = true;
                    timer6.Enabled = true;
                }
            }
            else
            {
                // Se existe o candidato cadastrado
                if (((Num_Cand_Conv == Senador.Num) && (List_String_Cand.Count == 3)))
                {
                    timer6.Enabled = false;
                    timer9.Enabled = false;
                    Esconde_Camp();
                    camp_nome_candid.Text = Senador.NomeUrna;
                    camp_nome_part.Text = Senador.Part.Abrev;
                    camp_nome_1sup.Text = Senador.Sup1;
                    camp_nome_2sup.Text = Senador.Sup2;
                    camp_image.BackgroundImage = senador.BuscaImagem(senador.Num, senador.Uf,"Senador");
                    camp_aperte_tec.Visible = true;
                    camp_image.Visible = true;
                    camp_laranja_rein.Visible = true;
                    camp_nome.Visible = true;
                    camp_nome_1sup.Visible = true;
                    camp_nome_2sup.Visible = true;
                    camp_1sup.Visible = true;
                    camp_2sup.Visible = true;
                    camp_nome_candid.Visible = true;
                    camp_nome_part.Visible = true;
                    camp_num.Visible = true;
                    camp_partido.Visible = true;
                    camp_seu_voto.Visible = true;
                    camp_verde_confir.Visible = true;
                    linha_Div.Visible = true;
                }
            }
            //VOTO EM BRANCO
            if(List_String_Cand.Count == 0)
            {
                timer6.Enabled = false;
                Esconde_Camp();
                camp_aperte_tec.Visible = true;
                camp_laranja_rein.Visible = true;
                camp_seu_voto.Visible = true;
                camp_verde_confir.Visible = true;
                camp_voto_branco.Visible = true;
                linha_Div.Visible = true;
                timer9.Enabled = true;
            }
            achouCandidato = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pri_Dig.Text.Length == 0 && timer9.Enabled == false)
            {
                pri_Dig.Visible = !pri_Dig.Visible;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sec_Dig.Text.Length == 0 && pri_Dig.Text.Length == 1)
            {
                sec_Dig.Visible = !sec_Dig.Visible;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (ter_Dig.Text.Length == 0 && sec_Dig.Text.Length == 1 && pri_Dig.Text.Length == 1)
            {
                ter_Dig.Visible = !ter_Dig.Visible;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            camp_vot_nul.Visible = !camp_vot_nul.Visible;
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            camp_voto_branco.Visible = !camp_voto_branco.Visible;
        }

    }
}