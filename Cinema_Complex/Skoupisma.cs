using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Complex
{
    public partial class Skoupisma : Form
    {
        bool sound;
        public Skoupisma(bool sound)
        {
            this.sound = sound;
            InitializeComponent();
        }

        private void Skoupisma_Load(object sender, EventArgs e)
        {
            if (sound)
            {
                button5.BackgroundImage = Properties.Resources.volume_sound_audio_on;
            }
            else
            {
                button5.BackgroundImage = Properties.Resources.volume_sound_audio_off;
            }
            pictureBox2.Parent = pictureBox1;
            pictureBox2.Location = new Point(650,30);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Location.X >= 30)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y);
            }
            else if(pictureBox2.Location.Y <= 450)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 5);
            }
            else
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Location.X <= 650)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y);
            }
            else if (pictureBox2.Location.Y >= 40)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 5);
            }
            else
            {
                timer2.Stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            pictureBox2.Location = new Point(650, 30);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Εντοπίστηκαν τα παρακάτω αντικείμενα:\n *Πορτοφόλι στη θέση D-2\n *Κινητό στη θέση F-3\n *Κλειδιά στη θέση F-5");
        }

        private void back_Click(object sender, EventArgs e)
        {
            Application_Management application_management = new Application_Management(sound);
            this.Close();
            application_management.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sound)
            {
                button5.BackgroundImage = Properties.Resources.volume_sound_audio_off;
                sound = false;
            }
            else
            {
                button5.BackgroundImage = Properties.Resources.volume_sound_audio_on;
                sound = true;
            }
        }

        private void infobutton_Click(object sender, EventArgs e)
        {
            String path = Directory.GetCurrentDirectory() + @"\Λειτουργία σκουπίσματος.pdf";
            if (File.Exists(path))
                System.Diagnostics.Process.Start(path);
        }

        private void infobutton_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.πληροφορίες_man;
                player.Play();
            }
        }

        private void back_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.πίσω_man;
                player.Play();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Έναρξη_Σκουπίσματος;
                player.Play();
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Διακοπή_Σκουπίσματος;
                player.Play();
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Χαμένα_Αντικείμενα;
                player.Play();
            }
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Χαρτογράφηση_Χώρου;
                player.Play();
            }
        }
    }
}
