namespace pizza_db
{
    partial class order
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
            guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(components);
            panel1 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2ColorTransition1
            // 
            guna2ColorTransition1.ColorArray = new Color[]
    {
    Color.Red,
    Color.Blue,
    Color.Orange
    };
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(23, 29);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 404);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(325, 113);
            label11.Name = "label11";
            label11.Size = new Size(37, 19);
            label11.TabIndex = 34;
            label11.Text = "pice ";
            // 
            // label10
            // 
            label10.AutoEllipsis = true;
            label10.AutoSize = true;
            label10.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(201, 113);
            label10.Name = "label10";
            label10.Size = new Size(60, 19);
            label10.TabIndex = 33;
            label10.Text = "quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 113);
            label8.Name = "label8";
            label8.Size = new Size(36, 19);
            label8.TabIndex = 31;
            label8.Text = "item";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(283, 314);
            label7.Name = "label7";
            label7.Size = new Size(17, 19);
            label7.TabIndex = 30;
            label7.Text = "฿";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(305, 318);
            label6.Name = "label6";
            label6.Size = new Size(33, 19);
            label6.TabIndex = 29;
            label6.Text = "999";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(48, 361);
            label5.Name = "label5";
            label5.Size = new Size(231, 19);
            label5.TabIndex = 28;
            label5.Text = "ขอบคุณ คุณลูกค้าที่อุดหนุนร้านของเราครับ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 318);
            label4.Name = "label4";
            label4.Size = new Size(76, 13);
            label4.TabIndex = 27;
            label4.Text = "Total Pice   :   ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 7.8F);
            label3.Location = new Point(104, 70);
            label3.Name = "label3";
            label3.Size = new Size(13, 13);
            label3.TabIndex = 26;
            label3.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 7.8F);
            label2.Location = new Point(38, 70);
            label2.Name = "label2";
            label2.Size = new Size(60, 13);
            label2.TabIndex = 25;
            label2.Text = "OrderID  : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 20);
            label1.Name = "label1";
            label1.Size = new Size(133, 29);
            label1.TabIndex = 24;
            label1.Text = "Pizza Shop";
            // 
            // button1
            // 
            button1.Location = new Point(173, 448);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 36);
            button1.TabIndex = 1;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(332, 161);
            dataGridView1.TabIndex = 35;
            // 
            // order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 505);
            Controls.Add(button1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "order";
            Text = "order";
            Load += order_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Panel panel1;
        private Button button1;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}