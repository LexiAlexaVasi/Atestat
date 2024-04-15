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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Sigur vrei să închizi pagina?", "Ieșire", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void butonF2_Click(object sender, EventArgs e)
        {
            Lista_cartilor butonF2 = new Lista_cartilor();
            butonF2.Show();
        }

        private void butonF3_Click(object sender, EventArgs e)
        {
            Lista_clientilor butonF3 = new Lista_clientilor();
            butonF3.Show();
        }

        private void butonF4_Click(object sender, EventArgs e)
        {
            Imprumuturi butonF4 = new Imprumuturi();
            butonF4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butonF5_Click(object sender, EventArgs e)
        {
            Descrierea_bibliotecii butonF5 = new Descrierea_bibliotecii();
            butonF5.Show();
        }
    }
}
