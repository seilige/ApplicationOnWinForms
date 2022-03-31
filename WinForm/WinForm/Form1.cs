using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinForm
{
    public partial class Form1 : Form, Iinput_feild, Ianimation
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Animation anim;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            anim = new Animation();
            animation();

            textBox_1.Text = "Enter your login";
            textBox_2.Text = "Enter your password";
            textBox_1.ForeColor = Color.Gray;
            textBox_2.ForeColor = Color.Gray;
            MaximizeBox = false;
        }

        public void animation()
        {
            anim.animation_for_main_form(animation_feild);
        }
        
        public void input_method(object sender, EventArgs e)
        {
            DTO.Login_user = textBox_1.Text;
            DTO.Pass_user = textBox_2.Text;

            if(DTO.Login_user == "Enter your login" || DTO.Login_user == "")
            {
                MessageBox.Show("Enter your login stupid user!");
                return;
            }

            if(DTO.Pass_user == "Enter your password" || DTO.Pass_user == "")
            {
                MessageBox.Show("Enter your login stupid user!");
                return;
            }

            Data_Base db = new Data_Base();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.get_Connection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = DTO.Login_user;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = DTO.Pass_user;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Successfully");
                Field_of_user folder = new Field_of_user();
                folder.ShowDialog();
            }
            else
            {
                MessageBox.Show("You are not registered");
            }
        }

        public void textBox_2_Enter(object sender, EventArgs e)
        {
            if (textBox_2.Text == "Enter your password")
            {
                textBox_2.Text = "";
                textBox_2.ForeColor = Color.Black;
            }
        }

        public void textBox_2_Leave(object sender, EventArgs e)
        {
            if (textBox_2.Text == "")
            {
                textBox_2.Text = "Enter your password";
                textBox_2.ForeColor = Color.Gray;
            }
        }

        public void textBox_1_Enter(object sender, EventArgs e)
        {
            if (textBox_1.Text == "Enter your login")
            {
                textBox_1.Text = "";
                textBox_1.ForeColor = Color.Black;
            }
        }

        public void textBox_1_Leave(object sender, EventArgs e)
        {
            if (textBox_1.Text == "")
            {
                textBox_1.Text = "Enter your login";
                textBox_1.ForeColor = Color.Gray;
            }
        }

        private void register_method(object sender, EventArgs e)
        {
            RegistForm registForm = new RegistForm();
            registForm.ShowDialog();
        }

        private void textBox_2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                input_method(sender, e);
            }
        }
    }
}
