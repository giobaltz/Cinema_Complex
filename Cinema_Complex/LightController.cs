using Cinema_Complex.Properties;
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
    public partial class LightController : Form
    {
        bool sound;
        public LightController(bool sound)
        {
            this.sound = sound;
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Green;
            pictureBox1.Image = Resources.hall;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Green;
            pictureBox1.Image = Resources.wc_cgi;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Green;
            pictureBox1.Image = Resources.cinema_lights;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Green;
            pictureBox1.Image = Resources.office;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Green;
            pictureBox1.Image = Resources.cgi_bar;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Green;
            pictureBox1.Image = Resources.reseption2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                if(pictureBox2.BackColor == Color.Green)
                {
                    pictureBox2.BackColor = Color.Red;
                    pictureBox1.Image = Resources.dark_reseption2;
                }
                else
                {
                    pictureBox2.BackColor = Color.Green;
                    pictureBox1.Image = Resources.reseption2;
                }
            }
            else if(radioButton2.Checked == true)
            {
                if (pictureBox2.BackColor == Color.Green)
                {
                    pictureBox2.BackColor = Color.Red;
                    pictureBox1.Image = Resources.dark_hall;
                }
                else
                {
                    pictureBox2.BackColor = Color.Green;
                    pictureBox1.Image = Resources.hall;
                }
            }
            else if (radioButton3.Checked == true)
            {
                if (pictureBox2.BackColor == Color.Green)
                {
                    pictureBox2.BackColor = Color.Red;
                    pictureBox1.Image = Resources.dark_wc_cgi;
                }
                else
                {
                    pictureBox2.BackColor = Color.Green;
                    pictureBox1.Image = Resources.wc_cgi;
                }
            }
            else if (radioButton4.Checked == true)
            {
                if (pictureBox2.BackColor == Color.Green)
                {
                    pictureBox2.BackColor = Color.Red;
                    pictureBox1.Image = Resources.dark_cinema_lights;
                }
                else
                {
                    pictureBox2.BackColor = Color.Green;
                    pictureBox1.Image = Resources.cinema_lights;
                }
            }
            else if (radioButton5.Checked == true)
            {
                if (pictureBox2.BackColor == Color.Green)
                {
                    pictureBox2.BackColor = Color.Red;
                    pictureBox1.Image = Resources.dark_office;
                }
                else
                {
                    pictureBox2.BackColor = Color.Green;
                    pictureBox1.Image = Resources.office;
                }
            }
            else if (radioButton6.Checked == true)
            {
                if (pictureBox2.BackColor == Color.Green)
                {
                    pictureBox2.BackColor = Color.Red;
                    pictureBox1.Image = Resources.dark_cgi_bar;
                }
                else
                {
                    pictureBox2.BackColor = Color.Green;
                    pictureBox1.Image = Resources.cgi_bar;
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Application_Management application_management = new Application_Management(sound);
            this.Close();
            application_management.Show();
        }

        private void LightController_Load(object sender, EventArgs e)
        {
            if (sound)
            {
                button7.BackgroundImage = Properties.Resources.volume_sound_audio_on;
            }
            else
            {
                button7.BackgroundImage = Properties.Resources.volume_sound_audio_off;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sound)
            {
                button7.BackgroundImage = Properties.Resources.volume_sound_audio_off;
                sound = false;
            }
            else
            {
                button7.BackgroundImage = Properties.Resources.volume_sound_audio_on;
                sound = true;
            }
        }
    }
}
