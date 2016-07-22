using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Ukwenza
{
    public partial class frmMoolka : Form
    {
        public frmMoolka()
        {
            InitializeComponent();
        }

        // DISPLAY TEXT
        Panel pnlTxt;
        Label lbltxt;
        Label lblContinua;
        string[] desc = new string[11];
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        int total, i;

        private void Display_Text(int cate)
        {
            pnlTxt.Visible = true;
            lbltxt.Text = desc[0];
            total = cate;
            i = 0;
        }
        int intrebari = 5;
        private void lupta()
        {
            if (intrebari >= 0)
            {
                lblQ.Text = lstEcuatii.Items[intrebari].ToString();
                lblR1.Text = lstrasp1.Items[intrebari].ToString();
                lblR2.Text = lstrasp2.Items[intrebari].ToString();
                lblR3.Text = lstrasp3.Items[intrebari].ToString();
                lblRC.Text = lstRC.Items[intrebari].ToString();
            }
        }

        private void lblContinua_Click(object sender, EventArgs e)
        {
            i++;
            if (i == total)
            {
                this.Controls.Remove(pnlTxt);
                this.Controls.Remove(lbltxt);
                this.Controls.Remove(lblContinua);

                if (Flags.Moolka == 1)
                {
                    pbH1.Visible = true;
                    pbH2.Visible = true;
                    pbH3.Visible = true;
                    pbMilk1.Visible = true;
                    pbMilk2.Visible = true;
                    pbMilk3.Visible = true;
                    pnlQ.Visible = true;
                    lupta();
                }
            }
            else
            {
                lbltxt.Text = desc[i];
            }
        }
        int inimi = 3;
        int lapte = 3;

        private void GameOver(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ai fost invins in lupta de Moolka, poti incerca sa te mai duelezi cu ea odata","Da",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                inimi = 3;
                lapte = 3;
                pbH1.Visible = false;
                pbH2.Visible = false;
                pbH3.Visible = false;
                pbMilk1.Visible = false;
                pbMilk2.Visible = false;
                pbMilk3.Visible = false;
                pnlQ.Visible = false;

                lstEcuatii.Items.Clear();
                lstrasp1.Items.Clear();
                lstrasp2.Items.Clear();
                lstrasp3.Items.Clear();
                lstRC.Items.Clear();

                frmMoolka_Load(sender, e);
                pbMoolka.Enabled = true;
            }
            else
            {
                MessageBox.Show("Speram ca ti-a placut aventura aceasta!");
                Application.Exit();
            }
        }

        private void raspunde(string raspuns, object sender, EventArgs e)
        {
            if (raspuns == lblRC.Text)
            {
                switch (lapte)
                {
                    case 1:
                        pbMilk1.Visible = false;
                        Flags.Moolka = 0;
                        globula = 1;
                        frmMoolka_Load(sender, e);
                        lapte--;
                        break;
                    case 2:
                        pbMilk2.Visible = false;
                        lapte--;
                        break;
                    case 3:
                        pbMilk3.Visible = false;
                        lapte--;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (inimi)
                {
                    case 1:
                        pbH1.Visible = false;
                        inimi--;
                        GameOver(sender,e);
                        break;
                    case 2:
                        pbH2.Visible = false;
                        inimi--;
                        break;
                    case 3:
                        pbH3.Visible = false;
                        inimi--;
                        break;
                    default:
                        break;
                }
            }
            intrebari--;
            lupta();
        }

        Panel Jurnal;
        PictureBox Close;
        Label text_Jurnal;
        PictureBox Left;
        PictureBox Right;
        ListBox LectiiJurnal;

        public void Close_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(Jurnal);
        }

        int jurnalT = 0;

        public void Left_Click(object sender, EventArgs e)
        {
            if (jurnalT <= 0)
            {
                jurnalT = LectiiJurnal.Items.Count - 1;
            }
            else
            jurnalT--;
            text_Jurnal.Text = LectiiJurnal.Items[jurnalT].ToString();
        }

        public void Right_Click(object sender, EventArgs e)
        {
            if (jurnalT >= LectiiJurnal.Items.Count - 1)
            {
                jurnalT = 0;
            }
            else
                jurnalT++;
            text_Jurnal.Text = LectiiJurnal.Items[jurnalT].ToString();
        }

        public void pune_in_jurnal()
        {
            LectiiJurnal.Items.Clear();
            if (Flags.FirstStatue == 0)
            {
                text_Jurnal.Text = LectiiJurnal.Items[0].ToString();
                LectiiJurnal.Items.Add("Am invatat despre ecuatii de la Arathos cand am ajuns in orasul Bazatonia, acest mi-a spus ca: 'O ecuatie este o propozitie cu o variabila in care apare o singura data semnul egal. De exemplu: 4x + 3 = 7. Pentru a rezolva e astfel de ecuatie vom trece toti termenii liberi(cei fara x) pe o parte a egalului, astfel ecuatie devine: 4x = 7 - 3, de unde avem 4x = 4 din care rezulta ca x = 1! Un alt exemplu este: 5x + 20 = 40 - 2(3 +2). Pentru a rezolva aceasta ecuatie trebuie doar sa il duci pe 20 in partea dreapta a egalului dupa care sa faci calcule! Astfel avem 5x = 40 - 2(3+2) - 20. Dupa calcule obtinem 5x = 40 - 30, de unde obtinem x = 2.'");

            }
            if (Flags.Moolka == 0)
            {
                LectiiJurnal.Items.Add("Am invins-o pe teribila Moolka, orasul Bazatoniei este salvat. Arathos mi-a spus ca ar trebui sa imi continui calatoria pentru a salva lumea. In continuare ar trebui sa il caut pe Magnus cel Rosu in turnul solitar din sudul Bazatonieni");
            }
        }

        public void ft_Jurnal()
        {
            LectiiJurnal = new ListBox();
            LectiiJurnal.Visible = false;
                       
            Left = new PictureBox();
            Right = new PictureBox();
            Jurnal = new Panel();
            text_Jurnal = new Label();
            Jurnal.Size = new Size(600, 400);
            Left.Size = new Size(50, 50);
            Right.Size = new Size(50, 50);
            Left.Location = new Point(200, 335);
            Right.Location = new Point(400, 335);
            Jurnal.Location = new Point(100, 100);
            text_Jurnal.Location = new Point(15, 30);
            text_Jurnal.BackColor = Color.Transparent;
            text_Jurnal.Font = new Font("Rockwell", 13);
            text_Jurnal.Size = new Size(500, 300);
            Close = new PictureBox();
            Close.Parent = Jurnal;
            Close.Location = new Point(535, 10);
            Close.Size = new Size(45, 45);
            Close.BackColor = Color.Transparent;
            Close.Click += new EventHandler(Close_Click);
            Left.Click += new EventHandler(Left_Click);
            Right.Click += new EventHandler(Right_Click);

            Left.BackgroundImage = new Bitmap(cale + "\\art\\arrow_left.png");
            Left.BackgroundImageLayout = ImageLayout.Stretch;
            Right.BackgroundImage = new Bitmap(cale + "\\art\\arrow_right.png");
            Right.BackgroundImageLayout = ImageLayout.Stretch;
            Jurnal.BackgroundImage = new Bitmap(cale + "\\art\\" + "panouh.png");
            Jurnal.BackgroundImageLayout = ImageLayout.Stretch;
            Close.BackgroundImage = new Bitmap(cale + "\\Resurse\\close_button.png");
            Close.BackgroundImageLayout = ImageLayout.Stretch;

            this.Controls.Add(Jurnal);
            Jurnal.Controls.Add(text_Jurnal);
            Jurnal.Controls.Add(Close);
            Jurnal.Controls.Add(Left);
            Jurnal.Controls.Add(Right);
            Jurnal.BringToFront();
            Close.BringToFront();
            text_Jurnal.BringToFront();
            Right.BringToFront();
            Left.BringToFront();
            text_Jurnal.Text = "Inca nu am nimic in jurnal, sper sa schimb asta in curand!";
            pune_in_jurnal();
        }
        int globula = 0;
        private void frmMoolka_Load(object sender, EventArgs e)
        {
            if (Flags.Moolka == 1)
            {
                pbMoolka.Visible = true;
                lblExit.Visible = false;

                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
                con.Open();
                string text = "select * from Intrebari where ID_Lupta=@ID_Lupta order by rnd(ID)";
                OleDbCommand com = new OleDbCommand(text, con);
                com.Parameters.AddWithValue("ID_Lupta", "M");
                OleDbDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    lstEcuatii.Items.Add(r["Exercitiu"]);
                    lstrasp1.Items.Add(r["R1"]);
                    lstrasp2.Items.Add(r["R2"]);
                    lstrasp3.Items.Add(r["R3"]);
                    lstRC.Items.Add(r["RC"]);
                }
            }
            else
            {
                pbMoolka.Visible = false;
                lblExit.Visible = true;

                pbH1.Visible = false;
                pbH2.Visible = false;
                pbH3.Visible = false;
                pbMilk1.Visible = false;
                pbMilk2.Visible = false;
                pbMilk3.Visible = false;
                pnlQ.Visible = false;
                if (globula == 1)
                {
                    functie();
                    pnlTxt.BringToFront();
                    lblContinua.BringToFront();
                    pbMoolka.SendToBack();
                    lbltxt.BringToFront();
                    desc[0] = "AH! Nu imi vine sa cred, ai reusit sa ma invingi. Esti tu cel ales sa ne invinga?";
                    desc[1] = "Acest lucru e imposibil, chiar daca m-ai invis, nu ai nici-o sansa impotriva celorlalte regine!";
                    Display_Text(2);
                }
            }
        }



        public void functie()
        {
            pnlTxt = new Panel();
            lblContinua = new Label();
            lbltxt = new Label();
            pnlTxt.Size = new Size(547, 231);
            lbltxt.Parent = pnlTxt;
            lblContinua.Parent = pnlTxt;
            lblContinua.Location = new Point(375, 192);
            lblContinua.Size = new Size(137, 29);
            lblContinua.Text = "Continua";
            lblContinua.Font = new Font("Rockwell", 17);
            lbltxt.Font = new Font("Rockwell", 15);
            lbltxt.Size = new Size(497, 161);
            lbltxt.Location = new Point(15, 16);
            lbltxt.Visible = true;
            pnlTxt.Location = new Point(this.Size.Width / 2 - 285, this.Size.Height / 2);
            pnlTxt.Visible = false;
            lblContinua.Click += new EventHandler(lblContinua_Click);
            pnlTxt.Name = "asd";
            pnlTxt.BackgroundImage = new Bitmap(cale + "\\art\\" + "panouh.png");
            pnlTxt.BackgroundImageLayout = ImageLayout.Stretch;
            lblContinua.BackColor = Color.Transparent;
            lbltxt.BackColor = Color.Transparent;
            this.Controls.Add(pnlTxt);
            pnlTxt.Controls.Add(lbltxt);
            pnlTxt.Controls.Add(lblContinua);
        }

        private void pbMoolka_Click(object sender, EventArgs e)
        {
            if (Flags.Moolka == 1)
            {
                functie();
                pnlTxt.BringToFront();
                lblContinua.BringToFront();
                pbMoolka.SendToBack();
                lbltxt.BringToFront();
                desc[0] = "Moooo, cine indrazneste sa intre in barlogul temutei Moolka?";
                desc[1] = "Cine esti tu, micutule om si ce doresti de la Regina ecuatiilor?";
                desc[2] = "Crezi ca ma poti invinge, eu detin cunostiinte neintalnite de voi oamenii!";
                desc[3] = "Te voi invinge cat ai zice 2+2!";
                pbMoolka.Enabled = false;

                Display_Text(4);
            }
        }

        private void lblR1_Click(object sender, EventArgs e)
        {
            raspunde((sender as Label).Text, sender, e);
        }

        private void frmMoolka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J)
            {
                ft_Jurnal();
            }
        }

        // ENDED DISPLAY OF TEXT

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
