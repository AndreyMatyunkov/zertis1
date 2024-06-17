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
    public partial class Avtoriz : Form
    {
        public Avtoriz()
        {
            InitializeComponent();
        }

        private void Vxod_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "rubies" && textBox2.Text == "cmjcFvB3cI")
            {
                Mexanik mexanik = new Mexanik();
                mexanik.Show();
            }
            if (textBox1.Text == "moving" && textBox2.Text == "A8HPZz9HTG")
            {
                Mexanik mexanik = new Mexanik();
                mexanik.Show();
            }
            if (textBox1.Text == "ragman" && textBox2.Text == "25Y9oOkwHn")
            {
                Mexanik mexanik = new Mexanik();
                mexanik.Show();
            }
            if (textBox1.Text == "coated" && textBox2.Text == "8g2FubQVZH")
            {
                Mexanik mexanik = new Mexanik();
                mexanik.Show();
            }


            if (textBox1.Text == "windle" && textBox2.Text == "2PAUAd0gMZ")
            {
                Master master = new Master();
                master.Show();
            }
            if (textBox1.Text == "improv" && textBox2.Text == "bcFFGU16f6")
            {
                Master master = new Master();
                master.Show();
            }
            if (textBox1.Text == "fiches" && textBox2.Text == "LO1qRB42GP")
            {
                Master master = new Master();
                master.Show();
            }


            if (textBox1.Text == "bellum" && textBox2.Text == "ZjXm3JW7RJ")
            {
                Cmena cmena = new Cmena();
                cmena.Show();
            }
            if (textBox1.Text == "siller" && textBox2.Text == "dVMfx1VMFF")
            {
                Cmena cmena = new Cmena();
                cmena.Show();
            }
            if (textBox1.Text == "fautor" && textBox2.Text == "RJ41C0qynP")
            {
                Cmena cmena = new Cmena();
                cmena.Show();
            }
        }
    }
}