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
    public partial class Consulta_Partido : Form
    {
        /*Permite a manipulação do arquivo*/
        FileStream arquivos;
        /*Permite a ecrita no arquivo*/
        StreamReader arquivoLer;

        /*Instância do ojeto lista*/
        Listas lista = new Listas();

        /*Construtor da classe*/
        public Consulta_Partido()
        {
            InitializeComponent();
            lista.Carrega_Partidos();
            cb_partidos.Text = lista.List_Partidos[0].Abrev;

            tb_nome.Text = lista.List_Partidos[0].Nome;
            tb_num.Text = lista.List_Partidos[0].Cod.ToString();
            tb_sigla.Text = lista.List_Partidos[0].Abrev;

            foreach (var item in lista.List_Partidos)
            {
                cb_partidos.Items.Add(item.Abrev);
            }
        }

        /*Ao selecionar um partido, mostra os dados na tela.
         *Não é possivel editar nada, neste momento.
         */
        private void cb_partidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_nome.Enabled = false;
            tb_num.Enabled = false;
            tb_sigla.Enabled = false;


            foreach (var x in lista.List_Partidos)
            {
                if (cb_partidos.Text == x.Abrev)
                {
                    tb_nome.Text = x.Nome;
                    tb_num.Text = Convert.ToString(x.Cod);
                    tb_sigla.Text = x.Abrev;
                }
            }
        }

        /*Envento acionado ao clicar no botão "Editar"
         *Habilita os campos para edição, nete momento.
         */
        private void bt_editar_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = true;
            tb_num.Enabled = true;
            tb_sigla.Enabled = true;
            bt_excluir.Enabled = true;
        }

        /*Evento acionado ao clicar no botão "Cancelar"*/
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            /*Fecha a tela*/
            this.Close();
        }

        /*Evento acionado ao clicar no botão "Salvar"*/
        private void bt_salvar_Click(object sender, EventArgs e) 
        {
            /*Verifica se todos os campos foram preenchidos*/
            if (tb_nome.TextLength <= 2)
            {
                MessageBox.Show("Preencha o campo" + '"' + "Nome" + '"' + "!",
                       "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nome_Partido.Focus();
            }
            else if (tb_sigla.TextLength < 2)
            {
                MessageBox.Show("Preencha o campo" + '"' + "Sigla" + '"' + "contendo no mínimo 2 letras" + "!",
                       "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sigla_Partido.Focus();
            }

            else if (tb_num.TextLength != 2)
            {
                MessageBox.Show("Preencha o campo " + '"' + "Número" + '"' + " com 2 dígitos!",
                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                num_Partido.Focus();
            }
            else
            {
                /*Percorre a lista de partidos*/
                foreach (var x in lista.List_Partidos)
                {
                    /*Econtrar na lista de partidos o partido escolhido para editar.*/
                    if (cb_partidos.Text == x.Abrev)
                    {
                        /*Se as informações do textbox estiverem iguais as da lista de partidos.*/
                        if ((x.Nome == tb_nome.Text) && (x.Cod == Convert.ToInt16(tb_num.Text)) && (x.Abrev == tb_sigla.Text))
                        {
                            /*Exibe uma mensagem informando que nada foi alterado */
                            MessageBox.Show("Você nao alterou nada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                        /*Se as informações do text forem diferentes da lista*/
                        else
                        {
                            /*Armazena o caminho do arquivo que armazena os partidos*/
                            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Partido.dll", FileMode.OpenOrCreate);
                            /*Permite a escrita no arquivo*/
                            arquivoLer = new StreamReader(arquivos);

                            /*Variavel que armazena os dados do candidato editado*/
                            string line = x.Nome + ";" + x.Abrev + ";" + x.Cod.ToString();

                            /*Atribui os novos valores ao candidato*/
                            x.Nome = tb_nome.Text;
                            x.Cod = Convert.ToInt16(tb_num.Text);
                            x.Abrev = tb_sigla.Text;

                            /*Variavel que armazena os novos dados do candidato editado*/
                            string novaLinha = x.Nome + ";" + x.Abrev + ";" + x.Cod.ToString();

                            string texto;
                            
                            /*Substitui no arquivo o candidato editado*/
                            while ((texto = arquivoLer.ReadLine()) != null)
                            {
                                if (texto == line)
                                {
                                    texto = texto.Replace(line, novaLinha);
                                }
                            }
                            arquivos.Close();
                            arquivoLer.Close();

                            arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Partido.dll", FileMode.Create);
                            arquivos.Close();

                            StreamWriter inserirInfo = new StreamWriter(Directory.GetCurrentDirectory() + "\\Cadastros\\Partido.dll", true);

                            foreach (var item in lista.List_Partidos)
                            {
                                inserirInfo.Write("{0};{1};{2}\n", item.Nome, item.Abrev, item.Cod);
                            }
                            inserirInfo.Close();
                            MessageBox.Show("Editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            lista.Carrega_Partidos();

                            cb_partidos.Items.Clear();

                            foreach (var item in lista.List_Partidos)
                            {
                                cb_partidos.Items.Add(item.Abrev);
                            }

                            cb_partidos.Text = lista.List_Partidos[0].Abrev;
                            tb_nome.Text = lista.List_Partidos[0].Nome;
                            tb_num.Text = lista.List_Partidos[0].Cod.ToString();
                            tb_sigla.Text = lista.List_Partidos[0].Abrev;

                            break;
                        }
                    }
                }
            }
        }

        /*Permite apenas letras no campo "Nome" do partido*/
        private void tb_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*Permite apenas números no campo "Numero" do partido*/
        private void tb_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*Permite apenas letras no campo "Sigla"*/
        private void tb_sigla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*Evento acionado ao clicar no botão "Excluir"*/
        private void bt_excluir_Click(object sender, EventArgs e)
        {
            /*Percorre a lista de partidos*/
            foreach (var x in lista.List_Partidos)
            {
                /*Econtrar na lista de partidos o partido escolhido para excluir.*/
                if (cb_partidos.Text == x.Abrev)
                {
                    /*Exclui o partido*/
                    lista.List_Partidos.Remove(x);

                    /*AO EXCLUIR O PARTIDO, DEVE-SE EXCLUIR TODOS OS CANDIDATOS VINCULADOS A ELE*/

                    /* Caminho do diretorio de cadastros */
                    string caminho = Directory.GetCurrentDirectory() + "\\Cadastros";
                    /* Caminho do diretorio de imagens*/
                    string caminhoImg = Directory.GetCurrentDirectory() + "\\Img";

                    /*Variavel para leitura ou criação de um arquivo*/
                    FileStream cadastro_Candidato;
                    /*Variavel que permite a escrita em um arquivo*/
                    StreamWriter insereInfo;

                    /*EXCLUIR TODOS OS DEPUTADOS ESTADUAIS DO PARTIDO*/

                    /*Carrega a lista de Dep. Estaduais*/
                    lista.Carrega_Dep_Estadual();
                    /*Percorre a lista de Deputados Estaduais */
                    for (int y = 0; y < lista.List_DepEstadual.Count; y++)
                    {
                        /* Verifica se o candidato é do partido a ser excluído*/
                        if (lista.List_DepEstadual[y].Part.Abrev == x.Abrev)
                        {
                            /*Deleta a imagem do candidato do diretorio de imagens*/
                            File.Delete(caminhoImg + "\\" + lista.List_DepEstadual[y].Num + "_" + lista.List_DepEstadual[y].Uf + ".jpg");
                            /*Remove o candidato*/
                            lista.List_DepEstadual.Remove(lista.List_DepEstadual[y]);
                            y--;
                        }
                    }

                    /*Cria um novo arquivo de Deputados Estaduais*/
                    cadastro_Candidato = new FileStream(caminho + "\\Deputado Estadual.dll", FileMode.Create);
                    /*Fecha o arquivo que acabou de ser criado*/
                    cadastro_Candidato.Close();

                    /*Inserir info recebe o caminho do arquivo de Deputados Estaduais*/
                    insereInfo = new StreamWriter(caminho + "\\Deputado Estadual.dll", true);

                    /*Percorre a lista de Deputados Estaduais*/
                    foreach (var y in lista.List_DepEstadual)
                    {
                        /*Escreve no arquivo todos os candidatos que estão na nova lista*/
                        insereInfo.WriteLine("{0};{1};{2};{3};{4}", y.Nome, y.NomeUrna, y.Num.ToString(), y.Part.Abrev, y.Uf);
                    }

                    /*Fecha a variavel que permite a escrita no arquivo*/
                    insereInfo.Close();

                    /*EXCLUIR TODOS OS DEPUTADOS FEDERAIS DO PARTIDO*/

                    /*Carrega a lista de Dep. Federais*/
                    lista.Carrega_Dep_Federal();
                    /*Percorre a lista de Deputados Federais */
                    for (int y = 0; y < lista.List_DepFederal.Count; y++)
                    {
                        /* Verifica se o candidato é do partido a ser excluído*/
                        if (lista.List_DepFederal[y].Part.Abrev == x.Abrev)
                        {
                            /*Deleta a imagem do candidato do diretorio de imagens*/
                            File.Delete(caminhoImg + "\\" + lista.List_DepFederal[y].Num + "_" + lista.List_DepFederal[y].Uf + ".jpg");
                            /*Remove o candidato*/
                            lista.List_DepFederal.Remove(lista.List_DepFederal[y]);
                            y--;
                        }
                    }

                    /*Cria um novo arquivo de Deputados Federais*/
                    cadastro_Candidato = new FileStream(caminho + "\\Deputado Federal.dll", FileMode.Create);
                    /*Fecha o arquivo que acabou de ser criado*/
                    cadastro_Candidato.Close();

                    /*Inserir info recebe o caminho do arquivo de Deputados Federais*/
                    insereInfo = new StreamWriter(caminho + "\\Deputado Federal.dll", true);

                    /*Percorre a lista de Deputados Federais*/
                    foreach (var y in lista.List_DepFederal)
                    {
                        /*Escreve no arquivo todos os candidatos que estão na nova lista*/
                        insereInfo.WriteLine("{0};{1};{2};{3};{4}", y.Nome, y.NomeUrna, y.Num.ToString(), y.Part.Abrev, y.Uf);
                    }

                    /*Fecha a variavel que permite a escrita no arquivo*/
                    insereInfo.Close();

                    /*EXCLUIR TODOS OS SENADORES DO PARTIDO*/

                    /*Carrega a lista de Senadores*/
                    lista.Carrega_Senador();
                    /*Percorre a lista de Senadores */
                    for (int y = 0; y < lista.List_Senador.Count; y++)
                    {
                        /* Verifica se o candidato é do partido a ser excluído*/
                        if (lista.List_Senador[y].Part.Abrev == x.Abrev)
                        {
                            /*Deleta a imagem do candidato do diretorio de imagens*/
                            File.Delete(caminhoImg + "\\" + lista.List_Senador[y].Num + "_" + lista.List_Senador[y].Uf + ".jpg");
                            /*Remove o candidato*/
                            lista.List_Senador.Remove(lista.List_Senador[y]);
                            y--;
                        }
                    }

                    /*Cria um novo arquivo de Senadores*/
                    cadastro_Candidato = new FileStream(caminho + "\\Senador.dll", FileMode.Create);
                    /*Fecha o arquivo que acabou de ser criado*/
                    cadastro_Candidato.Close();

                    /*Inserir info recebe o caminho do arquivo de Senadores*/
                    insereInfo = new StreamWriter(caminho + "\\Senador.dll", true);

                    /*Percorre a lista de Senadores*/
                    foreach (var y in lista.List_Senador)
                    {
                        /*Escreve no arquivo todos os candidatos que estão na nova lista*/
                        insereInfo.WriteLine("{0};{1};{2};{3};{4}", y.Nome, y.NomeUrna, y.Num.ToString(), y.Part.Abrev, y.Uf);
                    }

                    /*Fecha a variavel que permite a escrita no arquivo*/
                    insereInfo.Close();

                    /*EXCLUIR TODOS OS GOVERNADORES DO PARTIDO*/

                    /*Carrega a lista de Governadores*/
                    lista.Carrega_Governador();
                    /*Percorre a lista de Governadores */
                    for (int y = 0; y < lista.List_Governador.Count; y++)
                    {
                        /* Verifica se o candidato é do partido a ser excluído*/
                        if (lista.List_Governador[y].Part.Abrev == x.Abrev)
                        {
                            /*Deleta a imagem do candidato do diretorio de imagens*/
                            File.Delete(caminhoImg + "\\" + lista.List_Governador[y].Num + "_" + lista.List_Governador[y].Uf + ".jpg");
                            /*Remove o candidato*/
                            lista.List_Governador.Remove(lista.List_Governador[y]);
                            y--;
                        }
                    }

                    /*Cria um novo arquivo de Governadores*/
                    cadastro_Candidato = new FileStream(caminho + "\\Governador.dll", FileMode.Create);
                    /*Fecha o arquivo que acabou de ser criado*/
                    cadastro_Candidato.Close();

                    /*Inserir info recebe o caminho do arquivo de Governadores*/
                    insereInfo = new StreamWriter(caminho + "\\Governador.dll", true);

                    /*Percorre a lista de Governadores*/
                    foreach (var y in lista.List_Governador)
                    {
                        /*Escreve no arquivo todos os candidatos que estão na nova lista*/
                        insereInfo.WriteLine("{0};{1};{2};{3};{4}", y.Nome, y.NomeUrna, y.Num.ToString(), y.Part.Abrev, y.Uf);
                    }

                    /*Fecha a variavel que permite a escrita no arquivo*/
                    insereInfo.Close();

                    /*EXCLUIR TODOS OS PRESIDENTES DO PARTIDO*/

                    /*Carrega a lista de Presidentes*/
                    lista.Carrega_Presidente();
                    /*Percorre a lista de Presidentes*/
                    for (int y = 0; y < lista.List_Presidente.Count; y++)
                    {
                        /* Verifica se o candidato é do partido a ser excluído*/
                        if (lista.List_Presidente[y].Part.Abrev == x.Abrev)
                        {
                            /*Deleta a imagem do candidato do diretorio de imagens*/
                            File.Delete(caminhoImg + "\\" + lista.List_Presidente[y].Num + ".jpg");
                            /*Remove o candidato*/
                            lista.List_Presidente.Remove(lista.List_Presidente[y]);
                            y--;
                        }
                    }

                    /*Cria um novo arquivo de Presidentes*/
                    cadastro_Candidato = new FileStream(caminho + "\\Presidente.dll", FileMode.Create);
                    /*Fecha o arquivo que acabou de ser criado*/
                    cadastro_Candidato.Close();

                    /*Inserir info recebe o caminho do arquivo de Presidentes*/
                    insereInfo = new StreamWriter(caminho + "\\Presidente.dll", true);

                    /*Percorre a lista de Presidentes*/
                    foreach (var y in lista.List_Presidente)
                    {
                        /*Escreve no arquivo todos os candidatos que estão na nova lista*/
                        insereInfo.WriteLine("{0};{1};{2};{3};{4}", y.Nome, y.NomeUrna, y.Num.ToString(), y.Part.Abrev);
                    }

                    /*Fecha a variavel que permite a escrita no arquivo*/
                    insereInfo.Close();

                    MessageBox.Show("Todos os candidatos deste partido foram excluídos!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

                arquivos = new FileStream(Directory.GetCurrentDirectory() + "\\Cadastros\\Partido.dll", FileMode.Create);
                arquivos.Close();

                StreamWriter inserirInfo = new StreamWriter(Directory.GetCurrentDirectory() + "\\Cadastros\\Partido.dll", true);

                foreach (var item in lista.List_Partidos)
                {
                    inserirInfo.Write("{0};{1};{2}\n", item.Nome, item.Abrev, item.Cod);
                }
                inserirInfo.Close();
                MessageBox.Show("Excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lista.Carrega_Partidos();

                cb_partidos.Items.Clear();

                foreach (var item in lista.List_Partidos)
                {
                    cb_partidos.Items.Add(item.Abrev);
                }

                cb_partidos.Text = lista.List_Partidos[0].Abrev;
                tb_nome.Text = lista.List_Partidos[0].Nome;
                tb_num.Text = lista.List_Partidos[0].Cod.ToString();
                tb_sigla.Text = lista.List_Partidos[0].Abrev;

                bt_excluir.Enabled = false;
                break;
            }
        }

        /*Bloqueia a inserção de caracteres no combobox*/
        private void cb_partidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*Permite apenas as setas de navegação vertical no combobox*/
        private void cb_partidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
            {
                e.Handled = true;
            }

        }
    }
}