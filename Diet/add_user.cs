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

        public int radio_check = 0;
        public cl_user user;
        public add_user(cl_user user)
        {
            InitializeComponent();
            this.user = user;
            comboBox1.SelectedIndex = 0;
            SyncUser();
        }

        private void SyncUser()
        {
            // Здесь будет функция синхронизации пользователя с формой
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radio_btn_Click(object sender, EventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            radio_check = int.Parse(li.Tag.ToString());
        }
    }
}
