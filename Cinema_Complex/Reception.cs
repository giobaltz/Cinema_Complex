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
    public partial class Reception : Form
    {
        public Reception()
        {
            InitializeComponent();

            pictureBox2.Parent = pictureBox1;
            pictureBox3.Parent = pictureBox1;
            pictureBox4.Parent = pictureBox1;
            pictureBox5.Parent = pictureBox1;
            pictureBox6.Parent = pictureBox1;
            pictureBox7.Parent = pictureBox1;
            pictureBox8.Parent = pictureBox1;
            pictureBox9.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
        }

        private void Reception_Load(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
        }
    }
}
