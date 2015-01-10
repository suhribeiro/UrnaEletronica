namespace SGE
{
    partial class Relatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorios));
            this.cargos = new System.Windows.Forms.ComboBox();
            this.ufs = new System.Windows.Forms.ComboBox();
            this.gerar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.cargos.Location = new System.Drawing.Point(63, 44);
            this.cargos.Name = "cargos";
            this.cargos.Size = new System.Drawing.Size(164, 21);
            this.cargos.TabIndex = 0;
            this.cargos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cargos_KeyDown);
            this.cargos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cargos_KeyPress);
            // 
            // ufs
            // 
            this.ufs.FormattingEnabled = true;
            this.ufs.Location = new System.Drawing.Point(288, 44);
            this.ufs.Name = "ufs";
            this.ufs.Size = new System.Drawing.Size(121, 21);
            this.ufs.TabIndex = 0;
            this.ufs.SelectedIndexChanged += new System.EventHandler(this.ufs_SelectedIndexChanged);
            this.ufs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cargos_KeyDown);
            this.ufs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cargos_KeyPress);
            // 
            // gerar
            // 
            this.gerar.Location = new System.Drawing.Point(148, 150);
            this.gerar.Name = "gerar";
            this.gerar.Size = new System.Drawing.Size(75, 21);
            this.gerar.TabIndex = 1;
            this.gerar.Text = "Gerar";
            this.gerar.UseVisualStyleBackColor = true;
            this.gerar.Click += new System.EventHandler(this.gerar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(229, 150);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 21);
            this.cancelar.TabIndex = 1;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "UF";
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.gerar);
            this.Controls.Add(this.ufs);
            this.Controls.Add(this.cargos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cargos;
        private System.Windows.Forms.ComboBox ufs;
        private System.Windows.Forms.Button gerar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}