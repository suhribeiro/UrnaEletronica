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
    public partial class Login : Form
    {
        Tela_Principal principal;

        public Login()
        {
            InitializeComponent();
        }

        private void bt_Entra_Click(object sender, EventArgs e)
        {
            if ((campo_usuario.Text == "ADMIN") && (campo_senha.Text == "ADMIN"))
            {
                if (Application.OpenForms["Tela_Principal"] == null)
                {
                    StreamReader eleicao = new StreamReader(Directory.GetCurrentDirectory() + "\\Cadastros\\Sistema.dll");

                    bool linha;

                    linha = Convert.ToBoolean(eleicao.ReadLine());

                    if (linha == false)
                    {
                        principal = new Tela_Principal();
                        principal.TopLevel = true;
                        principal.menu_Gerenciar.Enabled = false;
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Votação em adamento!\nEsse módulo só estará disponível após o fim das eleições!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }

            else if ((campo_usuario.Text == "PRESIDENTEDASECAO") && (campo_senha.Text == "123"))
            {
                if (Application.OpenForms["Tela_Principal"] == null)
                {
                    principal = new Tela_Principal();
                    principal.TopLevel = true;
                    principal.menu_Cadastro.Enabled = false;
                    principal.menu_Consulta.Enabled = false;
                    principal.menu_Relatorios.Enabled = false;
                    principal.Show();
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("Usuário ou senha Inválidos!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
