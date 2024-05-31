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
            SuspendLayout();
            // 
            // label_edit_info
            // 
            label_edit_info.AutoSize = true;
            label_edit_info.Location = new Point(10, 7);
            label_edit_info.Name = "label_edit_info";
            label_edit_info.Size = new Size(27, 15);
            label_edit_info.TabIndex = 0;
            label_edit_info.Text = "Edit";
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Location = new Point(10, 81);
            label_address.Name = "label_address";
            label_address.Size = new Size(49, 15);
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
            textBox_address.TabIndex = 2;
            // 
            // label_road
            // 
            label_road.AutoSize = true;
            label_road.Location = new Point(10, 230);
            label_road.Name = "label_road";
            label_road.Size = new Size(34, 15);
            label_road.TabIndex = 3;
            label_road.Text = "Road";
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(10, 31);
            label_name.Name = "label_name";
            label_name.Size = new Size(95, 15);
            label_name.TabIndex = 4;
            label_name.Text = "Name-Lastname";
            label_name.Click += label_name_Click;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(10, 49);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(253, 23);
            textBox_name.TabIndex = 5;
            // 
            // textBox_zipcode
            // 
            textBox_zipcode.Location = new Point(10, 350);
            textBox_zipcode.Name = "textBox_zipcode";
            textBox_zipcode.Size = new Size(211, 23);
            textBox_zipcode.TabIndex = 6;
            // 
            // textBox_road
            // 
            textBox_road.Location = new Point(10, 248);
            textBox_road.Name = "textBox_road";
            textBox_road.Size = new Size(211, 23);
            textBox_road.TabIndex = 7;
            // 
            // label_zipcode
            // 
            label_zipcode.AutoSize = true;
            label_zipcode.Location = new Point(10, 332);
            label_zipcode.Name = "label_zipcode";
            label_zipcode.Size = new Size(50, 15);
            label_zipcode.TabIndex = 8;
            label_zipcode.Text = "Zipcode";
            // 
            // label_city
            // 
            label_city.AutoSize = true;
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
            textBox_city.TabIndex = 9;
            // 
            // button_save
            // 
            button_save.Location = new Point(240, 302);
            button_save.Name = "button_save";
            button_save.Size = new Size(213, 75);
            button_save.TabIndex = 11;
            button_save.Text = "SAVE";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textBox_tel
            // 
            textBox_tel.Location = new Point(242, 248);
            textBox_tel.Name = "textBox_tel";
            textBox_tel.Size = new Size(211, 23);
            textBox_tel.TabIndex = 13;
            // 
            // label_tel
            // 
            label_tel.AutoSize = true;
            label_tel.Location = new Point(242, 230);
            label_tel.Name = "label_tel";
            label_tel.Size = new Size(21, 15);
            label_tel.TabIndex = 12;
            label_tel.Text = "Tel";
            // 
            // button_back
            // 
            button_back.Location = new Point(10, 398);
            button_back.Name = "button_back";
            button_back.Size = new Size(211, 75);
            button_back.TabIndex = 14;
            button_back.Text = "BACK";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button1
            // 
            button1.Location = new Point(240, 398);
            button1.Name = "button1";
            button1.Size = new Size(213, 75);
            button1.TabIndex = 15;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // edit_info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 494);
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
            Name = "edit_info";
            Text = "edit_info";
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
    }
}