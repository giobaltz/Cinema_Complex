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
        bool sound;
        public Office(bool sound)
        {
            this.sound = sound;
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reception reception = new Reception(sound);
            this.Close();
            reception.Show();
        }

        private void Office_Load(object sender, EventArgs e)
        {
            if (sound)
            {
                button1.BackgroundImage = Properties.Resources.volume_sound_audio_on;
            }
            else 
            {
                button1.BackgroundImage = Properties.Resources.volume_sound_audio_off;
            }
            pictureBox3.Parent = pictureBox1;
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application_Management application_Management = new Application_Management(sound);
            application_Management.Show();
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

        private void infobutton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel2.BackColor = Color.Blue;
            panel3.BackColor = Color.Blue;
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Επιστροφή_στη_ρεσεψιόν;
                player.Play();
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Application_management;
                player.Play();
            }
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor =Color.LimeGreen;
            panel2.BackColor =Color.LimeGreen;
            panel3.BackColor =Color.LimeGreen;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Reception reception = new Reception(sound);
            this.Close();
            reception.Show();
        }
    }
}
