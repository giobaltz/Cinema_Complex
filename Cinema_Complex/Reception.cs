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
        bool sound;
        int i = 1;
        string pix10= "Star Wars: The Rise of Skywalker", pix11= "6 Underground", pix12= "Cats";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:
                    pictureBox10.Image = Properties.Resources.movie2;
                    pix10 = "6 Underground";
                    pictureBox11.Image = Properties.Resources.movie3;
                    pix11 = "Cats";
                    pictureBox12.Image = Properties.Resources.movie4;
                    pix12 = "The Irishman";
                    break;

                case 2:
                    pictureBox10.Image = Properties.Resources.movie3;
                    pix10 = "Cats";
                    pictureBox11.Image = Properties.Resources.movie4;
                    pix11 = "The Irishman";
                    pictureBox12.Image = Properties.Resources.movie5;
                    pix12 = "Ψηλά στον Ουρανό";
                    break;
                case 3:
                    pictureBox10.Image = Properties.Resources.movie4;
                    pix10 = "The Irishman";
                    pictureBox11.Image = Properties.Resources.movie5;
                    pix11 = "Ψηλά στον Ουρανό";
                    pictureBox12.Image = Properties.Resources.movie1;
                    pix12 = "Star Wars: The Rise of Skywalker";
                    break;
                case 4:
                    pictureBox10.Image = Properties.Resources.movie5;
                    pix10 = "Ψηλά στον Ουρανό";
                    pictureBox11.Image = Properties.Resources.movie1;
                    pix11 = "Star Wars: The Rise of Skywalker";
                    pictureBox12.Image = Properties.Resources.movie2;
                    pix12 = "6 Underground";
                    break;
                default:
                    pictureBox10.Image = Properties.Resources.movie1;
                    pix10 = "Star Wars: The Rise of Skywalker";
                    pictureBox11.Image = Properties.Resources.movie2;
                    pix11 = "6 Underground";
                    pictureBox12.Image = Properties.Resources.movie3;
                    pix12 = "Cats";
                    i = 0;
                    break;
            }
            i++;

        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            panel13.BackColor = Color.Blue;
            panel17.BackColor = Color.Blue;
            panel16.BackColor = Color.Blue;
            panel18.BackColor = Color.Blue;
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream= moviesound(0);
                player.Play();
            }
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            panel14.BackColor = Color.Blue;
            panel15.BackColor = Color.Blue;
            panel21.BackColor = Color.Blue;
            panel22.BackColor = Color.Blue;
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = moviesound(1);
                player.Play();
            }
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            panel19.BackColor = Color.Blue;
            panel20.BackColor = Color.Blue;
            panel23.BackColor = Color.Blue;
            panel24.BackColor = Color.Blue;
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = moviesound(2);
                player.Play();
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

        private void rightPictureBoxDoor_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Blue;
            panel4.BackColor = Color.Blue;
            panel6.BackColor = Color.Blue;
            panel8.BackColor = Color.Blue;
            panel10.BackColor = Color.Blue;
            panel12.BackColor = Color.Blue;
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Μόνο_προσωπικό;
                player.Play();
            }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ReservetionSystem reservetionSystem = new ReservetionSystem(sound,null);
            this.Close();
            reservetionSystem.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ReservetionSystem reservetionSystem = new ReservetionSystem(sound,pix10);
            this.Close();
            reservetionSystem.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ReservetionSystem reservetionSystem = new ReservetionSystem(sound,pix11);
            this.Close();
            reservetionSystem.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ReservetionSystem reservetionSystem = new ReservetionSystem(sound,pix12);
            this.Close();
            reservetionSystem.Show();
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.LimeGreen;
            panel17.BackColor = Color.LimeGreen;
            panel16.BackColor = Color.LimeGreen;
            panel18.BackColor = Color.LimeGreen;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Informations informations = new Informations();
            this.Close();
            informations.Show();
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            panel14.BackColor = Color.LimeGreen;
            panel15.BackColor = Color.LimeGreen;
            panel21.BackColor = Color.LimeGreen;
            panel22.BackColor = Color.LimeGreen;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            panel19.BackColor = Color.LimeGreen;
            panel20.BackColor = Color.LimeGreen;
            panel23.BackColor = Color.LimeGreen;
            panel24.BackColor = Color.LimeGreen;
        }

        private void leftPictureBoxDoor_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
            panel3.BackColor = Color.Blue;
            panel5.BackColor = Color.Blue;
            panel7.BackColor = Color.Blue;
            panel9.BackColor = Color.Blue;
            panel11.BackColor = Color.Blue;
            if (sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.Είσοδος;
                player.Play();
            }
        }
    }
}
