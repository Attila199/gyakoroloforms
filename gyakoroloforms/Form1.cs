using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyakoroloforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show($"Nem adott meg valamilyen adatot");
                return;

            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show($"Nem adott meg valamilyen adatot");
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show($"Nem adott meg valamilyen adatot");
                return;
            }
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show($"Nem adott meg valamilyen adatot");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show($"Nem adott meg valamilyen adatot");
            }
            else
            MessageBox.Show($"Üdvözöl {textBox1.Text}");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
