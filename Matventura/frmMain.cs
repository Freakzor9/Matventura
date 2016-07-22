using System;
using System.Drawing;
using System.IO;
using System.Data.OleDb;
using Matventura;
using System.Windows.Forms;



namespace Ukwenza
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        cst_messagebox Mesaj = new cst_messagebox();
        private void Form1_Load(object sender, EventArgs e)
        {
            frmMuzica form = new frmMuzica();
            form.Show();
            form.Hide();

            panelJoc.Location = new Point(32, 81);
            panelLogin.Location = new Point(32, 81);


            //btnAlege.Parent = panelJoc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContNou fCont = new ContNou();
            fCont.Show();
            //this.Close();
        }

        private int conectare()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select * from Useri";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                if(txtNume.Text.Trim() == r["Nume"].ToString() && txtParola.Text.Trim() == r["Parola"].ToString())
                {
                    Flags.User = r["Nume"].ToString();
                    Flags.Admin = Convert.ToInt16(r["Admin"]);
                    return 1;
                }
            }
            return 0;
        }

        private void btnConectare_Click(object sender, EventArgs e)
        {
            if (conectare() == 1)
            {
                panelLogin.Visible = false;
                panelJoc.Visible = true;
                MessageBox.Show("Bine ai venit " + txtNume.Text + "!");
                frmProfil form = new frmProfil();
                form.lblNume.Text = txtNume.Text;
            }
            else
            {
               // MessageBox.Show("Contul sau parola gresita!!!");
                Mesaj.lblMesaj.Text = "Contul sau parola gresita!!!";
                Mesaj.ShowDialog();
            }


        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAlege_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmProfil form = new frmProfil();
            form.Show();

        }

        private void lblIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblConectare_Click(object sender, EventArgs e)
        {
            if (conectare() == 1)
            {
                panelLogin.Visible = false;
                panelJoc.Visible = true;
                Mesaj.lblMesaj.Text = ("Bine ai venit " + txtNume.Text + "!");
                Mesaj.ShowDialog();
               // MessageBox.Show("Bine ai venit " + txtNume.Text + "!");
                frmProfil form = new frmProfil();
                form.lblNume.Text = txtNume.Text;
            }
            else
            {
                Mesaj.lblMesaj.Text = "Contul sau parola gresita!!!";
                Mesaj.ShowDialog();
                //MessageBox.Show("Contul sau parola gresita!!!");
            }
        }

        private void lblCont_Click(object sender, EventArgs e)
        {
            ContNou fCont = new ContNou();
            fCont.Show();
        }

        private void lblAbandon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblIncepe_Click(object sender, EventArgs e)
        {
            frmAventura fAventura = new frmAventura();
            fAventura.Show();

        }

        private void lblAlege_Click(object sender, EventArgs e)
        {
            frmAlege form = new frmAlege();
            form.Show();
        }

        private void lblCreaza_Click(object sender, EventArgs e)
        {
            frmCreare form = new frmCreare();
            form.Show();
        }
        private void lblConectare_MouseHover(object sender, EventArgs e)
        {

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
    }
}
