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
    public partial class Restaurant : Form
    {
        bool sound;
        public Restaurant(bool sound)
        {
            this.sound = sound;
            InitializeComponent();
        }

        private void Restaurant_Load(object sender, EventArgs e)
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

        private void back_Click(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.πίσω_woman;
                player.Play();
            }
            Hall hall = new Hall(sound);
            this.Close();
            hall.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text== "Εισαγωγή εισιτηρίου") 
            {
                textBox1.Text ="";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η παραγγελία σας εκτελέστηκε");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η παραγγελία σας ακυρώθηκε");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Εισαγωγή εισιτηρίου";
            }
        }

        private void button2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Enter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.coca_cola1;
                player.Play();
            }
        }

        private void button5_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Enter(object sender, EventArgs e)
        {

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

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Πατατάκια;
                player.Play();
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.coca_cola1;
                player.Play();
            }
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.pop_corn;
                player.Play();
            }
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.doritos;
                player.Play();
            }
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.εκτέλεση;
                player.Play();
            }
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.ακύρωση;
                player.Play();
            }
        }

        private void infobutton_Click(object sender, EventArgs e)
        {
            String path = Directory.GetCurrentDirectory() + @"\Μπάρ_Κυλικείο.pdf";
            if (File.Exists(path))
                System.Diagnostics.Process.Start(path);
        }

        private void infobutton_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.πληροφορίες_woman;
                player.Play();
            }
        }

        private void back_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.πίσω_woman;
                player.Play();
            }
        }
    }
}
