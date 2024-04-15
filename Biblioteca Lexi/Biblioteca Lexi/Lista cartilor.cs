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
    public partial class Lista_cartilor : Form
    {
        public Lista_cartilor()
        {
            InitializeComponent();
        }

        private void iesireF2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Sigur vrei să închizi pagina?", "Ieșire", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cartiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cartiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atestatDataSet);

        }

        private void Lista_cartilor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atestatDataSet.Carti' table. You can move, or remove it, as needed.
            this.cartiTableAdapter.Fill(this.atestatDataSet.Carti);

        }

        private void an_aparitieLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
