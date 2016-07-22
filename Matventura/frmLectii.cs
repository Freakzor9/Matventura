using System;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;
using Ukwenza;

namespace Matventura
{
    public partial class frmLectii : Form
    {
        public frmLectii()
        {
            InitializeComponent();
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        int index = 0;

        private void incarca()
        {
            txtTitlu.Text = lstTitlu.Items[index].ToString();
            txtExercitii.Text = lstExercitii.Items[index].ToString();
            txtLectie.Text = lstLectie.Items[index].ToString();
        }

        private void frmLectii_Load(object sender, EventArgs e)
        {
            lstTitlu.Items.Clear();
            lstID.Items.Clear();
            lstExercitii.Items.Clear();
            lstLectie.Items.Clear();
            if (Flags.Admin == 1)
            {
                lblAdauga.Visible = true;
                lblSterge.Visible = true;
                txtTitlu.ReadOnly = false;
                txtExercitii.ReadOnly = false;
                txtLectie.ReadOnly = false;
                lblSave.Visible = true;
                
            }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select * from Lectii";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                lstTitlu.Items.Add(r["Titlu"].ToString());
                lstID.Items.Add(r["ID"].ToString());
                lstExercitii.Items.Add(r["Exercitii"].ToString());
                lstLectie.Items.Add(r["Lectie"].ToString());
            }
            incarca();
        }

        private void pbRight_Click(object sender, EventArgs e)
        {
            if (index >= lstLectie.Items.Count - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            incarca();
        }

        private void pbLeft_Click(object sender, EventArgs e)
        {
            if (index <= 0)
            {
                index = lstLectie.Items.Count - 1;
            }
            else
            {
                index--;
            }
            incarca();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string qs = "Update Lectii SET Lectie=@lectie,Exercitii=@Exercitii where ID=@ID";
            OleDbCommand com = new OleDbCommand(qs, con);
            com.Parameters.AddWithValue("Lectie", txtLectie.Text);
            com.Parameters.AddWithValue("Exercitii", txtExercitii.Text);
            com.Parameters.AddWithValue("ID", lstID.Items[index].ToString());
            com.ExecuteNonQuery();
            con.Close();

            frmLectii_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
                frmEvaluare form = new frmEvaluare();
                form.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string qs = "Insert into Lectii (Titlu,Lectie,Exercitii) values(@Titlu,@Lectie,@Exercitii)";
            OleDbCommand com = new OleDbCommand(qs, con);
            com.Parameters.AddWithValue("Titlu",txtTitlu.Text);
            com.Parameters.AddWithValue("Lectie",txtLectie.Text);
            com.Parameters.AddWithValue("Exercitii",txtExercitii.Text);
            int asd = com.ExecuteNonQuery();
            con.Close();
            frmLectii_Load(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string qs = "Delete from Lectii where ID=" + lstID.Items[index].ToString();
            OleDbCommand com = new OleDbCommand(qs, con);
            int asd = com.ExecuteNonQuery();
            con.Close();
            frmLectii_Load(sender, e);
        }
    }
}
