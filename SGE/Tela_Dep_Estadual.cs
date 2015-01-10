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
using System.Media;

namespace SGE
{
    public partial class Tela_Dep_Estadual : Form
    {
        private DepEstadual dep_Est = new DepEstadual();
        private Partido partido = new Partido();
        private List<Label> list_Label = new List<Label>();
        private List<string> list_String_Part = new List<string>();
        private List<string> list_String_Cand = new List<string>();
        private string string_Conc5;
        private int num_part_conv;
        private string string_Conc2;
        private int num_cand_conv;
        public int aux_Converte = 0;
        public Listas listas;                                       //Declara objeto do tipo Lista, que contem todas as listas que serão utilizadas.
        bool achouPartido = false;                                  //Variavel booleana que armazena se o partido existe ou não.
        bool achouCandidato = false;                                //Variavel booleana que armazena se o candidato existe ou não.
        string ver;
        Estado uf = new Estado();

        public Tela_Dep_Estadual()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            Insere_label();
            Esconde_Camp();
        }

        public Tela_Dep_Estadual(string val)
        {
            uf.CadastraEstados();

            foreach(var x in uf.estados)
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
            timer4.Enabled = true;
            timer5.Enabled = true;
            Insere_label();
            Esconde_Camp();
        }

        public DepEstadual Dep_Est
        {
            get { return dep_Est; }
            set { dep_Est = value; }
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

        public List<string> List_String_Part
        {
            get { return list_String_Part; }
            set { list_String_Part = value; }
        }

        public string String_Conc5
        {
            get { return string_Conc5; }
            set { string_Conc5 = value; }
        }

        public int Num_Part_Conv
        {
            get { return num_part_conv; }
            set { num_part_conv = value; }
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
            camp_candid_inex.Visible = false;
            camp_image.Visible = false;
            camp_laranja_rein.Visible = false;
            camp_nome.Visible = false;
            camp_nome_candid.Visible = false;
            camp_nome_part.Visible = false;
            camp_num.Visible = false;
            camp_num_errado.Visible = false;
            camp_partido.Visible = false;
            camp_seu_voto.Visible = false;
            camp_verde_confir.Visible = false;
            camp_vot_nul.Visible = false;
            camp_voto_branco.Visible = false;
            camp_voto_leg_gra.Visible = false;
            camp_voto_leg_peq.Visible = false;
            linha_Div.Visible = false;

        }

        public void Insere_label()
        {
            List_Label.Add(pri_Dig);
            List_Label.Add(sec_Dig);
            List_Label.Add(ter_Dig);
            List_Label.Add(qua_Dig);
            List_Label.Add(qui_Dig);
        }

        public void Converte()
        {
            foreach (var x in List_Label)
            {
                if (x.TabIndex == aux_Converte)
                {
                    List_String_Cand.Add(x.Text);
                    if (aux_Converte <= 1)
                    {
                        List_String_Part.Add(x.Text);
                    }
                    aux_Converte++;
                    break;
                }
            }

            String_Conc2 = String.Concat(List_String_Part);

            String_Conc5 = String.Concat(List_String_Cand);
            Num_Cand_Conv = Convert.ToInt32(String_Conc5);
            Num_Part_Conv = Convert.ToInt32(String_Conc2);

        }

        public void Mostra()
        {
            listas = new Listas();

            listas.Carrega_Partidos();                                   //Carrega a lista dos partidos previamente cadastrados.

            foreach ( var x in listas.List_Partidos)                     //Verifica se na lista de partidos cadastrados existe o número digitado pelo eleitor.
            {
                if (x.Cod == Num_Part_Conv)                              // Se o partido estiver na lista de partidos
                {
                    achouPartido = true;                                 // Variavel "Achou Partido" recebe true.
                    partido = x;
                }
            }

            if ((achouPartido == false && List_String_Cand.Count >= 2) || (partido.Nome == null && (List_String_Cand.Count >=2)))               // Se não encontrar o partido, então voto é NULO
            {
                timer7.Enabled = false;
                timer8.Enabled = false;
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

            else                                                                    // Se encontrar o partido na lista 
            {
                listas.Carrega_Dep_Estadual();                                      //Carrega a lista de candidatos a Dep. Estadual

                foreach (var x in listas.List_DepEstadual)                         //Verifica se na lista de Dep. Estadual cadastrados existe o número digitado pelo eleitor.
                {
                    if ((x.Num == Num_Cand_Conv) && (x.Uf == ver))                                     // Se o candidato estiver na lista de partidos
                    {
                        achouCandidato = true;                                      // Variavel "Achou Candidato" recebe true.
                        dep_Est = x;
                    }
                }

                if (achouCandidato == false)                                        //Se não encontrar candidato
                {
                    //VOTO DE LEGENDA
                    if (((Num_Part_Conv == partido.Cod) && (List_String_Cand.Count == 2)))
                    {
                        timer6.Enabled = false;
                        timer8.Enabled = false;
                        timer9.Enabled = false;
                        Esconde_Camp();
                        camp_aperte_tec.Visible = true;
                        camp_laranja_rein.Visible = true;
                        camp_num.Visible = true;
                        camp_seu_voto.Visible = true;
                        camp_verde_confir.Visible = true;
                        camp_voto_leg_peq.Visible = true;
                        linha_Div.Visible = true;
                        camp_partido.Visible = true;
                        camp_nome_part.Text = partido.Abrev;
                        camp_nome_part.Visible = true;
                        timer7.Enabled = true;
                    }
                    if (((Num_Part_Conv == partido.Cod) && (List_String_Cand.Count == 5)))
                    {
                        timer7.Enabled = false;
                        timer6.Enabled = false;
                        timer9.Enabled = false;
                        Esconde_Camp();
                        camp_aperte_tec.Visible = true;
                        camp_laranja_rein.Visible = true;
                        camp_num.Visible = true;
                        camp_seu_voto.Visible = true;
                        camp_verde_confir.Visible = true;
                        camp_voto_leg_gra.Visible = true;
                        linha_Div.Visible = true;
                        camp_partido.Visible = true;
                        camp_nome_part.Text = partido.Abrev;
                        camp_nome_part.Visible = true;
                        camp_candid_inex.Visible = true;
                        timer8.Enabled = true;
                    }
                }
                else
                {
                    // Se existe o candidato cadastrado
                    if (((Num_Cand_Conv == Dep_Est.Num) && (List_String_Cand.Count == 5)))
                    {
                        timer6.Enabled = false;
                        timer7.Enabled = false;
                        timer8.Enabled = false;
                        timer9.Enabled = false;
                        Esconde_Camp();
                        camp_nome_candid.Text = Dep_Est.NomeUrna;
                        camp_nome_part.Text = Dep_Est.Part.Abrev;
                        camp_image.BackgroundImage = dep_Est.BuscaImagem(dep_Est.Num, dep_Est.Uf, "Estadual");
                        camp_aperte_tec.Visible = true;
                        camp_image.Visible = true;
                        camp_laranja_rein.Visible = true;
                        camp_nome.Visible = true;
                        camp_nome_candid.Visible = true;
                        camp_nome_part.Visible = true;
                        camp_num.Visible = true;
                        camp_partido.Visible = true;
                        camp_seu_voto.Visible = true;
                        camp_verde_confir.Visible = true;
                        linha_Div.Visible = true;
                    }
                }
            }
            //VOTO EM BRANCO
            if (List_String_Cand.Count == 0)
            {
                timer7.Enabled = false;
                timer8.Enabled = false;
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
            achouPartido = false;
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

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (qua_Dig.Text.Length == 0 && ter_Dig.Text.Length == 1 && sec_Dig.Text.Length == 1 && pri_Dig.Text.Length == 1)
            {
                qua_Dig.Visible = !qua_Dig.Visible;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (qui_Dig.Text.Length == 0 && qua_Dig.Text.Length == 1 && ter_Dig.Text.Length == 1 && sec_Dig.Text.Length == 1 && pri_Dig.Text.Length == 1)
            {
                qui_Dig.Visible = !qui_Dig.Visible;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            camp_vot_nul.Visible = !camp_vot_nul.Visible;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            camp_voto_leg_peq.Visible = !camp_voto_leg_peq.Visible;

        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            camp_voto_leg_gra.Visible = !camp_voto_leg_gra.Visible;
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            camp_voto_branco.Visible = !camp_voto_branco.Visible;
        }
    }
}
