namespace Matventura
{
    partial class cst_messagebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cst_messagebox));
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblConectare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMesaj
            // 
            this.lblMesaj.BackColor = System.Drawing.Color.Transparent;
            this.lblMesaj.Font = new System.Drawing.Font("Rockwell", 18.65F);
            this.lblMesaj.Location = new System.Drawing.Point(49, 27);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(522, 149);
            this.lblMesaj.TabIndex = 1;
            this.lblMesaj.Text = "MESAJ MESAJ MESAJ MESAJ MESAJ MESAJ ";
            // 
            // lblConectare
            // 
            this.lblConectare.AutoSize = true;
            this.lblConectare.BackColor = System.Drawing.Color.Transparent;
            this.lblConectare.Font = new System.Drawing.Font("Rockwell", 18.65F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lblConectare.Location = new System.Drawing.Point(265, 196);
            this.lblConectare.Name = "lblConectare";
            this.lblConectare.Size = new System.Drawing.Size(57, 31);
            this.lblConectare.TabIndex = 3;
            this.lblConectare.Text = "Ok.";
            this.lblConectare.Click += new System.EventHandler(this.lblConectare_Click);
            this.lblConectare.MouseEnter += new System.EventHandler(this.lblConectare_MouseEnter);
            this.lblConectare.MouseLeave += new System.EventHandler(this.lblConectare_MouseLeave);
            this.lblConectare.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblConectare_MouseMove);
            // 
            // cst_messagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 245);
            this.Controls.Add(this.lblConectare);
            this.Controls.Add(this.lblMesaj);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cst_messagebox";
            this.Text = "cst_messagebox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConectare;
        public System.Windows.Forms.Label lblMesaj;
    }
}