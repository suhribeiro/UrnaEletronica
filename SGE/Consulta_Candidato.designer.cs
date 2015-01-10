namespace SGE
{
    partial class Consulta_Candidato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Candidato));
            this.cargos = new System.Windows.Forms.ComboBox();
            this.uf_Lista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.consulta = new System.Windows.Forms.Button();
            this.edita = new System.Windows.Forms.Button();
            this.exclue = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.partidos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cargos
            // 
            this.cargos.FormattingEnabled = true;
            this.cargos.Items.AddRange(new object[] {
            "Deputado Estadual",
            "Deputado Federal",
            "Senador",
            "Governador",
            "Presidente"});
            this.cargos.Location = new System.Drawing.Point(87, 17);
            this.cargos.Name = "cargos";
            this.cargos.Size = new System.Drawing.Size(159, 21);
            this.cargos.TabIndex = 1;
            this.cargos.SelectedIndexChanged += new System.EventHandler(this.cargos_SelectedIndexChanged);
            this.cargos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combobox_KeyDown);
            this.cargos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combobox_KeyPress);
            // 
            // uf_Lista
            // 
            this.uf_Lista.FormattingEnabled = true;
            this.uf_Lista.Location = new System.Drawing.Point(197, 58);
            this.uf_Lista.Name = "uf_Lista";
            this.uf_Lista.Size = new System.Drawing.Size(49, 21);
            this.uf_Lista.TabIndex = 2;
            this.uf_Lista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combobox_KeyDown);
            this.uf_Lista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combobox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "UF";
            // 
            // consulta
            // 
            this.consulta.Location = new System.Drawing.Point(262, 40);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(75, 20);
            this.consulta.TabIndex = 4;
            this.consulta.Text = "Buscar";
            this.consulta.UseVisualStyleBackColor = true;
            this.consulta.Click += new System.EventHandler(this.consulta_Click);
            // 
            // edita
            // 
            this.edita.Location = new System.Drawing.Point(180, 278);
            this.edita.Name = "edita";
            this.edita.Size = new System.Drawing.Size(75, 20);
            this.edita.TabIndex = 4;
            this.edita.Text = "Editar";
            this.edita.UseVisualStyleBackColor = true;
            this.edita.Click += new System.EventHandler(this.edita_Click);
            // 
            // exclue
            // 
            this.exclue.Location = new System.Drawing.Point(261, 278);
            this.exclue.Name = "exclue";
            this.exclue.Size = new System.Drawing.Size(75, 20);
            this.exclue.TabIndex = 4;
            this.exclue.Text = "Excluir";
            this.exclue.UseVisualStyleBackColor = true;
            this.exclue.Click += new System.EventHandler(this.exclue_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(342, 278);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 20);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(152, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 147);
            this.listBox1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Partido";
            // 
            // partidos
            // 
            this.partidos.FormattingEnabled = true;
            this.partidos.Location = new System.Drawing.Point(87, 58);
            this.partidos.Name = "partidos";
            this.partidos.Size = new System.Drawing.Size(73, 21);
            this.partidos.TabIndex = 2;
            this.partidos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combobox_KeyDown);
            this.partidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combobox_KeyPress);
            // 
            // Consulta_Candidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 310);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.exclue);
            this.Controls.Add(this.edita);
            this.Controls.Add(this.consulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partidos);
            this.Controls.Add(this.uf_Lista);
            this.Controls.Add(this.cargos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consulta_Candidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Candidato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cargos;
        private System.Windows.Forms.ComboBox uf_Lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button consulta;
        private System.Windows.Forms.Button edita;
        private System.Windows.Forms.Button exclue;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox partidos;
    }
}