using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Complex
{
    public partial class Copier : Form
    {
        bool sound;
        public Copier(bool sound)
        {
            this.sound = sound;
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η σάρωση ξεκινά");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η σάρωση ακυρώθηκε");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εκτύπωση ξεκινά");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η εκτύπωση ακυρώθηκε");
        }

        private void back_Click(object sender, EventArgs e)
        {
            Application_Management application_management = new Application_Management(sound);
            this.Close();
            application_management.Show();
        }

        private void infobutton_Click(object sender, EventArgs e)
        {

        }
    }
}
