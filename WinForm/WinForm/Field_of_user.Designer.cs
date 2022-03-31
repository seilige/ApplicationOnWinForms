namespace WinForm
{
    partial class Field_of_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Field_of_user));
            this.open_slide_bar = new System.Windows.Forms.Label();
            this.del_user_file = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Label();
            this.change_file = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Label();
            this.user_text_box = new System.Windows.Forms.RichTextBox();
            this.delete_data_of_file = new System.Windows.Forms.Label();
            this.animation_two = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // open_slide_bar
            // 
            this.open_slide_bar.BackColor = System.Drawing.Color.Transparent;
            this.open_slide_bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_slide_bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.open_slide_bar.ForeColor = System.Drawing.Color.Coral;
            this.open_slide_bar.Location = new System.Drawing.Point(226, 351);
            this.open_slide_bar.Name = "open_slide_bar";
            this.open_slide_bar.Size = new System.Drawing.Size(84, 54);
            this.open_slide_bar.TabIndex = 13;
            this.open_slide_bar.Text = "Choose a place";
            this.open_slide_bar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.open_slide_bar.Click += new System.EventHandler(this.open_slide_bar_Click);
            this.open_slide_bar.MouseEnter += new System.EventHandler(this.open_slide_bar_MouseEnter);
            // 
            // del_user_file
            // 
            this.del_user_file.BackColor = System.Drawing.Color.Transparent;
            this.del_user_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_user_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.del_user_file.ForeColor = System.Drawing.Color.Coral;
            this.del_user_file.Location = new System.Drawing.Point(12, 300);
            this.del_user_file.Name = "del_user_file";
            this.del_user_file.Size = new System.Drawing.Size(96, 42);
            this.del_user_file.TabIndex = 14;
            this.del_user_file.Text = "Delete file";
            this.del_user_file.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.del_user_file.Click += new System.EventHandler(this.del_user_file_Click);
            this.del_user_file.MouseEnter += new System.EventHandler(this.del_user_file_MouseEnter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(114, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "Insert file";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button3.ForeColor = System.Drawing.Color.Coral;
            this.button3.Location = new System.Drawing.Point(620, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 39);
            this.button3.TabIndex = 16;
            this.button3.Text = "Show file data";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            // 
            // change_file
            // 
            this.change_file.BackColor = System.Drawing.Color.Transparent;
            this.change_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.change_file.ForeColor = System.Drawing.Color.Coral;
            this.change_file.Location = new System.Drawing.Point(468, 199);
            this.change_file.Name = "change_file";
            this.change_file.Size = new System.Drawing.Size(106, 39);
            this.change_file.TabIndex = 17;
            this.change_file.Text = "Select a file";
            this.change_file.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.change_file.Click += new System.EventHandler(this.change_file_Click);
            this.change_file.MouseEnter += new System.EventHandler(this.change_file_MouseEnter);
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 114);
            this.button1.TabIndex = 18;
            this.button1.Text = "Drag file here";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.DragDrop += new System.Windows.Forms.DragEventHandler(this.button1_DragDrop);
            this.button1.DragEnter += new System.Windows.Forms.DragEventHandler(this.button1_DragEnter);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // user_text_box
            // 
            this.user_text_box.BackColor = System.Drawing.SystemColors.Control;
            this.user_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.user_text_box.Location = new System.Drawing.Point(448, 12);
            this.user_text_box.Name = "user_text_box";
            this.user_text_box.ReadOnly = true;
            this.user_text_box.Size = new System.Drawing.Size(301, 184);
            this.user_text_box.TabIndex = 20;
            this.user_text_box.Text = "";
            this.user_text_box.MouseEnter += new System.EventHandler(this.user_text_box_MouseEnter);
            // 
            // delete_data_of_file
            // 
            this.delete_data_of_file.BackColor = System.Drawing.Color.Transparent;
            this.delete_data_of_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_data_of_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.delete_data_of_file.ForeColor = System.Drawing.Color.Coral;
            this.delete_data_of_file.Location = new System.Drawing.Point(340, 12);
            this.delete_data_of_file.Name = "delete_data_of_file";
            this.delete_data_of_file.Size = new System.Drawing.Size(102, 51);
            this.delete_data_of_file.TabIndex = 21;
            this.delete_data_of_file.Text = "Delete file data";
            this.delete_data_of_file.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete_data_of_file.Click += new System.EventHandler(this.delete_data_of_file_Click);
            this.delete_data_of_file.MouseEnter += new System.EventHandler(this.delete_data_of_file_MouseEnter);
            // 
            // animation_two
            // 
            this.animation_two.BackColor = System.Drawing.Color.Transparent;
            this.animation_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animation_two.ForeColor = System.Drawing.Color.Coral;
            this.animation_two.Location = new System.Drawing.Point(31, 33);
            this.animation_two.Name = "animation_two";
            this.animation_two.Size = new System.Drawing.Size(740, 465);
            this.animation_two.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(660, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 64);
            this.label1.TabIndex = 24;
            this.label1.Text = "Delete account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // Feild_of_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(761, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_data_of_file);
            this.Controls.Add(this.user_text_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.change_file);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.del_user_file);
            this.Controls.Add(this.open_slide_bar);
            this.Controls.Add(this.animation_two);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Feild_of_user";
            this.Text = "User feild";
            this.Load += new System.EventHandler(this.Feild_of_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label open_slide_bar;
        private System.Windows.Forms.Label del_user_file;
        private System.Windows.Forms.Label button2;
        private System.Windows.Forms.Label button3;
        private System.Windows.Forms.Label change_file;
        private System.Windows.Forms.Label button1;
        private System.Windows.Forms.RichTextBox user_text_box;
        private System.Windows.Forms.Label delete_data_of_file;
        private System.Windows.Forms.Label animation_two;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}