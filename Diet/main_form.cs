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
    public partial class main_form : Form
    {
        public cl_user user = new cl_user(); // Объект класса пользователя

        public main_form(cl_user user)
        {
            this.user = user;
            InitializeComponent();
            label_name.Text = user.name;
        }

        private void main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new eat_form(user);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "AAAAAAAAAAA";
        }


    }
}
