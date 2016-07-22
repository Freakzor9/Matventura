namespace Ukwenza
{
    partial class frmCampanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCampanie));
            this.pnlInceput = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblOras1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumeTurn = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblSat = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lblContinua = new System.Windows.Forms.Label();
            this.pnlInceput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInceput
            // 
            this.pnlInceput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlInceput.BackgroundImage")));
            this.pnlInceput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInceput.Controls.Add(this.label1);
            this.pnlInceput.Controls.Add(this.lblIntro);
            this.pnlInceput.Location = new System.Drawing.Point(12, 694);
            this.pnlInceput.Name = "pnlInceput";
            this.pnlInceput.Size = new System.Drawing.Size(818, 653);
            this.pnlInceput.TabIndex = 1;
            this.pnlInceput.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Incepe lupta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIntro
            // 
            this.lblIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro.Font = new System.Drawing.Font("Rockwell", 18.65F);
            this.lblIntro.Location = new System.Drawing.Point(199, 96);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(526, 312);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = resources.GetString("lblIntro.Text");
            // 
            // lblOras1
            // 
            this.lblOras1.BackColor = System.Drawing.Color.Transparent;
            this.lblOras1.Location = new System.Drawing.Point(795, 429);
            this.lblOras1.Name = "lblOras1";
            this.lblOras1.Size = new System.Drawing.Size(37, 33);
            this.lblOras1.TabIndex = 2;
            this.lblOras1.Click += new System.EventHandler(this.lblOras_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 16F);
            this.label2.Location = new System.Drawing.Point(765, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "1.Bazatonia";
            // 
            // lblNumeTurn
            // 
            this.lblNumeTurn.AutoSize = true;
            this.lblNumeTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeTurn.Font = new System.Drawing.Font("Rockwell", 16F);
            this.lblNumeTurn.Location = new System.Drawing.Point(793, 492);
            this.lblNumeTurn.Name = "lblNumeTurn";
            this.lblNumeTurn.Size = new System.Drawing.Size(113, 25);
            this.lblNumeTurn.TabIndex = 3;
            this.lblNumeTurn.Text = "2.Turnul F";
            this.lblNumeTurn.Visible = false;
            // 
            // lblTurn
            // 
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Location = new System.Drawing.Point(735, 567);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(37, 33);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Visible = false;
            this.lblTurn.Click += new System.EventHandler(this.lblTurn_Click);
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.BackColor = System.Drawing.Color.Transparent;
            this.lblSat.Font = new System.Drawing.Font("Rockwell", 16F);
            this.lblSat.Location = new System.Drawing.Point(322, 529);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(162, 25);
            this.lblSat.TabIndex = 3;
            this.lblSat.Text = "3.Satul functias";
            this.lblSat.Visible = false;
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(880, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(59, 47);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 4;
            this.pbClose.TabStop = false;
            this.pbClose.Visible = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lblContinua
            // 
            this.lblContinua.AutoSize = true;
            this.lblContinua.BackColor = System.Drawing.Color.Transparent;
            this.lblContinua.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Underline);
            this.lblContinua.ForeColor = System.Drawing.Color.DarkRed;
            this.lblContinua.Image = ((System.Drawing.Image)(resources.GetObject("lblContinua.Image")));
            this.lblContinua.Location = new System.Drawing.Point(30, 657);
            this.lblContinua.Name = "lblContinua";
            this.lblContinua.Size = new System.Drawing.Size(204, 25);
            this.lblContinua.TabIndex = 5;
            this.lblContinua.Text = "Continua Aventura";
            this.lblContinua.Visible = false;
            this.lblContinua.Click += new System.EventHandler(this.lblContinua_Click);
            // 
            // frmCampanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 716);
            this.Controls.Add(this.lblContinua);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblOras1);
            this.Controls.Add(this.pnlInceput);
            this.Controls.Add(this.lblSat);
            this.Controls.Add(this.lblNumeTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTurn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCampanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCampanie";
            this.Load += new System.EventHandler(this.frmCampanie_Load);
            this.pnlInceput.ResumeLayout(false);
            this.pnlInceput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlInceput;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOras1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumeTurn;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lblContinua;
    }
}