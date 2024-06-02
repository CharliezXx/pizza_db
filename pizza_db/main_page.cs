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

            cal();
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

        void clear_data()
        {
            name = "";
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_get_bill_Click(object sender, EventArgs e)
        {
            int uid = first_page.uid;
            comm = con.CreateCommand();
            comm.Parameters.AddWithValue("@user_id", uid);


            // add order_id
            comm.CommandText = "INSERT orders (customer_id)values(@user_id)";
            int do_command = comm.ExecuteNonQuery();



            // change window to basket
            this.Hide();
            basket b = new basket();
            b.ShowDialog();
            this.Close();
        }

        private void menu6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        public void cal()
        {

            int p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18;
            


            if (numericUpDown1.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p1 = 0;
                textBox_price_1.Text = Convert.ToString(p1);
            }
            else if (size1.Text == "S")// s
            {
                comm = con.CreateCommand();

                int mid = 1;                                                            // ดึงราคาจาก DB 
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //
                
                int multiplier = Convert.ToInt32(numericUpDown1.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar())*multiplier;           //คำนวณโดนเอาค่าราคาจาก DB มาคูณจำนวณ
                p1 = price;                                                             //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_1.Text = price.ToString();


            }
            else if (size1.Text == "M")//m
            {
                comm = con.CreateCommand();

                int mid = 2;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown1.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p1 = price;
                textBox_price_1.Text = price.ToString();
            }
            else if (size1.Text == "L")//l
            {
                comm = con.CreateCommand();

                int mid = 3;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown1.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p1 = price;
                textBox_price_1.Text = price.ToString();
            }
            ////////////////////////////////////////////////////

            if (numericUpDown2.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p2 = 0;
                textBox_price_2.Text = Convert.ToString(p2);
            }
            else if (size2.Text == "S")// s
            {
                comm = con.CreateCommand();

                int mid = 1;                                                            // ดึงราคาจาก DB 
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //

                int multiplier = Convert.ToInt32(numericUpDown2.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;           //คำนวณโดนเอาค่าราคาจาก DB มาคูณจำนวณ
                p1 = price;                                                             //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_2.Text = price.ToString();


            }
            else if (size2.Text == "M")//m
            {
                comm = con.CreateCommand();

                int mid = 2;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown2.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p1 = price;
                textBox_price_2.Text = price.ToString();
            }
            else if (size2.Text == "L")//l
            {
                comm = con.CreateCommand();

                int mid = 3;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown2.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p1 = price;
                textBox_price_2.Text = price.ToString();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void size1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();
        }
    }
}
