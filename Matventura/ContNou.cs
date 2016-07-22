using System;
using System.Drawing;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;
using Matventura;
namespace Ukwenza
{
    public partial class ContNou : Form
    {
        public ContNou()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        cst_messagebox Mesaj = new cst_messagebox();

        private void btnConectare_Click(object sender, EventArgs e)
        {
            if(txtParola.Text.Trim() != txtParola2.Text.Trim())
            {
                //MessageBox.Show("Parolele difera!");
                Mesaj.lblMesaj.Text = "Parolele difera!";
                Mesaj.ShowDialog();
            }
            else
            {
                if(IsValidEmail(txtMail.Text) != false)
                {
                    if (txtNume.Text.Trim() != "" && txtParola.Text.Trim() != "" && txtMail.Text.Trim() != "")
                    {
                        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
                        con.Open();
                        string qs = "Insert into Useri (Nume,Email,Parola) values (@Nume,@Email,@Parola)";
                        OleDbCommand com = new OleDbCommand(qs, con);
                        com.Parameters.AddWithValue("Nume", txtNume.Text);
                        com.Parameters.AddWithValue("Email", txtMail.Text);
                        com.Parameters.AddWithValue("Parola", txtNume.Text);
                        int asd = com.ExecuteNonQuery();
                        con.Close();
                        Mesaj.lblMesaj.Text = "Contul a fost creat, asteptati validarea unui Administrator";
                        Mesaj.ShowDialog();
                      //  MessageBox.Show("Contul a fost creat, asteptati validarea unui Administrator");
                        this.Close();
                    }
                }
                else
                {
                    Mesaj.lblMesaj.Text = "Adresa de e-mail nu este valida!";
                    Mesaj.ShowDialog();
                    //MessageBox.Show("Adresa de e-mail nu este valida!");
                }

            }
        }

        private void ContNou_Load(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblConectare_MouseEnter(object sender, EventArgs e)
        {
            ((sender) as Label).ForeColor = Color.FromArgb(59, 115, 145);
        }

        private void lblConectare_MouseLeave(object sender, EventArgs e)
        {
            ((sender) as Label).ForeColor = Color.Black;
        }

        private void lblConectare_MouseMove(object sender, MouseEventArgs e)
        {
            ((sender) as Label).ForeColor = Color.FromArgb(59, 115, 145);
        }
    }
}
