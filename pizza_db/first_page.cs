using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pizza_db
{
    
    public partial class first_page : Form
    {

        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=pizza_proj");
        
        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        public first_page()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            open_connection();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_showpass_login_CheckedChanged(object sender, EventArgs e)
        {
            textBox_password_firstpage.UseSystemPasswordChar = !checkBox_showpass_login.Checked;
        }
        private void Login_text_Click(object sender, EventArgs e)
        {

        }
        public static String username;
        public static String password;
        public static int uid;
        private void login_button_Click(object sender, EventArgs e)
        {
            username = textBox_name_firstpage.Text;
            password = textBox_password_firstpage.Text;
   
            MySqlCommand getname = con.CreateCommand();
            MySqlCommand getpassword = con.CreateCommand();
            MySqlCommand getuserid = con.CreateCommand();
            MySqlCommand getuidpass = con.CreateCommand();

            getname.Parameters.AddWithValue("@username",username);
            getpassword.Parameters.AddWithValue("@password",password);
            getuserid.Parameters.AddWithValue("@username", username);
            getuidpass.Parameters.AddWithValue("@username", username);

            
            getuidpass.CommandText = "SELECT password from pizza_proJ.customer where username =@username";
            getname.CommandText = "SELECT username from pizza_proj.customer where username = @username";
            getpassword.CommandText = "Select password from pizza_proj.customer where password = @password";
            getuserid.CommandText = "Select customer_id from pizza_proj.customer where username = @username";

            uid = Convert.ToInt32(getuserid.ExecuteScalar()); 
            string name = Convert.ToString(getname.ExecuteScalar());
            string pass = Convert.ToString(getpassword.ExecuteScalar());
            string conpass = Convert.ToString(getuidpass.ExecuteScalar());
            if (String.IsNullOrEmpty(textBox_name_firstpage.Text) || String.IsNullOrEmpty(textBox_password_firstpage.Text))
            {
                error_first_page.Visible = true;
            }
            else if (textBox_name_firstpage.Text == "admin" && textBox_password_firstpage.Text == "admin")
            {
                this.Hide();
                //order_admin o = new order_admin();
                //o.ShowDialog();
                this.Close();
            }
            else if (textBox_name_firstpage.Text != name || textBox_password_firstpage.Text != pass || pass != conpass)
            {
                //MessageBox.Show("Wrong password User ID = " + Convert.ToString(uid)); //เช็คค่าเฉยๆ
                error_first_page.Visible = true;
            } 
            else if (textBox_name_firstpage.Text == name && textBox_password_firstpage.Text == pass)
            {
                //MessageBox.Show("Correct password User ID = " + Convert.ToString(uid));
                this.Hide();
                main_page m = new main_page();
                m.ShowDialog();
                this.Close();
            }
            
        }
        
        private void register_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            register r = new register();   
            r.ShowDialog();
            this.Close();
        }
    }
    
}
