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
    public partial class Cmena : Form
    {
        public Cmena()
        {
            InitializeComponent();
        }

        private void Cmena_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoServis_databaseDataSet.shift". При необходимости она может быть перемещена или удалена.
            this.shiftTableAdapter.Fill(this.avtoServis_databaseDataSet.shift);

        }
    }
}
