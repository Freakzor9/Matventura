using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matventura
{
    public partial class cst_messagebox : Form
    {
        public cst_messagebox()
        {
            InitializeComponent();
        }

        private void lblConectare_MouseMove(object sender, MouseEventArgs e)
        {
            ((sender) as Label).ForeColor = Color.FromArgb(59, 115, 145);
        }

        private void lblConectare_MouseLeave(object sender, EventArgs e)
        {
            ((sender) as Label).ForeColor = Color.Black;
        }

        private void lblConectare_MouseEnter(object sender, EventArgs e)
        {
            ((sender) as Label).ForeColor = Color.FromArgb(59, 115, 145);
        }

        private void lblConectare_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
