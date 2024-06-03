namespace pizza_db
{
    partial class close
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
            closed_label = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // closed_label
            // 
            closed_label.AutoSize = true;
            closed_label.Font = new Font("Segoe UI", 100F);
            closed_label.Location = new Point(248, 9);
            closed_label.Name = "closed_label";
            closed_label.Size = new Size(427, 177);
            closed_label.TabIndex = 0;
            closed_label.Text = "ร้านปิด";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(330, 194);
            label1.Name = "label1";
            label1.Size = new Size(244, 45);
            label1.TabIndex = 1;
            label1.Text = "ไม่มีคนรับออร์เดอร์";
            // 
            // button1
            // 
            button1.Location = new Point(330, 254);
            button1.Name = "button1";
            button1.Size = new Size(244, 95);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // close
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(closed_label);
            Name = "close";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label closed_label;
        private Label label1;
        private Button button1;
    }
}