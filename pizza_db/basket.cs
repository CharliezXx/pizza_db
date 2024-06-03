using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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


            comm = con.CreateCommand();


            comm.CommandText = "DELETE FROM in_basket  WHERE o_id = (SELECT MAX(o_id)  FROM orders);DELETE FROM orders  WHERE o_id = (SELECT MAX(o_id)  FROM orders);";
            int del = comm.ExecuteNonQuery();
            this.Hide();
            main_page mp = new main_page();
            mp.ShowDialog();
            this.Close();
        }
        private void load_basket_griddata_init()
        {

            string sql = "SELECT pizza_proj.menu.menu_name, pizza_proj.in_basket.quantity, 'x',pizza_proj.menu.price FROM pizza_proj.menu RIGHT JOIN pizza_proj.in_basket ON pizza_proj.menu.menu_id = pizza_proj.in_basket.menu_id where pizza_proj.in_basket.o_id = (SELECT MAX(o_id)  FROM pizza_proj.orders);";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "in_basket");
            basketDataGridView.DataSource = ds.Tables["in_basket"].DefaultView;
            basketDataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            basketDataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            basketDataGridView.Columns[0].Width = 10;
            basketDataGridView.Columns[1].Width = 250;
            basketDataGridView.Columns[2].Width = 30;
            basketDataGridView.Columns[3].Width = 18;
            basketDataGridView.Columns[4].Width = 50;
        }

        private void basket_Load(object sender, EventArgs e)
        {
            con.Open();

            load_basket_griddata_init();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            order o = new order();
            o.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
