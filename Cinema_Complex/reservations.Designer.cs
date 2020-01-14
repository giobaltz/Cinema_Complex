namespace Cinema_Complex
{
    partial class Reservations
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ονοματεπώνυμο = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Αίθουσα = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Τίτλος = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ώρα = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Θέση = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.infobutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ονοματεπώνυμο,
            this.Αίθουσα,
            this.Τίτλος,
            this.Ώρα,
            this.Θέση});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(75, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(419, 287);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Ονοματεπώνυμο
            // 
            this.Ονοματεπώνυμο.Text = "Ονοματεπώνυμο";
            this.Ονοματεπώνυμο.Width = 115;
            // 
            // Αίθουσα
            // 
            this.Αίθουσα.Text = "Αίθουσα";
            // 
            // Τίτλος
            // 
            this.Τίτλος.Text = "Τίτλος";
            // 
            // Ώρα
            // 
            this.Ώρα.Text = "Ώρα";
            // 
            // Θέση
            // 
            this.Θέση.Text = "Θέση";
            // 
            // infobutton
            // 
            this.infobutton.BackColor = System.Drawing.Color.Transparent;
            this.infobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.infobutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infobutton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infobutton.ForeColor = System.Drawing.Color.Black;
            this.infobutton.Location = new System.Drawing.Point(12, 12);
            this.infobutton.Name = "infobutton";
            this.infobutton.Size = new System.Drawing.Size(22, 23);
            this.infobutton.TabIndex = 13;
            this.infobutton.Text = "i";
            this.infobutton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(4, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 93);
            this.button1.TabIndex = 14;
            this.button1.Text = "Προσθήκη";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(4, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 93);
            this.button2.TabIndex = 15;
            this.button2.Text = "Αφαίρεση";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 311);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infobutton);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.Reservations_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button infobutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Ονοματεπώνυμο;
        private System.Windows.Forms.ColumnHeader Τίτλος;
        private System.Windows.Forms.ColumnHeader Αίθουσα;
        private System.Windows.Forms.ColumnHeader Ώρα;
        private System.Windows.Forms.ColumnHeader Θέση;
    }
}