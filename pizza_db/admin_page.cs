using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pizza_db
{
    public partial class admin_page : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=pizza_proj");
        MySqlCommand comm;

        public admin_page()
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
        void load_grid()
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
        private void status_admin_Load(object sender, EventArgs e)
        {
            if (con.State == 0)
            {
                open_connection();
                load_grid();
            }
            else
            {
                load_grid();
            }
        }


        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void amlabel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            first_page fp = new first_page();
            fp.ShowDialog();
            this.Close();
        }
        void container()
        {
            int e_id = Convert.ToInt32(textBox_e_id.Text);
            var e_fn = textBox_e_first_name.Text;
            var e_lf = textBox_e_lastname.Text;
            var tel = textBox_e_tel.Text;
            var position = textBox_e_position.Text;
            var salary = textBox_salary.Text;
            var status = textBox_status.Text;

            comm = con.CreateCommand();
            comm.Parameters.AddWithValue("@e_id", e_id);
            comm.Parameters.AddWithValue("@firstname", e_fn);
            comm.Parameters.AddWithValue("@lastname", e_lf);
            comm.Parameters.AddWithValue("@tel", tel);
            comm.Parameters.AddWithValue("@position", position);
            comm.Parameters.AddWithValue("@salary", salary);
            comm.Parameters.AddWithValue("@status", status);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            load_grid();
            container();
            comm.CommandText = "INSERT into employee (e_id,e_firstname,e_lastname,tel,position,salary,status)VALUES(@e_id,@firstname,@lastname,@tel,@position,@salary,@status)";
            int ins = comm.ExecuteNonQuery();
            load_grid();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            load_grid();
            container();
            comm.CommandText = "UPDATE employee set e_firstname=@firstname,e_lastname=@lastname,tel=@tel,position=@position,salary=@salary,status=@status where e_id =@e_id";
            int uns = comm.ExecuteNonQuery();
            load_grid();
        }
        private void myDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = guna2DataGridView4.CurrentCell.RowIndex;
            textBox_e_id.Text = guna2DataGridView4.Rows[row].Cells["e_id"].Value.ToString();
            textBox_e_first_name.Text = guna2DataGridView4.Rows[row].Cells["e_firstname"].Value.ToString();
            textBox_e_lastname.Text = guna2DataGridView4.Rows[row].Cells["e_lastname"].Value.ToString();
            textBox_e_tel.Text = guna2DataGridView4.Rows[row].Cells["tel"].Value.ToString();
            textBox_e_position.Text = guna2DataGridView4.Rows[row].Cells["position"].Value.ToString();
            textBox_salary.Text = guna2DataGridView4.Rows[row].Cells["salary"].Value.ToString();
            textBox_status.Text = guna2DataGridView4.Rows[row].Cells["status"].Value.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox_e_id.Text = null;
            textBox_e_first_name.Text = null;
            textBox_e_lastname.Text = null;
            textBox_e_tel.Text = null;
            textBox_e_position.Text = null;
            textBox_salary.Text = null;
            textBox_status.Text = null;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            load_grid();
            container();
            comm.CommandText = "DELETE from employee where e_id = @e_id";
            int dd = comm.ExecuteNonQuery();
            load_grid();
        }
        void container2()
        {
            int v_id = Convert.ToInt32(textBox_v_id.Text);
            var type = textBox_type.Text;
            var licence = textBox_licence.Text;
            var e_id_v = Convert.ToInt32(textBox_eid_vehicle.Text);


            comm = con.CreateCommand();
            comm.Parameters.AddWithValue("@v_id", v_id);
            comm.Parameters.AddWithValue("@type", type);
            comm.Parameters.AddWithValue("@licence", licence);
            comm.Parameters.AddWithValue("@e_id_v", e_id_v);

        }
        private void guna2DataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = guna2DataGridView5.CurrentCell.RowIndex;
            textBox_v_id.Text = guna2DataGridView5.Rows[row].Cells["v_id"].Value.ToString();
            textBox_type.Text = guna2DataGridView5.Rows[row].Cells["type"].Value.ToString();
            textBox_licence.Text = guna2DataGridView5.Rows[row].Cells["licence"].Value.ToString();
            textBox_eid_vehicle.Text = guna2DataGridView5.Rows[row].Cells["e_id"].Value.ToString();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            load_grid();
            container2();
            comm.CommandText = "INSERT INTO vehicle (v_id,type,licence,e_id)values(@v_id,@type,@licence,@e_id_v)";
            int isrt_v = comm.ExecuteNonQuery();
            load_grid();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            load_grid();
            container2();
            comm.CommandText = "UPDATE vehicle set v_id=@v_id,type = @type,licence=@licence,e_id=@e_id_v where v_id=@v_id";
            int uptd_v = comm.ExecuteNonQuery();
            load_grid();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox_eid_vehicle.Text = null;
            textBox_licence.Text = null;
            textBox_type.Text = null;
            textBox_v_id.Text = null;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            load_grid();
            container2();
            comm.CommandText = "DELETE from vehicle where v_id = @v_id";
            int ddv = comm.ExecuteNonQuery();
            load_grid();
        }
    }
}
