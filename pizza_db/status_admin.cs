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
            o

            // Load data into guna2DataGridView1
            string sql = "SELECT * from orders";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "orders");
            guna2DataGridView1.DataSource = ds.Tables["orders"].DefaultView;

            // Attach DataBindingComplete event handler
            guna2DataGridView1.DataBindingComplete += Guna2DataGridView1_DataBindingComplete;

            // Load data into guna2DataGridView2
            MySqlCommand comm2 = con.CreateCommand();
            comm2.CommandText = "SELECT * from addr";
            DataSet ds2 = new DataSet();
            MySqlDataAdapter da2 = new MySqlDataAdapter(comm2);
            da2.Fill(ds2, "addr");
            guna2DataGridView2.DataSource = ds2.Tables["addr"].DefaultView;

            // Attach DataBindingComplete event handler
            guna2DataGridView2.DataBindingComplete += Guna2DataGridView2_DataBindingComplete;

            // Load data into guna2DataGridView3 (for employee table)
           
        }

        private void Guna2DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            guna2DataGridView1.Columns[0].Width = 150;
            guna2DataGridView1.Columns[1].Width = 150;
            guna2DataGridView1.Columns[2].Width = 150;
            guna2DataGridView1.Columns[3].Width = 150;
            guna2DataGridView1.Columns[4].Width = 150;
        }

        private void Guna2DataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            guna2DataGridView2.Columns[0].Width = 125;
            guna2DataGridView2.Columns[1].Width = 125;
            guna2DataGridView2.Columns[2].Width = 125;
            guna2DataGridView2.Columns[3].Width = 125;
            guna2DataGridView2.Columns[4].Width = 125;
            guna2DataGridView2.Columns[5].Width = 125;
        }

        
        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }
    }
}
