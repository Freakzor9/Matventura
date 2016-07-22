using System;
using System.Drawing;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Ukwenza
{
    public partial class frmAlege : Form
    {
        public frmAlege()
        {
            InitializeComponent();
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath);

        private void frmAlege_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select * from Aventuri";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                lst.Items.Add(r["Nume Aventura"]);
                lstD.Items.Add(r["Descriere"]);
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst.SelectedIndex == -1)
                return;
            lblDesc.Text = lstD.Items[lst.SelectedIndex].ToString();
        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
