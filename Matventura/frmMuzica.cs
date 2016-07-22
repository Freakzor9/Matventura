using System;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace Matventura
{
    public partial class frmMuzica : Form
    {
        public frmMuzica()
        {
            InitializeComponent();
        }

        private SoundPlayer Player = new SoundPlayer();
        string cale = Path.GetDirectoryName(Application.ExecutablePath);

        private void frmMuzica_Load(object sender, EventArgs e)
        {
            this.Hide();

            Player.SoundLocation = cale + "\\melodie.wav";
            Player.PlayLooping();
        }
    }
}
