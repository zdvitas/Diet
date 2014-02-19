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

        public cl_user user; // Объект класса пользователя
        public form_login()
        {
            InitializeComponent();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            // Вызывает окно добавления пользователя
            add_user add_form = new add_user(user);
            add_form.ShowDialog();

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            // Добавить авторизацию

            main_form form = new main_form(user);
            form.Show();
            this.Hide();
        }
    }
}
