using System;
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
    public partial class Tela_Presidente : Form
    {
        private Presidente presidente = new Presidente();
        private Partido partido = new Partido();
        private List<Label> list_Label = new List<Label>();
        private List<string> list_String_Cand = new List<string>();
        private string string_Conc2;
        private int num_cand_conv;
        public int aux_Converte = 0;
        public Listas listas;                                       //Declara objeto do tipo Lista, que contem todas as listas que serão utilizadas.
        bool achouCandidato = false;                                //Variavel booleana que armazena se o candidato existe ou não.

        
        public Tela_Presidente()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
            Insere_label();
            Esconde_Camp();
        }

        public Presidente Presidente
        {
            get { return presidente; }
            set { presidente = value; }
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

        public string String_Conc2
        {
            get { return string_Conc2; }
            set { string_Conc2 = value; }
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
            camp_nome_vice_pres.Visible = false;
            camp_vice_pres.Visible = false;
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

            String_Conc2 = String.Concat(List_String_Cand);
            Num_Cand_Conv = Convert.ToInt32(String_Conc2);

        }

        public void Mostra()
        {
            listas = new Listas();

            listas.Carrega_Presidente();                                         //Carrega a lista de candidatos a Governador

            foreach (var x in listas.List_Presidente)                           //Verifica se na lista de Presidentes cadastrados existe o número digitado pelo eleitor.
            {
                if (x.Num == Num_Cand_Conv)                                     // Se o candidato estiver na lista de partidos
                {
                    achouCandidato = true;                                      // Variavel "Achou Candidato" recebe true.
                    presidente = x;
                }
            }
            if (achouCandidato == false)                                        //Se não encontrar candidato
            {
                //VOTO NULO
                if (((Num_Cand_Conv != Presidente.Num) && (List_String_Cand.Count == 2)) || (Presidente.Nome == null && (List_String_Cand.Count == 2)))
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
                if (((Num_Cand_Conv == Presidente.Num) && (List_String_Cand.Count == 2)))
                {
                    timer6.Enabled = false;
                    timer9.Enabled = false;
                    Esconde_Camp();
                    camp_nome_candid.Text = Presidente.NomeUrna;
                    camp_nome_part.Text = Presidente.Part.Abrev;
                    camp_nome_vice_pres.Text = Presidente.Vice;
                    camp_image.BackgroundImage = presidente.BuscaImagem(presidente.Num, presidente.Uf, "Presidente");
                    camp_aperte_tec.Visible = true;
                    camp_image.Visible = true;
                    camp_laranja_rein.Visible = true;
                    camp_nome.Visible = true;
                    camp_nome_vice_pres.Visible = true;
                    camp_vice_pres.Visible = true;
                    camp_nome_candid.Visible = true;
                    camp_nome_part.Visible = true;
                    camp_num.Visible = true;
                    camp_partido.Visible = true;
                    camp_seu_voto.Visible = true;
                    camp_verde_confir.Visible = true;
                    linha_Div.Visible = true;
                }
            }
            //VOTO BRANCO
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
