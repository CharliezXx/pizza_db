namespace pizza_db
{
    partial class order_admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            amlabel1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            amlabel2 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(amlabel2);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 528);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // amlabel1
            // 
            amlabel1.AutoSize = true;
            amlabel1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amlabel1.ForeColor = Color.White;
            amlabel1.Location = new Point(37, 10);
            amlabel1.Name = "amlabel1";
            amlabel1.Size = new Size(381, 26);
            amlabel1.TabIndex = 8;
            amlabel1.Text = "Pizza Shop Management System 1.0";
            amlabel1.Click += amlabel1_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("MS Reference Sans Serif", 16.2F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 291);
            label5.Name = "label5";
            label5.Size = new Size(199, 31);
            label5.TabIndex = 7;
            label5.Text = "Management";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("MS Reference Sans Serif", 16.2F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 225);
            label4.Name = "label4";
            label4.Size = new Size(196, 31);
            label4.TabIndex = 6;
            label4.Text = "Status";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Reference Sans Serif", 16.2F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 149);
            label1.Name = "label1";
            label1.Size = new Size(196, 31);
            label1.TabIndex = 3;
            label1.Text = "Order";
            label1.Click += label1_Click;
            // 
            // amlabel2
            // 
            amlabel2.BackColor = Color.Transparent;
            amlabel2.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amlabel2.ForeColor = Color.White;
            amlabel2.Location = new Point(116, 486);
            amlabel2.Name = "amlabel2";
            amlabel2.Size = new Size(133, 42);
            amlabel2.TabIndex = 2;
            amlabel2.Text = "log out";
            amlabel2.Click += amlabel2_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(230, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(993, 478);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSlateGray;
            panel2.Controls.Add(amlabel1);
            panel2.Location = new Point(230, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(993, 54);
            panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(34, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 91);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // mian_admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 527);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "mian_admin";
            Text = "mian_admin";
            Load += mian_admin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label amlabel2;
        private NotifyIcon notifyIcon1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label amlabel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}