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
    public partial class close : Form
    {
        public close()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            first_page fp = new first_page();
            fp.ShowDialog();
            this.Close(); 
        }
    }
}
