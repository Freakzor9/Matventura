using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Ukwenza
{
    public partial class frmOras : Form
    {
        public frmOras()
        {
            InitializeComponent();
        }
        int total, i;
        string[] desc = new string[11];
        string cale = Path.GetDirectoryName(Application.ExecutablePath);


        private void frmOras_Load(object sender, EventArgs e)
        {
            if (Flags.FirstStatue == 1)
            {
                lblUp.Visible = false;
                //pnlText.Location = new Point(this.Size.Width / 2 - 285 , this.Size.Height / 2 );
            }
        }


        private void lblStatuie_Click(object sender, EventArgs e)
        {
            if (Flags.FirstStatue == 1)
            {
                Flags.FirstStatue = 0;
                functie();
                pnlTxt.BringToFront();
                lblContinua.BringToFront();
                lblStatuie.SendToBack();
                lbltxt.BringToFront();
                desc[0] = "Te apropii de statuie si simti o anumita putere ce incearca sa comunice cu tine. Indata ce ajungi langa ea auzi o voce puternica si hotarata.";
                desc[1] = "Am stiut ca va sosi ziua asta! In sfarsit, tu cel ce ne va salva ai ajuns. Eu sunt Arathos, si in era oamenilor eu am fondat Bazatonia cu ajutorul matematicii pure!";
                desc[2] = "Eu am fost maestrul ecuatiilor de gradul intai cand eram inca tanar, dar acum am ramas doar o legenda spiritul meu fiind blocat in acest simbol al Anticului. De cand invadatorii au cucerit lumea noastra acest fost mare oras al cunoasterii a stagnat.";
                desc[3] = "Dar acum ca ai aparut tu vom putea sa recucerim orasul si sa invatam omenirea magia matematicii!";
                desc[4] = "Pentru inceput eu te voi invata fundamentele ecuatiilor de gradul intai. O ecuatie este o propozitie cu o variabila in care apare o singura data semnul egal.";
                desc[5] = "De exemplu: 4x + 3 = 7. Pentru a rezolva e astfel de ecuatie vom trece toti termenii liberi(cei fara x) pe o parte a egalului, astfel ecuatie devine: 4x = 7 - 3, de unde avem 4x = 4 din care rezulta ca x = 1!";
                desc[6] = "Pentru a deveni mai bun incearca sa rezolvi urmatoarele ecuatii simple: 5x + 20 = 40 - 2(3 +2). Pentru a rezolva aceasta ecuatie trebuie doar sa il duci pe 20 in partea dreapta a egalului dupa care sa faci calcule! Astfel avem 5x = 40 - 2(3+2) - 20. Dupa calcule obtinem 5x = 40 - 30, de unde obtinem x = 2.";

                Display_Text(7);
            }
            else
            {
                if(Flags.Magnus == 0 && Flags.Moolka == 0)
                {
                    functie();
                    pnlTxt.BringToFront();
                    lblContinua.BringToFront();
                    lblStatuie.SendToBack();
                    lbltxt.BringToFront();
                    Flags.Magnus = 1;
                    frmCampanie form = new frmCampanie();
                    form.verificare();
                    desc[0] = "Felicitari, ai invins-o pe Moolka si ai recucerit orasul Bazatoniei, in sfarsit ma pot odihni din nou!";
                    desc[1] = "Iti recomand sa il cauti pe Magnus cel Rosu in turnul sau din sudul oraslui, acesta este un mare intelept si te poate ajuta in calatoria ta.";
                    Display_Text(2);
                }
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Display_Text(int cate)
        {
            pnlTxt.Visible = true;
            lbltxt.Text = desc[0];
            total = cate;
            i = 0;
        }
        Panel pnlTxt;
        Label lbltxt;
        Label lblContinua;

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
            if(Flags.FirstStatue == 0)
            {
                text_Jurnal.Text = LectiiJurnal.Items[0].ToString();
            }
            if(Flags.Moolka == 0)
            {
                text_Jurnal.Text = LectiiJurnal.Items[1].ToString();
            }
        }

        public void ft_Jurnal()
        {
            LectiiJurnal = new ListBox();
            LectiiJurnal.Visible = false;
            LectiiJurnal.Items.Add("Am invatat despre ecuatii de la Arathos cand am ajuns in orasul Bazatonia, acest mi-a spus ca: 'O ecuatie este o propozitie cu o variabila in care apare o singura data semnul egal. De exemplu: 4x + 3 = 7. Pentru a rezolva e astfel de ecuatie vom trece toti termenii liberi(cei fara x) pe o parte a egalului, astfel ecuatie devine: 4x = 7 - 3, de unde avem 4x = 4 din care rezulta ca x = 1! Un alt exemplu este: 5x + 20 = 40 - 2(3 +2). Pentru a rezolva aceasta ecuatie trebuie doar sa il duci pe 20 in partea dreapta a egalului dupa care sa faci calcule! Astfel avem 5x = 40 - 2(3+2) - 20. Dupa calcule obtinem 5x = 40 - 30, de unde obtinem x = 2.'");
            LectiiJurnal.Items.Add("Am invins-o pe teribila Moolka, orasul Bazatoniei este salvat. Arathos mi-a spus ca ar trebui sa imi continui calatoria pentru a salva lumea. In continuare ar trebui sa il caut pe Magnus cel Rosu in turnul solitar din sudul Bazatonieni");

            Left = new PictureBox();
            Right = new PictureBox();
            Jurnal = new Panel();
            text_Jurnal = new Label();
            Jurnal.Size = new Size(600, 400);
            Left.Size = new Size(50, 50);
            Right.Size = new Size(50, 50);
            Left.Location = new Point(200, 335);
            Right.Location = new Point(400, 335);
            Jurnal.Location = new Point(100 , 100);
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

        private void label1_Click(object sender, EventArgs e)
        {
            frmMoolka form1 = new frmMoolka();
            form1.ShowDialog();
        }

        private void frmOras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J)
            {
                ft_Jurnal();
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
                lblUp.Visible = true;
            }
            else
            {
                lbltxt.Text = desc[i];
            }
        }
    }
}
