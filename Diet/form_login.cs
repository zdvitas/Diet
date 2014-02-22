using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diet
{
    public partial class form_login : Form
    {

        public cl_user user = new cl_user(); // Объект класса пользователя
        public form_login()
        {

            InitializeComponent();
            SyncUsers();
        }

        public void SyncUsers()
        {
            listBox1.Items.Clear();
            var con = new mysql_connect();
            con.connect();
            string[] users = con.get_users();
            listBox1.Items.AddRange(users);
            con.diconnect();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            // Вызывает окно добавления пользователя
            add_user add_form = new add_user(user);
            add_form.ShowDialog();
           // while (!add_form.closed)
            {

            }
            SyncUsers();

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя!", "ОШИБКА!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mysql_connect con = new mysql_connect();
            con.connect();

            // авторизация пользователя
            string pass = Microsoft.VisualBasic.Interaction.InputBox("Введите пароль", "Авторизация", "");
            user = con.Auth_user(listBox1.SelectedItem.ToString(), pass);

            con.diconnect();
            if (user == null)
            {
                MessageBox.Show("Ошибка авторизации", "ОШИБКА!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            main_form form = new main_form(user);
            form.Show();
            this.Hide();

        }


        private void btn_select_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (sender as Button);
            btn.Image = Properties.Resources.btn_2;
        }

        private void btn_select_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.Image = Properties.Resources.btn_1;
        }

        private void btn_select_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (sender as Button);
            btn.Image = Properties.Resources.btn_3;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя!", "ОШИБКА!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mysql_connect con = new mysql_connect();
            con.connect();
            string pass = Microsoft.VisualBasic.Interaction.InputBox("Введите пароль", "Авторизация", "");
            // авторизация пользователя
            user = con.Auth_user(listBox1.SelectedItem.ToString(), pass);

            con.diconnect();

            if (user == null)
            {
                MessageBox.Show("Ошибка авторизации", "ОШИБКА!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            add_user add_form = new add_user(user);
            add_form.ShowDialog();
            //while (!add_form.closed)
            {

            }
            SyncUsers();
        }
    }
}
