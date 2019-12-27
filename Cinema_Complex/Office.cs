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
    public partial class Office : Form
    {
        public Office()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reception reception = new Reception();
            this.Close();
            reception.Show();
        }

        private void Office_Load(object sender, EventArgs e)
        {
            pictureBox3.Parent = pictureBox1;
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application_Management application_Management = new Application_Management();
            application_Management.Show();
        }
    }
}
