using System;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinForm
{
    interface Iinput_feild
    {
        void textBox_1_Enter(object sender, EventArgs e);
        void textBox_1_Leave(object sender, EventArgs e);
        void textBox_2_Enter(object sender, EventArgs e);
        void textBox_2_Leave(object sender, EventArgs e);
        void input_method(object sender, EventArgs e);
    }

    interface Ianimation
    {
        void animation();
    }

    interface I_animation
    {
        void full_screen_animation_for_feild_of_user(PictureBox obj, Label animation);
        void small_animation_for_feild_of_user(Label obj);
        void animation_for_main_form(Label obj);
    }

    interface Ibuttons
    {
        void file_1_Click(object sender, EventArgs e);
        void file_2_Click(object sender, EventArgs e);
        void file_3_Click(object sender, EventArgs e);
        void file_4_Click(object sender, EventArgs e);
        void file_5_Click(object sender, EventArgs e);
        void file_6_Click(object sender, EventArgs e);
        void file_7_Click(object sender, EventArgs e);
        void file_8_Click(object sender, EventArgs e);
        void file_9_Click(object sender, EventArgs e);
        void file_10_Click(object sender, EventArgs e);
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Data_Base
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=mysql;database=seilige");

        public void open_Connection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void close_Connection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection get_Connection()
        {
            return connection;
        }
    }

    class DTO
    {
        public static string Login_user = string.Empty;
        public static string Pass_user = string.Empty;
    }

    class Animation : I_animation
    {
        public async void full_screen_animation_for_feild_of_user(PictureBox obj, Label animation)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i <= 10; ++i)
                {
                    if (i == 3 || i == 6 || i == 8)
                    {
                        obj.Size = new System.Drawing.Size(777, 522);
                        animation.SendToBack();
                        Thread.Sleep(300);
                        obj.Size = new System.Drawing.Size(0, 0);
                        obj.SendToBack();
                    }

                    if (i == 10)
                    {
                        i = -1;
                    }

                    Thread.Sleep(2000);
                }
            });
        }

        public async void small_animation_for_feild_of_user(Label obj)
        {
            await Task.Run(() =>
            {
                string[] array = { "<3  <3", "0  0", "x  x", "~  ^", "(@)  (@)", ">_", ">", ">_", ">", ">_", ">", "</>", "ae", "?  ?", "X  X", "1  1", "e.Effect = DragDropEffects.Copy;}}private void button1_DragDrop(object sender, DragEventArgs e){line = (string[])e.Data.GetData(DataFormats.FileDrop);button1.Text = line[0].Substring(line[0].LastIndexOf('\\') + 1);}private void button2_Click(object sender, EventArgs e){string file = string.Empty;try{StreamReader f = new StreamReader(line[0]);file = f.ReadToEnd();f.Close();}catch (Exception ex){MessageBox.Show(${ ex });class Data_Base{MySqlConnection connection = new MySqlConnection(server = localhost; port = 3306; username = mysql; database = seilige);public void open_Connection(){if(connection.State == System.Data.ConnectionState.Closed){connection.Open();}}public void close_Connection(){if (connection.State == System.Data.ConnectionState.Open){connection.Close();}}public MySqlConnection get_Connection(){return connection;}}class DTO{public static string Login_user { get; set; }public static string Pass_user { get; set; }" };

                for (int i = 0; i <= array.Length - 1; ++i)
                {
                    obj.Text = array[i].ToString();

                    if (i == array.Length - 1)
                    {
                        i = -1;
                    }

                    Thread.Sleep(900);
                }
            });
        }

        public async void animation_for_main_form(Label obj)
        {
            await Task.Run(() =>
            {
                string[] array = { @"\", "|", "/", "-", @"\", "|", "/", "-" };

                for (int i = 0; i <= array.Length - 1; ++i)
                {
                    obj.Text = array[i].ToString();

                    if (i == array.Length - 1)
                    {
                        i = -1;
                    }

                    Thread.Sleep(500);
                }
            });
        }

        public async void animation_for_feild_of_user(PictureBox pb, Label obj)
        {
            await Task.Run(() =>
            {
                pb.Size = new System.Drawing.Size(777, 522);
                obj.SendToBack();
                Thread.Sleep(300);
                pb.Size = new System.Drawing.Size(0, 0);
                pb.SendToBack();
            });
        }
    }
}
