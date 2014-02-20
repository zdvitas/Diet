using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Diet
{
    class mysql_connect
    {

        private MySqlConnection myConnection;

        public mysql_connect()
        {
        }

        private
        string v_base = "Diet";
        string v_host = "zdvitas.asuscomm.com";
        string v_user = "diet";
        string v_pass = "qwerty123";

        public string connect()
        {
            string Connect = "Database=" + v_base + ";Data Source=" + v_host +
            ";User Id=" + v_user + ";Password=" + v_pass + ";charset=utf8";
            myConnection = new MySqlConnection(Connect);
            try
            {
                myConnection.Open(); //Устанавливаем соединение с базой данных.  
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
            return "OK";
                 

        }

        public cl_user Auth_user(string login , string pass)
        {
            cl_user user ;
            user = null;
            MySqlDataReader MyDataReader;
            string query = "select * from users where login ='" + login +"' and pass = " + "'" + pass + "';" ;
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            MyDataReader = myCommand.ExecuteReader();

            try
            {


                while (MyDataReader.Read())
                {
                    user = new cl_user();
                    user.id = !MyDataReader.IsDBNull(0) ? MyDataReader.GetInt32(0) : 0;
                    user.name = !MyDataReader.IsDBNull(1) ? MyDataReader.GetString(1) : "";
                    user.sex = !MyDataReader.IsDBNull(3) ? MyDataReader.GetBoolean(3) : false;
                    user.rost = !MyDataReader.IsDBNull(4) ? MyDataReader.GetInt32(4) : 0;
                    user.ves = !MyDataReader.IsDBNull(5) ? MyDataReader.GetInt32(5) : 0;
                    user.age = !MyDataReader.IsDBNull(6) ? MyDataReader.GetInt32(6) : 0;

                }
            }
            catch
            {

            }
            MyDataReader.Close();

            return user;

        }

        public string Post_Query(string query)
        {
            string rez = "ОК";
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                rez = e.ToString();
                // Let it silence
            }

            return rez;
        }

  

        public string[] get_users()
        {
            List<string> rez = new List<string>();

            MySqlDataReader MyDataReader;
            string query = "select login from users ;";
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            MyDataReader = myCommand.ExecuteReader();

            try
            {
                while (MyDataReader.Read())
                {
                   string tmp = !MyDataReader.IsDBNull(0) ? MyDataReader.GetString(0) : "";
                   if(tmp != "")
                       rez.Add(tmp);
                }
            }
            catch
            {

            }
            MyDataReader.Close();

            return rez.ToArray<string>();
        }

        public List<cl_product> get_products()
        {
            var rez = new List<cl_product>();

            MySqlDataReader MyDataReader;
            string query = "select * from products ;";
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            MyDataReader = myCommand.ExecuteReader();

            try
            {
                while (MyDataReader.Read())
                {
                    var tmp = new cl_product();
                    tmp.id = !MyDataReader.IsDBNull(0) ? MyDataReader.GetInt32(0) : 0;
                    tmp.name = !MyDataReader.IsDBNull(1) ? MyDataReader.GetString(1) : "";
                    tmp.fats = !MyDataReader.IsDBNull(2) ? MyDataReader.GetFloat(2) : 0;
                    tmp.proteins = !MyDataReader.IsDBNull(3) ? MyDataReader.GetFloat(3) : 0;
                    tmp.carbo = !MyDataReader.IsDBNull(4) ? MyDataReader.GetFloat(4) : 0;
                    tmp.kkals = !MyDataReader.IsDBNull(5) ? MyDataReader.GetFloat(5) : 0;


                    if (tmp.name != "")
                        rez.Add(tmp);
                }
            }
            catch
            {

            }
            MyDataReader.Close();

            return rez;
        }

        public List<cl_product> get_dishes()
        {
            var rez = new List<cl_product>();

            MySqlDataReader MyDataReader;
            string query = "select * from dishes ;";
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            MyDataReader = myCommand.ExecuteReader();
            

            try
            {
                while (MyDataReader.Read())
                {
                    var tmp = new cl_dish();

                    tmp.name = !MyDataReader.IsDBNull(1) ? MyDataReader.GetString(1) : "";
                    tmp.fats = !MyDataReader.IsDBNull(2) ? MyDataReader.GetFloat(2) : 0;
                    tmp.proteins = !MyDataReader.IsDBNull(3) ? MyDataReader.GetFloat(3) : 0;
                    tmp.carbo = !MyDataReader.IsDBNull(4) ? MyDataReader.GetFloat(4) : 0;
                    tmp.kkals = !MyDataReader.IsDBNull(5) ? MyDataReader.GetFloat(5) : 0;


                    if (tmp.name != "")
                        rez.Add(tmp);
                }
            }
            catch
            {

            }
            MyDataReader.Close();

            return rez;
        }


        public void diconnect()
        {
            myConnection.Close();
        }
    }
}
