using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace WinForm
{
    public partial class Field_of_user : Form, Ianimation
    {
        public Field_of_user()
        {
            InitializeComponent();
        }

        public static string[] line = null;
        public static string current_file_of_user = string.Empty;
        public static string name = string.Empty;
        private Animation anim = null;

        private void Feild_of_user_Load(object sender, EventArgs e)
        {
            anim = new Animation();
            MaximizeBox = false;

            anim.full_screen_animation_for_feild_of_user(pictureBox1, animation_two);
            animation();
        }

        public void animation()
        {
            anim.small_animation_for_feild_of_user(animation_two);
        }
        
        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            line = (string[])e.Data.GetData(DataFormats.FileDrop);
            button1.Text = line[0].Substring(line[0].LastIndexOf('\\') + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (line == null)
            {
                MessageBox.Show("Drag file");
            }
            else if(current_file_of_user == string.Empty)
            {
                MessageBox.Show("Choose a place");
            }
            else
            {
                button2_Click_method(sender, e);
            }
        }

        private void button2_Click_method(object sender, EventArgs e)
        {
            string file = string.Empty;
            
            try
            {
                StreamReader f = new StreamReader(line[0]);
                file = f.ReadToEnd();
                f.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }

            Data_Base db = new Data_Base();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand mySqlCommand = new MySqlCommand($"UPDATE `users` SET {current_file_of_user} = @d WHERE `users`.`login` = @l AND `users`.`password` = @p", db.get_Connection());

            mySqlCommand.Parameters.Add("@l", MySqlDbType.VarChar).Value = DTO.Login_user;
            mySqlCommand.Parameters.Add("@p", MySqlDbType.VarChar).Value = DTO.Pass_user;
            mySqlCommand.Parameters.Add("@d", MySqlDbType.Text).Value = file;

            adapter.SelectCommand = mySqlCommand;
            adapter.Fill(table);

            db.open_Connection();

            if(mySqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data uploaded successfully");
            }
            else
            {
                MessageBox.Show("Some exception");
            }

            db.close_Connection();

            line = null;
            current_file_of_user = string.Empty;
            button1.Text = "Drag file here";
        }

        private void del_user_file_Click(object sender, EventArgs e)
        {
            line = null;
            current_file_of_user = string.Empty;
            button1.Text = "Drag file here";
        }

        private void open_slide_bar_Click(object sender, EventArgs e)
        {
            slide_bar s = new slide_bar();
            Data_Base db = new Data_Base();

            db.open_Connection();

            for (int i = 1; i <= 10; i++)
            {
                string users_data = string.Empty;
                MySqlCommand sqlCommand_for_table = new MySqlCommand($"SELECT `File_{i}` FROM `users` WHERE `users`.`login` = @l AND `users`.`password` = @p", db.get_Connection());

                sqlCommand_for_table.Parameters.Add("@l", MySqlDbType.VarChar).Value = DTO.Login_user;
                sqlCommand_for_table.Parameters.Add("@p", MySqlDbType.VarChar).Value = DTO.Pass_user;

                MySqlDataReader reader = sqlCommand_for_table.ExecuteReader();    

                while (reader.Read())
                {
                    users_data += reader[0].ToString();
                }

                reader.Close();

                if(users_data.Length > 0)
                {
                    switch (i)
                    {
                        case 1:
                            s.file_1.Text = "Overwriting";
                            break;

                        case 2:
                            s.file_2.Text = "Overwriting";
                            break;

                        case 3:
                            s.file_3.Text = "Overwriting";
                            break;

                        case 4:
                            s.file_4.Text = "Overwriting";
                            break;

                        case 5:
                            s.file_5.Text = "Overwriting";
                            break;

                        case 6:
                            s.file_6.Text = "Overwriting";
                            break;

                        case 7:
                            s.file_7.Text = "Overwriting";
                            break;

                        case 8:
                            s.file_8.Text = "Overwriting";
                            break;

                        case 9:
                            s.file_9.Text = "Overwriting";
                            break;

                        case 10:
                            s.file_10.Text = "Overwriting";
                            break;
                    }
                }
            }

            db.close_Connection();
            s.ShowDialog();
        }

        private void change_file_Click(object sender, EventArgs e)
        {
            slide_2 s = new slide_2();
            Data_Base db = new Data_Base();

            db.open_Connection();

            for (int i = 1; i <= 10; i++)
            {
                string users_data = string.Empty;
                MySqlCommand sqlCommand_for_table = new MySqlCommand($"SELECT `File_{i}` FROM `users` WHERE `users`.`login` = @l AND `users`.`password` = @p", db.get_Connection());

                sqlCommand_for_table.Parameters.Add("@l", MySqlDbType.VarChar).Value = DTO.Login_user;
                sqlCommand_for_table.Parameters.Add("@p", MySqlDbType.VarChar).Value = DTO.Pass_user;

                MySqlDataReader reader = sqlCommand_for_table.ExecuteReader();

                while (reader.Read())
                {
                    users_data += reader[0].ToString();
                }

                reader.Close();

                if (users_data.Length > 0)
                {
                    switch (i)
                    {
                        case 1:
                            s.File_1_t.Text = "Some data";
                            break;

                        case 2:
                            s.File_2_t.Text = "Some data";
                            break;

                        case 3:
                            s.File_3_t.Text = "Some data";
                            break;

                        case 4:
                            s.File_4_t.Text = "Some data";
                            break;

                        case 5:
                            s.File_5_t.Text = "Some data";
                            break;

                        case 6:
                            s.File_6_t.Text = "Some data";
                            break;

                        case 7:
                            s.File_7_t.Text = "Some data";
                            break;

                        case 8:
                            s.File_8_t.Text = "Some data";
                            break;

                        case 9:
                            s.File_9_t.Text = "Some data";
                            break;

                        case 10:
                            s.File_10_t.Text = "Some data";
                            break;
                    }
                }
            }

            db.close_Connection();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(name == string.Empty)
            {
                MessageBox.Show("First of all select a file");
            }
            else
            {
                button3_Click_method(sender, e);
            }
        }

        private void button3_Click_method(object sender, EventArgs e)
        {
            string users_data = string.Empty;

            Data_Base db = new Data_Base();
            MySqlCommand sqlCommand = new MySqlCommand($"SELECT {name} FROM `users` WHERE `users`.`login` = @l AND `users`.`password` = @p", db.get_Connection());

            sqlCommand.Parameters.Add("@l", MySqlDbType.VarChar).Value = DTO.Login_user;
            sqlCommand.Parameters.Add("@p", MySqlDbType.VarChar).Value = DTO.Pass_user;

            db.open_Connection();

            MySqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                users_data += reader[0].ToString();
            }

            reader.Close();

            user_text_box.Text = users_data;
            line = null;
            current_file_of_user = string.Empty;
        }
        
        private void delete_data_of_file_Click(object sender, EventArgs e)
        {
            if(name == string.Empty)
            {
                MessageBox.Show("First of all select a file");
                return;
            }
            else
            {
                delete_data_of_file_Click_method(sender, e);
            }
        }

        private void delete_data_of_file_Click_method(object sender, EventArgs e)
        {
            Data_Base db = new Data_Base();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand mySqlCommand = new MySqlCommand($"UPDATE `users` SET {name} = @d WHERE `users`.`login` = @l AND `users`.`password` = @p", db.get_Connection());

            mySqlCommand.Parameters.Add("@l", MySqlDbType.VarChar).Value = DTO.Login_user;
            mySqlCommand.Parameters.Add("@p", MySqlDbType.VarChar).Value = DTO.Pass_user;
            mySqlCommand.Parameters.Add("@d", MySqlDbType.Text).Value = string.Empty;
         
            adapter.SelectCommand = mySqlCommand;
            adapter.Fill(table);

            db.open_Connection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data deleted successfully");
                user_text_box.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Some exception");
            }

            db.close_Connection();

            line = null;
            current_file_of_user = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Data_Base db = new Data_Base();
            MySqlCommand mySqlCommand = new MySqlCommand("DELETE FROM `users` WHERE `users`.`login` = @L AND `users`.`password` = @P", db.get_Connection());

            mySqlCommand.Parameters.Add("@L", MySqlDbType.VarChar).Value = DTO.Login_user;
            mySqlCommand.Parameters.Add("@P", MySqlDbType.VarChar).Value = DTO.Pass_user;

            db.open_Connection();

            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account deleted successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Some exception");
            }

            db.close_Connection();
        }

        private async void open_slide_bar_MouseEnter(object sender, EventArgs e)
        {
            anim.animation_for_feild_of_user(pictureBox1, animation_two);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            anim.animation_for_feild_of_user(pictureBox1, animation_two);
        }

        private void del_user_file_MouseEnter(object sender, EventArgs e)
        {
            anim.animation_for_feild_of_user(pictureBox1, animation_two);
        }

        private void delete_data_of_file_MouseEnter(object sender, EventArgs e)
        {
            anim.animation_for_feild_of_user(pictureBox1, animation_two);
        }

        private void change_file_MouseEnter(object sender, EventArgs e)
        {
            anim.animation_for_feild_of_user(pictureBox1, animation_two);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            anim.animation_for_feild_of_user(pictureBox1, animation_two);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            anim.animation_for_feild_of_user(pictureBox1, animation_two);
        }

        private void user_text_box_MouseEnter(object sender, EventArgs e)
        {
            anim.animation_for_feild_of_user(pictureBox1, animation_two);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            anim.animation_for_feild_of_user(pictureBox1, animation_two);
        }
    }
}
