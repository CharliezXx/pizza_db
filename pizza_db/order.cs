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
    public partial class order : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=pizza_proj");
        MySqlCommand comm;
        public order()
        {
            InitializeComponent();
        }
        

        private void open_connection()
        {
            

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        private void order_Load(object sender, EventArgs e)
        {
           


            open_connection();
            string sql = "SELECT pizza_proj.menu.menu_name, pizza_proj.in_basket.quantity,pizza_proj.menu.price FROM pizza_proj.menu RIGHT JOIN pizza_proj.in_basket ON pizza_proj.menu.menu_id = pizza_proj.in_basket.menu_id where pizza_proj.in_basket.o_id = (SELECT MAX(o_id)  FROM pizza_proj.orders);";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "in_basket");
            guna2DataGridView1.DataSource = ds.Tables["in_basket"].DefaultView;
            guna2DataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            guna2DataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            guna2DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            guna2DataGridView1.Columns[0].Width = 100;
            guna2DataGridView1.Columns[1].Width = 50;
            guna2DataGridView1.Columns[2].Width = 50;

            comm = con.CreateCommand();
            comm.CommandText = "SELECT MAX(o_id) FROM pizza_proj.orders";
            string oid =Convert.ToString(comm.ExecuteScalar());

            
            

            comm = con.CreateCommand();
            
            comm.CommandText = "SELECT e_firstname from employee where position = 'admin'";
            string e_fname = Convert.ToString(comm.ExecuteScalar());

            comm = con.CreateCommand();
            
            comm.CommandText = "SELECT e_lastname from employee where position = 'admin'";
            string e_lname = Convert.ToString(comm.ExecuteScalar());
            

            label7.Text = "Take order by : "+e_fname+" "+e_lname;
            
            label2.Text = "Order ID : " + oid;
            decimal ttp = main_page.TTP;
            label6.Text = Convert.ToString(ttp+" ฿");
            random_driver();
            void random_driver()
            {
                //comm.CommandText = "select max(e_id) from employee";
                //int max_emp = Convert.ToInt32(comm.ExecuteScalar());
                Random rng = new Random();
                int rand2 = rng.Next(3, 7);

                comm = con.CreateCommand();
                comm.Parameters.AddWithValue("@random", rand2);
                comm.CommandText = "SELECT status from employee where e_id = @random";
                string status = Convert.ToString(comm.ExecuteScalar());

                


                if (status != "busy")
                {

                    comm = con.CreateCommand();
                    comm.Parameters.AddWithValue("@random", rand2);
                    comm.CommandText = "SELECT licence from vehicle where e_id = @random";
                    string v_lic = Convert.ToString(comm.ExecuteScalar());
                    label3.Text = "Vehicle : " + v_lic;

                    comm = con.CreateCommand();
                    comm.Parameters.AddWithValue("@random", rand2);
                    comm.CommandText = "SELECT v_id from vehicle where e_id = @random";
                    string v_id = Convert.ToString(comm. ExecuteScalar());

                    comm = con.CreateCommand();
                    comm.Parameters.AddWithValue("@v_id", v_id);
                    comm.CommandText = "UPDATE orders set employee_id = 2 ,vehicle_id = @v_id where o_id = (SELECT MAX(o_id)  FROM orders)";
                    int ist_ttb = comm.ExecuteNonQuery();
                }
                else if (status == "busy")
                {
                    random_driver();
                }else
                {
                    MessageBox.Show("Sorry, No Driver");
                    comm = con.CreateCommand();
                    comm.CommandText = "DELETE FROM in_basket  WHERE o_id = (SELECT MAX(o_id)  FROM orders);DELETE FROM orders  WHERE o_id = (SELECT MAX(o_id)  FROM orders);";
                    int del = comm.ExecuteNonQuery();
                    this.Hide();
                    main_page mp = new main_page();
                    mp.ShowDialog();
                    this.Close();
                }
            }
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_page mp = new main_page();
            mp.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
