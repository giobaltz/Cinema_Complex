using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Cinema_Complex
{
    public partial class Reception : Form
    {
        bool sound =false;
        bool sound_door =true;
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
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Πληροφορίες_κρατήσεων;
                player.Play();
            }
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Πληροφορίες_ταινιών;
                player.Play();
            }
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sound)
            {
                button1.BackgroundImage=Properties.Resources.volume_sound_audio_off;
                sound = false;
            }
            else 
            {
                button1.BackgroundImage = Properties.Resources.volume_sound_audio_on;
                sound = true;
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            if (sound && sound_door)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Είσοδος;
                player.Play();
                timer1.Start();
                sound_door = false;
            }
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            if (sound && sound_door)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Μόνο_εργαζόμενοι;
                player.Play();
                timer1.Start();
                sound_door = false;
            }
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            if (sound && sound_door)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Είσοδος;
                player.Play();
                timer1.Start();
                sound_door = false;
            }
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            if (sound && sound_door)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Μόνο_εργαζόμενοι;
                player.Play();
                timer1.Start();
                sound_door = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            sound_door = true;
        }
    }
}
