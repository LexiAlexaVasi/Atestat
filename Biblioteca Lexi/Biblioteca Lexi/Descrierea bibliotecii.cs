using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Lexi
{
    public partial class Descrierea_bibliotecii : Form
    {
        public Descrierea_bibliotecii()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iesireF4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Sigur vrei să închizi pagina?", "Ieșire", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
