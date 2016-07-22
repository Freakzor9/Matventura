namespace Ukwenza
{
    partial class frmTurn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurn));
            this.lblIntrare = new System.Windows.Forms.Label();
            this.lblTxt = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblTurnE = new System.Windows.Forms.Label();
            this.pbMagnus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagnus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntrare
            // 
            this.lblIntrare.BackColor = System.Drawing.Color.Transparent;
            this.lblIntrare.Location = new System.Drawing.Point(199, 461);
            this.lblIntrare.Name = "lblIntrare";
            this.lblIntrare.Size = new System.Drawing.Size(38, 53);
            this.lblIntrare.TabIndex = 0;
            this.lblIntrare.Click += new System.EventHandler(this.lblIntrare_Click);
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblTxt.Font = new System.Drawing.Font("Rockwell", 18.65F);
            this.lblTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTxt.Location = new System.Drawing.Point(112, 329);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(181, 29);
            this.lblTxt.TabIndex = 5;
            this.lblTxt.Text = "Intrarea in turn";
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Image = ((System.Drawing.Image)(resources.GetObject("lblExit.Image")));
            this.lblExit.Location = new System.Drawing.Point(55, 564);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(56, 55);
            this.lblExit.TabIndex = 6;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblTurnE
            // 
            this.lblTurnE.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnE.Image = ((System.Drawing.Image)(resources.GetObject("lblTurnE.Image")));
            this.lblTurnE.Location = new System.Drawing.Point(343, 576);
            this.lblTurnE.Name = "lblTurnE";
            this.lblTurnE.Size = new System.Drawing.Size(56, 55);
            this.lblTurnE.TabIndex = 6;
            this.lblTurnE.Visible = false;
            this.lblTurnE.Click += new System.EventHandler(this.lblTurnE_Click);
            // 
            // pbMagnus
            // 
            this.pbMagnus.BackColor = System.Drawing.Color.Transparent;
            this.pbMagnus.Image = ((System.Drawing.Image)(resources.GetObject("pbMagnus.Image")));
            this.pbMagnus.Location = new System.Drawing.Point(299, 219);
            this.pbMagnus.Name = "pbMagnus";
            this.pbMagnus.Size = new System.Drawing.Size(191, 329);
            this.pbMagnus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMagnus.TabIndex = 7;
            this.pbMagnus.TabStop = false;
            this.pbMagnus.Visible = false;
            this.pbMagnus.Click += new System.EventHandler(this.pbMagnus_Click);
            // 
            // frmTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 640);
            this.Controls.Add(this.pbMagnus);
            this.Controls.Add(this.lblTurnE);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.lblIntrare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTurn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lblTurn";
            this.Load += new System.EventHandler(this.frmTurn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMagnus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntrare;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTurnE;
        private System.Windows.Forms.PictureBox pbMagnus;
    }
}