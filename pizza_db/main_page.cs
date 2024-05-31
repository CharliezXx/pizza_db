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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace pizza_db
{
    public partial class main_page : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=pizza_proj");
        MySqlCommand comm;

        public main_page()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label_username_Click(object sender, EventArgs e)
        {
        }
        public static String name;
        private void main_page_Load(object sender, EventArgs e)
        {
            con.Open();
            comm = con.CreateCommand();
            var u_id = first_page.uid;
            comm.Parameters.AddWithValue("@uid", u_id);
            comm.CommandText = "SELECT username from pizza_proj.customer where customer_id = @uid";
            name = Convert.ToString(comm.ExecuteScalar());

            label_username.Text = "Username : " + name;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clear_data();
            this.Hide();
            first_page fp = new first_page();
            fp.ShowDialog();
            this.Close();
        }

        private void button_edit_address_Click(object sender, EventArgs e)
        {
            this.Hide();
            edit_info ed = new edit_info();
            ed.ShowDialog();
            this.Close();
        }

        void clear_data() {
            name = "";
        }
    }
}
