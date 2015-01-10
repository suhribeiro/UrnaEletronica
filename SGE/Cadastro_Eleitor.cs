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
    public partial class Cadastro_Eleitor : Form
    {
        string caminho = Directory.GetCurrentDirectory() + "\\Cadastros";
        FileStream cadastro_Eleitor;
        Listas lista = new Listas();
        Eleitor eleitor;
        Estado estado = new Estado();
        bool achou = false;
       
        public Cadastro_Eleitor()
        {
            InitializeComponent();
            estado.CadastraEstados();
            foreach (var item in estado.estados)
            {
                uf_Eleitor.Items.Add(item.Sigla);
            }

            uf_Eleitor.Text = estado.estados[0].Sigla;
        }

        public bool ValidaTitulo(string strTitulo)
        {
            

            int dig1; int dig2; int dig3; int dig4; int dig5; int dig6;
            int dig7; int dig8; int dig9; int dig10; int dig11;
            int dig12; int dv1; int dv2; int qDig;

            if (strTitulo.Length == 0) //Validação do preenchimento
            {
                return false; //Caso não seja informado o Título
            }
            else
            {
                if (strTitulo.Length < 12)
                {
                    return false;
                }
                else if (strTitulo.Length > 12)
                {
                    return false;
                }
            }

            qDig = strTitulo.Length; //Total de caracteres

            
            //Gravar posição dos caracteres
            dig1 = Convert.ToInt16(strTitulo.Substring(qDig - 12, 1));
            dig2 = Convert.ToInt16(strTitulo.Substring(qDig - 11, 1));
            dig3 = Convert.ToInt16(strTitulo.Substring(qDig - 10, 1));
            dig4 = Convert.ToInt16(strTitulo.Substring(qDig - 9, 1));
            dig5 = Convert.ToInt16(strTitulo.Substring(qDig - 8, 1));
            dig6 = Convert.ToInt16(strTitulo.Substring(qDig - 7, 1));
            dig7 = Convert.ToInt16(strTitulo.Substring(qDig - 6, 1));
            dig8 = Convert.ToInt16(strTitulo.Substring(qDig - 5, 1));
            dig9 = Convert.ToInt16(strTitulo.Substring(qDig - 4, 1));
            dig10 = Convert.ToInt16(strTitulo.Substring(qDig - 3, 1));
            dig11 = Convert.ToInt16(strTitulo.Substring(qDig - 2, 1));
            dig12 = Convert.ToInt16(strTitulo.Substring(qDig -1, 1));

            //Cálculo para o primeiro dígito validador
            dv1 = (dig1 * 2) + (dig2 * 3) + (dig3 * 4) + (dig4 * 5) + (dig5 * 6) +
                    (dig6 * 7) + (dig7 * 8) + (dig8 * 9);
            dv1 = dv1 % 11;

            if (dv1 == 10)
            {
                dv1 = 0; //Se o resto for igual a 10, dv1 igual a zero
            }
            if (dv1 == 0 && ((dig9 == 0 && dig10 == 1) || (dig9 == 0 && dig10 == 2)))
            {
                dv1 = 1;
            }
           

            //Cálculo para o segundo dígito validador
            dv2 = (dig9 * 7) + (dig10 * 8) + (dig11 * 9);
            dv2 = dv2 % 11;

            if (dv2 == 10)
            {
                dv2 = 0; //Se o resto for igual a 10, dv1 igual a zero
            }
            
            if (dv2 == 0 && ((dig9 == 0 && dig10 == 1) || (dig9 == 0 && dig10 == 2)))
            {
                dv2 = 1;
            }
          
            //Validação dos dígitos validadores, após o cálculo realizado
            if ( (dig11 == (int)dv1) && (dig12 == (int)dv2))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Inscrição Inválida", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                inscricao_Eleitor.Focus();
                return false;
            }

        }

        private bool Verfica_Campos()
        {
            bool aux = false;
            List<TextBox> textbox = new List<TextBox>();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    textbox.Add((TextBox)item);
                }
            }

            textbox = textbox.OrderBy(x => x.TabIndex).ToList();

            foreach (TextBox item in textbox)
            {

                if (item.Name == nome_Eleitor.Name && item.TextLength == 0)
                {
                    MessageBox.Show("Preencha o campo " + '"' + "Nome" + '"' + "!",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nome_Eleitor.Focus();
                    aux = true;
                    break;
                }

                else if (item.Name == inscricao_Eleitor.Name && item.TextLength != 12)
                {
                    MessageBox.Show("Preencha o campo " + '"' + " Inscrição " + '"' + "com 12 dígitos"  + "!\nCaso o título possua menos de 12 dígitos, complete com 0 a esquerda",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inscricao_Eleitor.Focus();
                    aux = true;
                    break;
                }

                else if (item.Name == zona_Eleitor.Name && item.TextLength != 4)
                {
                    MessageBox.Show("Preencha o campo " + '"' + "Zona" + '"' + "!",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    zona_Eleitor.Focus();
                    aux = true;
                    break;
                }

                else if (item.Name == secao_Eleitor.Name && item.TextLength != 4)
                {
                    MessageBox.Show("Preencha o campo " + '"' + "Seção" + '"' + "!",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    secao_Eleitor.Focus();
                    aux = true;
                    break;
                }
            }

            return aux;
        }

        private void SomenteLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Limpar_TextBox()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)(item)).Text = String.Empty;
                }
            }
            nome_Eleitor.Focus();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            Limpar_TextBox();
            uf_Eleitor.Text = estado.estados[0].Sigla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_incluir_Click(object sender, EventArgs e)
        {
            eleitor = new Eleitor();
            lista.Carrega_Eleitor();

            if (Verfica_Campos() == false && ValidaTitulo(inscricao_Eleitor.Text)==true)
            {
                eleitor.Nome = nome_Eleitor.Text;
                eleitor.Titulo = Convert.ToInt64(inscricao_Eleitor.Text);
                eleitor.Secao = Convert.ToInt16(secao_Eleitor.Text);
                eleitor.Uf = uf_Eleitor.Text;
                eleitor.Zona = Convert.ToInt16(zona_Eleitor.Text);
                eleitor.Voto = false;

                if (lista.List_Eleitor.Count != 0)
                {
                    foreach (var item in lista.List_Eleitor)
                    {
                        if (item.Titulo == eleitor.Titulo)
                        {
                            MessageBox.Show("Eleitor já cadastrado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            achou = true;
                            break;
                        }
                    }
                    if (achou == false)
                    {
                        try
                        {
                            cadastro_Eleitor = new FileStream(caminho + "\\Eleitor.dll", FileMode.OpenOrCreate);
                            cadastro_Eleitor.Close();

                            string[] info = new string[6];
                            info[0] = eleitor.Nome;
                            info[1] = eleitor.Uf;
                            info[2] = eleitor.Secao.ToString();
                            info[3] = eleitor.Titulo.ToString();
                            info[4] = eleitor.Zona.ToString();
                            info[5] = eleitor.Voto.ToString();

                            DialogResult resultado = MessageBox.Show("Os dados informados estão corretos?", "Confirmação", MessageBoxButtons.YesNo);

                            if (resultado == DialogResult.Yes)
                            {
                                StreamWriter inserirInfo = new StreamWriter(caminho + "\\Eleitor.dll", true);
                                inserirInfo.WriteLine("{0};{1};{2};{3};{4};{5}", info[0], info[1], info[2], info[3], info[4], info[5]);
                                inserirInfo.Close();
                                MessageBox.Show("Eleitor cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                Limpar_TextBox();
                            }
                        }

                        catch
                        {
                            MessageBox.Show("Erro ao cadastrar eleitor!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                else
                {
                    try
                    {
                        cadastro_Eleitor = new FileStream(caminho + "\\Eleitor.dll", FileMode.OpenOrCreate);
                        cadastro_Eleitor.Close();

                        string[] info = new string[6];
                        info[0] = eleitor.Nome;
                        info[1] = eleitor.Uf;
                        info[2] = eleitor.Secao.ToString();
                        info[3] = eleitor.Titulo.ToString();
                        info[4] = eleitor.Zona.ToString();
                        info[5] = eleitor.Voto.ToString();

                        DialogResult resultado = MessageBox.Show("Os dados informados estão corretos?", "Confirmação", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {
                            StreamWriter inserirInfo = new StreamWriter(caminho + "\\Eleitor.dll", true);
                            inserirInfo.WriteLine("{0};{1};{2};{3};{4};{5}", info[0], info[1], info[2], info[3], info[4], info[5]);
                            inserirInfo.Close();
                            MessageBox.Show("Eleitor cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao cadastrar eleitor!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }  
        }
        
        private void inscricao_Eleitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rg_Eleitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo não aceita caracteres especiais!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void zona_Eleitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void secao_Eleitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void uf_Eleitor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void uf_Eleitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
