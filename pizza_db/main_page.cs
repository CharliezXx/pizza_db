using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
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
        private void insertIntoInBasket(decimal quantity, int menuId)
        {
            using (MySqlConnection con = new MySqlConnection())
            {
                con.Open();

                string sql = "INSERT INTO in_basket (quantity, menu_id) VALUES (@quantity, @menuId)";
                MySqlCommand comm = new MySqlCommand(sql, con);

                comm.Parameters.AddWithValue("@quantity", quantity);
                comm.Parameters.AddWithValue("@menuId", menuId);

                comm.ExecuteNonQuery();

                con.Close();
            }
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
            decimal tp = cal();
            comm = con.CreateCommand();
            comm.Parameters.AddWithValue("@user_id", uid);
            comm.Parameters.AddWithValue("@total_price",tp);

            // add order_id
            comm.CommandText = "INSERT orders (customer_id,total_price)values(@user_id,@total_price)";
            int do_command = comm.ExecuteNonQuery();


            if (q1 != 0)
            {
                comm.Parameters.AddWithValue("@quan1", q1);
                comm.Parameters.AddWithValue("@mid1", m1);
                comm.CommandText = "INSERT INTO pizza_proj.in_basket (quantity,menu_id)VALUES(@quan1,@mid1) on duplicate key update quantity =@quan1,menu_id=@mid1";
                do_command = comm.ExecuteNonQuery();
            }
            
            if (q2 != 0)
            {
                
                 comm.Parameters.AddWithValue("@quan2", q2);
                 comm.Parameters.AddWithValue("@mid2", m2);
                 comm.CommandText = "INSERT INTO pizza_proj.in_basket (quantity,menu_id)VALUES(@quan2,@mid2) on duplicate key update quantity =@quan2,menu_id=@mid2";
                 do_command = comm.ExecuteNonQuery();
           
            }
            else
            
            if (q3 != 0)
            {
                comm.Parameters.AddWithValue("@quan3", q3);
                comm.Parameters.AddWithValue("@mid3", m3);
                comm.CommandText = "INSERT INTO pizza_proj.in_basket (quantity,menu_id)VALUES(@quan3,@mid3) on duplicate key update quantity =@quan3,menu_id=@mid3";
                do_command = comm.ExecuteNonQuery();
            }
           

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
        int q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18 = 0;
        int m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16, m17, m18 = 0;
        public decimal cal()
        {

            int p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18 = 0;
            

            if (numericUpDown1.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p1 = 0;
                q1 = 0;
                m1 = 0;
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
                
                
                
                p1 = price;
                q1 = multiplier;
                m1 = mid;//เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_1.Text = price.ToString();


            }
            else if (size1.Text == "M")//m
            {
                comm = con.CreateCommand();

                int mid = 2;
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //

                int multiplier = Convert.ToInt32(numericUpDown1.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;           //คำนวณโดนเอาค่าราคาจาก DB มาคูณจำนวณ
                
                
                p1 = price;
                q1 = multiplier;
                m1 = mid;                                                             //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_1.Text = price.ToString();
            }
            else if (size1.Text == "L")//l
            {
                comm = con.CreateCommand();

                int mid = 3;
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //

                int multiplier = Convert.ToInt32(numericUpDown1.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;           //คำนวณโดนเอาค่าราคาจาก DB มาคูณจำนวณ
                
                
                p1 = price;
                q1 = multiplier;
                m1 = mid;                                                             //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_1.Text = price.ToString();
            }
            else
            {
                p1 = 0;
                q1 = 0;
                m1 = 0;
            }
            ////////////////////////////////////////////////////


            if (numericUpDown2.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p2 = 0;
                q2 = 0;
                m2 = 0;
                textBox_price_2.Text = Convert.ToString(p2);
            }
            else if (size2.Text == "S")// s
            {
                comm = con.CreateCommand();

                int mid = 4;                                                            // ดึงราคาจาก DB 
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //

                int multiplier = Convert.ToInt32(numericUpDown2.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar())*multiplier;
                
                
                
                p2 = price;
                q2 = multiplier;
                m2 = mid; //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_2.Text = price.ToString();


            }
            else if (size2.Text == "M")//m
            {
                comm = con.CreateCommand();

                int mid = 5;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown2.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) *multiplier;
                p2 = price;
                q2 = multiplier;
                m2 = mid;
                textBox_price_2.Text = price.ToString();
            }
            else if (size2.Text == "L")//l
            {
                comm = con.CreateCommand();

                int mid = 6;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown2.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p2 = price;
                q2 = multiplier;
                m2 = mid;
                textBox_price_2.Text = price.ToString();
            }
            else
            {
                p2 = 0;
                q2 = 0;
                m2 = 0;
            }
            ////////////////////////////////////////////////////

            if (numericUpDown3.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p3 = 0;
                q3 = 0;
                m3 = 0;
                textBox_price_3.Text = Convert.ToString(p3);
            }
            else if (size3.Text == "S")// s
            {
                comm = con.CreateCommand();

                int mid = 7;                                                            // ดึงราคาจาก DB 
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //

                int multiplier = Convert.ToInt32(numericUpDown3.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar())*multiplier;           //คำนวณโดนเอาค่าราคาจาก DB มาคูณจำนวณ
                p3 = price;
                q3 = multiplier;
                m3 = mid;                                                          //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_3.Text = price.ToString();


            }
            else if (size3.Text == "M")//m
            {
                comm = con.CreateCommand();

                int mid = 8;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown3.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) *multiplier;
                p3 = price;
                q3 = multiplier;
                m3 = mid;
                textBox_price_3.Text = price.ToString();
            }
            else if (size3.Text == "L")//l
            {
                comm = con.CreateCommand();

                int mid = 9;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown3.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p3 = price;
                q3 = multiplier;
                m3 = mid;
                textBox_price_3.Text = price.ToString();
            }
            else
            {
                p3 = 0;
                q3 = 0;
                m3 = 0;
            }
            ////////////////////////////////////////////////////

            if (numericUpDown4.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p4 = 0;
                q4 = 0;
                m4 = 0; 
                textBox_price_4.Text = Convert.ToString(p4);
            }
            else if (size4.Text == "S")// s
            {
                comm = con.CreateCommand();

                int mid = 10;                                                            // ดึงราคาจาก DB 
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //

                int multiplier = Convert.ToInt32(numericUpDown4.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar())*multiplier;           //คำนวณโดนเอาค่าราคาจาก DB มาคูณจำนวณ
                p4 = price;
                q4 = multiplier;
                m4 = mid;                                                            //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_4.Text = price.ToString();


            }
            else if (size4.Text == "M")//m
            {
                comm = con.CreateCommand();

                int mid = 11;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown4.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) *multiplier;
                p4 = price;
                q4 = multiplier;
                m4 = mid;
                textBox_price_4.Text = price.ToString();
            }
            else if (size4.Text == "L")//l
            {
                comm = con.CreateCommand();

                int mid = 12;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown4.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p4 = price;
                q4 = multiplier;
                m4 = mid;
                textBox_price_4.Text = price.ToString();
            }
            else
            {
                p4 = 0;
                q4 = 0;
                m4 = 0;
            }
            ////////////////////////////////////////////////////

            if (numericUpDown5.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p5 = 0;
                textBox_price_5.Text = Convert.ToString(p5);
            }
            else if (size5.Text == "S")// s
            {
                comm = con.CreateCommand();

                int mid = 13;                                                            // ดึงราคาจาก DB 
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //

                int multiplier = Convert.ToInt32(numericUpDown5.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar())*multiplier;           //คำนวณโดนเอาค่าราคาจาก DB มาคูณจำนวณ
                p5 = price;                                                             //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_5.Text = price.ToString();


            }
            else if (size5.Text == "M")//m
            {
                comm = con.CreateCommand();

                int mid = 14;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown5.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) *multiplier;
                p5 = price;
                textBox_price_5.Text = price.ToString();
            }
            else if (size5.Text == "L")//l
            {
                comm = con.CreateCommand();

                int mid = 15;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown5.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p5 = price;
                textBox_price_5.Text = price.ToString();
            }
            else
            {
                p5 = 0;
            }
            ////////////////////////////////////////////////////
            if (numericUpDown6.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p6 = 0;
                textBox_price_6.Text = Convert.ToString(p6);
            }
            else if (size6.Text == "S")// s
            {
                comm = con.CreateCommand();

                int mid = 16;                                                            // ดึงราคาจาก DB 
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //

                int multiplier = Convert.ToInt32(numericUpDown6.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar())*multiplier;           //คำนวณโดนเอาค่าราคาจาก DB มาคูณจำนวณ
                p6 = price;                                                             //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_6.Text = price.ToString();


            }
            else if (size6.Text == "M")//m
            {
                comm = con.CreateCommand();

                int mid = 17;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown6.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) *multiplier;
                p6 = price;
                textBox_price_6.Text = price.ToString();
            }
            else if (size6.Text == "L")//l
            {
                comm = con.CreateCommand();

                int mid = 18;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown6.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p6 = price;
                textBox_price_6.Text = price.ToString();
            }
            else
            {
                p6 = 0;
            }
            ////////////////////////////////////////////////////
            if (numericUpDown7.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p7 = 0;
                textBox_price_7.Text = Convert.ToString(p7);
            }
            else if (size7.Text == "S")// s
            {
                comm = con.CreateCommand();

                int mid = 19;                                                            // ดึงราคาจาก DB 
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //

                int multiplier = Convert.ToInt32(numericUpDown7.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar())*multiplier;           //คำนวณโดนเอาค่าราคาจาก DB มาคูณจำนวณ
                p7 = price;                                                             //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_7.Text = price.ToString();


            }
            else if (size7.Text == "M")//m
            {
                comm = con.CreateCommand();

                int mid = 20;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown7.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) *multiplier;
                p7 = price;
                textBox_price_7.Text = price.ToString();
            }
            else if (size7.Text == "L")//l
            {
                comm = con.CreateCommand();

                int mid = 21;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown7.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p7 = price;
                textBox_price_7.Text = price.ToString();
            }
            else
            {
                p7 = 0;
            }
            ////////////////////////////////////////////////////
            if (numericUpDown8.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p8 = 0;
                textBox_price_8.Text = Convert.ToString(p8);
            }
            else if (size8.Text == "S")// s
            {
                comm = con.CreateCommand();

                int mid = 22;                                                            // ดึงราคาจาก DB 
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //

                int multiplier = Convert.ToInt32(numericUpDown8.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar())*multiplier;           //คำนวณโดนเอาค่าราคาจาก DB มาคูณจำนวณ
                p8 = price;                                                             //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_8.Text = price.ToString();


            }
            else if (size8.Text == "M")//m
            {
                comm = con.CreateCommand();

                int mid = 23;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown8.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) *multiplier;
                p8 = price;
                textBox_price_8.Text = price.ToString();
            }
            else if (size8.Text == "L")//l
            {
                comm = con.CreateCommand();

                int mid = 24;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown8.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p8 = price;
                textBox_price_8.Text = price.ToString();
            }
            else
            {
                p8 = 0;
            }
            ////////////////////////////////////////////////////

            if (numericUpDown9.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p9 = 0;
                textBox_price_9.Text = Convert.ToString(p9);
            }
            else if (size9.Text == "S")// s
            {
                comm = con.CreateCommand();

                int mid = 25;                                                            // ดึงราคาจาก DB 
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //

                int multiplier = Convert.ToInt32(numericUpDown9.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar())*multiplier;           //คำนวณโดนเอาค่าราคาจาก DB มาคูณจำนวณ
                p9 = price;                                                             //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_9.Text = price.ToString();


            }
            else if (size9.Text == "M")//m
            {
                comm = con.CreateCommand();

                int mid = 26;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown9.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) *multiplier;
                p9 = price;
                textBox_price_9.Text = price.ToString();
            }
            else if (size9.Text == "L")//l
            {
                comm = con.CreateCommand();

                int mid = 27;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown9.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p9 = price;
                textBox_price_9.Text = price.ToString();
            }
            else
            {
                p9 = 0;
            }
            ////////////////////////////////////////////////////

            if (numericUpDown10.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p10 = 0;
                textBox_price_10.Text = Convert.ToString(p10);
            }
            else if (size10.Text == "S")// s
            {
                comm = con.CreateCommand();

                int mid = 28;                                                            // ดึงราคาจาก DB 
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //

                int multiplier = Convert.ToInt32(numericUpDown10.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar())*multiplier;           //คำนวณโดนเอาค่าราคาจาก DB มาคูณจำนวณ
                p10 = price;                                                             //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_10.Text = price.ToString();


            }
            else if (size10.Text == "M")//m
            {
                comm = con.CreateCommand();

                int mid = 29;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown10.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) *multiplier;
                p10 = price;
                textBox_price_10.Text = price.ToString();
            }
            else if (size10.Text == "L")//l
            {
                comm = con.CreateCommand();

                int mid = 30;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown10.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p10 = price;
                textBox_price_10.Text = price.ToString();
            }
            else
            {
                p10 = 0;
            }
            ////////////////////////////////////////////////////


            if (numericUpDown11.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p11 = 0;
                textBox_price_11.Text = Convert.ToString(p11);
            }
            else if (size11.Text == "S")// s
            {
                comm = con.CreateCommand();

                int mid = 31;                                                            // ดึงราคาจาก DB 
                comm.Parameters.AddWithValue("@mid", mid);                              // 
                comm.CommandText = "SELECT price from menu where menu_id = @mid";       //

                int multiplier = Convert.ToInt32(numericUpDown11.Value);                 //ตัวคูณ โดยจำนวนสินค้า
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;           //คำนวณโดนเอาค่าราคาจาก DB มาคูณจำนวณ
                p11 = price;                                                             //เอาราคาที่คำนวณแล้วไปเก็บไว้ในตัวแปล
                textBox_price_11.Text = price.ToString();


            }
            else if (size11.Text == "M")//m
            {
                comm = con.CreateCommand();

                int mid = 32;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown11.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p11 = price;
                textBox_price_11.Text = price.ToString();
            }
            else if (size11.Text == "L")//l
            {
                comm = con.CreateCommand();

                int mid = 33;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown11.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p11 = price;
                textBox_price_11.Text = price.ToString();
            }
            else {
                p11 = 0;
            }
            ////////////////////////////////////////////////////
            if (numericUpDown12.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p12 = 0;
                textBox_price_12.Text = Convert.ToString(p12);
            }
            else {
                comm = con.CreateCommand();
                int mid = 34;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown12.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p12 = price;
                textBox_price_12.Text = price.ToString();
            }
            ////////////////////////////////////////////////////
            if (numericUpDown13.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p13 = 0;
                textBox_price_13.Text = Convert.ToString(p13);
            }
            else
            {
                comm = con.CreateCommand();
                int mid = 35;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown13.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p13 = price;
                textBox_price_13.Text = price.ToString();
            }
            ////////////////////////////////////////////////////
            if (numericUpDown14.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p14 = 0;
                textBox_price_14.Text = Convert.ToString(p14);
            }
            else
            {
                comm = con.CreateCommand();
                int mid = 36;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown14.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p14 = price;
                textBox_price_14.Text = price.ToString();
            }
            ////////////////////////////////////////////////////
            if (numericUpDown15.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p15 = 0;
                textBox_price_15.Text = Convert.ToString(p15);
            }
            else
            {
                comm = con.CreateCommand();
                int mid = 37;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown15.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p15 = price;
                textBox_price_15.Text = price.ToString();
            }
            ////////////////////////////////////////////////////
            if (numericUpDown16.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p16 = 0;
                textBox_price_16.Text = Convert.ToString(p16);
            }
            else
            {
                comm = con.CreateCommand();
                int mid = 38;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown16.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p16 = price;
                textBox_price_16.Text = price.ToString();
            }
            ////////////////////////////////////////////////////
            if (numericUpDown17.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p17 = 0;
                textBox_price_17.Text = Convert.ToString(p17);
            }
            else
            {
                comm = con.CreateCommand();
                int mid = 39;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown17.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p17 = price;
                textBox_price_17.Text = price.ToString();
            }
            ////////////////////////////////////////////////////
            if (numericUpDown18.Value == 0) //check ว่าถ้าได้เลือกซักชิ้น
            {
                p18 = 0;
                textBox_price_18.Text = Convert.ToString(p18);
            }
            else
            {
                comm = con.CreateCommand();
                int mid = 40;
                comm.Parameters.AddWithValue("@mid", mid);
                comm.CommandText = "SELECT price from menu where menu_id = @mid";
                int multiplier = Convert.ToInt32(numericUpDown18.Value);
                int price = Convert.ToInt32(comm.ExecuteScalar()) * multiplier;
                p18 = price;
                textBox_price_18.Text = price.ToString();
            }
            decimal sum = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14 + p15 + p16 + p17 + p18;
            
            textBox10.Text ="TOTAL PRICE = "+ sum.ToString();
            return sum;
        }




        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void size1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void size2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void size3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void size4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void size5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void size6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void size7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void size8_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void size9_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void size10_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void size11_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }
    }
}
