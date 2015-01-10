namespace SGE
{
    partial class Consulta_Partido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Partido));
            this.lb_siglaPartido = new System.Windows.Forms.Label();
            this.num_Partido = new System.Windows.Forms.TextBox();
            this.sigla_Partido = new System.Windows.Forms.TextBox();
            this.nome_Partido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_partidos = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.tb_sigla = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_siglaPartido
            // 
            this.lb_siglaPartido.AutoSize = true;
            this.lb_siglaPartido.Location = new System.Drawing.Point(199, 15);
            this.lb_siglaPartido.Name = "lb_siglaPartido";
            this.lb_siglaPartido.Size = new System.Drawing.Size(30, 13);
            this.lb_siglaPartido.TabIndex = 3;
            this.lb_siglaPartido.Text = "Sigla";
            // 
            // num_Partido
            // 
            this.num_Partido.Location = new System.Drawing.Point(54, 159);
            this.num_Partido.MaxLength = 2;
            this.num_Partido.Name = "num_Partido";
            this.num_Partido.Size = new System.Drawing.Size(31, 20);
            this.num_Partido.TabIndex = 2;
            // 
            // sigla_Partido
            // 
            this.sigla_Partido.Location = new System.Drawing.Point(54, 104);
            this.sigla_Partido.Name = "sigla_Partido";
            this.sigla_Partido.Size = new System.Drawing.Size(72, 20);
            this.sigla_Partido.TabIndex = 1;
            // 
            // nome_Partido
            // 
            this.nome_Partido.Location = new System.Drawing.Point(54, 48);
            this.nome_Partido.Name = "nome_Partido";
            this.nome_Partido.Size = new System.Drawing.Size(338, 20);
            this.nome_Partido.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sigla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // cb_partidos
            // 
            this.cb_partidos.FormattingEnabled = true;
            this.cb_partidos.Location = new System.Drawing.Point(235, 12);
            this.cb_partidos.Name = "cb_partidos";
            this.cb_partidos.Size = new System.Drawing.Size(121, 21);
            this.cb_partidos.TabIndex = 4;
            this.cb_partidos.SelectedIndexChanged += new System.EventHandler(this.cb_partidos_SelectedIndexChanged);
            this.cb_partidos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_partidos_KeyDown);
            this.cb_partidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_partidos_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_salvar);
            this.panel1.Controls.Add(this.bt_cancelar);
            this.panel1.Controls.Add(this.bt_excluir);
            this.panel1.Controls.Add(this.bt_editar);
            this.panel1.Controls.Add(this.tb_num);
            this.panel1.Controls.Add(this.tb_sigla);
            this.panel1.Controls.Add(this.tb_nome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 226);
            this.panel1.TabIndex = 8;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(118, 188);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 12;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(361, 188);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 11;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Enabled = false;
            this.bt_excluir.Location = new System.Drawing.Point(280, 188);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_excluir.TabIndex = 10;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(199, 188);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 9;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // tb_num
            // 
            this.tb_num.Enabled = false;
            this.tb_num.Location = new System.Drawing.Point(53, 151);
            this.tb_num.MaxLength = 2;
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(31, 20);
            this.tb_num.TabIndex = 8;
            this.tb_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_num_KeyPress);
            // 
            // tb_sigla
            // 
            this.tb_sigla.Enabled = false;
            this.tb_sigla.Location = new System.Drawing.Point(53, 96);
            this.tb_sigla.Name = "tb_sigla";
            this.tb_sigla.Size = new System.Drawing.Size(72, 20);
            this.tb_sigla.TabIndex = 7;
            this.tb_sigla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_sigla_KeyPress);
            // 
            // tb_nome
            // 
            this.tb_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(53, 40);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(338, 20);
            this.tb_nome.TabIndex = 3;
            this.tb_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nome_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sigla";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nome";
            // 
            // Consulta_Partido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_partidos);
            this.Controls.Add(this.lb_siglaPartido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consulta_Partido";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Partido";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_siglaPartido;
        private System.Windows.Forms.TextBox num_Partido;
        private System.Windows.Forms.TextBox sigla_Partido;
        private System.Windows.Forms.TextBox nome_Partido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_partidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tb_sigla;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_salvar;
    }
}