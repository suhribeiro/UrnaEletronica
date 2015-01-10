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
    public partial class Cadastro_Partido : Form
    {
        /*Variavel que armazena o caminho do diretorio "Cadastros"*/
        string caminho = Directory.GetCurrentDirectory() + "\\Cadastros";
        /*Váriavel usada para manipular o arquivo*/
        FileStream cadastro_Partido;
        /*Objeto do tipo "Lista"*/
        Listas lista = new Listas();
        /*Objeto do tipo "Partido"*/
        Partido partido;
        /*Variavel booleana que indica se o partido foi encontrado ou não*/
        bool achou;

        /*Construtor da classe*/
        public Cadastro_Partido()
        {
            InitializeComponent();
        }

        /*Permite apenas a inserção de letras no campo "Sigla" do partido"*/
        private void SomenteLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(sigla_Partido.Focused==true && e.KeyChar ==(char)Keys.Space)
            {
                e.Handled = true;
            }

            if(!char.IsLetter(e.KeyChar)&& !(e.KeyChar==(char)Keys.Back)&&!(e.KeyChar==(char)Keys.Space))
            {
                e.Handled = true; 
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
        }

        /*Permite apenas a inserção de números no campo "Numero" do partido*/
        private void num_Partido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        /*Método que limpa todos os textbox da tela*/
        private void Limpar_TextBox()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)(item)).Text = String.Empty;
                }
            }
            nome_Partido.Focus();
        }

        /*Evento acionado ao clicar no botão "Incluir"*/
        private void bt_Incluir_Click(object sender, EventArgs e)
        {
            /*Carrega a lista de partidos*/
            lista.Carrega_Partidos();
            partido = new Partido();
            achou = false;
            bool aux = true;
            
            /*Verifica se todos os campos foram preenchidos e se o partido já existe, se não existir o partido é cadastrado*/
            switch (aux)
            {
                case true:

                    if (nome_Partido.TextLength > 2 && sigla_Partido.TextLength > 1 && num_Partido.TextLength == 2)
                    {
                        partido.Nome = nome_Partido.Text.ToUpper();
                        partido.Abrev = sigla_Partido.Text;
                        partido.Cod = Convert.ToInt32(num_Partido.Text);
                    }
                    else if (nome_Partido.TextLength <= 2)
                    {
                        MessageBox.Show("Preencha o campo" + '"' + "Nome" + '"' + "!",
                               "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nome_Partido.Focus();
                        break;
                    }
                    else if (sigla_Partido.TextLength < 2)
                    {
                        MessageBox.Show("Preencha o campo" + '"' + "Sigla" + '"' + "contendo no mínimo 2 letras" + "!",
                               "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sigla_Partido.Focus();
                        break;
                    }

                    else if (num_Partido.TextLength != 2)
                    {
                        MessageBox.Show("Preencha o campo " + '"' + "Número" + '"' + " com 2 dígitos!",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        num_Partido.Focus();
                        break;
                    }

                    if (lista.List_Partidos.Count != 0)
                    {
                        foreach (var item in lista.List_Partidos)
                        {
                            if ((item.Nome == partido.Nome) || (item.Abrev == partido.Abrev) || (item.Cod == partido.Cod))
                            {
                                MessageBox.Show("Partido já cadastrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                achou = true;
                                break;
                            }
                        }
                    }
                    if (achou == false)
                    {
                        try
                        {
                            cadastro_Partido = new FileStream(caminho + "\\Partido.dll", FileMode.OpenOrCreate);
                            cadastro_Partido.Close();

                            string[] info = new string[3];

                            info[0] = partido.Nome;
                            info[1] = partido.Abrev;
                            info[2] = partido.Cod.ToString();

                            DialogResult result = MessageBox.Show("Os dados informados estão corretos?", "Confirmação", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                StreamWriter insereInfo = new StreamWriter(caminho + "\\Partido.dll", true);
                                insereInfo.WriteLine("{0};{1};{2}", info[0], info[1], info[2]);
                                insereInfo.Close();
                                MessageBox.Show("Partido cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }

                        catch
                        {
                            MessageBox.Show("Erro ao cadastrar candidato!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    break;
            }
        }

        /*Evento acionado ao clicar no botão "Cancelar"*/
        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            /*Fecha a tela*/
            this.Close();
        }

        /*Evento acionado ao clicar no botão "Limpar"*/
        private void bt_limpar_Click(object sender, EventArgs e)
        {
            /*Chama o metodo que limpa todos os textbox da tela*/
            Limpar_TextBox();
        }
    }
}
