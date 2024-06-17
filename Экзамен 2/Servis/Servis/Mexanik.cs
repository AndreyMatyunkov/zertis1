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
    public partial class Mexanik : Form
    {
        public Mexanik()
        {
            InitializeComponent();
        }

        private void orderuserlistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderuserlistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.avtoServis_databaseDataSet);

        }

        private void Mexanik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoServis_databaseDataSet.orderuserlist". При необходимости она может быть перемещена или удалена.
            this.orderuserlistTableAdapter.Fill(this.avtoServis_databaseDataSet.orderuserlist);

        }
    }
}
