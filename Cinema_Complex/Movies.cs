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
    public partial class Movies : Form
    {
        bool sound;
        public Movies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (radioButton1.Checked)
                {
                    MessageBox.Show("Η εισαγωγή της ταινίας " + textBox1.Text + " στην αίθουσα " + comboBox1.SelectedItem + " την ώρα " + comboBox2.SelectedItem + " ολοκληρώθηκε");
                }
                else
                {
                    MessageBox.Show("Η διαγραφή της ταινίας " + textBox1.Text + " στην αίθουσα " + comboBox1.SelectedItem + " την ώρα " + comboBox2.SelectedItem + " ολοκληρώθηκε");
                }
            }
            else 
            {
                MessageBox.Show("Εισάγεται ταινία");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.SelectedItem = "A";
            comboBox2.SelectedItem = "17:00-19:00";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                radioButton2.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "A";
            comboBox2.SelectedItem = "17:00-19:00";
        }

        private void back_Click(object sender, EventArgs e)
        {
            Application_Management application_management = new Application_Management(sound);
            this.Close();
            application_management.Show();
        }
    }
}
