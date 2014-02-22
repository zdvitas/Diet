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
    public partial class form_add_dish : Form
    {
        List<cl_product> products;

        List<cl_eated> dish_comp;

        public string[] ListToArray()
        {
            var rez = new string[products.Count];

            for (int i = 0; i < products.Count; i++)
            {
                rez[i] = products[i].name;
            }

            return rez;

        }
        public form_add_dish()
        {
            
            InitializeComponent();

            

            var con = new mysql_connect();
            con.connect();
            products = con.get_products();
            //products.AddRange(con.get_dishes());
            string[] products_name = ListToArray();
            comboBox1.Items.AddRange(products_name);
            comboBox1.SelectedIndex = 0;
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
        private void CalcTotal()
        {
            var tmp = products[comboBox1.SelectedIndex];
            float k = (float)text_mas.Value / 100f;
            text_prot_total.Text = (tmp.proteins * k).ToString();
            text_kkal_total.Text = (tmp.kkals * k).ToString();
            text_fats_total.Text = (tmp.fats * k).ToString();
            text_carbo_total.Text = (tmp.carbo * k).ToString();
        }

        private void text_mas_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {

        }
    }
}
