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
    public partial class Tela_FInaliza_Votacao : Form
    {
        /*Construtor da classe*/
        public Tela_FInaliza_Votacao()
        {
            InitializeComponent();
        }

        /*Evento acionado ao clicar no botão "Finalizar votação"
         *Abre a tela para autenticação do usuário
         *Se estiver correto, finaliza.
         */
        private void finaliza_Click(object sender, EventArgs e)
        {
            if (senha.TextLength > 0)
            {
                if (senha.Text == "123")
                {
                    StreamWriter eleicao = new StreamWriter(Directory.GetCurrentDirectory() + "\\Cadastros\\Sistema.dll");

                    eleicao.Write(false);

                    eleicao.Close();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha Inválidos!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Insira a senha!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
