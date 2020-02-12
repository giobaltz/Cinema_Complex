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
    public partial class Reservations : Form
    {
        bool sound;
        string[] row1 = { "Χρήστος Γιαννίκης","Β","Avengers","21:00","A-5"};
        string[] row2 = { "Θάνος Γιαννίκης","Α","Inception","14:00","C-5"};
        string[] row3 = { "Γιώργος Μπαλτζόγλου","D","1917","21:00","E-5"};
        
        public Reservations(bool sound)
        {
            this.sound = sound;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η κράτηση προστέθηκε!");
        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            if (sound)
            {
                button7.BackgroundImage = Properties.Resources.volume_sound_audio_on;
            }
            else
            {
                button7.BackgroundImage = Properties.Resources.volume_sound_audio_off;
            }
            var listViewItem1 = new ListViewItem(row1);
            var listViewItem2 = new ListViewItem(row2);
            var listViewItem3 = new ListViewItem(row3);
            listView1.Items.Add(listViewItem1);
            listView1.Items.Add(listViewItem2);
            listView1.Items.Add(listViewItem3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η κράτηση αφαιρέθηκε!");
        }

        private void back_Click(object sender, EventArgs e)
        {
            Application_Management application_management = new Application_Management(sound);
            this.Close();
            application_management.Show();
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

        private void infobutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
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
    }
}
