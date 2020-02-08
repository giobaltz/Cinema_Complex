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
    public partial class ReservetionSystem : Form
    {
        public bool sound;
        public ReservetionSystem()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = comboBox1.SelectedItem.ToString();
            if (curItem.Equals("Star Wars: The Rise of Skywalker"))
            {
                pictureBox1.Image = Properties.Resources.movie1;
            }
            else if (curItem.Equals("6 Underground"))
            {
                pictureBox1.Image = Properties.Resources.movie2;
            }
            else if (curItem.Equals("Cats"))
            {
                pictureBox1.Image = Properties.Resources.movie3;
            }
            else if (curItem.Equals("The Irishman"))
            {
                pictureBox1.Image = Properties.Resources.movie4;
            }
            else if (curItem.Equals("Ψηλά στον Ουρανό"))
            {
                pictureBox1.Image = Properties.Resources.movie5;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.BackColor != Color.Green)
            {
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor != Color.Green)
            {
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Gray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor != Color.Green)
            {
                button3.BackColor = Color.Green;
            }
            else
            {
                button3.BackColor = Color.Gray;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor != Color.Green)
            {
                button4.BackColor = Color.Green;
            }
            else
            {
                button4.BackColor = Color.Gray;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor != Color.Green)
            {
                button6.BackColor = Color.Green;
            }
            else
            {
                button6.BackColor = Color.Gray;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor != Color.Green)
            {
                button7.BackColor = Color.Green;
            }
            else
            {
                button7.BackColor = Color.Gray;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor != Color.Green)
            {
                button8.BackColor = Color.Green;
            }
            else
            {
                button8.BackColor = Color.Gray;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor != Color.Green)
            {
                button9.BackColor = Color.Green;
            }
            else
            {
                button9.BackColor = Color.Gray;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor != Color.Green)
            {
                button18.BackColor = Color.Green;
            }
            else
            {
                button18.BackColor = Color.Gray;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor != Color.Green)
            {
                button15.BackColor = Color.Green;
            }
            else
            {
                button15.BackColor = Color.Gray;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor != Color.Green)
            {
                button14.BackColor = Color.Green;
            }
            else
            {
                button14.BackColor = Color.Gray;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor != Color.Green)
            {
                button13.BackColor = Color.Green;
            }
            else
            {
                button13.BackColor = Color.Gray;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor != Color.Green)
            {
                button11.BackColor = Color.Green;
            }
            else
            {
                button11.BackColor = Color.Gray;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor != Color.Green)
            {
                button10.BackColor = Color.Green;
            }
            else
            {
                button10.BackColor = Color.Gray;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.BackColor != Color.Green)
            {
                button27.BackColor = Color.Green;
            }
            else
            {
                button27.BackColor = Color.Gray;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.BackColor != Color.Green)
            {
                button26.BackColor = Color.Green;
            }
            else
            {
                button26.BackColor = Color.Gray;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor != Color.Green)
            {
                button23.BackColor = Color.Green;
            }
            else
            {
                button23.BackColor = Color.Gray;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor != Color.Green)
            {
                button22.BackColor = Color.Green;
            }
            else
            {
                button22.BackColor = Color.Gray;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor != Color.Green)
            {
                button21.BackColor = Color.Green;
            }
            else
            {
                button21.BackColor = Color.Gray;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor != Color.Green)
            {
                button20.BackColor = Color.Green;
            }
            else
            {
                button20.BackColor = Color.Gray;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor != Color.Green)
            {
                button19.BackColor = Color.Green;
            }
            else
            {
                button19.BackColor = Color.Gray;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Reception reception = new Reception(sound);
            this.Close();
            reception.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            this.Close();
            payment.Show();
        }
    }
}
