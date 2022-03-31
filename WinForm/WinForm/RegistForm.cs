using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinForm
{
    public partial class RegistForm : Form, Iinput_feild
    {
        public RegistForm()
        {
            InitializeComponent();
        }

        private void RegistForm_Load(object sender, EventArgs e)
        {
            textBox_1.Text = "Enter your login";
            Registration_feild_2.Text = "Enter your password";
            textBox_1.ForeColor = Color.Gray;
            Registration_feild_2.ForeColor = Color.Gray;
            MaximizeBox = false;
        }

        public void textBox_1_Enter(object sender, EventArgs e)
        {
            if(textBox_1.Text == "Enter your login")
            {
                textBox_1.Text = "";
                textBox_1.ForeColor = Color.Black;
            }
        }
        public void textBox_1_Leave(object sender, EventArgs e)
        {
            if(textBox_1.Text == "")
            {
                textBox_1.Text = "Enter your login";
                textBox_1.ForeColor = Color.Gray;
            }
        }
        public void textBox_2_Enter(object sender, EventArgs e)
        {
            if (Registration_feild_2.Text == "Enter your password")
            {
                Registration_feild_2.Text = "";
                Registration_feild_2.ForeColor = Color.Black;
            }
        }

        public void textBox_2_Leave(object sender, EventArgs e)
        {
            if (Registration_feild_2.Text == "")
            {
                Registration_feild_2.Text = "Enter your password";
                Registration_feild_2.ForeColor = Color.Gray;
            }
        }

        public void input_method(object sender, EventArgs e)
        {
            if (textBox_1.Text == "" || textBox_1.Text == "Enter your login")
            {
                MessageBox.Show("Enter your login stupid user!");
                return;
            }

            if (Registration_feild_2.Text == "" || Registration_feild_2.Text == "Enter your password")
            {
                MessageBox.Show("Enter your password stupid user!");
                return;
            }
            else
            {
                fucntion();
            }
        }

        private void fucntion(){
            Data_Base data_Base = new Data_Base();
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES(@login, @pass)", data_Base.get_Connection());
            DataTable table_for_login = new DataTable();
            DataTable table_for_password = new DataTable();
            MySqlDataAdapter adapter_for_login = new MySqlDataAdapter();
            MySqlDataAdapter adapter_for_password = new MySqlDataAdapter();
            MySqlCommand command_login = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", data_Base.get_Connection());
            MySqlCommand command_password = new MySqlCommand("SELECT * FROM `users` WHERE `password` = @uP", data_Base.get_Connection());

            command_login.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBox_1.Text;
            command_password.Parameters.Add("@uP", MySqlDbType.VarChar).Value = Registration_feild_2.Text;
            mySqlCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox_1.Text;
            mySqlCommand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Registration_feild_2.Text;

            adapter_for_login.SelectCommand = command_login;
            adapter_for_password.SelectCommand = command_password;
            adapter_for_login.Fill(table_for_login);
            adapter_for_password.Fill(table_for_password);

            if(table_for_login.Rows.Count > 0)
            {
                MessageBox.Show("Some mistake");
                return;
            }

            if(table_for_password.Rows.Count > 0)
            {
                MessageBox.Show("Some mistake");
                return;
            }

            data_Base.open_Connection();

            if(mySqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account has been successfully created");
                this.Close();
            }
            else
            {
                MessageBox.Show("Some mistake has occurred");
            }

            data_Base.close_Connection();
        }

        private void Registration_feild_2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                input_method(sender, e);
            }
        }
    }
}
