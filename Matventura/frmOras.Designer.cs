namespace Ukwenza
{
    partial class frmOras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOras));
            this.lblStatuie = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatuie
            // 
            this.lblStatuie.BackColor = System.Drawing.Color.Transparent;
            this.lblStatuie.Location = new System.Drawing.Point(148, 73);
            this.lblStatuie.Name = "lblStatuie";
            this.lblStatuie.Size = new System.Drawing.Size(180, 456);
            this.lblStatuie.TabIndex = 2;
            this.lblStatuie.Click += new System.EventHandler(this.lblStatuie_Click);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Image = ((System.Drawing.Image)(resources.GetObject("lblExit.Image")));
            this.lblExit.Location = new System.Drawing.Point(369, 573);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(56, 55);
            this.lblExit.TabIndex = 3;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblUp
            // 
            this.lblUp.BackColor = System.Drawing.Color.Transparent;
            this.lblUp.Image = ((System.Drawing.Image)(resources.GetObject("lblUp.Image")));
            this.lblUp.Location = new System.Drawing.Point(654, 425);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(56, 55);
            this.lblUp.TabIndex = 4;
            this.lblUp.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmOras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 637);
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblStatuie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOras";
            this.Load += new System.EventHandler(this.frmOras_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOras_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblStatuie;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblUp;
    }
}