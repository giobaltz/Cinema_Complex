namespace Cinema_Complex
{
    partial class Hall
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.infobutton = new System.Windows.Forms.Button();
            this.pictureBox_wc = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.voice_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bar_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_wc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infobutton
            // 
            this.infobutton.BackColor = System.Drawing.Color.Transparent;
            this.infobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.infobutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infobutton.ForeColor = System.Drawing.Color.Black;
            this.infobutton.Location = new System.Drawing.Point(12, 12);
            this.infobutton.Name = "infobutton";
            this.infobutton.Size = new System.Drawing.Size(22, 23);
            this.infobutton.TabIndex = 13;
            this.infobutton.Text = "i";
            this.infobutton.UseVisualStyleBackColor = false;
            // 
            // pictureBox_wc
            // 
            this.pictureBox_wc.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_wc.BackgroundImage = global::Cinema_Complex.Properties.Resources.wc;
            this.pictureBox_wc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_wc.Location = new System.Drawing.Point(835, 120);
            this.pictureBox_wc.Name = "pictureBox_wc";
            this.pictureBox_wc.Size = new System.Drawing.Size(23, 22);
            this.pictureBox_wc.TabIndex = 21;
            this.pictureBox_wc.TabStop = false;
            // 
            // back
            // 
            this.back.BackgroundImage = global::Cinema_Complex.Properties.Resources.back_arrow;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Location = new System.Drawing.Point(12, 79);
            this.back.Name = "back";
            this.back.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.back.Size = new System.Drawing.Size(50, 23);
            this.back.TabIndex = 19;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // voice_button
            // 
            this.voice_button.BackColor = System.Drawing.Color.Transparent;
            this.voice_button.BackgroundImage = global::Cinema_Complex.Properties.Resources.volume_sound_audio_off;
            this.voice_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voice_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voice_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voice_button.ForeColor = System.Drawing.Color.Black;
            this.voice_button.Location = new System.Drawing.Point(50, 12);
            this.voice_button.Name = "voice_button";
            this.voice_button.Size = new System.Drawing.Size(22, 23);
            this.voice_button.TabIndex = 15;
            this.voice_button.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Cinema_Complex.Properties.Resources.hall;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1028, 539);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bar_label
            // 
            this.bar_label.AutoSize = true;
            this.bar_label.BackColor = System.Drawing.Color.Transparent;
            this.bar_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bar_label.Font = new System.Drawing.Font("Sitka Heading", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_label.Location = new System.Drawing.Point(575, 120);
            this.bar_label.Name = "bar_label";
            this.bar_label.Size = new System.Drawing.Size(28, 18);
            this.bar_label.TabIndex = 22;
            this.bar_label.Text = "Bar";
            this.bar_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 539);
            this.Controls.Add(this.bar_label);
            this.Controls.Add(this.pictureBox_wc);
            this.Controls.Add(this.back);
            this.Controls.Add(this.voice_button);
            this.Controls.Add(this.infobutton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Hall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hall";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_wc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button infobutton;
        private System.Windows.Forms.Button voice_button;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox pictureBox_wc;
        private System.Windows.Forms.Label bar_label;
    }
}