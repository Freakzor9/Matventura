using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Matventura
{
    public partial class frmEvaluare : Form
    {
        public frmEvaluare()
        {
            InitializeComponent();
        }
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        cst_messagebox Mesaj = new cst_messagebox();
        int intrebari = 4;
        int corecte = 1;
        int test_curent = 0;
        string tip_test;
        private void incarca_teste()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select * from Teste";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                if (r["Tip"] == "F")
                    lstF.Items.Add(r["ID_Test"].ToString());
                else
                    lstE.Items.Add(r["ID_Test"].ToString());
            }
        }
        private void incarca_intrebari()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text;
            text = "select * from Teste where ID_Test=@ID_Test order by rnd(ID)";
            OleDbCommand com = new OleDbCommand(text, con);
            if (tip_test == "F")
                com.Parameters.AddWithValue("ID_Test", lstF.Items[test_curent].ToString());
            else
                com.Parameters.AddWithValue("ID_Test", lstE.Items[test_curent].ToString());

            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                lstEcuatii.Items.Add(r["Intrebare"]);
                lstrasp1.Items.Add(r["R1"]);
                lstrasp2.Items.Add(r["R2"]);
                lstrasp3.Items.Add(r["R3"]);
                lstRC.Items.Add(r["RC"]);
            }
            lblQ.Text = lstEcuatii.Items[i].ToString();
            lblR1.Text = lstrasp1.Items[i].ToString();
            lblR2.Text = lstrasp2.Items[i].ToString();
            lblR3.Text = lstrasp3.Items[i].ToString();
            lblRC.Text = lstRC.Items[i].ToString();
        }
        private void frmEvaluare_Load(object sender, EventArgs e)
        {
            incarca_teste();
            pnlTest.Location = new Point(33, 26);

        }
        int i = 0;
        private void raspunde(string raspuns, object sender, EventArgs e)
        {
            i++;
            if (i < 5)
            {
                if (raspuns == lblRC.Text)
                {
                    lblNota.Text = (Convert.ToInt16(lblNota.Text) + 1).ToString();
                    corecte++;
                }
                else
                {
                    Mesaj.lblMesaj.Text = "Raspuns gresit, raspunsul corect era " + lblRC.Text;
                    Mesaj.ShowDialog();
                }
                lblQ.Text = lstEcuatii.Items[i].ToString();
                lblR1.Text = lstrasp1.Items[i].ToString();
                lblR2.Text = lstrasp2.Items[i].ToString();
                lblR3.Text = lstrasp3.Items[i].ToString();
                lblRC.Text = lstRC.Items[i].ToString();
            }
            else
            {
                Mesaj.lblMesaj.Text = "Ai obtinut scorul de " + lblNota.Text;
                Mesaj.ShowDialog();
                if (corecte >= 4)
                {
                    Mesaj.lblMesaj.Text = "Felicitari ai obtinut medalia pentru finalizarea cu brio a testului!";
                }
                else
                {
                    Mesaj.lblMesaj.Text = "Nu ai reusit sa obtii punctajul necesar pentru a trece testul.";
                }
                Mesaj.ShowDialog();
            }
        }

        private void lblR2_Click(object sender, EventArgs e)
        {
            raspunde((sender as Label).Text, sender, e);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEcuatii_Click(object sender, EventArgs e)
        {
            tip_test = "M";
            pnlAlege.Visible = false;
            pnlTest.Visible = true;
            incarca_intrebari();
        }

        private void lblFunctii_Click(object sender, EventArgs e)
        {
            tip_test = "F";
            pnlAlege.Visible = false;
            pnlTest.Visible = true;
            incarca_intrebari();
        }
    }
}
