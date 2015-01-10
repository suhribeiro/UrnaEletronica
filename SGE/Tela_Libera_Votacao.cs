using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE
{
    public partial class Tela_Libera_Votacao : Form
    {
        Listas lista = new Listas();
        Eleitor eleitor = new Eleitor();
        Urna urna;

        public Tela_Libera_Votacao()
        {
            InitializeComponent();
        }

        private bool Verifica_Campo()
        {
            bool aux = false;

                if (insere_Inscricao.Text.Length!=12)
                {
                    MessageBox.Show("Preencha o campo " + '"' + " Inscrição " + '"' + "com 12 dígitos" + "!\nCaso o título não possua 12 dígitos, complete com 0 a esquerda",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    insere_Inscricao.Focus();
                    aux = true;
                }
            return aux;
        }

        public void Modifica_Voto (string titulo)
        {
            Eleitor aux = new Eleitor();
            lista.Carrega_Eleitor();

            foreach (var item in lista.List_Eleitor)
            {
                if (item.Titulo.ToString() == titulo)
                {
                    item.Voto = true;
                    aux = item;
                    lista.Carrega_Eleitor(aux);
                    break;
                }
            }
        }

        public bool Verifica_Voto (string titulo)
        {
            lista.Carrega_Eleitor();

            foreach (var item in lista.List_Eleitor)
            {
                if (item.Titulo.ToString() == titulo)
                {
                    if (item.Voto == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ValidaTitulo(string titulo)
        {


            int dig1; int dig2; int dig3; int dig4; int dig5; int dig6;
            int dig7; int dig8; int dig9; int dig10; int dig11;
            int dig12; int dv1; int dv2; int qDig;

            if (titulo.Length == 0) //Validação do preenchimento
            {
                return false; //Caso não seja informado o Título
            }
            else
            {
                if (titulo.Length < 12)
                {
                    return false;
                }
                else if (titulo.Length > 12)
                {
                    return false;
                }
            }

            qDig = titulo.Length; //Total de caracteres


            //Gravar posição dos caracteres
            dig1 = Convert.ToInt16(titulo.Substring(qDig - 12, 1));
            dig2 = Convert.ToInt16(titulo.Substring(qDig - 11, 1));
            dig3 = Convert.ToInt16(titulo.Substring(qDig - 10, 1));
            dig4 = Convert.ToInt16(titulo.Substring(qDig - 9, 1));
            dig5 = Convert.ToInt16(titulo.Substring(qDig - 8, 1));
            dig6 = Convert.ToInt16(titulo.Substring(qDig - 7, 1));
            dig7 = Convert.ToInt16(titulo.Substring(qDig - 6, 1));
            dig8 = Convert.ToInt16(titulo.Substring(qDig - 5, 1));
            dig9 = Convert.ToInt16(titulo.Substring(qDig - 4, 1));
            dig10 = Convert.ToInt16(titulo.Substring(qDig - 3, 1));
            dig11 = Convert.ToInt16(titulo.Substring(qDig - 2, 1));
            dig12 = Convert.ToInt16(titulo.Substring(qDig - 1, 1));

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
            dv2 = (dig9 * 7) + (dig10 * 8) + (dv1 * 9);
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
            if (dig11 == dv1 && dig12 == dv2)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Inscrição Inválida", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                insere_Inscricao.Focus();
                return false;
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
            insere_Inscricao.Focus();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            Limpar_TextBox();
        }

        private void insere_Inscricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas números!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Liberar_Click(object sender, EventArgs e)
        {
            if (Verifica_Campo() == false)
            {
                if (ValidaTitulo(insere_Inscricao.Text) == true)
                {
                    if (Verifica_Voto(insere_Inscricao.Text) == false)
                    {
                        urna = new Urna(insere_Inscricao.Text.Substring(12 - 4, 2), insere_Inscricao.Text);
                        urna.TopLevel = true;
                        urna.Show();
                    }
                    else
                    {
                        MessageBox.Show("Esse eleitor já votou", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        insere_Inscricao.Clear();
                    }
                }
            }
        }
    }
}
