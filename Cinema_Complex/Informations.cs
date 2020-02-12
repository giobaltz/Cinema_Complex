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
    public partial class Informations : Form
    {
        public Informations()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = comboBox1.SelectedItem.ToString();
            if (curItem.Equals("Star Wars: The Rise of Skywalker"))
            {
                pictureBox1.Image = Properties.Resources.movie1;
                richTextBox1.Text = Properties.Resources.InformationMovie1;
            }
            else if (curItem.Equals("6 Underground"))
            {
                pictureBox1.Image = Properties.Resources.movie2;
                richTextBox1.Text = Properties.Resources.InformationMovie2;
            }
            else if (curItem.Equals("Cats"))
            {
                pictureBox1.Image = Properties.Resources.movie3;
                richTextBox1.Text = Properties.Resources.InformationMovie3;
            }
            else if (curItem.Equals("The Irishman"))
            {
                pictureBox1.Image = Properties.Resources.movie4;
                richTextBox1.Text = Properties.Resources.InformationMovie4;
            }
            else if (curItem.Equals("Ψηλά στον Ουρανό"))
            {
                pictureBox1.Image = Properties.Resources.movie5;
                richTextBox1.Text = Properties.Resources.InformationMovie5;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Informations_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Properties.Resources.InformationMovie5;
        }
    }
}
