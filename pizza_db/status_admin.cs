using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace pizza_db
{
    public partial class status_admin : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=pizza_proj");
        MySqlCommand comm;
        public status_admin()
        {
            InitializeComponent();
        }
        private void open_connection()
        {
            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void status_admin_Load(object sender, EventArgs e)
        {
            

            // Load data into guna2DataGridView1
            string sql = "SELECT * from orders";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "orders");
            guna2DataGridView1.DataSource = ds.Tables["orders"].DefaultView;


            // Load data into guna2DataGridView2
            comm = con.CreateCommand();
            comm.CommandText = "SELECT * from addr";
            DataSet ds2 = new DataSet();
            MySqlDataAdapter da2 = new MySqlDataAdapter(comm);
            da2.Fill(ds2, "addr");
            guna2DataGridView2.DataSource = ds2.Tables["addr"].DefaultView;

            

            comm = con.CreateCommand();
            comm.CommandText = "SELECT * from customer";
            DataSet ds3 = new DataSet();
            MySqlDataAdapter da3 = new MySqlDataAdapter(comm);
            da3.Fill(ds3, "customer");
            guna2DataGridView3.DataSource = ds3.Tables["customer"].DefaultView;


            comm = con.CreateCommand();
            comm.CommandText = "SELECT * from employee";
            DataSet ds4 = new DataSet();
            MySqlDataAdapter da4 = new MySqlDataAdapter(comm);
            da4.Fill(ds4, "employee");
            guna2DataGridView4.DataSource = ds4.Tables["employee"].DefaultView;

            comm = con.CreateCommand();
            comm.CommandText = "SELECT * from vehicle";
            DataSet ds5 = new DataSet();
            MySqlDataAdapter da5 = new MySqlDataAdapter(comm);
            da5.Fill(ds5, "vehicle");
            guna2DataGridView5.DataSource = ds5.Tables["vehicle"].DefaultView;

            comm = con.CreateCommand();
            comm.CommandText = "SELECT * from menu";
            DataSet ds6 = new DataSet();
            MySqlDataAdapter da6 = new MySqlDataAdapter(comm);
            da6.Fill(ds6, "menu");
            guna2DataGridView6.DataSource = ds6.Tables["menu"].DefaultView;

            comm = con.CreateCommand();
            comm.CommandText = "SELECT * from in_basket";
            DataSet ds7 = new DataSet();
            MySqlDataAdapter da7 = new MySqlDataAdapter(comm);
            da7.Fill(ds7, "in_basket");
            guna2DataGridView7.DataSource = ds7.Tables["in_basket"].DefaultView;

        }

        
        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void address_Click(object sender, EventArgs e)
        {

        }
    }
}
