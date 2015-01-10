using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace SGE
{
    public partial class Urna : Form
    {
        Tela_Dep_Estadual t_Dep_E;
        Tela_Dep_Federal t_Dep_F;
        Tela_Senador t_Senador;
        Tela_Governador t_Governador;
        Tela_Presidente t_Presidente;
        Tela_Fim t_Fim;
        SoundPlayer sound;
        Listas lista;
        Estado estado = new Estado();
        string auxIns;
        string auxUf;
        int aux_Inserir = 0;
        string caminho = Directory.GetCurrentDirectory() + "\\Cadastros";
        FileStream cadastro_Candidato;
 
        public Urna()
        {   
            InitializeComponent();
            t_Dep_F = new Tela_Dep_Federal();
            t_Dep_E = new Tela_Dep_Estadual();
            t_Senador = new  Tela_Senador();
            t_Governador = new Tela_Governador();
            t_Presidente = new Tela_Presidente();
            t_Fim = new Tela_Fim();
            t_Dep_E.TopLevel = false;
            tela.Controls.Add(t_Dep_E);
            t_Dep_E.Show();
            sound = new SoundPlayer(SGE.Properties.Resources.Deputado_Estadual);
            sound.Play();
        }

        public Urna(string val, string inscr)
        {
            auxUf = val;
            auxIns = inscr;
            InitializeComponent();
            t_Dep_F = new Tela_Dep_Federal(val);
            t_Dep_E = new Tela_Dep_Estadual(val);
            t_Senador = new Tela_Senador(val);
            t_Governador = new Tela_Governador(val);
            t_Presidente = new Tela_Presidente();
            t_Fim = new Tela_Fim();
            t_Dep_E.TopLevel = false;
            tela.Controls.Add(t_Dep_E);
            t_Dep_E.Show();
            sound = new SoundPlayer(SGE.Properties.Resources.Deputado_Estadual);
            sound.Play();
        }

        public void Inserir(string digito)
        {
            if (tela.Controls.Contains(t_Dep_E) && t_Dep_E.timer9.Enabled != true)
            {
                foreach (var x in t_Dep_E.List_Label)
                {
                    if (x.TabIndex == aux_Inserir)
                    {
                        x.Text = digito;
                        x.Visible = true;
                        aux_Inserir++;
                        t_Dep_E.Converte();
                        t_Dep_E.Mostra();
                        break;
                    }
                }
            }

            if (tela.Controls.Contains(t_Dep_F) && t_Dep_F.timer9.Enabled != true)
            {
                foreach (var x in t_Dep_F.List_Label)
                {
                    if (x.TabIndex == aux_Inserir)
                    {
                        x.Text = digito;
                        x.Visible = true;
                        aux_Inserir++;
                        t_Dep_F.Converte();
                        t_Dep_F.Mostra();
                        break;
                    }
                }
            }

            if (tela.Controls.Contains(t_Senador) && t_Senador.timer9.Enabled != true)
            {
                foreach (var x in t_Senador.List_Label)
                {
                    if (x.TabIndex == aux_Inserir)
                    {
                        x.Text = digito;
                        x.Visible = true;
                        aux_Inserir++;
                        t_Senador.Converte();
                        t_Senador.Mostra();
                        break;
                    }
                }
            }

            if (tela.Controls.Contains(t_Governador) && t_Governador.timer9.Enabled != true)
            {
                foreach (var x in t_Governador.List_Label)
                {
                    if (x.TabIndex == aux_Inserir)
                    {
                        x.Text = digito;
                        x.Visible = true;
                        aux_Inserir++;
                        t_Governador.Converte();
                        t_Governador.Mostra();
                        break;
                    }
                }
            }

            if (tela.Controls.Contains(t_Presidente) && t_Presidente.timer9.Enabled != true)
            {
                foreach (var x in t_Presidente.List_Label)
                {
                    if (x.TabIndex == aux_Inserir)
                    {
                        x.Text = digito;
                        x.Visible = true;
                        aux_Inserir++;
                        t_Presidente.Converte();
                        t_Presidente.Mostra();
                        break;
                    }
                }
            }
        }

        private void Num_1_Click(object sender, EventArgs e)
        {
            Inserir(Num_1.Text);  
        }

        private void Num_2_Click(object sender, EventArgs e)
        {
            Inserir(Num_2.Text);
        }

        private void Num_3_Click(object sender, EventArgs e)
        {
            Inserir(Num_3.Text);
        }
        
        private void Num_4_Click(object sender, System.EventArgs e)
        {
            Inserir(Num_4.Text);
        }
        
        private void Num_5_Click(object sender, EventArgs e)
        {
            Inserir(Num_5.Text);
        }

        private void Num_6_Click(object sender, EventArgs e)
        {
            Inserir(Num_6.Text);
        }

        private void Num_7_Click(object sender, System.EventArgs e)
        {
            Inserir(Num_7.Text);
        }

        private void Num_8_Click(object sender, EventArgs e)
        {
            Inserir(Num_8.Text);
        }

        private void Num_9_Click(object sender, EventArgs e)
        {
            Inserir(Num_9.Text);
        }

        private void Num_0_Click(object sender, EventArgs e)
        {
            Inserir(Num_0.Text);
        }

        private void Bt_Corrige_Click(object sender, EventArgs e)
        {
            if (tela.Controls.Contains(t_Dep_E))
            {
                foreach (var x in t_Dep_E.List_Label)
                {
                    x.Text = "";
                    x.Visible = true;
                }

                t_Dep_E.timer6.Enabled = false;
                t_Dep_E.timer7.Enabled = false;
                t_Dep_E.timer8.Enabled = false;
                t_Dep_E.timer9.Enabled = false;
                t_Dep_E.List_String_Cand.Clear();
                t_Dep_E.List_String_Part.Clear();
                t_Dep_E.Esconde_Camp();
                t_Dep_E.aux_Converte = 0;
                aux_Inserir = 0;
            }

            if (tela.Controls.Contains(t_Dep_F))
            {
                foreach (var x in t_Dep_F.List_Label)
                {
                    x.Text = "";
                    x.Visible = true;
                }

                t_Dep_F.timer6.Enabled = false;
                t_Dep_F.timer7.Enabled = false;
                t_Dep_F.timer8.Enabled = false;
                t_Dep_F.timer9.Enabled = false;
                t_Dep_F.List_String_Cand.Clear();
                t_Dep_F.List_String_Part.Clear();
                t_Dep_F.Esconde_Camp();
                t_Dep_F.aux_Converte = 0;
                aux_Inserir = 0;
            }

            if (tela.Controls.Contains(t_Senador))
            {
                foreach (var x in t_Senador.List_Label)
                {
                    x.Text = "";
                    x.Visible = true;
                }

                t_Senador.timer6.Enabled = false;
                t_Senador.timer9.Enabled = false;
                t_Senador.List_String_Cand.Clear();
                t_Senador.Esconde_Camp();
                t_Senador.aux_Converte = 0;
                aux_Inserir = 0;
            }


            if (tela.Controls.Contains(t_Governador))
            {
                foreach (var x in t_Governador.List_Label)
                {
                    x.Text = "";
                    x.Visible = true;
                }

                t_Governador.timer6.Enabled = false;
                t_Governador.timer9.Enabled = false;
                t_Governador.List_String_Cand.Clear();
                t_Governador.Esconde_Camp();
                t_Governador.aux_Converte = 0;
                aux_Inserir = 0;
            }

            if (tela.Controls.Contains(t_Presidente))
            {
                foreach (var x in t_Presidente.List_Label)
                {
                    x.Text = "";
                    x.Visible = true;
                }

                t_Presidente.timer6.Enabled = false;
                t_Presidente.timer9.Enabled = false;
                t_Presidente.List_String_Cand.Clear();
                t_Presidente.Esconde_Camp();
                t_Presidente.aux_Converte = 0;
                aux_Inserir = 0;
            }
        }

        private void Bt_Confirma_Click(object sender, EventArgs e)
        {
            if ((tela.Controls.Contains(t_Dep_E) && t_Dep_E.List_String_Cand.Count >= 2) || t_Dep_E.timer9.Enabled == true)
            {
                sound = new SoundPlayer(SGE.Properties.Resources.Deputado_Federal);
                sound.Play();
                Conta_Voto();
                t_Dep_E.Close();
                aux_Inserir = 0;
                t_Dep_F.TopLevel = false;
                tela.Controls.Add(t_Dep_F);
                t_Dep_F.Show();
            }

            if ((tela.Controls.Contains(t_Dep_F) && t_Dep_F.List_String_Cand.Count >= 2) || t_Dep_F.timer9.Enabled == true)
            {
                sound = new SoundPlayer(SGE.Properties.Resources.Senador);
                sound.Play();
                Conta_Voto();
                t_Dep_F.Close();
                aux_Inserir = 0;
                t_Senador.TopLevel = false;
                tela.Controls.Add(t_Senador);
                t_Senador.Show();
            }

            if ((tela.Controls.Contains(t_Senador) && t_Senador.List_String_Cand.Count == 3) || t_Senador.timer9.Enabled == true)
            {
                sound = new SoundPlayer(SGE.Properties.Resources.Governador);
                sound.Play();
                Conta_Voto();
                t_Senador.Close();
                aux_Inserir = 0;
                t_Governador.TopLevel = false;
                tela.Controls.Add(t_Governador);
                t_Governador.Show();
            }

            if ((tela.Controls.Contains(t_Governador) && t_Governador.List_String_Cand.Count == 2) || t_Governador.timer9.Enabled == true)
            {
                sound = new SoundPlayer(SGE.Properties.Resources.Presidente);
                sound.Play();
                Conta_Voto();
                t_Governador.Close();
                aux_Inserir = 0;
                t_Presidente.TopLevel = false;
                tela.Controls.Add(t_Presidente);
                t_Presidente.Show();
            }

            if ((tela.Controls.Contains(t_Presidente) && t_Presidente.List_String_Cand.Count == 2) || t_Presidente.timer9.Enabled == true)
            {
                sound = new SoundPlayer(SGE.Properties.Resources.Obrigado);
                sound.Play();
                Conta_Voto();
                t_Presidente.Close();
                aux_Inserir = 0;
                t_Fim.TopLevel = false;
                tela.Controls.Add(t_Fim);
                timer1.Enabled = true;
                t_Fim.Show();
            }

        }

        private void Bt_Branco_Click(object sender, EventArgs e)
        {
            if (tela.Controls.Contains(t_Dep_E) && t_Dep_E.List_String_Cand.Count == 0)
            {
                t_Dep_E.Mostra();
                foreach (var x in t_Dep_E.List_Label)
                {
                    x.Visible = false;
                }
            }

            if (tela.Controls.Contains(t_Dep_F) && t_Dep_F.List_String_Cand.Count == 0)
            {
                t_Dep_F.Mostra();
                foreach (var x in t_Dep_F.List_Label)
                {
                    x.Visible = false;
                }
            }

            if (tela.Controls.Contains(t_Senador) && t_Senador.List_String_Cand.Count == 0)
            {
                t_Senador.Mostra();
                foreach (var x in t_Senador.List_Label)
                {
                    x.Visible = false;
                }
            }

            if (tela.Controls.Contains(t_Governador) && t_Governador.List_String_Cand.Count == 0)
            {
                t_Governador.Mostra();
                foreach (var x in t_Governador.List_Label)
                {
                    x.Visible = false;
                }
            }

            if (tela.Controls.Contains(t_Presidente) && t_Presidente.List_String_Cand.Count == 0)
            {
                t_Presidente.Mostra();
                foreach (var x in t_Presidente.List_Label)
                {
                    x.Visible = false;
                }
            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            Tela_Libera_Votacao telaLiberaVotacao = new Tela_Libera_Votacao();
            telaLiberaVotacao.Modifica_Voto(auxIns);
            this.Close();
            timer1.Enabled = false;
        }

        private void Conta_Voto()
        {
            bool achou = false;
            int votos;
            lista = new Listas();
            lista.Carrega_Dep_Estadual();
            lista.Carrega_Dep_Federal();
            lista.Carrega_Senador();
            lista.Carrega_Governador();
            lista.Carrega_Presidente();
            lista.Carrega_Partidos();
            estado.CadastraEstados();
            lista.Carrega_Nulo_Estadual();
            lista.Carrega_Nulo_Federal();
            lista.Carrega_Nulo_Governador();
            lista.Carrega_Nulo_Presidente();
            lista.Carrega_Nulo_Senador();
            lista.Carrega_Branco_Estadual();
            lista.Carrega_Branco_Federal();
            lista.Carrega_Branco_Governador();
            lista.Carrega_Branco_Presidente();
            lista.Carrega_Branco_Senador();
            string encontraUf;

            foreach (var x in estado.estados)
            {
                if(x.DigVer == auxUf)
                {
                    auxUf = x.Sigla;
                    break;
                }
            }

            if (t_Dep_E.List_String_Cand.Count == 5)
            {
                foreach (var x in lista.List_DepEstadual)
                {
                    if (x.Num == t_Dep_E.Num_Cand_Conv && auxUf == x.Uf)
                    {
                        votos = Convert.ToInt32(x.ContaVotos);
                        votos++;
                        x.ContaVotos = votos.ToString();
                        achou = true;
                        break;
                    }
                }
                if (achou == true)
                {
                    cadastro_Candidato = new FileStream(caminho + "\\Deputado Estadual.dll", FileMode.Create);
                    cadastro_Candidato.Close();

                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Deputado Estadual.dll", true);

                    foreach (var x in lista.List_DepEstadual)
                    {
                        insereInfo.WriteLine("{0};{1};{2};{3};{4};{5}", x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Uf, x.ContaVotos);
                    }

                    t_Dep_E.List_String_Cand.Clear();
                    insereInfo.Close();
                }
                else
                {
                    for (int i = 0; i < lista.list_Nulo_D_Est.Count; i++)
                    {
                        encontraUf = lista.list_Nulo_D_Est[i].Substring(0, 2);

                        if (auxUf == encontraUf)
                        {
                            votos = Convert.ToInt32(lista.list_Nulo_D_Est[i].Substring(3));
                            votos++;
                            lista.list_Nulo_D_Est[i] = auxUf + "_" + votos.ToString();
                        }
                    }

                    cadastro_Candidato = new FileStream(caminho + "\\Votos Nulos Deputado Estadual.dll", FileMode.Create);
                    cadastro_Candidato.Close();

                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Votos Nulos Deputado Estadual.dll", true);

                    foreach (var item in lista.list_Nulo_D_Est)
                    {
                        insereInfo.WriteLine(item);
                    }

                    t_Dep_E.List_String_Cand.Clear();
                    insereInfo.Close();
                }

            }

            if (t_Dep_F.List_String_Cand.Count == 4)
            {
                foreach (var x in lista.List_DepFederal)
                {
                    if (x.Num == t_Dep_F.Num_Cand_Conv && auxUf == x.Uf)
                    {
                        votos = Convert.ToInt32(x.ContaVotos);
                        votos++;
                        x.ContaVotos = votos.ToString();
                        achou = true;
                        break;
                    }
                }
                if (achou == true)
                {
                    cadastro_Candidato = new FileStream(caminho + "\\Deputado Federal.dll", FileMode.Create);
                    cadastro_Candidato.Close();

                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Deputado Federal.dll", true);

                    foreach (var x in lista.List_DepFederal)
                    {
                        insereInfo.WriteLine("{0};{1};{2};{3};{4};{5}", x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Uf, x.ContaVotos);
                    }

                    t_Dep_F.List_String_Cand.Clear();
                    insereInfo.Close();
                }
                else
                {
                    for (int i = 0; i < lista.list_Nulo_D_Fed.Count; i++)
                    {
                        encontraUf = lista.list_Nulo_D_Fed[i].Substring(0, 2);

                        if (auxUf == encontraUf)
                        {
                            votos = Convert.ToInt32(lista.list_Nulo_D_Fed[i].Substring(3));
                            votos++;
                            lista.list_Nulo_D_Fed[i] = auxUf + "_" + votos.ToString();
                        }
                    }

                    cadastro_Candidato = new FileStream(caminho + "\\Votos Nulos Deputado Federal.dll", FileMode.Create);
                    cadastro_Candidato.Close();

                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Votos Nulos Deputado Federal.dll", true);

                    foreach (var item in lista.list_Nulo_D_Fed)
                    {
                        insereInfo.WriteLine(item);
                    }

                    t_Dep_F.List_String_Cand.Clear();
                    insereInfo.Close();
                }
            }

            if (t_Senador.List_String_Cand.Count == 3)
            {
                foreach (var x in lista.List_Senador)
                {
                    if (x.Num == t_Senador.Num_Cand_Conv && auxUf == x.Uf)
                    {
                        votos = Convert.ToInt32(x.ContaVotos);
                        votos++;
                        x.ContaVotos = votos.ToString();
                        achou = true;
                        break;
                    }
                }
                if (achou == true)
                {
                    cadastro_Candidato = new FileStream(caminho + "\\Senador.dll", FileMode.Create);
                    cadastro_Candidato.Close();

                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Senador.dll", true);

                    foreach (var x in lista.List_Senador)
                    {
                        insereInfo.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7}", x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Uf, x.Sup1, x.Sup2, x.ContaVotos);
                    }

                    t_Senador.List_String_Cand.Clear();
                    insereInfo.Close();
                }
                else
                {
                    for (int i = 0; i < lista.list_Nulo_Sen.Count; i++)
                    {
                        encontraUf = lista.list_Nulo_Sen[i].Substring(0, 2);

                        if (auxUf == encontraUf)
                        {
                            votos = Convert.ToInt32(lista.list_Nulo_Sen[i].Substring(3));
                            votos++;
                            lista.list_Nulo_Sen[i] = auxUf + "_" + votos.ToString();
                        }
                    }

                    cadastro_Candidato = new FileStream(caminho + "\\Votos Nulos Senador.dll", FileMode.Create);
                    cadastro_Candidato.Close();

                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Votos Nulos Senador.dll", true);

                    foreach (var item in lista.list_Nulo_Sen)
                    {
                        insereInfo.WriteLine(item);
                    }

                    t_Senador.List_String_Cand.Clear();
                    insereInfo.Close();
                }
            }

            if (t_Governador.List_String_Cand.Count == 2)
            {
                foreach (var x in lista.List_Governador)
                {
                    if (x.Num == t_Governador.Num_Cand_Conv && auxUf == x.Uf)
                    {
                        votos = Convert.ToInt32(x.ContaVotos);
                        votos++;
                        x.ContaVotos = votos.ToString();
                        achou = true;
                        break;
                    }
                }
                if (achou == true)
                {
                    cadastro_Candidato = new FileStream(caminho + "\\Governador.dll", FileMode.Create);
                    cadastro_Candidato.Close();

                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Governador.dll", true);

                    foreach (var x in lista.List_Governador)
                    {
                        insereInfo.WriteLine("{0};{1};{2};{3};{4};{5};{6}", x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Uf, x.Vice, x.ContaVotos);
                    }

                    t_Governador.List_String_Cand.Clear();
                    insereInfo.Close();
                }
                else
                {
                    for (int i = 0; i < lista.list_Nulo_Gov.Count; i++)
                    {
                        encontraUf = lista.list_Nulo_Gov[i].Substring(0, 2);

                        if (auxUf == encontraUf)
                        {
                            votos = Convert.ToInt32(lista.list_Nulo_Gov[i].Substring(3));
                            votos++;
                            lista.list_Nulo_Gov[i] = auxUf + "_" + votos.ToString();
                        }
                    }

                    cadastro_Candidato = new FileStream(caminho + "\\Votos Nulos Governador.dll", FileMode.Create);
                    cadastro_Candidato.Close();

                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Votos Nulos Governador.dll", true);

                    foreach (var item in lista.list_Nulo_Gov)
                    {
                        insereInfo.WriteLine(item);
                    }

                    t_Governador.List_String_Cand.Clear();
                    insereInfo.Close();
                }
            }

            if (t_Presidente.List_String_Cand.Count == 2)
            {
                
                foreach (var x in lista.List_Presidente)
                {
                    if (x.Num == t_Presidente.Num_Cand_Conv)
                    {
                        for (int i = 0; i < x.ContaVotos.Count(); i++)
                        {
                            encontraUf = x.ContaVotos[i].Substring(0,2);

                            if (encontraUf == auxUf)
                            {
                                votos = Convert.ToInt32(x.ContaVotos[i].Substring(3));
                                votos++;
                                x.ContaVotos[i] = auxUf + "_" + votos.ToString();
                                votos = Convert.ToInt32(x.ContaVotos[0].Substring(3));
                                votos++;
                                x.ContaVotos[0] = "BR_" + votos.ToString();
                                achou = true;
                                break;
                            }
                        }
                        break;
                    }
                }
                if (achou == true)
                {
                    cadastro_Candidato = new FileStream(caminho + "\\Presidente.dll", FileMode.Create);
                    cadastro_Candidato.Close();

                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Presidente.dll", true);

                    foreach (var x in lista.List_Presidente)
                    {
                        insereInfo.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14}" +
                        ";{15};{16};{17};{18};{19};{20};{21};{22};{23};{24};{25};{26};{27};{28};{29};{30};{31};{32}"
                        , x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Vice, x.ContaVotos[0],
                        x.ContaVotos[1], x.ContaVotos[2], x.ContaVotos[3], x.ContaVotos[4], x.ContaVotos[5],
                        x.ContaVotos[6], x.ContaVotos[7], x.ContaVotos[8], x.ContaVotos[9], x.ContaVotos[10],
                        x.ContaVotos[11], x.ContaVotos[12], x.ContaVotos[13], x.ContaVotos[14], x.ContaVotos[15],
                        x.ContaVotos[16], x.ContaVotos[17], x.ContaVotos[18], x.ContaVotos[19], x.ContaVotos[20],
                        x.ContaVotos[21], x.ContaVotos[22], x.ContaVotos[23], x.ContaVotos[24], x.ContaVotos[25],
                        x.ContaVotos[26], x.ContaVotos[27]);
                    }

                    t_Presidente.List_String_Cand.Clear();
                    insereInfo.Close();
                }
                else
                {
                    for (int i = 0; i < lista.Nulo_Presidente.Count; i++)
                    {
                        encontraUf = lista.Nulo_Presidente[i].Substring(0, 2);

                        if (auxUf == encontraUf)
                        {
                            votos = Convert.ToInt32(lista.Nulo_Presidente[i].Substring(3));
                            votos++;
                            lista.Nulo_Presidente[i] = auxUf + "_" + votos.ToString();
                            votos = Convert.ToInt32(lista.Nulo_Presidente[0].Substring(3));
                            votos++;
                            lista.Nulo_Presidente[0] = "BR_" + votos.ToString();
                        }
                    }

                    cadastro_Candidato = new FileStream(caminho + "\\Votos Nulos Presidente.dll", FileMode.Create);
                    cadastro_Candidato.Close();

                    StreamWriter insereInfo = new StreamWriter(caminho + "\\Votos Nulos Presidente.dll", true);

                    foreach (var item in lista.Nulo_Presidente)
                    {
                        insereInfo.WriteLine(item);
                    }

                    t_Presidente.List_String_Cand.Clear();
                    insereInfo.Close();
                }
            }

            if (t_Dep_E.List_String_Cand.Count == 0 && Application.OpenForms["Tela_Dep_Estadual"] != null)
            {
                for (int i = 0; i < lista.list_Branco_D_Est.Count; i++)
                {
                    encontraUf = lista.list_Branco_D_Est[i].Substring(0, 2);

                    if (auxUf == encontraUf)
                    {
                        votos = Convert.ToInt32(lista.list_Branco_D_Est[i].Substring(3));
                        votos++;
                        lista.list_Branco_D_Est[i] = auxUf + "_" + votos.ToString();
                    }
                }

                cadastro_Candidato = new FileStream(caminho + "\\Votos Brancos Deputado Estadual.dll", FileMode.Create);
                cadastro_Candidato.Close();

                StreamWriter insereInfo = new StreamWriter(caminho + "\\Votos Brancos Deputado Estadual.dll", true);

                foreach (var item in lista.list_Branco_D_Est)
                {
                    insereInfo.WriteLine(item);
                }

                insereInfo.Close();
            }

            if (t_Dep_F.List_String_Cand.Count == 0 && Application.OpenForms["Tela_Dep_Federal"] != null)
            {
                for (int i = 0; i < lista.list_Branco_D_Fed.Count; i++)
                {
                    encontraUf = lista.list_Branco_D_Fed[i].Substring(0, 2);

                    if (auxUf == encontraUf)
                    {
                        votos = Convert.ToInt32(lista.list_Branco_D_Fed[i].Substring(3));
                        votos++;
                        lista.list_Branco_D_Fed[i] = auxUf + "_" + votos.ToString();
                    }
                }

                cadastro_Candidato = new FileStream(caminho + "\\Votos Brancos Deputado Federal.dll", FileMode.Create);
                cadastro_Candidato.Close();

                StreamWriter insereInfo = new StreamWriter(caminho + "\\Votos Brancos Deputado Federal.dll", true);

                foreach (var item in lista.list_Branco_D_Fed)
                {
                    insereInfo.WriteLine(item);
                }

                insereInfo.Close();
            }

            if (t_Senador.List_String_Cand.Count == 0 && Application.OpenForms["Tela_Senador"] != null)
            {
                for (int i = 0; i < lista.list_Branco_Sen.Count; i++)
                {
                    encontraUf = lista.list_Branco_Sen[i].Substring(0, 2);

                    if (auxUf == encontraUf)
                    {
                        votos = Convert.ToInt32(lista.list_Branco_Sen[i].Substring(3));
                        votos++;
                        lista.list_Branco_Sen[i] = auxUf + "_" + votos.ToString();
                    }
                }

                cadastro_Candidato = new FileStream(caminho + "\\Votos Brancos Senador.dll", FileMode.Create);
                cadastro_Candidato.Close();

                StreamWriter insereInfo = new StreamWriter(caminho + "\\Votos Brancos Senador.dll", true);

                foreach (var item in lista.list_Branco_Sen)
                {
                    insereInfo.WriteLine(item);
                }

                insereInfo.Close();
            }

            if (t_Governador.List_String_Cand.Count == 0 && Application.OpenForms["Tela_Governador"] != null)
            {
                for (int i = 0; i < lista.list_Branco_Gov.Count; i++)
                {
                    encontraUf = lista.list_Branco_Gov[i].Substring(0, 2);

                    if (auxUf == encontraUf)
                    {
                        votos = Convert.ToInt32(lista.list_Branco_Gov[i].Substring(3));
                        votos++;
                        lista.list_Branco_Gov[i] = auxUf + "_" + votos.ToString();
                    }
                }

                cadastro_Candidato = new FileStream(caminho + "\\Votos Brancos Governador.dll", FileMode.Create);
                cadastro_Candidato.Close();

                StreamWriter insereInfo = new StreamWriter(caminho + "\\Votos Brancos Governador.dll", true);

                foreach (var item in lista.list_Branco_Gov)
                {
                    insereInfo.WriteLine(item);
                }

                insereInfo.Close();
            }

            if (t_Presidente.List_String_Cand.Count == 0 && Application.OpenForms["Tela_Presidente"] != null)
            {
                for (int i = 0; i < lista.Branco_Presidente.Count; i++)
                {
                    encontraUf = lista.Branco_Presidente[i].Substring(0, 2);

                    if (auxUf == encontraUf)
                    {
                        votos = Convert.ToInt32(lista.Branco_Presidente[i].Substring(3));
                        votos++;
                        lista.Branco_Presidente[i] = auxUf + "_" + votos.ToString();
                        votos = Convert.ToInt32(lista.Branco_Presidente[0].Substring(3));
                        votos++;
                        lista.Branco_Presidente[0] = "BR_" + votos.ToString();
                    }
                }

                cadastro_Candidato = new FileStream(caminho + "\\Votos Brancos Presidente.dll", FileMode.Create);
                cadastro_Candidato.Close();

                StreamWriter insereInfo = new StreamWriter(caminho + "\\Votos Brancos Presidente.dll", true);

                foreach (var item in lista.Branco_Presidente)
                {
                    insereInfo.WriteLine(item);
                }

                insereInfo.Close();
            }
        }
    }
}
