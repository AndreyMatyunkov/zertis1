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
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.avtoServis_databaseDataSet);

        }

        private void Master_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoServis_databaseDataSet.shift". При необходимости она может быть перемещена или удалена.
            this.shiftTableAdapter.Fill(this.avtoServis_databaseDataSet.shift);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoServis_databaseDataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.avtoServis_databaseDataSet.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoServis_databaseDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.avtoServis_databaseDataSet.user);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Cotrydniki cotrydniki = new Cotrydniki();
                cotrydniki.Show();
                this.Hide(); // Скрываем текущую форму
            }
        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Cmena cmena = new Cmena();
                cmena.Show();
                this.Hide(); // Скрываем текущую форму
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                Zakaz zakaz = new Zakaz();
                zakaz.Show();
                this.Hide(); // Скрываем текущую форму
            }
        }
    }
}
