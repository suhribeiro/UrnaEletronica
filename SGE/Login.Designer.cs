namespace SGE
{
    public partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.campo_usuario = new System.Windows.Forms.TextBox();
            this.campo_senha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Entra = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campo_usuario
            // 
            this.campo_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.campo_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.campo_usuario.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campo_usuario.Location = new System.Drawing.Point(46, 296);
            this.campo_usuario.Name = "campo_usuario";
            this.campo_usuario.Size = new System.Drawing.Size(255, 20);
            this.campo_usuario.TabIndex = 0;
            this.campo_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // campo_senha
            // 
            this.campo_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.campo_senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.campo_senha.Location = new System.Drawing.Point(46, 387);
            this.campo_senha.Name = "campo_senha";
            this.campo_senha.PasswordChar = '●';
            this.campo_senha.Size = new System.Drawing.Size(255, 20);
            this.campo_senha.TabIndex = 1;
            this.campo_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(43, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 26);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(43, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 26);
            this.panel2.TabIndex = 1;
            // 
            // bt_Entra
            // 
            this.bt_Entra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Entra.BackgroundImage")));
            this.bt_Entra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Entra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Entra.Location = new System.Drawing.Point(77, 464);
            this.bt_Entra.Name = "bt_Entra";
            this.bt_Entra.Size = new System.Drawing.Size(89, 23);
            this.bt_Entra.TabIndex = 2;
            this.bt_Entra.UseVisualStyleBackColor = true;
            this.bt_Entra.Click += new System.EventHandler(this.bt_Entra_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(75, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 27);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(174, 462);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(93, 27);
            this.panel4.TabIndex = 1;
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Sair.BackgroundImage")));
            this.bt_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Sair.Location = new System.Drawing.Point(176, 464);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(89, 23);
            this.bt_Sair.TabIndex = 3;
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 578);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.bt_Entra);
            this.Controls.Add(this.campo_senha);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.campo_usuario);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campo_usuario;
        private System.Windows.Forms.TextBox campo_senha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Entra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bt_Sair;
    }
}