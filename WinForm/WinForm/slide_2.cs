using System;
using System.Windows.Forms;

namespace WinForm
{
    public partial class slide_2 : Form, Ibuttons
    {
        public slide_2()
        {
            InitializeComponent();
        }

        private void slide_2_Load(object sender, EventArgs e)
        {    
            MaximizeBox = false;
        }

        public void file_1_Click(object sender, EventArgs e)
        {
            Field_of_user.name = "File_1";
            this.Close();
        }

        public void file_2_Click(object sender, EventArgs e)
        {
            Field_of_user.name = "File_2";
            this.Close();
        }

        public void file_3_Click(object sender, EventArgs e)
        {
            Field_of_user.name = "File_3";
            this.Close();
        }

        public void file_4_Click(object sender, EventArgs e)
        {
            Field_of_user.name = "File_4";
            this.Close();
        }

        public void file_5_Click(object sender, EventArgs e)
        {
            Field_of_user.name = "File_5";
            this.Close();
        }

        public void file_6_Click(object sender, EventArgs e)
        {
            Field_of_user.name = "File_6";
            this.Close();
        }

        public void file_7_Click(object sender, EventArgs e)
        {
            Field_of_user.name = "File_7";
            this.Close();
        }

        public void file_8_Click(object sender, EventArgs e)
        {
            Field_of_user.name = "File_8";
            this.Close();
        }

        public void file_9_Click(object sender, EventArgs e)
        {
            Field_of_user.name = "File_9";
            this.Close();
        }

        public void file_10_Click(object sender, EventArgs e)
        {
            Field_of_user.name = "File_10";
            this.Close();
        }
    }
}
