using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pizza_db
{
    public partial class edit_info : Form
    {
        private const string ConnectionString = "host=localhost;user=root;password=;database=pizza_proj";
        MySqlConnection conn = new MySqlConnection(ConnectionString);
        MySqlCommand comm;

        public edit_info()
        {
            InitializeComponent();
        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }
        void clear()
        {
            textBox_address.Text = null;
            textBox_city.Text = null;
            textBox_name.Text = null;
            textBox_road.Text = null;
            textBox_zipcode.Text = null;
            textBox_tel.Text = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_page m = new main_page();
            m.ShowDialog();
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {

            int u_id = first_page.uid;
            
            var name = textBox_name.Text;
            var lastname = textBox_lastname.Text;
            var addr = textBox_address.Text;
            var road = textBox_road.Text;
            var zipcode = textBox_zipcode.Text;
            var tel = textBox_tel.Text;
            var city = textBox_city.Text;
            var user = first_page.username;
            comm = conn.CreateCommand();

            comm.Parameters.AddWithValue("@user", user);
            comm.Parameters.AddWithValue("@name", name);
            comm.Parameters.AddWithValue("@lastname", lastname);
            comm.Parameters.AddWithValue("@addr", addr);
            comm.Parameters.AddWithValue("@u_id", u_id);
            comm.Parameters.AddWithValue("@road", road);
            comm.Parameters.AddWithValue("@tel", tel);
            comm.Parameters.AddWithValue("@city", city);
            comm.Parameters.AddWithValue("@zipcode", zipcode);
            
            comm.CommandText = "INSERT INTO pizza_proj.addr (addr_id,place,road,zipcode,city,tel) values(@u_id,@addr,@road,@zipcode,@city,@tel)on duplicate key update place = @addr,road =@road,zipcode=@zipcode,city=@city,tel=@tel";
            int addedinfo = comm.ExecuteNonQuery();
            comm.CommandText = "INSERT INTO pizza_proj.customer (customer_id,firstname,lastname,addr_id) values(@u_id,@name,@lastname,@u_id)on duplicate key update customer_id=@u_id,firstname=@name ,addr_id = @u_id ,username=@user ,lastname=@lastname";
            int addedinfo2 = comm.ExecuteNonQuery();

            try
            {

                MessageBox.Show("Save Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void open_connection()
        {
            
            conn.Open();

        }
        private void edit_info_Load(object sender, EventArgs e)
        {
            
            
        }

        private void edit_info_Activated(object sender, EventArgs e)
        {

        }

        private void edit_info_Load_1(object sender, EventArgs e)
        {
            open_connection();
            comm = conn.CreateCommand();
            int u_id = first_page.uid;
            var name = textBox_name.Text;
            var lastname = textBox_lastname.Text;
            var addr = textBox_address.Text;
            var road = textBox_road.Text;
            var zipcode = textBox_zipcode.Text;
            var tel = textBox_tel.Text;
            var city = textBox_city.Text;


            comm.Parameters.AddWithValue("@u_id", u_id);
            


            comm.CommandText = "SELECT firstname from customer where addr_id = @u_id";
            String name_old = Convert.ToString(comm.ExecuteScalar());
            textBox_name.Text = name_old;

            comm.CommandText = "SELECT lastname from customer where addr_id = @u_id";
            String lastname_old = Convert.ToString(comm.ExecuteScalar());
            textBox_lastname.Text = lastname_old;

            comm.CommandText = "SELECT place from addr where addr_id = @u_id";
            String address_old = Convert.ToString(comm.ExecuteScalar());
            textBox_address.Text = address_old;

            comm.CommandText = "SELECT road from addr where addr_id = @u_id";
            String road_old = Convert.ToString(comm.ExecuteScalar());
            textBox_road.Text = road_old;

            comm.CommandText = "SELECT zipcode from addr where addr_id = @u_id";
            String zipcode_old = Convert.ToString(comm.ExecuteScalar());
            textBox_zipcode.Text = zipcode_old;

            comm.CommandText = "SELECT tel from addr where addr_id = @u_id";
            String tel_old = Convert.ToString(comm.ExecuteScalar());
            textBox_tel.Text = tel_old;

            comm.CommandText = "SELECT city from addr where addr_id = @u_id";
            String city_old = Convert.ToString(comm.ExecuteScalar());
            textBox_city.Text = city_old;
        }
    }
}
