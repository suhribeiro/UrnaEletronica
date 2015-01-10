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

namespace SGE
{
    public partial class Tela_Principal : Form
    {
        Login tela_Login = new Login();

        //Objetos das funcionalidades de cadastro
        Cadastro_Candidato telaCadastroCandidato;
        Cadastro_Partido telaCadastroPartido;
        Cadastro_Eleitor telaCadastroEleitor;

        //Objetos das funcionalidades de consulta
        Consulta_Partido consulta_partido;
        Consulta_Candidato consulta_candidato;
        Consulta_Eleitor consulta_eleitor;

        /*Tela para liberar a urna*/
        Tela_Libera_Votacao libera;

        /*Instância do objeto lista*/
        Listas lista = new Listas();

        /*Construtor da classe*/
        public Tela_Principal()
        {
            InitializeComponent();
        }

        /*Evento acionado ao clicar em Cadastro>>Candidato*/
        private void cad_Candidato_Click(object sender, EventArgs e)
        {
            lista.Carrega_Partidos();

            /*Verifica se existe partido cadastrado, se existir abre a tela de cadastro de candidatos*/
            if (Application.OpenForms["Cadastro_Candidato"] == null)
            {
                if (lista.List_Partidos.Count != 0)
                {
                    telaCadastroCandidato = new Cadastro_Candidato();
                    telaCadastroCandidato.TopLevel = true;
                    telaCadastroCandidato.Show();
                }
                /*Se não existir, exibe uma mensagem informando*/
                else
                {
                    MessageBox.Show("Não existe partido para cadastrar candidato!", "Informção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        /*Evento acionado ao clicar em Cadastro>>Partido*/
        private void cad_Partido_Click(object sender, EventArgs e)
        {
            /*Abre a tela de cadastro*/
            if(Application.OpenForms["Cadastro_Partido"]==null)
            {
                telaCadastroPartido = new Cadastro_Partido();
                telaCadastroPartido.TopLevel = true;
                telaCadastroPartido.Show();
            }
        }

        /*Fecha a tela*/
        private void Tela_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /*Evento acionado ao clicar em "Iniciar votação"*/
        private void iniciar_votacao_Click(object sender, EventArgs e)
        {
            /*Se a una não estiver sendo executada*/
            if (Application.OpenForms["Urna"] == null)
            {
                /*Abre a tela para liberação da urna*/
                libera = new Tela_Libera_Votacao();
                libera.Show();
                StreamWriter eleicao = new StreamWriter(Directory.GetCurrentDirectory() + "\\Cadastros\\Sistema.dll");
                eleicao.Write(true);
                eleicao.Close();
            }
        }

        /*Evento acionado ao clicar em Cadastro>>Eleitor*/
        private void cad_Eleitor_Click(object sender, EventArgs e)
        {
            /*Abre a tela de cadastro de eleitor*/
            if (Application.OpenForms["Cadastro_Eleitor"] == null)
            {
                telaCadastroEleitor = new Cadastro_Eleitor();
                telaCadastroEleitor.TopLevel = true;
                telaCadastroEleitor.Show();
            }

        }

        /*Evento acionado ao clicar em Consulta>>Partido*/
        private void consulta_Partido_Click(object sender, EventArgs e)
        {
            /*Abre a tela de consulta de partido*/
            if(Application.OpenForms["Consulta_Partido"]==null)
            {
                consulta_partido = new Consulta_Partido();
                consulta_partido.TopLevel = true;
                consulta_partido.Show();
            }
        }

        /*Evento acionado ao clicar em Consulta>>Candidato*/
        private void consulta_Candidato_Click(object sender, EventArgs e)
        {
            /*Carrega a lista de todos os candidatos aos cargos*/
            lista.Carrega_Dep_Estadual();
            lista.Carrega_Dep_Federal();
            lista.Carrega_Governador();
            lista.Carrega_Senador();
            lista.Carrega_Presidente();

            /*Abre a tela de consulta de candidatos*/
            if (Application.OpenForms["Consulta_Candidato"] == null)
            {
                if (lista.List_DepEstadual.Count != 0 || lista.List_DepFederal.Count != 0 || lista.List_Senador.Count != 0 || lista.List_Governador.Count != 0 || lista.List_Presidente.Count != 0)
                {
                    consulta_candidato = new Consulta_Candidato();
                    consulta_candidato.TopLevel = true;
                    consulta_candidato.Show();
                }
                else
                {
                    MessageBox.Show("Não existe candidatos cadastrados!", "Informção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /*Evento acionado ao clicar em Consulta>>Eleitor*/
        private void consulta_Eleitor_Click(object sender, EventArgs e)
        {
            /*Carrega a lista de eleitores*/
            lista.Carrega_Eleitor();

            /*Abre a tela de consulta de eleitores*/
            if (Application.OpenForms["Consulta_Eleitor"] == null)
            {
                if (lista.List_Eleitor.Count != 0)
                {
                    consulta_eleitor = new Consulta_Eleitor();
                    consulta_eleitor.TopLevel = true;
                    consulta_eleitor.Show();
                }
            }
        }

        /*Evento acionado ao clicar em "Finalizar Votação"*/
        private void finalizar_votacao_Click(object sender, EventArgs e)
        {
            /*Abre a tela que finaliza a votação*/
            if (Application.OpenForms["Urna"] == null)
            {
                Tela_FInaliza_Votacao finaliza = new Tela_FInaliza_Votacao();
                finaliza.TopLevel = true;
                finaliza.Show();
            }
        }

        /*Evento acionado ao clicar em "Relatorios"*/
        private void menu_Relatorios_Click(object sender, EventArgs e)
        {
            /*Abre a tela de  relatorios*/
            if (Application.OpenForms["Relatorios"] == null)
            {
                Relatorios relatorios = new Relatorios();
                relatorios.TopLevel = true;
                relatorios.Show();
            }
        }
    }
}
