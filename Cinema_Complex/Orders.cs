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

    public partial class Orders : Form
    {
        bool sound;
        string[] row1 = { "Α50", "Coca Cola", "2" };
        string[] row2 = { "B30", "Chips", "1.50" };
        string[] row3 = { "C15", "Pop Corn", "3" };

        public Orders(bool sound)
        {
            this.sound = sound;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η παραγγελία εκτελέστηκε!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η παραγγελία ακυρώθηκε!");
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            if (sound)
            {
                button5.BackgroundImage = Properties.Resources.volume_sound_audio_on;
            }
            else
            {
                button5.BackgroundImage = Properties.Resources.volume_sound_audio_off;
            }
            var listViewItem1 = new ListViewItem(row1);
            var listViewItem2 = new ListViewItem(row2);
            var listViewItem3 = new ListViewItem(row3);
            listView1.Items.Add(listViewItem1);
            listView1.Items.Add(listViewItem2);
            listView1.Items.Add(listViewItem3);
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
            String path = Directory.GetCurrentDirectory() + @"\Σύστημα παραγγελιών.pdf";
            if (File.Exists(path))
                System.Diagnostics.Process.Start(path);
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

        private void infobutton_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.πληροφορίες_man;
                player.Play();
            }
        }
    }
}
