using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servis
{
    public partial class Cotrydniki : Form
    {
        public Cotrydniki()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.avtoServis_databaseDataSet);

        }

        private void Cotrydniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoServis_databaseDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.avtoServis_databaseDataSet.user);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
