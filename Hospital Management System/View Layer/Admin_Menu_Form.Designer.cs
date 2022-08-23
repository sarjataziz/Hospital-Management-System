namespace Hospital_Management_System.View_Layer
{
    partial class Admin_Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Menu_Form));
            this.label = new System.Windows.Forms.Label();
            this.Admin_Doctor_PictureBox = new System.Windows.Forms.PictureBox();
            this.Admin_Patient_PictureBox = new System.Windows.Forms.PictureBox();
            this.Admin_Doctor_Button = new System.Windows.Forms.Button();
            this.Admin_Patient_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Admin_Username_TextBox = new System.Windows.Forms.TextBox();
            this.Admin_ID_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Admin_Name_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Admin_Logout_Button = new System.Windows.Forms.Button();
            this.Admin_Profile_PictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Admin_Test_Button = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Doctor_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Patient_PictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Profile_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.DimGray;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(1, 37);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(1450, 78);
            this.label.TabIndex = 0;
            this.label.Text = "Admin Panel";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin_Doctor_PictureBox
            // 
            this.Admin_Doctor_PictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.Admin_Doctor_PictureBox.Image = global::Hospital_Management_System.Properties.Resources.doctor_health_hospital_man_icon;
            this.Admin_Doctor_PictureBox.Location = new System.Drawing.Point(639, 212);
            this.Admin_Doctor_PictureBox.Name = "Admin_Doctor_PictureBox";
            this.Admin_Doctor_PictureBox.Size = new System.Drawing.Size(186, 164);
            this.Admin_Doctor_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Admin_Doctor_PictureBox.TabIndex = 2;
            this.Admin_Doctor_PictureBox.TabStop = false;
            // 
            // Admin_Patient_PictureBox
            // 
            this.Admin_Patient_PictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.Admin_Patient_PictureBox.Image = global::Hospital_Management_System.Properties.Resources.illness_patient_icon;
            this.Admin_Patient_PictureBox.Location = new System.Drawing.Point(877, 212);
            this.Admin_Patient_PictureBox.Name = "Admin_Patient_PictureBox";
            this.Admin_Patient_PictureBox.Size = new System.Drawing.Size(186, 164);
            this.Admin_Patient_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Admin_Patient_PictureBox.TabIndex = 3;
            this.Admin_Patient_PictureBox.TabStop = false;
            // 
            // Admin_Doctor_Button
            // 
            this.Admin_Doctor_Button.BackColor = System.Drawing.Color.Gray;
            this.Admin_Doctor_Button.Location = new System.Drawing.Point(639, 413);
            this.Admin_Doctor_Button.Name = "Admin_Doctor_Button";
            this.Admin_Doctor_Button.Size = new System.Drawing.Size(186, 45);
            this.Admin_Doctor_Button.TabIndex = 6;
            this.Admin_Doctor_Button.Text = "Doctors";
            this.Admin_Doctor_Button.UseVisualStyleBackColor = false;
            this.Admin_Doctor_Button.Click += new System.EventHandler(this.Admin_Doctor_Button_Click);
            // 
            // Admin_Patient_Button
            // 
            this.Admin_Patient_Button.BackColor = System.Drawing.Color.Gray;
            this.Admin_Patient_Button.Location = new System.Drawing.Point(877, 413);
            this.Admin_Patient_Button.Name = "Admin_Patient_Button";
            this.Admin_Patient_Button.Size = new System.Drawing.Size(186, 45);
            this.Admin_Patient_Button.TabIndex = 7;
            this.Admin_Patient_Button.Text = "Patients";
            this.Admin_Patient_Button.UseVisualStyleBackColor = false;
            this.Admin_Patient_Button.Click += new System.EventHandler(this.Admin_Patient_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.Admin_Username_TextBox);
            this.panel1.Controls.Add(this.Admin_ID_TextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Admin_Name_TextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Admin_Logout_Button);
            this.panel1.Controls.Add(this.Admin_Profile_PictureBox);
            this.panel1.Location = new System.Drawing.Point(-2, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 779);
            this.panel1.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(198, 388);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 26);
            this.textBox4.TabIndex = 29;
            this.textBox4.Text = "Admin";
            // 
            // Admin_Username_TextBox
            // 
            this.Admin_Username_TextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Admin_Username_TextBox.Location = new System.Drawing.Point(198, 349);
            this.Admin_Username_TextBox.Name = "Admin_Username_TextBox";
            this.Admin_Username_TextBox.Size = new System.Drawing.Size(175, 26);
            this.Admin_Username_TextBox.TabIndex = 28;
            // 
            // Admin_ID_TextBox
            // 
            this.Admin_ID_TextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Admin_ID_TextBox.Location = new System.Drawing.Point(198, 312);
            this.Admin_ID_TextBox.Name = "Admin_ID_TextBox";
            this.Admin_ID_TextBox.Size = new System.Drawing.Size(175, 26);
            this.Admin_ID_TextBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SlateGray;
            this.label4.Location = new System.Drawing.Point(100, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "User ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SlateGray;
            this.label3.Location = new System.Drawing.Point(100, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(100, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID:";
            // 
            // Admin_Name_TextBox
            // 
            this.Admin_Name_TextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Admin_Name_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Admin_Name_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Name_TextBox.Location = new System.Drawing.Point(128, 220);
            this.Admin_Name_TextBox.Name = "Admin_Name_TextBox";
            this.Admin_Name_TextBox.Size = new System.Drawing.Size(245, 30);
            this.Admin_Name_TextBox.TabIndex = 23;
            this.Admin_Name_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Admin";
            // 
            // Admin_Logout_Button
            // 
            this.Admin_Logout_Button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Admin_Logout_Button.FlatAppearance.BorderSize = 0;
            this.Admin_Logout_Button.Location = new System.Drawing.Point(0, 733);
            this.Admin_Logout_Button.Name = "Admin_Logout_Button";
            this.Admin_Logout_Button.Size = new System.Drawing.Size(485, 46);
            this.Admin_Logout_Button.TabIndex = 21;
            this.Admin_Logout_Button.Text = "Logout";
            this.Admin_Logout_Button.UseVisualStyleBackColor = false;
            this.Admin_Logout_Button.Click += new System.EventHandler(this.Admin_Logout_Button_Click_1);
            // 
            // Admin_Profile_PictureBox
            // 
            this.Admin_Profile_PictureBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Admin_Profile_PictureBox.Location = new System.Drawing.Point(161, 50);
            this.Admin_Profile_PictureBox.Name = "Admin_Profile_PictureBox";
            this.Admin_Profile_PictureBox.Size = new System.Drawing.Size(186, 164);
            this.Admin_Profile_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Admin_Profile_PictureBox.TabIndex = 20;
            this.Admin_Profile_PictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(639, 703);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Room";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = global::Hospital_Management_System.Properties.Resources.Patient_Room_icon;
            this.pictureBox1.Location = new System.Drawing.Point(639, 502);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(877, 703);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "Department";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Image = global::Hospital_Management_System.Properties.Resources.department_organization_chart_tree_icon;
            this.pictureBox2.Location = new System.Drawing.Point(877, 502);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(1120, 703);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 45);
            this.button3.TabIndex = 19;
            this.button3.Text = "Bill";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox3.Image = global::Hospital_Management_System.Properties.Resources.bill_card_credit_expenditure_icon;
            this.pictureBox3.Location = new System.Drawing.Point(1120, 502);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(186, 164);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // Admin_Test_Button
            // 
            this.Admin_Test_Button.BackColor = System.Drawing.Color.Gray;
            this.Admin_Test_Button.Location = new System.Drawing.Point(1120, 413);
            this.Admin_Test_Button.Name = "Admin_Test_Button";
            this.Admin_Test_Button.Size = new System.Drawing.Size(186, 45);
            this.Admin_Test_Button.TabIndex = 21;
            this.Admin_Test_Button.Text = "Test Results";
            this.Admin_Test_Button.UseVisualStyleBackColor = false;
            this.Admin_Test_Button.Click += new System.EventHandler(this.Admin_Test_Button_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox4.Image = global::Hospital_Management_System.Properties.Resources.test_results_research_analysis_icon;
            this.pictureBox4.Location = new System.Drawing.Point(1120, 212);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(186, 164);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EmailTextBox.Location = new System.Drawing.Point(198, 432);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(175, 26);
            this.EmailTextBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(100, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Email:";
            // 
            // Admin_Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1451, 891);
            this.Controls.Add(this.Admin_Test_Button);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Admin_Patient_Button);
            this.Controls.Add(this.Admin_Doctor_Button);
            this.Controls.Add(this.Admin_Patient_PictureBox);
            this.Controls.Add(this.Admin_Doctor_PictureBox);
            this.Controls.Add(this.label);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Admin_Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Menu_Form_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Menu_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Doctor_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Patient_PictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_Profile_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox Admin_Doctor_PictureBox;
        private System.Windows.Forms.PictureBox Admin_Patient_PictureBox;
        private System.Windows.Forms.Button Admin_Doctor_Button;
        private System.Windows.Forms.Button Admin_Patient_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox Admin_Username_TextBox;
        private System.Windows.Forms.TextBox Admin_ID_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Admin_Logout_Button;
        private System.Windows.Forms.PictureBox Admin_Profile_PictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Admin_Test_Button;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox Admin_Name_TextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label5;
    }
}