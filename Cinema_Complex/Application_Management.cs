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
        bool sound;
        public Application_Management(bool sound)
        {
            this.sound = sound;
            InitializeComponent();
        }

        private void Application_Management_Load(object sender, EventArgs e)
        {
            if (sound)
            {
                button7.BackgroundImage = Properties.Resources.volume_sound_audio_on;
            }
            else
            {
                button7.BackgroundImage = Properties.Resources.volume_sound_audio_off;
            }
            button1.BackColor = Color.FromArgb(62,151,155);
            button2.BackColor = Color.FromArgb(109,180,100);
            button3.BackColor = Color.FromArgb(243,193,78);
            button4.BackColor = Color.FromArgb(247,128,85);
            button5.BackColor = Color.FromArgb(201,118,148);
            button6.BackColor = Color.FromArgb(62,151,155);
        }

        private void infobutton_Click(object sender, EventArgs e)
        {

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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.κρατήσεις;
                player.Play();
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.ταινίες;
                player.Play();
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.σκούπισμα;
                player.Play();
            }
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.φωτισμός;
                player.Play();
            }
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.εκτέλεση_παραγγελιών;
                player.Play();
            }
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.έλεγχος_εισιτηρίων;
                player.Play();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LightController lightController = new LightController();
            this.Close();
            lightController.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservations reservation = new Reservations();
            this.Close();
            reservation.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movies movies = new Movies();
            this.Close();
            movies.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Skoupisma skoupisma = new Skoupisma();
            this.Close();
            skoupisma.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            this.Close();
            orders.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Copier copier = new Copier();
            this.Close();
            copier.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Office office = new Office(sound);
            this.Close();
            office.Show();
        }
    }
}
