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
    public partial class Consulta_Eleitor : Form
    {
        FileStream arquivos;
        StreamReader arquivoLer;

        Listas list = new Listas();
        bool achou = false;

        public Consulta_Eleitor()
        {
            InitializeComponent();
            nome_Eleitor.Enabled = false;
            inscricao_Eleitor.Enabled = false;
            zona_Eleitor.Enabled = false;
            secao_Eleitor.Enabled = false;
            uf_Eleitor.Enabled = false;
        }

        private void bt_buscaEleitor_Click(object sender, EventArgs e)
        {
            list.Carrega_Eleitor();

            foreach(var x in list.List_Eleitor)
            {
                if (x.Titulo.ToString() == tb_inscricaoEleitor.Text)
                {
                    achou = true;
                    nome_Eleitor.Text = x.Nome;
                    inscricao_Eleitor.Text = x.Titulo.ToString();
                    zona_Eleitor.Text = x.Zona.ToString();
                    secao_Eleitor.Text = x.Secao.ToString();
                    uf_Eleitor.Text = x.Uf;
                    break;
                }
                else
                {
                    achou = false;
                }
            }
            if (achou == false)
            {
                MessageBox.Show("Não foi encontrado nenhum eleitor para a busca realizada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

         private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_inscricaoEleitor.Clear();
            nome_Eleitor.Clear();
            inscricao_Eleitor.Clear();
            zona_Eleitor.Clear();
            secao_Eleitor.Clear();
            uf_Eleitor.Text = " ";
        }

        private void bt_excluirEleitor_Click(object sender, EventArgs e)
        {
            /*Percorre a lista de eleitores*/
            foreach (var x in list.List_Eleitor)
            {
                /*Econtra na lista de eleitores o eleitor escolhido para excluir.*/
                if (nome_Eleitor.Text == x.Nome)
                {
                    /*Se as informações do textbox estiverem iguais as da lista de candidatos.*/
                    if ((x.Nome == nome_Eleitor.Text) && (x.Titulo.ToString() == inscricao_Eleitor.Text));
                    {
                        list.List_Eleitor.Remove(x);
                        break;
                    }
                }
            }
                
                arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Eleitor.dll", FileMode.Create);
                arquivos.Close();

                StreamWriter inserirInfo = new StreamWriter(Directory.GetCurrentDirectory() + "\\Cadastros\\Eleitor.dll", true);

                foreach (var item in list.List_Eleitor)
                {
                    inserirInfo.WriteLine("{0};{1};{2};{3};{4};{5}", item.Nome,item.Uf,item.Secao,item.Titulo,item.Zona,item.Voto);
                }
                inserirInfo.Close();
                MessageBox.Show("Excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_inscricaoEleitor.Clear();
                nome_Eleitor.Clear();
                inscricao_Eleitor.Clear();
                zona_Eleitor.Clear();
                secao_Eleitor.Clear();
                uf_Eleitor.Text = " ";
                
        }
    }
}
