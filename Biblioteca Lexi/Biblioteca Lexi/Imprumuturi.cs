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
    public partial class Imprumuturi : Form
    {
        public Imprumuturi()
        {
            InitializeComponent();
        }

        private void iesireF4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Sigur vrei să închizi pagina?", "Ieșire", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void imprumuturiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imprumuturiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atestatDataSet);

        }

        private void Imprumuturi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atestatDataSet.Imprumuturi' table. You can move, or remove it, as needed.
            this.imprumuturiTableAdapter.Fill(this.atestatDataSet.Imprumuturi);

        }
    }
}
