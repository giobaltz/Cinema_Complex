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
    public partial class WC : Form
    {
        public bool sound;
        public WC()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hall hall = new Hall(sound);
            this.Close();
            hall.Show();
        }
    }
}
