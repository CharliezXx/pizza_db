namespace WindowsForm1
{
    partial class Form1
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
            this.Teacher_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.student_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.advisor_combobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dob_datepicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.gpa_textbox = new System.Windows.Forms.TextBox();
            this.major_combobox = new System.Windows.Forms.ComboBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.sid_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Teacher_tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Teacher_tabControl
            // 
            this.Teacher_tabControl.Controls.Add(this.tabPage1);
            this.Teacher_tabControl.Controls.Add(this.tabPage2);
            this.Teacher_tabControl.Location = new System.Drawing.Point(-2, 1);
            this.Teacher_tabControl.Name = "Teacher_tabControl";
            this.Teacher_tabControl.SelectedIndex = 0;
            this.Teacher_tabControl.Size = new System.Drawing.Size(744, 692);
            this.Teacher_tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.student_dataGridView);
            this.panel2.Location = new System.Drawing.Point(8, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 329);
            this.panel2.TabIndex = 1;
            // 
            // student_dataGridView
            // 
            this.student_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.student_dataGridView.Name = "student_dataGridView";
            this.student_dataGridView.RowHeadersWidth = 62;
            this.student_dataGridView.RowTemplate.Height = 28;
            this.student_dataGridView.Size = new System.Drawing.Size(722, 329);
            this.student_dataGridView.TabIndex = 0;
            this.student_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_dataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.advisor_combobox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dob_datepicker);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Controls.Add(this.update_btn);
            this.panel1.Controls.Add(this.insert_btn);
            this.panel1.Controls.Add(this.female_radioButton);
            this.panel1.Controls.Add(this.male_radioButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gpa_textbox);
            this.panel1.Controls.Add(this.major_combobox);
            this.panel1.Controls.Add(this.name_textbox);
            this.panel1.Controls.Add(this.sid_textbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 311);
            this.panel1.TabIndex = 0;
            // 
            // advisor_combobox
            // 
            this.advisor_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.advisor_combobox.FormattingEnabled = true;
            this.advisor_combobox.Items.AddRange(new object[] {
            "---Select---"});
            this.advisor_combobox.Location = new System.Drawing.Point(111, 253);
            this.advisor_combobox.Name = "advisor_combobox";
            this.advisor_combobox.Size = new System.Drawing.Size(303, 28);
            this.advisor_combobox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Advisor";
            // 
            // dob_datepicker
            // 
            this.dob_datepicker.CustomFormat = "yyyy-MM-dd";
            this.dob_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob_datepicker.Location = new System.Drawing.Point(111, 213);
            this.dob_datepicker.Name = "dob_datepicker";
            this.dob_datepicker.Size = new System.Drawing.Size(304, 26);
            this.dob_datepicker.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "DOB";
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.LightGreen;
            this.clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Location = new System.Drawing.Point(492, 224);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(205, 46);
            this.clear_btn.TabIndex = 14;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.LightGreen;
            this.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Location = new System.Drawing.Point(492, 154);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(205, 46);
            this.delete_btn.TabIndex = 13;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.LightGreen;
            this.update_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Location = new System.Drawing.Point(492, 85);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(205, 46);
            this.update_btn.TabIndex = 12;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.LightGreen;
            this.insert_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_btn.Location = new System.Drawing.Point(492, 20);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(205, 46);
            this.insert_btn.TabIndex = 11;
            this.insert_btn.Text = "INSERT";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Location = new System.Drawing.Point(198, 178);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(87, 24);
            this.female_radioButton.TabIndex = 10;
            this.female_radioButton.TabStop = true;
            this.female_radioButton.Text = "Female";
            this.female_radioButton.UseVisualStyleBackColor = true;
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Location = new System.Drawing.Point(111, 178);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(68, 24);
            this.male_radioButton.TabIndex = 9;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "Male";
            this.male_radioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // gpa_textbox
            // 
            this.gpa_textbox.Location = new System.Drawing.Point(111, 138);
            this.gpa_textbox.Name = "gpa_textbox";
            this.gpa_textbox.Size = new System.Drawing.Size(304, 26);
            this.gpa_textbox.TabIndex = 7;
            // 
            // major_combobox
            // 
            this.major_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.major_combobox.FormattingEnabled = true;
            this.major_combobox.Items.AddRange(new object[] {
            "---Select---"});
            this.major_combobox.Location = new System.Drawing.Point(111, 95);
            this.major_combobox.Name = "major_combobox";
            this.major_combobox.Size = new System.Drawing.Size(303, 28);
            this.major_combobox.TabIndex = 6;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(111, 55);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(304, 26);
            this.name_textbox.TabIndex = 5;
            // 
            // sid_textbox
            // 
            this.sid_textbox.Location = new System.Drawing.Point(111, 17);
            this.sid_textbox.Name = "sid_textbox";
            this.sid_textbox.Size = new System.Drawing.Size(304, 26);
            this.sid_textbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "GPA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Major";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teacher";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 323);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(730, 333);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 311);
            this.panel3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 694);
            this.Controls.Add(this.Teacher_tabControl);
            this.Name = "Form1";
            this.Text = "Student and Teacher Forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Teacher_tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.student_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Teacher_tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton female_radioButton;
        private System.Windows.Forms.RadioButton male_radioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gpa_textbox;
        private System.Windows.Forms.ComboBox major_combobox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox sid_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView student_dataGridView;
        private System.Windows.Forms.ComboBox advisor_combobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dob_datepicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

