namespace pizza_db
{
    partial class main_page
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label_username = new Label();
            button_logout = new Button();
            button_edit_address = new Button();
            button_edit_payment = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(49, 146);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(499, 1001);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Location = new Point(49, 30);
            label_username.Name = "label_username";
            label_username.Size = new Size(75, 20);
            label_username.TabIndex = 2;
            label_username.Text = "Username";
            label_username.Click += label_username_Click;
            // 
            // button_logout
            // 
            button_logout.Location = new Point(473, 66);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(75, 73);
            button_logout.TabIndex = 3;
            button_logout.Text = "Logout";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button1_Click_1;
            // 
            // button_edit_address
            // 
            button_edit_address.Location = new Point(50, 66);
            button_edit_address.Name = "button_edit_address";
            button_edit_address.Size = new Size(74, 73);
            button_edit_address.TabIndex = 4;
            button_edit_address.Text = "Edit";
            button_edit_address.UseVisualStyleBackColor = true;
            button_edit_address.Click += button_edit_address_Click;
            // 
            // button_edit_payment
            // 
            button_edit_payment.Location = new Point(130, 66);
            button_edit_payment.Name = "button_edit_payment";
            button_edit_payment.Size = new Size(74, 73);
            button_edit_payment.TabIndex = 5;
            button_edit_payment.Text = "Payment";
            button_edit_payment.UseVisualStyleBackColor = true;
            // 
            // main_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(599, 801);
            Controls.Add(button_edit_payment);
            Controls.Add(button_edit_address);
            Controls.Add(button_logout);
            Controls.Add(label_username);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "main_page";
            Text = "Main";
            Load += main_page_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label_username;
        private Button button_logout;
        private Button button_edit_address;
        private Button button_edit_payment;
    }
}