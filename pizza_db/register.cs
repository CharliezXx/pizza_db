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
using System.Xml.Linq;

namespace pizza_db
{
    public partial class register : Form
    {
        private const string ConnectionString = "host=localhost;user=root;password=;database=pizza_proj";
        MySqlConnection con = new MySqlConnection(ConnectionString);
        MySqlCommand comm;
        public register()
        {
            InitializeComponent();
            error_label.Visible = false;
            error_label_username_taken.Visible = false;
        }
        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }

        private void back_register_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            first_page f = new first_page();
            f.ShowDialog();
            this.Close();
        }

        private void register_Load(object sender, EventArgs e)
        {
            open_connection();
        }

        private void label_password_regis_Click(object sender, EventArgs e)
        {

        }


        private void confirm_regis_button_Click(object sender, EventArgs e)
        {
            var username = textBox_name_regis.Text;
            var password = textBox_password_regis.Text;
            comm = con.CreateCommand();

            comm.Parameters.AddWithValue("@username", username);
            comm.Parameters.AddWithValue("@password", password);

            comm.CommandText = "SELECT count(username) from pizza_proj.customer where username = @username";
            int result = Convert.ToInt32(comm.ExecuteScalar());

            if (string.IsNullOrEmpty(textBox_confirm_regis.Text) || string.IsNullOrEmpty(textBox_password_regis.Text) || string.IsNullOrEmpty(textBox_name_regis.Text) || (textBox_password_regis.Text != textBox_confirm_regis.Text) || (textBox_password_regis.Text.Length < 6))
            {
                error_label.Visible = true;
            }
            else if (result > 0)
            {

                error_label_username_taken.Visible = true;
            }
            else
            {

                comm.CommandText = "INSERT INTO `pizza_proj`.`customer` (`username`, `password`)" + "VALUES" + "(@username, @password)";

                try
                {
                    int rowsAffected = comm.ExecuteNonQuery();
                    MessageBox.Show("Save Data Completed!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.Hide();
                first_page f = new first_page();
                f.ShowDialog();
                this.Close();
            }


        }

        private void textBox_password_regis_TextChanged(object sender, EventArgs e)
        {
           
       
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_password_regis.UseSystemPasswordChar = !checkBox_show_regis.Checked;
            textBox_confirm_regis.UseSystemPasswordChar = !checkBox_show_regis.Checked;
        }
    }
}
