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
    public partial class Application_Management : Form
    {
        public Application_Management()
        {
            InitializeComponent();
        }

        private void Application_Management_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(62,151,155);
            button2.BackColor = Color.FromArgb(109,180,100);
            button3.BackColor = Color.FromArgb(243,193,78);
            button4.BackColor = Color.FromArgb(247,128,85);
            button5.BackColor = Color.FromArgb(201,118,148);
            button6.BackColor = Color.FromArgb(62,151,155);
        }
    }
}
