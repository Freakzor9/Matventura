using System;
using System.Drawing;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Ukwenza
{
    public partial class frmProfil : Form
    {
        public frmProfil()
        {
            InitializeComponent();
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        private void frmProfil_Load(object sender, EventArgs e)
        {
            lblNume.Text = Flags.User;
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select * from Useri";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                if(r["Nume"].ToString() == lblNume.Text)
                {
                    lblEmail.Text = r["Email"].ToString();
                    lblAventuri.Text = r["AventuriF"].ToString();
                }
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstAventuri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
