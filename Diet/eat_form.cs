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
    public partial class eat_form : Form
    {
        List<cl_product> products;
        List<cl_eated> eated = new List<cl_eated>();

        cl_user user;

        public string[] ListToArray()
        {
            var rez = new string[products.Count];

            for (int i = 0; i < products.Count; i++ )
            {
                rez[i] = products[i].name;
            }

            return rez;

        }
        public eat_form(cl_user user)
        {

            InitializeComponent();
            this.user = user;

            var con = new mysql_connect();
            con.connect();
            products = con.get_products();
            products.AddRange(con.get_dishes());
            string[] products_name = ListToArray();
            comboBox1.Items.AddRange(products_name);
            comboBox1.SelectedIndex = 0;
            con.diconnect();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tmp = products[comboBox1.SelectedIndex];
            text_fats.Text = tmp.fats.ToString();
            text_kkal.Text = tmp.kkals.ToString();
            text_carbo.Text = tmp.carbo.ToString();
            text_prot.Text = tmp.proteins.ToString();
            CalcTotal();
        }

        private void text_mas_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void CalcTotal()
        {
            var tmp = products[comboBox1.SelectedIndex];
            float k = (float)text_mas.Value / 100f;
            text_prot_total.Text = (tmp.proteins * k).ToString();
            text_kkal_total.Text = (tmp.kkals * k).ToString();
            text_fats_total.Text = (tmp.fats * k).ToString();
            text_carbo_total.Text = (tmp.carbo * k).ToString();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            
            
            eated.Add(new cl_eated(products[comboBox1.SelectedIndex], user, (float)text_mas.Value));
            SyncTable();
        }

        private void SyncTable()
        {
            // Сделать паше пересчет суммы всех параметров
            dataGridView1.Rows.Clear();
            foreach(var tmp in eated)
            {
                string[] agrs = new string[6];
                float k = tmp.mas / 100;
                agrs[0] = tmp.product.name;
                agrs[1] = tmp.mas.ToString();
                agrs[2] = (tmp.product.fats * k).ToString();
                agrs[3] = (tmp.product.proteins * k).ToString();
                agrs[4] = (tmp.product.carbo * k).ToString();
                agrs[5] = (tmp.product.kkals * k).ToString();
                
                dataGridView1.Rows.Add(agrs);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new mysql_connect();
            con.connect();
            foreach(var tmp in eated)
            {
                con.Post_Query(tmp.make_post_query());
            }
           // 
            con.diconnect();
        }

        private void btn_add_dish_Click(object sender, EventArgs e)
        {

        }


        
    }
}
