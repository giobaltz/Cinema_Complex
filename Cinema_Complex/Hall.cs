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
    public partial class Hall : Form
    {
        bool sound;
        public Hall()
        {

            InitializeComponent();
        }




        private void back_Click_1(object sender, EventArgs e)
        {
            Reception reception = new Reception(sound);
            this.Close();
            reception.Show();
        }
    }
}
