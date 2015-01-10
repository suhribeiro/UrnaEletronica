namespace SGE
{
    partial class Tela_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            this.menu_Principal = new System.Windows.Forms.MenuStrip();
            this.menu_Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.cad_Eleitor = new System.Windows.Forms.ToolStripMenuItem();
            this.cad_Candidato = new System.Windows.Forms.ToolStripMenuItem();
            this.cad_Partido = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta_Eleitor = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta_Candidato = new System.Windows.Forms.ToolStripMenuItem();
            this.consulta_Partido = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Relatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Gerenciar = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciar_votacao = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizar_votacao = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Principal
            // 
            this.menu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Cadastro,
            this.menu_Consulta,
            this.menu_Relatorios,
            this.menu_Gerenciar,
            this.menu_sobre});
            this.menu_Principal.Location = new System.Drawing.Point(0, 0);
            this.menu_Principal.Name = "menu_Principal";
            this.menu_Principal.Size = new System.Drawing.Size(883, 24);
            this.menu_Principal.TabIndex = 0;
            this.menu_Principal.Text = "menuStrip1";
            // 
            // menu_Cadastro
            // 
            this.menu_Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cad_Eleitor,
            this.cad_Candidato,
            this.cad_Partido});
            this.menu_Cadastro.Name = "menu_Cadastro";
            this.menu_Cadastro.Size = new System.Drawing.Size(66, 20);
            this.menu_Cadastro.Text = "Cadastro";
            // 
            // cad_Eleitor
            // 
            this.cad_Eleitor.Name = "cad_Eleitor";
            this.cad_Eleitor.Size = new System.Drawing.Size(129, 22);
            this.cad_Eleitor.Text = "Eleitor";
            this.cad_Eleitor.Click += new System.EventHandler(this.cad_Eleitor_Click);
            // 
            // cad_Candidato
            // 
            this.cad_Candidato.Name = "cad_Candidato";
            this.cad_Candidato.Size = new System.Drawing.Size(129, 22);
            this.cad_Candidato.Text = "Candidato";
            this.cad_Candidato.Click += new System.EventHandler(this.cad_Candidato_Click);
            // 
            // cad_Partido
            // 
            this.cad_Partido.Name = "cad_Partido";
            this.cad_Partido.Size = new System.Drawing.Size(129, 22);
            this.cad_Partido.Text = "Partido";
            this.cad_Partido.Click += new System.EventHandler(this.cad_Partido_Click);
            // 
            // menu_Consulta
            // 
            this.menu_Consulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulta_Eleitor,
            this.consulta_Candidato,
            this.consulta_Partido});
            this.menu_Consulta.Name = "menu_Consulta";
            this.menu_Consulta.Size = new System.Drawing.Size(66, 20);
            this.menu_Consulta.Text = "Consulta";
            // 
            // consulta_Eleitor
            // 
            this.consulta_Eleitor.Name = "consulta_Eleitor";
            this.consulta_Eleitor.Size = new System.Drawing.Size(129, 22);
            this.consulta_Eleitor.Text = "Eleitor";
            this.consulta_Eleitor.Click += new System.EventHandler(this.consulta_Eleitor_Click);
            // 
            // consulta_Candidato
            // 
            this.consulta_Candidato.Name = "consulta_Candidato";
            this.consulta_Candidato.Size = new System.Drawing.Size(129, 22);
            this.consulta_Candidato.Text = "Candidato";
            this.consulta_Candidato.Click += new System.EventHandler(this.consulta_Candidato_Click);
            // 
            // consulta_Partido
            // 
            this.consulta_Partido.Name = "consulta_Partido";
            this.consulta_Partido.Size = new System.Drawing.Size(129, 22);
            this.consulta_Partido.Text = "Partido";
            this.consulta_Partido.Click += new System.EventHandler(this.consulta_Partido_Click);
            // 
            // menu_Relatorios
            // 
            this.menu_Relatorios.Name = "menu_Relatorios";
            this.menu_Relatorios.Size = new System.Drawing.Size(71, 20);
            this.menu_Relatorios.Text = "Relatórios";
            this.menu_Relatorios.Click += new System.EventHandler(this.menu_Relatorios_Click);
            // 
            // menu_Gerenciar
            // 
            this.menu_Gerenciar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciar_votacao,
            this.finalizar_votacao});
            this.menu_Gerenciar.Name = "menu_Gerenciar";
            this.menu_Gerenciar.Size = new System.Drawing.Size(62, 20);
            this.menu_Gerenciar.Text = "Votação";
            // 
            // iniciar_votacao
            // 
            this.iniciar_votacao.Name = "iniciar_votacao";
            this.iniciar_votacao.Size = new System.Drawing.Size(163, 22);
            this.iniciar_votacao.Text = "Iniciar Votação";
            this.iniciar_votacao.Click += new System.EventHandler(this.iniciar_votacao_Click);
            // 
            // finalizar_votacao
            // 
            this.finalizar_votacao.Name = "finalizar_votacao";
            this.finalizar_votacao.Size = new System.Drawing.Size(163, 22);
            this.finalizar_votacao.Text = "Finalizar Votação";
            this.finalizar_votacao.Click += new System.EventHandler(this.finalizar_votacao_Click);
            // 
            // menu_sobre
            // 
            this.menu_sobre.Name = "menu_sobre";
            this.menu_sobre.Size = new System.Drawing.Size(49, 20);
            this.menu_sobre.Text = "Sobre";
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(883, 494);
            this.Controls.Add(this.menu_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_Principal;
            this.Name = "Tela_Principal";
            this.Text = "SGE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tela_Principal_FormClosed);
            this.menu_Principal.ResumeLayout(false);
            this.menu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menu_Principal;
        public System.Windows.Forms.ToolStripMenuItem menu_Cadastro;
        public System.Windows.Forms.ToolStripMenuItem menu_Consulta;
        public System.Windows.Forms.ToolStripMenuItem menu_Relatorios;
        public System.Windows.Forms.ToolStripMenuItem menu_Gerenciar;
        public System.Windows.Forms.ToolStripMenuItem cad_Eleitor;
        public System.Windows.Forms.ToolStripMenuItem cad_Candidato;
        public System.Windows.Forms.ToolStripMenuItem cad_Partido;
        public System.Windows.Forms.ToolStripMenuItem consulta_Eleitor;
        public System.Windows.Forms.ToolStripMenuItem consulta_Candidato;
        public System.Windows.Forms.ToolStripMenuItem consulta_Partido;
        public System.Windows.Forms.ToolStripMenuItem iniciar_votacao;
        public System.Windows.Forms.ToolStripMenuItem finalizar_votacao;
        public System.Windows.Forms.ToolStripMenuItem menu_sobre;
    }
}