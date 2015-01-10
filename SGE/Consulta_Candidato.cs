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
using System.Drawing.Imaging;

namespace SGE
{
    public partial class Consulta_Candidato : Form
    {
        /*Instâcia do objeto lista*/
        Listas lista = new Listas();
        /*Instância do ojeto partido*/
        Partido partido = new Partido();
        /*Instância do objeto Dep. Estadual*/
        DepEstadual dep_Estadual = new DepEstadual();
        /*Instância do objeto Dep. Federal*/
        DepFederal dep_Federal = new DepFederal();
        /*Instância do objeto Senador*/
        Senador senador = new Senador();
        /*Instância do objeto Governador*/
        Governador governador = new Governador();
        /*Instância do objeto Presidente*/
        Presidente presidente = new Presidente();
        /*Instância do objeto Estado*/
        Estado estado = new Estado();
        
        /*Listas auxiliares de todos os cargos*/
        List<DepEstadual> auxEst;
        List<DepFederal> auxFed;
        List<Senador> auxSen;
        List<Governador> auxGov;
        List<Presidente> auxPres;
        
        /*Construtor da classe*/
        public Consulta_Candidato()
        {
            InitializeComponent();
            estado.CadastraEstados();
            lista.Carrega_Partidos();

            foreach (var item in lista.List_Partidos)
            {
                partidos.Items.Add(item.Abrev);
            }

            foreach (var item in estado.estados)
            {
                uf_Lista.Items.Add(item.Sigla);
            }

            uf_Lista.Text = uf_Lista.Items[0].ToString();
            cargos.Text = cargos.Items[0].ToString();
            partidos.Text = partidos.Items[0].ToString();

        }

