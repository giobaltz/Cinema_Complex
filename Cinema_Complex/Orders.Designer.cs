namespace Cinema_Complex
{
    partial class Orders
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.infobutton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Εισιτήριο = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Παραγγελία = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Τιμή = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 93);
            this.button2.TabIndex = 19;
            this.button2.Text = "Ακύρωση";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 93);
            this.button1.TabIndex = 18;
            this.button1.Text = "Εκτέλεση";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.infobutton.TabIndex = 17;
            this.infobutton.Text = "i";
            this.infobutton.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Εισιτήριο,
            this.Παραγγελία,
            this.Τιμή});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(75, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(419, 287);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Εισιτήριο
            // 
            this.Εισιτήριο.DisplayIndex = 1;
            this.Εισιτήριο.Text = "Εισιτήριο";
            // 
            // Παραγγελία
            // 
            this.Παραγγελία.DisplayIndex = 0;
            this.Παραγγελία.Text = "Παραγγελία";
            this.Παραγγελία.Width = 115;
            // 
            // Τιμή
            // 
            this.Τιμή.Text = "Τιμή";
            // 
            // back
            // 
            this.back.BackgroundImage = global::Cinema_Complex.Properties.Resources.back_arrow;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Location = new System.Drawing.Point(12, 52);
            this.back.Name = "back";
            this.back.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.back.Size = new System.Drawing.Size(50, 23);
            this.back.TabIndex = 21;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 311);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infobutton);
            this.Controls.Add(this.listView1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button infobutton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Παραγγελία;
        private System.Windows.Forms.ColumnHeader Εισιτήριο;
        private System.Windows.Forms.ColumnHeader Τιμή;
        private System.Windows.Forms.Button back;
    }
}