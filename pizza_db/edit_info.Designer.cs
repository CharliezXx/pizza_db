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
            SuspendLayout();
            // 
            // label_edit_info
            // 
            label_edit_info.AutoSize = true;
            label_edit_info.Location = new Point(12, 9);
            label_edit_info.Name = "label_edit_info";
            label_edit_info.Size = new Size(35, 20);
            label_edit_info.TabIndex = 0;
            label_edit_info.Text = "Edit";
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Location = new Point(12, 39);
            label_address.Name = "label_address";
            label_address.Size = new Size(62, 20);
            label_address.TabIndex = 1;
            label_address.Text = "Address";
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(12, 62);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(575, 160);
            textBox_address.TabIndex = 2;
            // 
            // label_road
            // 
            label_road.AutoSize = true;
            label_road.Location = new Point(12, 235);
            label_road.Name = "label_road";
            label_road.Size = new Size(40, 20);
            label_road.TabIndex = 3;
            label_road.Text = "road";
            // 
            // edit_info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 801);
            Controls.Add(label_road);
            Controls.Add(textBox_address);
            Controls.Add(label_address);
            Controls.Add(label_edit_info);
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
    }
}