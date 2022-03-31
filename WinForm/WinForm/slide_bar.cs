using System;
using System.Windows.Forms;

namespace WinForm
{
    public partial class slide_bar : Form, Ibuttons
    {
        public slide_bar()
        {
            InitializeComponent();
        }
        
        private void slide_bar_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        public void file_1_Click(object sender, EventArgs e)
        {
            Field_of_user.current_file_of_user = "File_1";
            this.Close();
        }

        public void file_2_Click(object sender, EventArgs e)
        {
            Field_of_user.current_file_of_user = "File_2";
            this.Close();
        }

        public void file_3_Click(object sender, EventArgs e)
        {
            Field_of_user.current_file_of_user = "File_3";
            this.Close();
        }

        public void file_4_Click(object sender, EventArgs e)
        {
            Field_of_user.current_file_of_user = "File_4";
            this.Close();
        }

        public void file_5_Click(object sender, EventArgs e)
        {
            Field_of_user.current_file_of_user = "File_5";
            this.Close();
        }

        public void file_6_Click(object sender, EventArgs e)
        {
            Field_of_user.current_file_of_user = "File_6";
            this.Close();
        }

        public void file_7_Click(object sender, EventArgs e)
        {
            Field_of_user.current_file_of_user = "File_7";
            this.Close();
        }

        public void file_8_Click(object sender, EventArgs e)
        {
            Field_of_user.current_file_of_user = "File_8";
            this.Close();
        }

        public void file_9_Click(object sender, EventArgs e)
        {
            Field_of_user.current_file_of_user = "File_9";
            this.Close();
        }

        public void file_10_Click(object sender, EventArgs e)
        {
            Field_of_user.current_file_of_user = "File_10";
            this.Close();
        }
    }
}
