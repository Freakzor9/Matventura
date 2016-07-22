using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Ukwenza
{
    public partial class frmCampanie : Form
    {
        public frmCampanie()
        {
            InitializeComponent();
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void incarcare_salvare()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select * from Salvari where User=@user";
            OleDbCommand com = new OleDbCommand(text, con);
            com.Parameters.AddWithValue("User", Flags.User);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                Flags.Magnus = Convert.ToInt16(r["Magnus"]);
                Flags.Moolka = Convert.ToInt16(r["Moolka"]);
                Flags.FirstStatue = Convert.ToInt16(r["Statuie"]);
                Flags.Finalizata = Convert.ToInt16(r["Finalizata"]);
            }
        }

        public void verificare()
        {
            if (Flags.Load == 1)
                incarcare_salvare();
            if (Flags.Moolka == 0)
            {
                lblNumeTurn.Visible = true;
                lblTurn.Visible = true;
            }
            if (Flags.Magnus == 1)
            {
                lblSat.Visible = true;
            }
        }

        private void frmCampanie_Load(object sender, EventArgs e)
        {
            verificare();
            lblOras1.Visible = false;
            pnlInceput.Location = new Point(0, 1);
            pnlInceput.Size = new Size(this.Size.Width, this.Size.Height);
            lblIntro.Location = new Point(this.Size.Width / 2 - 200, this.Size.Height / 2 - 200);
            label1.Location=new Point(this.Size.Width / 2 - 100, this.Size.Height / 2 + 200);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pbClose.Visible = true;
            pnlInceput.Visible = false;
            lblOras1.Visible = true;
            lblContinua.Visible = true;
        }

        private void lblOras_Click(object sender, EventArgs e)
        {
            frmOras form1 = new frmOras();
            form1.ShowDialog();
        }

        private void lblTurn_Click(object sender, EventArgs e)
        {
            frmTurn form = new frmTurn();
            form.ShowDialog();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string qs = "Update Salvari SET Statuie=@statuie,Magnus=@magnus,Moolka=@moolka,Finalizata=@finalizata where User=@user";
            OleDbCommand com = new OleDbCommand(qs, con);
            com.Parameters.AddWithValue("Statuie",Flags.FirstStatue);
            com.Parameters.AddWithValue("Magnus", Flags.Magnus);
            com.Parameters.AddWithValue("Moolka", Flags.Moolka);
            com.Parameters.AddWithValue("Finalizata", Flags.Finalizata);
            com.Parameters.AddWithValue("User", Flags.User);
            com.ExecuteNonQuery();
            con.Close();
            this.Close();
        }

        private void lblContinua_Click(object sender, EventArgs e)
        {
            verificare();
        }
    }
}
