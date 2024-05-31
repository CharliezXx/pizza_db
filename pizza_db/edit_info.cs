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
        MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=pizza_proj");
        


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
            MySqlCommand send_name;
            MySqlCommand a_id;
            var u_id = first_page.uid;
            var name = textBox_name.Text;
            
            send_name = conn.CreateCommand();
            a_id = conn.CreateCommand();
            send_name.Parameters.AddWithValue("@name", name);
            a_id.Parameters.AddWithValue("@uid", u_id);
            send_name.CommandText = "Update customer set name = @name where customer_id = @uid";
            a_id.CommandText = "Insert into addr_id from pizza_proj.addr";
        }

        private void edit_info_Load(object sender, EventArgs e)
        {
            conn.Open();
           
        }
    }
}
