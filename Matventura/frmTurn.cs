using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace Ukwenza
{
    public partial class frmTurn : Form
    {
        public frmTurn()
        {
            InitializeComponent();
        }

        int total, i;
        string[] desc = new string[11];
        string cale = Path.GetDirectoryName(Application.ExecutablePath);

        private void lblIntrare_Click(object sender, EventArgs e)
        {
            pbMagnus.Visible = true;
            lblIntrare.Visible = false;
            lblTxt.Visible = false;
            lblExit.Visible = false;
            lblTurnE.Visible = true;
            

            this.BackgroundImage = new Bitmap(cale + "\\Interior\\int6.jpg");
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTurnE_Click(object sender, EventArgs e)
        {
            pbMagnus.Visible = false;
            lblIntrare.Visible = true;
            lblTxt.Visible = true;
            lblExit.Visible = true;
            lblTurnE.Visible = false;

            this.BackgroundImage = new Bitmap(cale + "\\Resurse\\MT.jpg");
        }

        Panel pnlTxt;
        Label lbltxt;
        Label lblContinua;


        private void pbMagnus_Click(object sender, EventArgs e)
        {
            functie();
            pnlTxt.BringToFront();
            lblContinua.BringToFront();
            lbltxt.BringToFront();
            desc[0] = "Bine ai venit in turnul meu tinere intelept, eu sunt Magnus cel Rosu";
            desc[1] = "Am inteles de la fortele superioare ca esti intr-o misiune pentru a salva oamenii cu ajutorul Matematicii!";
            desc[2] = "Eu  te pot invata despre functii, pentru a-ti continua calatoria!";
            desc[3] = "În matematică, o funcție este o relație care asociază fiecărui element dintr-o mulțime (domeniul) un singur element dintr-o altă (posibil din aceeași) mulțime (codomeniul). Noțiunea de funcție este fundamentală în aproape toate ramurile matematicii și în toate științele exacte.";
            desc[4] = "De exemplu: functia f:{1,2,3,4,5}->N, unde f(x) = 3x - 1. Astfel avem valorile f(1) = 2, f(2) = 5, si asa mai departe";
            desc[5] = "Pentru a calcula intersectiile cu axele graficului folosim expresiile f(x) = 0, pentru intersectia cu Ox si pentru intersectia cu Oy calculam f(0)";
            desc[6] = "Pentru a afla daca un punct se afla sau nu pe un grafic al unei functii trebuie sa calculam f(x0)= y0 (unde x0,y0 reprezinta coordonatele punctului).";
            desc[7] = "Incearca urmatorul exercitiu: fie f,g:{3,5,7} -> R, f(x) = x+1, g(x) = x-3.Care din punctele urmatoare apartin graficului functiei f, sau graficului functiei g ? ";
            desc[8] = "Bun, acum incearca exercitiul urmator: 2) Fie f:R -> R, f(x) = 3x + 2. Calculati: a) f(1) b) f(1/3) c) f(-1/6) d) f(-2)";
            desc[9] = "Felicitari, sunt sigur ca acum o vei putea invinge pe urmatoarea regina Mootematiciana, din satul";

            Display_Text(10);
        }

        private void Display_Text(int cate)
        {
            pnlTxt.Visible = true;
            lbltxt.Text = desc[0];
            total = cate;
            i = 0;
        }

        private void lblContinua_Click(object sender, EventArgs e)
        {
            i++;
            if (i == total)
            {
                this.Controls.Remove(pnlTxt);
                this.Controls.Remove(lbltxt);
                this.Controls.Remove(lblContinua);
            }
            else
            {
                lbltxt.Text = desc[i];
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

        private void frmTurn_Load(object sender, EventArgs e)
        {
            
        }
    }
}
