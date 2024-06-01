using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_address.Text = null;
            textBox_city.Text = null;
            textBox_name.Text = null;
            textBox_road.Text = null;
            textBox_zipcode.Text = null;
            textBox_tel.Text = null;
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

            int a_id = first_page.uid;
            var name = textBox_name.Text;
            var addr = textBox_address.Text;
            var road = textBox_road.Text;
            var zipcode = textBox_zipcode.Text;
            var tel = textBox_tel.Text;
            var city = textBox_city.Text;
            var user = first_page.username;
            comm = conn.CreateCommand();

            comm.Parameters.AddWithValue("@user", user);
            comm.Parameters.AddWithValue("@name", name);
            comm.Parameters.AddWithValue("@addr", addr);
            comm.Parameters.AddWithValue("@a_id", a_id);
            comm.Parameters.AddWithValue("@road", road);
            comm.Parameters.AddWithValue("@tel", tel);
            comm.Parameters.AddWithValue("@city", city);
            comm.Parameters.AddWithValue("@zipcode", zipcode);
            
            comm.CommandText = "INSERT INTO pizza_proj.addr (addr_id,place,road,zipcode,city) values(@a_id,@addr,@road,@zipcode,@city)on duplicate key update place = @addr,road =@road,zipcode=@zipcode,city=@city";
            int addedinfo = comm.ExecuteNonQuery();
            comm.CommandText = "INSERT INTO pizza_proj.customer (customer_id,name,tel,addr_id) values(@a_id,@name,@tel,@a_id)on duplicate key update customer_id=@a_id,name=@name , tel = @tel ,addr_id = @a_id ,username=@user ";
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
        }
    }
}
