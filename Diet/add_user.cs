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
    public partial class add_user : Form
    {
        public bool closed = false;

        public int radio_check = 0;
        public cl_user user;
        public add_user(cl_user user)
        {
            InitializeComponent();
            this.user = user;
            comboBox1.SelectedIndex = 0;
            SyncUsertoForm();
            closed = false;
        }

        private void SyncUsertoForm() //  user to form
        {
            // Заполнение формы из   user
            textBox1.Text = user.name;
            if (!user.sex)
                comboBox1.SelectedIndex = 1;
            numericUpDown1.Value = user.age;
            numericUpDown2.Value = user.rost;
            numericUpDown3.Value = user.ves;

        }

        public void SyncFormToUser()
        {
            user.sex = false;
            if (comboBox1.SelectedIndex == 0)
            {
                user.sex = true;
            }
            user.name = textBox1.Text;
            user.age = (int)numericUpDown1.Value;
            user.rost = (int)numericUpDown2.Value;
            user.ves = (int)numericUpDown3.Value;


        }

        private void radio_btn_Click(object sender, EventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            radio_check = int.Parse(li.Tag.ToString());
        }



        private void btn_select_Click(object sender, EventArgs e)
        {
            SyncFormToUser();
            string pass = Microsoft.VisualBasic.Interaction.InputBox("Придумайте пароль", "Создание пароля", "");
            string rez;
            var con = new mysql_connect();
            con.connect();

            rez = "INSERT INTO users ( `login`,`pass` ,`sex`,  `rost`,`ves`,`age`) VALUES ( '";
            rez += user.name + "', '" + pass.ToString() + "', '" + user.sex.ToString() + "' , '" + user.rost.ToString() +
                "' ,'" + user.ves.ToString() + "','" + user.age.ToString() + "');";
            con.Post_Query(rez);
            closed = true;
            this.Close();
        }

        private void btn_select_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.Image = Properties.Resources.btn_1;
        }

        private void btn_select_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (sender as Button);
            btn.Image = Properties.Resources.btn_2;
        }

        private void btn_select_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (sender as Button);
            btn.Image = Properties.Resources.btn_3;
        }

        private void add_user_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_user_FormClosing(object sender, FormClosingEventArgs e)
        {
            closed = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SyncFormToUser();
            string pass = Microsoft.VisualBasic.Interaction.InputBox("Введите пароль", "Создание пароля", "");
            string rez;
            var con = new mysql_connect();
            con.connect();
            rez = "UPDATE users SET `login`='" + user.name.ToString() + "', `pass`='" + pass.ToString() + "', `sex`='" + user.sex.ToString() + "', `age`='" + user.age.ToString() + "', `rost`='" + user.rost.ToString() + "', `ves`='" + user.ves.ToString() + "'where id=" + user.id + ";";
            MessageBox.Show(con.Post_Query(rez));

            closed = true;
            this.Close();
        }
    }
}
