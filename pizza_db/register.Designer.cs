namespace pizza_db
{
    partial class register
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
            back_register_button = new Button();
            register_text1 = new Label();
            label_username_regis = new Label();
            label_password_regis = new Label();
            label_confirm_regis = new Label();
            textBox_name_regis = new TextBox();
            textBox_password_regis = new TextBox();
            textBox_confirm_regis = new TextBox();
            confirm_regis_button = new Button();
            error_label = new Label();
            error_label_username_taken = new Label();
            checkBox_show_regis = new CheckBox();
            SuspendLayout();
            // 
            // back_register_button
            // 
            back_register_button.Font = new Font("SimSun", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back_register_button.Location = new Point(68, 267);
            back_register_button.Name = "back_register_button";
            back_register_button.Size = new Size(153, 57);
            back_register_button.TabIndex = 6;
            back_register_button.Text = "back";
            back_register_button.UseVisualStyleBackColor = true;
            back_register_button.Click += back_register_button_Click;
            // 
            // register_text1
            // 
            register_text1.AutoSize = true;
            register_text1.Font = new Font("Sitka Text", 24.2499962F);
            register_text1.Location = new Point(190, 26);
            register_text1.Name = "register_text1";
            register_text1.Size = new Size(141, 48);
            register_text1.TabIndex = 2;
            register_text1.Text = "register";
            // 
            // label_username_regis
            // 
            label_username_regis.AutoSize = true;
            label_username_regis.Font = new Font("Segoe UI", 9F);
            label_username_regis.Location = new Point(68, 71);
            label_username_regis.Name = "label_username_regis";
            label_username_regis.Size = new Size(60, 15);
            label_username_regis.TabIndex = 3;
            label_username_regis.Text = "Username";
            // 
            // label_password_regis
            // 
            label_password_regis.AutoSize = true;
            label_password_regis.Font = new Font("Segoe UI", 9F);
            label_password_regis.Location = new Point(68, 119);
            label_password_regis.Name = "label_password_regis";
            label_password_regis.Size = new Size(57, 15);
            label_password_regis.TabIndex = 4;
            label_password_regis.Text = "Password";
            label_password_regis.Click += label_password_regis_Click;
            // 
            // label_confirm_regis
            // 
            label_confirm_regis.AutoSize = true;
            label_confirm_regis.Font = new Font("Segoe UI", 9F);
            label_confirm_regis.Location = new Point(68, 172);
            label_confirm_regis.Name = "label_confirm_regis";
            label_confirm_regis.Size = new Size(104, 15);
            label_confirm_regis.TabIndex = 5;
            label_confirm_regis.Text = "Confirm password";
            // 
            // textBox_name_regis
            // 
            textBox_name_regis.Location = new Point(68, 89);
            textBox_name_regis.Name = "textBox_name_regis";
            textBox_name_regis.Size = new Size(377, 23);
            textBox_name_regis.TabIndex = 1;
            // 
            // textBox_password_regis
            // 
            textBox_password_regis.Location = new Point(68, 137);
            textBox_password_regis.Name = "textBox_password_regis";
            textBox_password_regis.Size = new Size(377, 23);
            textBox_password_regis.TabIndex = 2;
            textBox_password_regis.UseSystemPasswordChar = true;
            textBox_password_regis.TextChanged += textBox_password_regis_TextChanged;
            // 
            // textBox_confirm_regis
            // 
            textBox_confirm_regis.Location = new Point(68, 190);
            textBox_confirm_regis.Name = "textBox_confirm_regis";
            textBox_confirm_regis.Size = new Size(377, 23);
            textBox_confirm_regis.TabIndex = 3;
            textBox_confirm_regis.UseSystemPasswordChar = true;
            // 
            // confirm_regis_button
            // 
            confirm_regis_button.Font = new Font("SimSun", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirm_regis_button.Location = new Point(292, 267);
            confirm_regis_button.Name = "confirm_regis_button";
            confirm_regis_button.Size = new Size(153, 57);
            confirm_regis_button.TabIndex = 5;
            confirm_regis_button.Text = "lesssgooo";
            confirm_regis_button.UseVisualStyleBackColor = true;
            confirm_regis_button.Click += confirm_regis_button_Click;
            // 
            // error_label
            // 
            error_label.AutoSize = true;
            error_label.ForeColor = Color.Red;
            error_label.Location = new Point(68, 216);
            error_label.Name = "error_label";
            error_label.Size = new Size(205, 15);
            error_label.TabIndex = 10;
            error_label.Text = "Incorrect data or password not match";
            // 
            // error_label_username_taken
            // 
            error_label_username_taken.AutoSize = true;
            error_label_username_taken.ForeColor = Color.Red;
            error_label_username_taken.Location = new Point(292, 115);
            error_label_username_taken.Name = "error_label_username_taken";
            error_label_username_taken.Size = new Size(156, 15);
            error_label_username_taken.TabIndex = 11;
            error_label_username_taken.Text = "This username already taken";
            // 
            // checkBox_show_regis
            // 
            checkBox_show_regis.AutoSize = true;
            checkBox_show_regis.Location = new Point(337, 215);
            checkBox_show_regis.Name = "checkBox_show_regis";
            checkBox_show_regis.RightToLeft = RightToLeft.Yes;
            checkBox_show_regis.Size = new Size(108, 19);
            checkBox_show_regis.TabIndex = 4;
            checkBox_show_regis.Text = "Show password";
            checkBox_show_regis.UseVisualStyleBackColor = true;
            checkBox_show_regis.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // register
            // 
            AcceptButton = confirm_regis_button;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(524, 361);
            Controls.Add(checkBox_show_regis);
            Controls.Add(error_label_username_taken);
            Controls.Add(error_label);
            Controls.Add(confirm_regis_button);
            Controls.Add(textBox_confirm_regis);
            Controls.Add(textBox_password_regis);
            Controls.Add(textBox_name_regis);
            Controls.Add(label_confirm_regis);
            Controls.Add(label_password_regis);
            Controls.Add(label_username_regis);
            Controls.Add(register_text1);
            Controls.Add(back_register_button);
            MinimizeBox = false;
            Name = "register";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button back_register_button;
        private Label register_text1;
        private Label label_username_regis;
        private Label label_password_regis;
        private Label label_confirm_regis;
        private TextBox textBox_name_regis;
        private TextBox textBox_password_regis;
        private TextBox textBox_confirm_regis;
        private Button confirm_regis_button;
        private Label error_label;
        private Label error_label_username_taken;
        private CheckBox checkBox_show_regis;
    }
}