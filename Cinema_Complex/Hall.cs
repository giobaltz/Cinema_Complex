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
        public Hall(bool sound)
        {
            InitializeComponent();
            this.sound = sound;
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.Parent = pictureBox1;
            pictureBox3.BackColor = Color.Transparent;
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            Reception reception = new Reception(sound);
            this.Close();
            reception.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant(sound);
            this.Close();
            restaurant.Show();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Blue;
            panel3.BackColor = Color.Blue;
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.μπαρ;
                player.Play();
            }
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LimeGreen;
            panel2.BackColor = Color.LimeGreen;
            panel3.BackColor = Color.LimeGreen;
        }

        private void Hall_Load(object sender, EventArgs e)
        {
            if (sound)
            {
                button1.BackgroundImage = Properties.Resources.volume_sound_audio_on;
            }
            else
            {
                button1.BackgroundImage = Properties.Resources.volume_sound_audio_off;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WC wC = new WC(sound);
            this.Close();
            wC.Show();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Blue;
            panel5.BackColor = Color.Blue;
            panel6.BackColor = Color.Blue;
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.μπαρ;
                player.Play();
            }
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.LimeGreen;
            panel5.BackColor = Color.LimeGreen;
            panel6.BackColor = Color.LimeGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sound)
            {
                button1.BackgroundImage = Properties.Resources.volume_sound_audio_off;
                sound = false;
            }
            else
            {
                button1.BackgroundImage = Properties.Resources.volume_sound_audio_on;
                sound = true;
            }
        }
    }
}
