using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet
{
    public class cl_eated
    {
        public int id;
        public cl_product product;
        public cl_user user;
        public cl_dish dish;
        public int kkal;
        public float mas;
        
        public cl_eated(cl_product prod , cl_user usr , float mas)
        {
            this.product = prod;
            this.user = usr;
            this.mas = mas;
            this.dish = null;
            
        }

        public cl_eated(cl_dish dish, cl_user usr, float mas)
        {
            this.product = null;
            this.user = usr;
            this.mas = mas;
            this.dish = dish;
        }

        public string make_post_query()
        {
            string rez= "";
            // Так муторно, потому что нет стандартного формата вывода времени, который нам подходит

            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string time = DateTime.Now.ToShortTimeString();
            
            
            if(dish == null)
            {
                rez = "INSERT INTO eated (`user_id`, `product_id`,  `mas`, `date` , `time`) VALUES ( ";
                rez += "'" + user.id.ToString() + "', '"+product.id.ToString()+"' , '"+mas.ToString()+"' ,'" +date+ "' ,'"+ time + "')";
            } else
            {
                rez = "INSERT INTO eated (`user_id`,  `dish_id`, `mas`, `date`) VALUES ( ";
                rez += "'" + user.id.ToString() + "', '" + dish.id.ToString()+"' , '"+mas.ToString()+"' ,'" +date+ "' ,'"+ time + "')";
            }

            return rez;
        }

    }
}