        /*Método que exclui um candidato*/
        public void Exclue_Candidato()
        {
            /*Caminho do diretorio de cadastros*/
            string caminho = Directory.GetCurrentDirectory() + "\\Cadastros";
            /*Camindo do diretorio de imagens*/
            string caminhoImg = Directory.GetCurrentDirectory() + "\\Img";
            /*Váriavel usada para manipular o arquivo*/
            FileStream cadastro_Candidato;

            /*Novas instâncias dos objetos*/
            partido = new Partido();
            dep_Estadual = new DepEstadual();
            dep_Federal = new DepFederal();
            senador = new Senador();
            governador = new Governador();
            presidente = new Presidente();
            estado = new Estado();
            lista = new Listas();

            /*Permite a escrita no arquivo*/
            StreamWriter insereInfo;

            
            if (listBox1.SelectedItem != null)
            {
                /*Verifica a lista de candidatos, de acordo com o cargo selecionado.
                 *Quando encontra o candidato, exclui da lista e reescreve o arquivo de acordo com a nova lista.
                 */
                switch (cargos.Text)
                {
                    case "Deputado Estadual":

                        uf_Lista.Visible = true;
                        lista.Carrega_Dep_Estadual();

                        foreach (var item in lista.List_DepEstadual)
                        {
                            if ((item.Uf == auxEst[listBox1.SelectedIndex].Uf) && (item.Num == auxEst[listBox1.SelectedIndex].Num))
                            {
                                lista.List_DepEstadual.Remove(item);
                                break;
                            }
                        }

                        File.Delete(caminhoImg + "\\" + auxEst[listBox1.SelectedIndex].Num + "_" + auxEst[listBox1.SelectedIndex].Uf + ".jpg");

                        cadastro_Candidato = new FileStream(caminho + "\\Deputado Estadual.dll", FileMode.Create);
                        cadastro_Candidato.Close();

                        insereInfo = new StreamWriter(caminho + "\\Deputado Estadual.dll", true);

                        foreach (var x in lista.List_DepEstadual)
                        {
                            insereInfo.WriteLine("{0};{1};{2};{3};{4};{5}", x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Uf,x.ContaVotos);
                        }

                        insereInfo.Close();
                        MessageBox.Show("Candidato excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        listBox1.Items.Clear();
                        break;

                    case "Deputado Federal":

                        uf_Lista.Visible = true;
                        lista.Carrega_Dep_Federal();

                        foreach (var item in lista.List_DepFederal)
                        {
                            if ((item.Uf == auxFed[listBox1.SelectedIndex].Uf) && (item.Num == auxFed[listBox1.SelectedIndex].Num))
                            {
                                lista.List_DepFederal.Remove(item);
                                break;
                            }
                        }

                        File.Delete(caminhoImg + "\\" + auxFed[listBox1.SelectedIndex].Num + "_" + auxFed[listBox1.SelectedIndex].Uf + ".jpg");

                        cadastro_Candidato = new FileStream(caminho + "\\Deputado Federal.dll", FileMode.Create);
                        cadastro_Candidato.Close();

                        insereInfo = new StreamWriter(caminho + "\\Deputado Federal.dll", true);

                        foreach (var x in lista.List_DepFederal)
                        {
                            insereInfo.WriteLine("{0};{1};{2};{3};{4};{5}", x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Uf,x.ContaVotos);
                        }

                        insereInfo.Close();
                        MessageBox.Show("Candidato excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        listBox1.Items.Clear();
                        break;

                    case "Senador":

                        uf_Lista.Visible = true;
                        lista.Carrega_Senador();

                        foreach (var item in lista.List_Senador)
                        {
                            if ((item.Uf == auxSen[listBox1.SelectedIndex].Uf) && (item.Num == auxSen[listBox1.SelectedIndex].Num))
                            {
                                lista.List_Senador.Remove(item);
                                break;
                            }
                        }

                        File.Delete(caminhoImg + "\\" + auxSen[listBox1.SelectedIndex].Num + "_" + auxSen[listBox1.SelectedIndex].Uf + ".jpg");

                        cadastro_Candidato = new FileStream(caminho + "\\Senador.dll", FileMode.Create);
                        cadastro_Candidato.Close();

                        insereInfo = new StreamWriter(caminho + "\\Senador.dll", true);

                        foreach (var x in lista.List_Senador)
                        {
                            insereInfo.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7}", x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Uf, x.Sup1, x.Sup2,x.ContaVotos);
                        }

                        insereInfo.Close();
                        MessageBox.Show("Candidato excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        listBox1.Items.Clear();
                        break;

                    case "Governador":

                        uf_Lista.Visible = true;
                        lista.Carrega_Governador();

                        foreach (var item in lista.List_Governador)
                        {
                            if ((item.Uf == auxGov[listBox1.SelectedIndex].Uf) && (item.Num == auxGov[listBox1.SelectedIndex].Num))
                            {
                                lista.List_Governador.Remove(item);
                                break;
                            }
                        }

                        File.Delete(caminhoImg + "\\" + auxGov[listBox1.SelectedIndex].Num + "_" + auxGov[listBox1.SelectedIndex].Uf + ".jpg");

                        cadastro_Candidato = new FileStream(caminho + "\\Governador.dll", FileMode.Create);
                        cadastro_Candidato.Close();

                        insereInfo = new StreamWriter(caminho + "\\Governador.dll", true);

                        foreach (var x in lista.List_Governador)
                        {
                            insereInfo.WriteLine("{0};{1};{2};{3};{4};{5};{6}", x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Uf, x.Vice,x.ContaVotos);
                        }

                        insereInfo.Close();
                        MessageBox.Show("Candidato excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        listBox1.Items.Clear();
                        break;

                    case "Presidente":

                        uf_Lista.Visible = false;
                        lista.Carrega_Presidente();

                        foreach (var item in lista.List_Presidente)
                        {
                            if (item.Num == auxPres[listBox1.SelectedIndex].Num)
                            {
                                lista.List_Presidente.Remove(item);
                                break;
                            }
                        }

                        File.Delete(caminhoImg + "\\" + auxPres[listBox1.SelectedIndex].Num + ".jpg");

                        cadastro_Candidato = new FileStream(caminho + "\\Presidente.dll", FileMode.Create);
                        cadastro_Candidato.Close();

                        insereInfo = new StreamWriter(caminho + "\\Presidente.dll", true);

                        foreach (var x in lista.List_Presidente)
                        {
                            insereInfo.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14}"+
                                ";{15};{16};{17};{18};{19};{20};{21};{22};{23};{24};{25};{26};{27};{28};{29};{30};{31};{32}"
                                , x.Nome, x.NomeUrna, x.Num.ToString(), x.Part.Abrev, x.Uf, x.Vice, x.ContaVotos[0],
                                x.ContaVotos[1], x.ContaVotos[2], x.ContaVotos[3], x.ContaVotos[4], x.ContaVotos[5], 
                                x.ContaVotos[6], x.ContaVotos[7], x.ContaVotos[8], x.ContaVotos[9], x.ContaVotos[10],
                                x.ContaVotos[11], x.ContaVotos[12], x.ContaVotos[13], x.ContaVotos[14], x.ContaVotos[15],
                                x.ContaVotos[16], x.ContaVotos[17], x.ContaVotos[18], x.ContaVotos[19], x.ContaVotos[20],
                                x.ContaVotos[21], x.ContaVotos[22], x.ContaVotos[23], x.ContaVotos[24], x.ContaVotos[25],
                                x.ContaVotos[26], x.ContaVotos[27]);
                        }

                        insereInfo.Close();
                        MessageBox.Show("Candidato excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        listBox1.Items.Clear();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Selecione o item a ser excluído!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*Método acionado ao clicar no botão "Consulta"*/
        private void consulta_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            /*Percorre a lista de candidatos referente ao cargo selecionado e exibe na tela, caso encontre*/
            switch (cargos.Text)
            {
                case "Deputado Estadual":

                    partidos.Visible = true;
                    uf_Lista.Visible = true;
                    auxEst = new List<DepEstadual>();
                    lista.Carrega_Dep_Estadual();

                    foreach (var item in lista.List_DepEstadual)
                    {
                        if ((item.Uf == uf_Lista.Text) && (item.Part.Abrev == partidos.Text))
                        {
                            listBox1.Items.Add(item.Nome);
                            auxEst.Add(item);
                        }
                    }

                    if (auxEst.Count == 0)
                    {
                        MessageBox.Show("Não foi encontrado nenhum candidato para a busca realizada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;

                case "Deputado Federal":

                    partidos.Visible = true;
                    uf_Lista.Visible = true;
                    auxFed = new List<DepFederal>();
                    lista.Carrega_Dep_Federal();

                    foreach (var item in lista.List_DepFederal)
                    {
                        if ((item.Uf == uf_Lista.Text) && (item.Part.Abrev == partidos.Text))
                        {
                            listBox1.Items.Add(item.Nome);
                            auxFed.Add(item);
                        }                      
                    }

                    if (auxFed.Count == 0)
                    {
                        MessageBox.Show("Não foi encontrado nenhum candidato para a busca realizada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;

                case "Senador":

                    partidos.Visible = true;
                    uf_Lista.Visible = true;
                    auxSen = new List<Senador>();
                    lista.Carrega_Senador();

                    foreach (var item in lista.List_Senador)
                    {
                        if ((item.Uf == uf_Lista.Text) && (item.Part.Abrev == partidos.Text))
                        {
                            listBox1.Items.Add(item.Nome);
                            auxSen.Add(item);
                        }
                    }

                    if (auxSen.Count == 0)
                    {
                        MessageBox.Show("Não foi encontrado nenhum candidato para a busca realizada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;

                case "Governador":

                    partidos.Visible = true;
                    uf_Lista.Visible = true;
                    auxGov = new List<Governador>();
                    lista.Carrega_Governador();

                    foreach (var item in lista.List_Governador)
                    {
                        if ((item.Uf == uf_Lista.Text) && (item.Part.Abrev == partidos.Text))
                        {
                            listBox1.Items.Add(item.Nome);
                            auxGov.Add(item);
                        }
                    }

                    if (auxGov.Count == 0)
                    {
                        MessageBox.Show("Não foi encontrado nenhum candidato para a busca realizada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;

                case "Presidente":

                    partidos.Visible = false;
                    uf_Lista.Visible = false;
                    auxPres = new List<Presidente>();
                    lista.Carrega_Presidente();

                    foreach (var item in lista.List_Presidente)
                    {
                        listBox1.Items.Add(item.Nome);
                        auxPres.Add(item);
                    }

                    if (auxPres.Count == 0)
                    {
                        MessageBox.Show("Não foi encontrado nenhum candidato para a busca realizada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;

            }
        }

        /*Método que abre a tela de "Editar candidato"*/
        private void Abrir_Ed(string cargo,string nome, string partido, string nomeUrna, int num, string uf, string sup1, string sup2, string vice)
        {
            Edita_Candidato editar = new Edita_Candidato(cargo, nome, partido, nomeUrna, num, uf, sup1, sup2, vice);
            editar.TopLevel = true;
            editar.Show();
        }

        /*Evento acionado ao clicar no botão editar*/
        private void edita_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Edita_Cndidato"] == null)
            {
                if (listBox1.SelectedItem != null)
                {
                    /*Abre a tela de "Editar candidatos", de acordo com o cargo selecionado. 
                     *Já envia os dados do candidato selecionado para a tela de edição
                     */
                    switch (cargos.Text)
                    {
                        case "Deputado Estadual":

                            label2.Visible = true;
                            uf_Lista.Visible = true;
                            lista.Carrega_Dep_Estadual();

                            foreach (var item in lista.List_DepEstadual)
                            {
                                if ((item.Uf == auxEst[listBox1.SelectedIndex].Uf) && (item.Num == auxEst[listBox1.SelectedIndex].Num))
                                {
                                    Abrir_Ed("Deputado Estadual", item.Nome, item.Part.Abrev, item.NomeUrna, item.Num, item.Uf, null, null, null);
                                    break;
                                }
                            }

                            break;

                        case "Deputado Federal":

                            label2.Visible = true;
                            uf_Lista.Visible = true;
                            lista.Carrega_Dep_Federal();

                            foreach (var item in lista.List_DepFederal)
                            {
                                if ((item.Uf == auxFed[listBox1.SelectedIndex].Uf) && (item.Num == auxFed[listBox1.SelectedIndex].Num))
                                {
                                    Abrir_Ed("Deputado Federal", item.Nome, item.Part.Abrev, item.NomeUrna, item.Num, item.Uf, null, null, null);
                                    break;
                                }
                            }

                            break;

                        case "Senador":

                            label2.Visible = true;
                            uf_Lista.Visible = true;
                            lista.Carrega_Senador();

                            foreach (var item in lista.List_Senador)
                            {
                                if ((item.Uf == auxSen[listBox1.SelectedIndex].Uf) && (item.Num == auxSen[listBox1.SelectedIndex].Num))
                                {
                                    Abrir_Ed("Senador", item.Nome, item.Part.Abrev, item.NomeUrna, item.Num, item.Uf, item.Sup1, item.Sup2, null);
                                    break;
                                }
                            }

                            break;

                        case "Governador":

                            label2.Visible = true;
                            uf_Lista.Visible = true;
                            lista.Carrega_Governador();

                            foreach (var item in lista.List_Governador)
                            {
                                if ((item.Uf == auxGov[listBox1.SelectedIndex].Uf) && (item.Num == auxGov[listBox1.SelectedIndex].Num))
                                {
                                    Abrir_Ed("Governador", item.Nome, item.Part.Abrev, item.NomeUrna, item.Num, item.Uf, null, null, item.Vice);
                                    break;
                                }
                            }

                            break;

                        case "Presidente":

                            label2.Visible = false;
                            uf_Lista.Visible = false;
                            lista.Carrega_Presidente();

                            foreach (var item in lista.List_Presidente)
                            {
                                if (item.Num == auxEst[listBox1.SelectedIndex].Num)
                                {
                                    Abrir_Ed("Presidente", item.Nome, item.Part.Abrev, item.NomeUrna, item.Num, null, null, null, item.Vice);
                                    break;
                                }
                            }

                            break;
                    }

                    listBox1.Items.Clear();
                    partidos.Text = partidos.Items[0].ToString();
                    uf_Lista.Text = uf_Lista.Items[0].ToString();

                }
                else
                {
                    MessageBox.Show("Selecione o item a ser editado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /*Evento acionado ao clicar no botão "Cancelar"*/
        private void cancelar_Click(object sender, EventArgs e)
        {
            /*Fecha a tela*/
            this.Close();
        }

        /*Evento acionado ao clicar no botão "Excluir"*/
        private void exclue_Click(object sender, EventArgs e)
        {
            /*Chama o método que realiza a exclusão do candidato*/
            Exclue_Candidato();
        }

        /*Método que habilita ou desabilita itens da tela, de acordo com o cargo selecionado*/
        private void cargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cargos.Text)
            {

                case "Deputado Estadual":
                    listBox1.Items.Clear();
                    uf_Lista.Visible = true;
                    label2.Visible = true;
                    break;

                case "Deputado Federal":
                    listBox1.Items.Clear();
                    listBox1.Items.Clear();
                    label2.Visible = true;
                    break;

                case "Senador":
                    uf_Lista.Visible = true;
                    listBox1.Items.Clear();
                    label2.Visible = true;
                    break;

                case "Governador":
                    uf_Lista.Visible = true;
                    listBox1.Items.Clear();
                    label2.Visible = true;
                    break;

                case "Presidente":
                    uf_Lista.Visible = false;
                    listBox1.Items.Clear();
                    label2.Visible = false;
                    break;
            }
        }

        /*Metodo que bloqueia a inserção de qualquer caracter no combobox*/
        private void combobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*Permite apenas as setas verticais para navegação no combobox*/
        private void combobox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
            {
                e.Handled = true;
            }
        }

    }
}
