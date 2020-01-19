using Microsoft.VisualBasic;
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
        bool sound, color;
        bool sound_door =true;
        int i = 1;
        public Reception(bool sound)
        {
            InitializeComponent();
            this.sound = sound;
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
            if (sound)
            {
                button1.BackgroundImage = Properties.Resources.volume_sound_audio_on;
            }
            else
            {
                button1.BackgroundImage = Properties.Resources.volume_sound_audio_off;
            }
            pictureBox10.Image = Properties.Resources.movie1;
            pictureBox11.Image = Properties.Resources.movie2;
            pictureBox12.Image = Properties.Resources.movie3;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            label1.Text = "Μόνο \n" + "Προσωπικό";
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

        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            sound_door = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:
                    pictureBox10.Image = Properties.Resources.movie2;
                    pictureBox11.Image = Properties.Resources.movie3;
                    pictureBox12.Image = Properties.Resources.movie4;
                    break;

                case 2:
                    pictureBox10.Image = Properties.Resources.movie3;
                    pictureBox11.Image = Properties.Resources.movie4;
                    pictureBox12.Image = Properties.Resources.movie5;
                    break;
                case 3:
                    pictureBox10.Image = Properties.Resources.movie4;
                    pictureBox11.Image = Properties.Resources.movie5;
                    pictureBox12.Image = Properties.Resources.movie1;
                    break;
                case 4:
                    pictureBox10.Image = Properties.Resources.movie5;
                    pictureBox11.Image = Properties.Resources.movie1;
                    pictureBox12.Image = Properties.Resources.movie2;
                    break;
                default:
                    pictureBox10.Image = Properties.Resources.movie1;
                    pictureBox11.Image = Properties.Resources.movie2;
                    pictureBox12.Image = Properties.Resources.movie3;
                    i = 0;
                    break;
            }
            i++;

        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream= moviesound(0);
                player.Play();
            }
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = moviesound(1);
                player.Play();
            }
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = moviesound(2);
                player.Play();
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (Interaction.InputBox("Πληκτρολογήστε τον ειδικό κωδικό για την είσοδο στο γραφείου του κινηματογράφου", "Έλεγχος εισόδου", "Πληκτρολογήστε εδώ!").Equals("1234"))
            {
                Office office = new Office(sound);
                this.Close();
                office.Show();
            }
            else
            {
                MessageBox.Show("Πληκτρολογήσατε λάθος κωδικό");
            }

        }

        private System.IO.UnmanagedMemoryStream moviesound(int z) {
            int y = i + z;
            if (y == 6)
            {
                y = 1;
            }
            else if (y == 7) 
            {
                y = 2;
            }
            switch (y) {            
                case 1:
                    return Properties.Resources.movie1sound;
                case 2:
                    return Properties.Resources.movie2sound;
                case 3:
                    return Properties.Resources.movie3sound;
                case 4:
                    return Properties.Resources.movie4sound;
                default:
                    return Properties.Resources.movie5sound;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Interaction.InputBox("Πληκτρολογήστε τον ειδικό κωδικό για την είσοδο στο γραφείου του κινηματογράφου", "Έλεγχος εισόδου", "Πληκτρολογήστε εδώ!").Equals("1234"))
            {
                Office office = new Office(sound);
                this.Close();
                office.Show();
            }
            else
            {
                MessageBox.Show("Πληκτρολογήσατε λάθος κωδικό");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (Interaction.InputBox("Πληκτρολογήστε τον ειδικό κωδικό για την είσοδο στο γραφείου του κινηματογράφου", "Έλεγχος εισόδου", "Πληκτρολογήστε εδώ!").Equals("1234"))
            {
                Office office = new Office(sound);
                this.Close();
                office.Show();
            }
            else
            {
                MessageBox.Show("Πληκτρολογήσατε λάθος κωδικό");
            }
        }

        private void infobutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hall hall = new Hall(sound);
            this.Close();
            hall.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Hall hall = new Hall(sound);
            this.Close();
            hall.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Hall hall = new Hall(sound);
            this.Close();
            hall.Show();
        }

        public void PaintColor()
        {
            if (color) {
                
            }
        }

        private void rightPictureBoxDoor_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Blue;
            panel4.BackColor = Color.Blue;
            panel6.BackColor = Color.Blue;
            panel8.BackColor = Color.Blue;
            panel10.BackColor = Color.Blue;
            panel12.BackColor = Color.Blue;
        }

        private void rightPictureBoxDoor_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LimeGreen;
            panel4.BackColor = Color.LimeGreen;
            panel6.BackColor = Color.LimeGreen;
            panel8.BackColor = Color.LimeGreen;
            panel10.BackColor = Color.LimeGreen;
            panel12.BackColor = Color.LimeGreen;
        }

        private void leftPictureBoxDoor_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LimeGreen;
            panel3.BackColor = Color.LimeGreen;
            panel5.BackColor = Color.LimeGreen;
            panel7.BackColor = Color.LimeGreen;
            panel9.BackColor = Color.LimeGreen;
            panel11.BackColor = Color.LimeGreen;
        }

        private void leftPictureBoxDoor_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel3.BackColor = Color.Blue;
            panel5.BackColor = Color.Blue;
            panel7.BackColor = Color.Blue;
            panel9.BackColor = Color.Blue;
            panel11.BackColor = Color.Blue;
        }
    }
}
