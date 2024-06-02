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
    public partial class basket : Form
    {

        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=pizza_proj");
        MySqlCommand comm;
        public basket()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            main_page mp = new main_page();
            mp.ShowDialog();
            this.Close();
        }
        private void load_basket_griddata_init()
        {

            string sql = "SELECT pizza_proj.menu.menu_name, size, pizza_proj.in_basket.quantity, pizza_proj.menu.price\r\nFROM pizza_proj.menu RIGHT JOIN pizza_proj.in_basket \r\nON pizza_proj.menu.menu_id = pizza_proj.in_basket.menu_id";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "in_basket");
            basketDataGridView.DataSource = ds.Tables["in_basket"].DefaultView;
        }

        private void basket_Load(object sender, EventArgs e)
        {
            con.Open();
            
            load_basket_griddata_init();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
