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
    public partial class Lista_clientilor : Form
    {
        public Lista_clientilor()
        {
            InitializeComponent();
        }

        private void iesireF3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Sigur vrei să închizi pagina?", "Ieșire", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.atestatDataSet);

        }

        private void Lista_clientilor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atestatDataSet.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.atestatDataSet.Clienti);

        }

        private void clientiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
