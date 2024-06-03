namespace pizza_db
{
    partial class edit_info
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
            label_edit_info = new Label();
            label_address = new Label();
            textBox_address = new TextBox();
            label_road = new Label();
            label_name = new Label();
            textBox_name = new TextBox();
            textBox_zipcode = new TextBox();
            textBox_road = new TextBox();
            label_zipcode = new Label();
            label_city = new Label();
            textBox_city = new TextBox();
            button_save = new Button();
            textBox_tel = new TextBox();
            label_tel = new Label();
            button_back = new Button();
            button1 = new Button();
            textBox_lastname = new TextBox();
            label_lastname = new Label();
            SuspendLayout();
            // 
            // label_edit_info
            // 
            label_edit_info.AutoSize = true;
            label_edit_info.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_edit_info.ForeColor = Color.Yellow;
            label_edit_info.Location = new Point(10, 7);
            label_edit_info.Name = "label_edit_info";
            label_edit_info.Size = new Size(28, 15);
            label_edit_info.TabIndex = 0;
            label_edit_info.Text = "Edit";
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_address.ForeColor = Color.Yellow;
            label_address.Location = new Point(10, 81);
            label_address.Name = "label_address";
            label_address.Size = new Size(51, 15);
            label_address.TabIndex = 1;
            label_address.Text = "Address";
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(10, 98);
            textBox_address.Margin = new Padding(3, 2, 3, 2);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(443, 121);
            textBox_address.TabIndex = 3;
            // 
            // label_road
            // 
            label_road.AutoSize = true;
            label_road.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_road.ForeColor = Color.Yellow;
            label_road.Location = new Point(10, 230);
            label_road.Name = "label_road";
            label_road.Size = new Size(35, 15);
            label_road.TabIndex = 3;
            label_road.Text = "Road";
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_name.ForeColor = Color.Yellow;
            label_name.Location = new Point(10, 31);
            label_name.Name = "label_name";
            label_name.Size = new Size(62, 15);
            label_name.TabIndex = 4;
            label_name.Text = "Firstname";
            label_name.Click += label_name_Click;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(10, 49);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(211, 23);
            textBox_name.TabIndex = 1;
            // 
            // textBox_zipcode
            // 
            textBox_zipcode.Location = new Point(10, 350);
            textBox_zipcode.Name = "textBox_zipcode";
            textBox_zipcode.Size = new Size(211, 23);
            textBox_zipcode.TabIndex = 7;
            // 
            // textBox_road
            // 
            textBox_road.Location = new Point(10, 248);
            textBox_road.Name = "textBox_road";
            textBox_road.Size = new Size(211, 23);
            textBox_road.TabIndex = 4;
            // 
            // label_zipcode
            // 
            label_zipcode.AutoSize = true;
            label_zipcode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_zipcode.ForeColor = Color.Yellow;
            label_zipcode.Location = new Point(10, 332);
            label_zipcode.Name = "label_zipcode";
            label_zipcode.Size = new Size(51, 15);
            label_zipcode.TabIndex = 8;
            label_zipcode.Text = "Zipcode";
            // 
            // label_city
            // 
            label_city.AutoSize = true;
            label_city.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_city.ForeColor = Color.Yellow;
            label_city.Location = new Point(10, 280);
            label_city.Name = "label_city";
            label_city.Size = new Size(28, 15);
            label_city.TabIndex = 10;
            label_city.Text = "City";
            // 
            // textBox_city
            // 
            textBox_city.Location = new Point(10, 298);
            textBox_city.Name = "textBox_city";
            textBox_city.Size = new Size(211, 23);
            textBox_city.TabIndex = 6;
            // 
            // button_save
            // 
            button_save.BackColor = Color.Yellow;
            button_save.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_save.Location = new Point(240, 302);
            button_save.Name = "button_save";
            button_save.Size = new Size(213, 75);
            button_save.TabIndex = 8;
            button_save.Text = "SAVE";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // textBox_tel
            // 
            textBox_tel.Location = new Point(242, 248);
            textBox_tel.Name = "textBox_tel";
            textBox_tel.Size = new Size(211, 23);
            textBox_tel.TabIndex = 5;
            // 
            // label_tel
            // 
            label_tel.AutoSize = true;
            label_tel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_tel.ForeColor = Color.Yellow;
            label_tel.Location = new Point(242, 230);
            label_tel.Name = "label_tel";
            label_tel.Size = new Size(23, 15);
            label_tel.TabIndex = 12;
            label_tel.Text = "Tel";
            // 
            // button_back
            // 
            button_back.BackColor = Color.Yellow;
            button_back.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_back.Location = new Point(10, 398);
            button_back.Name = "button_back";
            button_back.Size = new Size(211, 75);
            button_back.TabIndex = 10;
            button_back.Text = "BACK";
            button_back.UseVisualStyleBackColor = false;
            button_back.Click += button_back_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(240, 398);
            button1.Name = "button1";
            button1.Size = new Size(213, 75);
            button1.TabIndex = 9;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox_lastname
            // 
            textBox_lastname.Location = new Point(242, 49);
            textBox_lastname.Name = "textBox_lastname";
            textBox_lastname.Size = new Size(211, 23);
            textBox_lastname.TabIndex = 2;
            // 
            // label_lastname
            // 
            label_lastname.AutoSize = true;
            label_lastname.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_lastname.ForeColor = Color.Yellow;
            label_lastname.Location = new Point(242, 31);
            label_lastname.Name = "label_lastname";
            label_lastname.Size = new Size(60, 15);
            label_lastname.TabIndex = 17;
            label_lastname.Text = "Lastname";
            // 
            // edit_info
            // 
            AcceptButton = button_save;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(466, 494);
            Controls.Add(label_lastname);
            Controls.Add(textBox_lastname);
            Controls.Add(button1);
            Controls.Add(button_back);
            Controls.Add(textBox_tel);
            Controls.Add(label_tel);
            Controls.Add(button_save);
            Controls.Add(label_city);
            Controls.Add(textBox_city);
            Controls.Add(label_zipcode);
            Controls.Add(textBox_road);
            Controls.Add(textBox_zipcode);
            Controls.Add(textBox_name);
            Controls.Add(label_name);
            Controls.Add(label_road);
            Controls.Add(textBox_address);
            Controls.Add(label_address);
            Controls.Add(label_edit_info);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "edit_info";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "edit_info";
            Activated += edit_info_Activated;
            Load += edit_info_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_edit_info;
        private Label label_address;
        private TextBox textBox_address;
        private Label label_road;
        private Label label_name;
        private TextBox textBox_name;
        private TextBox textBox_zipcode;
        private TextBox textBox_road;
        private Label label_zipcode;
        private Label label_city;
        private TextBox textBox_city;
        private Button button_save;
        private TextBox textBox_tel;
        private Label label_tel;
        private Button button_back;
        private Button button1;
        private TextBox textBox_lastname;
        private Label label_lastname;
    }
}