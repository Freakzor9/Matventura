namespace Ukwenza
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.label1 = new System.Windows.Forms.Label();
            this.panelJoc = new System.Windows.Forms.Panel();
            this.lblAbandon = new System.Windows.Forms.Label();
            this.lblProfil = new System.Windows.Forms.Label();
            this.lblAlege = new System.Windows.Forms.Label();
            this.lblIncepe = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblCont = new System.Windows.Forms.Label();
            this.lblIesire = new System.Windows.Forms.Label();
            this.lblConectare = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelJoc.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matventura";
            // 
            // panelJoc
            // 
            this.panelJoc.BackColor = System.Drawing.Color.Transparent;
            this.panelJoc.Controls.Add(this.lblAbandon);
            this.panelJoc.Controls.Add(this.lblProfil);
            this.panelJoc.Controls.Add(this.lblAlege);
            this.panelJoc.Controls.Add(this.lblIncepe);
            this.panelJoc.Location = new System.Drawing.Point(22, 57);
            this.panelJoc.Name = "panelJoc";
            this.panelJoc.Size = new System.Drawing.Size(561, 360);
            this.panelJoc.TabIndex = 2;
            this.panelJoc.Visible = false;
            // 
            // lblAbandon
            // 
            this.lblAbandon.AutoSize = true;
            this.lblAbandon.Font = new System.Drawing.Font("Rockwell", 18.65F, System.Drawing.FontStyle.Underline);
            this.lblAbandon.Location = new System.Drawing.Point(152, 283);
            this.lblAbandon.Name = "lblAbandon";
            this.lblAbandon.Size = new System.Drawing.Size(295, 29);
            this.lblAbandon.TabIndex = 0;
            this.lblAbandon.Text = "Abandoneaza aventura...";
            this.lblAbandon.Click += new System.EventHandler(this.lblAbandon_Click);
            this.lblAbandon.MouseEnter += new System.EventHandler(this.lblConectare_MouseEnter);
            this.lblAbandon.MouseLeave += new System.EventHandler(this.lblConectare_MouseLeave);
            this.lblAbandon.MouseHover += new System.EventHandler(this.lblConectare_MouseHover);
            this.lblAbandon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblConectare_MouseMove);
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Font = new System.Drawing.Font("Rockwell", 18.65F, System.Drawing.FontStyle.Underline);
            this.lblProfil.Location = new System.Drawing.Point(190, 209);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(177, 29);
            this.lblProfil.TabIndex = 0;
            this.lblProfil.Text = "Profil utilizator";
            this.lblProfil.Click += new System.EventHandler(this.label4_Click);
            this.lblProfil.MouseEnter += new System.EventHandler(this.lblConectare_MouseEnter);
            this.lblProfil.MouseLeave += new System.EventHandler(this.lblConectare_MouseLeave);
            this.lblProfil.MouseHover += new System.EventHandler(this.lblConectare_MouseHover);
            this.lblProfil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblConectare_MouseMove);
            // 
            // lblAlege
            // 
            this.lblAlege.AutoSize = true;
            this.lblAlege.Font = new System.Drawing.Font("Rockwell", 18.65F, System.Drawing.FontStyle.Underline);
            this.lblAlege.Location = new System.Drawing.Point(180, 137);
            this.lblAlege.Name = "lblAlege";
            this.lblAlege.Size = new System.Drawing.Size(187, 29);
            this.lblAlege.TabIndex = 0;
            this.lblAlege.Text = "Alege aventura";
            this.lblAlege.Click += new System.EventHandler(this.lblAlege_Click);
            this.lblAlege.MouseEnter += new System.EventHandler(this.lblConectare_MouseEnter);
            this.lblAlege.MouseLeave += new System.EventHandler(this.lblConectare_MouseLeave);
            this.lblAlege.MouseHover += new System.EventHandler(this.lblConectare_MouseHover);
            this.lblAlege.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblConectare_MouseMove);
            // 
            // lblIncepe
            // 
            this.lblIncepe.AutoSize = true;
            this.lblIncepe.Font = new System.Drawing.Font("Rockwell", 18.65F, System.Drawing.FontStyle.Underline);
            this.lblIncepe.Location = new System.Drawing.Point(176, 63);
            this.lblIncepe.Name = "lblIncepe";
            this.lblIncepe.Size = new System.Drawing.Size(197, 29);
            this.lblIncepe.TabIndex = 0;
            this.lblIncepe.Text = "Incepe aventura";
            this.lblIncepe.Click += new System.EventHandler(this.lblIncepe_Click);
            this.lblIncepe.MouseEnter += new System.EventHandler(this.lblConectare_MouseEnter);
            this.lblIncepe.MouseLeave += new System.EventHandler(this.lblConectare_MouseLeave);
            this.lblIncepe.MouseHover += new System.EventHandler(this.lblConectare_MouseHover);
            this.lblIncepe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblConectare_MouseMove);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.lblCont);
            this.panelLogin.Controls.Add(this.lblIesire);
            this.panelLogin.Controls.Add(this.lblConectare);
            this.panelLogin.Controls.Add(this.txtParola);
            this.panelLogin.Controls.Add(this.txtNume);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Location = new System.Drawing.Point(478, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(564, 363);
            this.panelLogin.TabIndex = 3;
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Font = new System.Drawing.Font("Rockwell", 18.65F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lblCont.Location = new System.Drawing.Point(13, 308);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(125, 31);
            this.lblCont.TabIndex = 2;
            this.lblCont.Text = "Cont Nou";
            this.lblCont.Click += new System.EventHandler(this.lblCont_Click);
            this.lblCont.MouseLeave += new System.EventHandler(this.lblConectare_MouseLeave);
            this.lblCont.MouseHover += new System.EventHandler(this.lblConectare_MouseHover);
            this.lblCont.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblConectare_MouseMove);
            // 
            // lblIesire
            // 
            this.lblIesire.AutoSize = true;
            this.lblIesire.Font = new System.Drawing.Font("Rockwell", 18.65F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lblIesire.Location = new System.Drawing.Point(400, 308);
            this.lblIesire.Name = "lblIesire";
            this.lblIesire.Size = new System.Drawing.Size(82, 31);
            this.lblIesire.TabIndex = 2;
            this.lblIesire.Text = "Iesire";
            this.lblIesire.Click += new System.EventHandler(this.lblIesire_Click);
            this.lblIesire.MouseLeave += new System.EventHandler(this.lblConectare_MouseLeave);
            this.lblIesire.MouseHover += new System.EventHandler(this.lblConectare_MouseHover);
            this.lblIesire.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblConectare_MouseMove);
            // 
            // lblConectare
            // 
            this.lblConectare.AutoSize = true;
            this.lblConectare.Font = new System.Drawing.Font("Rockwell", 18.65F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lblConectare.Location = new System.Drawing.Point(197, 254);
            this.lblConectare.Name = "lblConectare";
            this.lblConectare.Size = new System.Drawing.Size(135, 31);
            this.lblConectare.TabIndex = 2;
            this.lblConectare.Text = "Conectare";
            this.lblConectare.Click += new System.EventHandler(this.lblConectare_Click);
            this.lblConectare.MouseEnter += new System.EventHandler(this.lblConectare_MouseEnter);
            this.lblConectare.MouseLeave += new System.EventHandler(this.lblConectare_MouseLeave);
            this.lblConectare.MouseHover += new System.EventHandler(this.lblConectare_MouseHover);
            this.lblConectare.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblConectare_MouseMove);
            // 
            // txtParola
            // 
            this.txtParola.BackColor = System.Drawing.Color.BurlyWood;
            this.txtParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParola.Font = new System.Drawing.Font("Rockwell", 10.45F);
            this.txtParola.Location = new System.Drawing.Point(238, 166);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(211, 24);
            this.txtParola.TabIndex = 1;
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.Color.BurlyWood;
            this.txtNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNume.Font = new System.Drawing.Font("Rockwell", 10.45F);
            this.txtNume.Location = new System.Drawing.Point(238, 95);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(211, 24);
            this.txtNume.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18.65F);
            this.label3.Location = new System.Drawing.Point(43, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18.65F);
            this.label2.Location = new System.Drawing.Point(43, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nume Utilizator";
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 468);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelJoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelJoc.ResumeLayout(false);
            this.panelJoc.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelJoc;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIncepe;
        private System.Windows.Forms.Label lblAbandon;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.Label lblAlege;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Label lblIesire;
        private System.Windows.Forms.Label lblConectare;
    }
}

