namespace Matventura
{
    partial class frmLectii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLectii));
            this.txtLectie = new System.Windows.Forms.TextBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.txtExercitii = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstLectie = new System.Windows.Forms.ListBox();
            this.lstExercitii = new System.Windows.Forms.ListBox();
            this.lstID = new System.Windows.Forms.ListBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTitlu = new System.Windows.Forms.ListBox();
            this.lblAdauga = new System.Windows.Forms.Label();
            this.lblSterge = new System.Windows.Forms.Label();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLectie
            // 
            this.txtLectie.BackColor = System.Drawing.Color.BurlyWood;
            this.txtLectie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLectie.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLectie.Location = new System.Drawing.Point(71, 64);
            this.txtLectie.Multiline = true;
            this.txtLectie.Name = "txtLectie";
            this.txtLectie.ReadOnly = true;
            this.txtLectie.Size = new System.Drawing.Size(433, 431);
            this.txtLectie.TabIndex = 0;
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(755, 15);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(59, 47);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 26;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbLeft
            // 
            this.pbLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbLeft.Image")));
            this.pbLeft.Location = new System.Drawing.Point(71, 511);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(56, 57);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeft.TabIndex = 27;
            this.pbLeft.TabStop = false;
            this.pbLeft.Click += new System.EventHandler(this.pbLeft_Click);
            // 
            // pbRight
            // 
            this.pbRight.Image = ((System.Drawing.Image)(resources.GetObject("pbRight.Image")));
            this.pbRight.Location = new System.Drawing.Point(448, 511);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(56, 57);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRight.TabIndex = 27;
            this.pbRight.TabStop = false;
            this.pbRight.Click += new System.EventHandler(this.pbRight_Click);
            // 
            // txtExercitii
            // 
            this.txtExercitii.BackColor = System.Drawing.Color.BurlyWood;
            this.txtExercitii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExercitii.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtExercitii.Location = new System.Drawing.Point(525, 108);
            this.txtExercitii.Multiline = true;
            this.txtExercitii.Name = "txtExercitii";
            this.txtExercitii.ReadOnly = true;
            this.txtExercitii.Size = new System.Drawing.Size(276, 387);
            this.txtExercitii.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18.65F);
            this.label2.Location = new System.Drawing.Point(559, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Exercitii propuse";
            // 
            // lstLectie
            // 
            this.lstLectie.FormattingEnabled = true;
            this.lstLectie.Location = new System.Drawing.Point(525, 525);
            this.lstLectie.Name = "lstLectie";
            this.lstLectie.Size = new System.Drawing.Size(41, 43);
            this.lstLectie.TabIndex = 29;
            this.lstLectie.Visible = false;
            // 
            // lstExercitii
            // 
            this.lstExercitii.FormattingEnabled = true;
            this.lstExercitii.Location = new System.Drawing.Point(582, 525);
            this.lstExercitii.Name = "lstExercitii";
            this.lstExercitii.Size = new System.Drawing.Size(41, 43);
            this.lstExercitii.TabIndex = 29;
            this.lstExercitii.Visible = false;
            // 
            // lstID
            // 
            this.lstID.FormattingEnabled = true;
            this.lstID.Location = new System.Drawing.Point(638, 525);
            this.lstID.Name = "lstID";
            this.lstID.Size = new System.Drawing.Size(41, 43);
            this.lstID.TabIndex = 29;
            this.lstID.Visible = false;
            // 
            // lblSave
            // 
            this.lblSave.BackColor = System.Drawing.Color.Transparent;
            this.lblSave.Font = new System.Drawing.Font("Rockwell", 15.65F);
            this.lblSave.Location = new System.Drawing.Point(133, 525);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(92, 28);
            this.lblSave.TabIndex = 28;
            this.lblSave.Text = "Salvare";
            this.lblSave.Visible = false;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18.65F);
            this.label1.Location = new System.Drawing.Point(538, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Evaluare cunostiinte";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstTitlu
            // 
            this.lstTitlu.FormattingEnabled = true;
            this.lstTitlu.Location = new System.Drawing.Point(661, 19);
            this.lstTitlu.Name = "lstTitlu";
            this.lstTitlu.Size = new System.Drawing.Size(41, 43);
            this.lstTitlu.TabIndex = 29;
            this.lstTitlu.Visible = false;
            // 
            // lblAdauga
            // 
            this.lblAdauga.BackColor = System.Drawing.Color.Transparent;
            this.lblAdauga.Font = new System.Drawing.Font("Rockwell", 15.65F);
            this.lblAdauga.Location = new System.Drawing.Point(231, 525);
            this.lblAdauga.Name = "lblAdauga";
            this.lblAdauga.Size = new System.Drawing.Size(111, 28);
            this.lblAdauga.TabIndex = 28;
            this.lblAdauga.Text = "Adaugare";
            this.lblAdauga.Visible = false;
            this.lblAdauga.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSterge
            // 
            this.lblSterge.BackColor = System.Drawing.Color.Transparent;
            this.lblSterge.Font = new System.Drawing.Font("Rockwell", 15.65F);
            this.lblSterge.Location = new System.Drawing.Point(362, 525);
            this.lblSterge.Name = "lblSterge";
            this.lblSterge.Size = new System.Drawing.Size(80, 28);
            this.lblSterge.TabIndex = 28;
            this.lblSterge.Text = "Sterge";
            this.lblSterge.Visible = false;
            this.lblSterge.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTitlu
            // 
            this.txtTitlu.BackColor = System.Drawing.Color.BurlyWood;
            this.txtTitlu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitlu.Font = new System.Drawing.Font("Rockwell", 15.65F);
            this.txtTitlu.Location = new System.Drawing.Point(150, 29);
            this.txtTitlu.Multiline = true;
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.ReadOnly = true;
            this.txtTitlu.Size = new System.Drawing.Size(260, 29);
            this.txtTitlu.TabIndex = 30;
            // 
            // frmLectii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 602);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstExercitii);
            this.Controls.Add(this.lstID);
            this.Controls.Add(this.lstTitlu);
            this.Controls.Add(this.lstLectie);
            this.Controls.Add(this.lblSterge);
            this.Controls.Add(this.lblAdauga);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.txtExercitii);
            this.Controls.Add(this.txtLectie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLectii";
            this.Text = "frmLectii";
            this.Load += new System.EventHandler(this.frmLectii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLectie;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.TextBox txtExercitii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstLectie;
        private System.Windows.Forms.ListBox lstExercitii;
        private System.Windows.Forms.ListBox lstID;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTitlu;
        private System.Windows.Forms.Label lblAdauga;
        private System.Windows.Forms.Label lblSterge;
        private System.Windows.Forms.TextBox txtTitlu;
    }
}