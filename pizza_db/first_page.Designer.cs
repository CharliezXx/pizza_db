namespace pizza_db
{
    partial class first_page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login_button = new Button();
            Login_text = new Label();
            textBox_name_firstpage = new TextBox();
            username_label = new Label();
            textBox_password_firstpage = new TextBox();
            password_label = new Label();
            register_linklabel = new LinkLabel();
            text1 = new Label();
            checkBox_showpass_login = new CheckBox();
            error_first_page = new Label();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.Location = new Point(82, 242);
            login_button.Name = "login_button";
            login_button.Size = new Size(358, 59);
            login_button.TabIndex = 5;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // Login_text
            // 
            Login_text.AutoSize = true;
            Login_text.Font = new Font("Sitka Text", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_text.Location = new Point(201, 37);
            Login_text.Name = "Login_text";
            Login_text.Size = new Size(120, 47);
            Login_text.TabIndex = 1;
            Login_text.Text = "LOGIN";
            Login_text.TextAlign = ContentAlignment.TopCenter;
            Login_text.Click += Login_text_Click;
            // 
            // textBox_name_firstpage
            // 
            textBox_name_firstpage.Location = new Point(82, 111);
            textBox_name_firstpage.Name = "textBox_name_firstpage";
            textBox_name_firstpage.Size = new Size(358, 23);
            textBox_name_firstpage.TabIndex = 1;
            textBox_name_firstpage.TextChanged += textBox1_TextChanged;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Location = new Point(82, 93);
            username_label.Name = "username_label";
            username_label.Size = new Size(60, 15);
            username_label.TabIndex = 3;
            username_label.Text = "Username";
            // 
            // textBox_password_firstpage
            // 
            textBox_password_firstpage.Location = new Point(82, 165);
            textBox_password_firstpage.Name = "textBox_password_firstpage";
            textBox_password_firstpage.Size = new Size(358, 23);
            textBox_password_firstpage.TabIndex = 2;
            textBox_password_firstpage.UseSystemPasswordChar = true;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(82, 147);
            password_label.Name = "password_label";
            password_label.Size = new Size(57, 15);
            password_label.TabIndex = 5;
            password_label.Text = "Password";
            // 
            // register_linklabel
            // 
            register_linklabel.AutoSize = true;
            register_linklabel.Location = new Point(222, 199);
            register_linklabel.Name = "register_linklabel";
            register_linklabel.Size = new Size(47, 15);
            register_linklabel.TabIndex = 3;
            register_linklabel.TabStop = true;
            register_linklabel.Text = "Sign up";
            register_linklabel.LinkClicked += register_linklabel_LinkClicked;
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Location = new Point(82, 199);
            text1.Name = "text1";
            text1.Size = new Size(134, 15);
            text1.TabIndex = 7;
            text1.Text = "Don't have an account ?";
            // 
            // checkBox_showpass_login
            // 
            checkBox_showpass_login.AutoSize = true;
            checkBox_showpass_login.Location = new Point(332, 199);
            checkBox_showpass_login.Name = "checkBox_showpass_login";
            checkBox_showpass_login.RightToLeft = RightToLeft.Yes;
            checkBox_showpass_login.Size = new Size(108, 19);
            checkBox_showpass_login.TabIndex = 4;
            checkBox_showpass_login.Text = "Show password";
            checkBox_showpass_login.UseVisualStyleBackColor = true;
            checkBox_showpass_login.CheckedChanged += checkBox_showpass_login_CheckedChanged;
            // 
            // error_first_page
            // 
            error_first_page.AutoSize = true;
            error_first_page.ForeColor = Color.Red;
            error_first_page.Location = new Point(82, 224);
            error_first_page.Name = "error_first_page";
            error_first_page.Size = new Size(165, 15);
            error_first_page.TabIndex = 9;
            error_first_page.Text = "Wrong username or password";
            error_first_page.Visible = false;
            // 
            // first_page
            // 
            AcceptButton = login_button;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Coral;
            ClientSize = new Size(524, 361);
            Controls.Add(error_first_page);
            Controls.Add(checkBox_showpass_login);
            Controls.Add(text1);
            Controls.Add(register_linklabel);
            Controls.Add(password_label);
            Controls.Add(textBox_password_firstpage);
            Controls.Add(username_label);
            Controls.Add(textBox_name_firstpage);
            Controls.Add(Login_text);
            Controls.Add(login_button);
            MaximizeBox = false;
            Name = "first_page";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_button;
        private Label Login_text;
        private TextBox textBox_name_firstpage;
        private Label username_label;
        private TextBox textBox_password_firstpage;
        private Label password_label;
        private LinkLabel register_linklabel;
        private Label text1;
        private CheckBox checkBox_showpass_login;
        private Label error_first_page;
    }
}
