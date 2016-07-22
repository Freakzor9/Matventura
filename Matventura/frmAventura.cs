using System;
using System.Windows.Forms;
using Matventura;
using System.Drawing;

namespace Ukwenza
{
    public partial class frmAventura : Form
    {
        public frmAventura()
        {
            InitializeComponent();
        }

        private void lblConectare_MouseLeave(object sender, EventArgs e)
        {
            ((sender) as Label).ForeColor = Color.Black;
            Cursor.Current = Cursors.Default;
        }

        private void lblConectare_MouseMove(object sender, MouseEventArgs e)
        {
            ((sender) as Label).ForeColor = Color.FromArgb(59, 115, 145);
        }

        private void lblConectare_MouseEnter(object sender, EventArgs e)
        {
            ((sender) as Label).ForeColor = Color.FromArgb(59, 115, 145);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmCampanie form = new frmCampanie();
            form.Show();
            this.Hide();
        }

        private void frmAventura_Load(object sender, EventArgs e)
        {
            if (Flags.Admin == 1)
                lblEdit.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmEditare form = new FrmEditare();
            form.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmAlege form = new frmAlege();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Flags.Load = 1;
            frmCampanie form = new frmCampanie();
            form.Show();
            this.Hide();
        }

        private void lblLectii_Click(object sender, EventArgs e)
        {
            frmLectii form = new frmLectii();
            form.Show();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
