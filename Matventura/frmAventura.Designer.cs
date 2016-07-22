namespace Ukwenza
{
    partial class frmAventura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAventura));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblLectii = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18.65F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(120, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Incepe Aventura Principala";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.lblConectare_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.lblConectare_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblConectare_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18.65F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(120, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Continua Aventura Principala";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.lblConectare_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.lblConectare_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblConectare_MouseMove);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.BackColor = System.Drawing.Color.Transparent;
            this.lblEdit.Font = new System.Drawing.Font("Rockwell", 18.65F, System.Drawing.FontStyle.Underline);
            this.lblEdit.Location = new System.Drawing.Point(120, 354);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(392, 29);
            this.lblEdit.TabIndex = 4;
            this.lblEdit.Text = "Administrare Aventura Principala";
            this.lblEdit.Visible = false;
            this.lblEdit.Click += new System.EventHandler(this.label4_Click);
            this.lblEdit.MouseEnter += new System.EventHandler(this.lblConectare_MouseEnter);
            this.lblEdit.MouseLeave += new System.EventHandler(this.lblConectare_MouseLeave);
            this.lblEdit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblConectare_MouseMove);
            // 
            // lblLectii
            // 
            this.lblLectii.AutoSize = true;
            this.lblLectii.BackColor = System.Drawing.Color.Transparent;
            this.lblLectii.Font = new System.Drawing.Font("Rockwell", 18.65F, System.Drawing.FontStyle.Underline);
            this.lblLectii.Location = new System.Drawing.Point(120, 253);
            this.lblLectii.Name = "lblLectii";
            this.lblLectii.Size = new System.Drawing.Size(348, 29);
            this.lblLectii.TabIndex = 4;
            this.lblLectii.Text = "Lectii din Aventura Principala";
            this.lblLectii.Click += new System.EventHandler(this.lblLectii_Click);
            this.lblLectii.MouseEnter += new System.EventHandler(this.lblConectare_MouseEnter);
            this.lblLectii.MouseLeave += new System.EventHandler(this.lblConectare_MouseLeave);
            this.lblLectii.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblConectare_MouseMove);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(531, 25);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(59, 47);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 26;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // frmAventura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 446);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblLectii);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAventura";
            this.Text = "frmAventura";
            this.Load += new System.EventHandler(this.frmAventura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblLectii;
        private System.Windows.Forms.PictureBox pbClose;
    }
}