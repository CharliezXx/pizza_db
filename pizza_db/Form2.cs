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
    }
}
