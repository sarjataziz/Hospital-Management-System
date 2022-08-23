namespace Hospital_Management_System.View_Layer
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.Login_User_PictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.User_Password_TextBox = new System.Windows.Forms.TextBox();
            this.User_Login_Button = new System.Windows.Forms.Button();
            this.Go_To_Back_Login_Button = new System.Windows.Forms.Button();
            this.Show_Password_CheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.GoToRegistrationFrom_Lebel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Login_User_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Login our System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_User_PictureBox
            // 
            this.Login_User_PictureBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Login_User_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Login_User_PictureBox.Image")));
            this.Login_User_PictureBox.Location = new System.Drawing.Point(169, 112);
            this.Login_User_PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.Login_User_PictureBox.Name = "Login_User_PictureBox";
            this.Login_User_PictureBox.Size = new System.Drawing.Size(194, 149);
            this.Login_User_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Login_User_PictureBox.TabIndex = 1;
            this.Login_User_PictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password: ";
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Username_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username_TextBox.Location = new System.Drawing.Point(155, 268);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(233, 26);
            this.Username_TextBox.TabIndex = 4;
            // 
            // User_Password_TextBox
            // 
            this.User_Password_TextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.User_Password_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_Password_TextBox.Location = new System.Drawing.Point(155, 320);
            this.User_Password_TextBox.Name = "User_Password_TextBox";
            this.User_Password_TextBox.PasswordChar = '*';
            this.User_Password_TextBox.Size = new System.Drawing.Size(233, 26);
            this.User_Password_TextBox.TabIndex = 5;
            this.User_Password_TextBox.Tag = "";
            // 
            // User_Login_Button
            // 
            this.User_Login_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.User_Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Login_Button.ForeColor = System.Drawing.Color.White;
            this.User_Login_Button.Location = new System.Drawing.Point(155, 431);
            this.User_Login_Button.Name = "User_Login_Button";
            this.User_Login_Button.Size = new System.Drawing.Size(229, 38);
            this.User_Login_Button.TabIndex = 6;
            this.User_Login_Button.Text = "Login";
            this.User_Login_Button.UseVisualStyleBackColor = false;
            this.User_Login_Button.Click += new System.EventHandler(this.User_Login_Button_Click);
            // 
            // Go_To_Back_Login_Button
            // 
            this.Go_To_Back_Login_Button.BackColor = System.Drawing.Color.Gray;
            this.Go_To_Back_Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Go_To_Back_Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go_To_Back_Login_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Go_To_Back_Login_Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Go_To_Back_Login_Button.Location = new System.Drawing.Point(155, 475);
            this.Go_To_Back_Login_Button.Name = "Go_To_Back_Login_Button";
            this.Go_To_Back_Login_Button.Size = new System.Drawing.Size(229, 37);
            this.Go_To_Back_Login_Button.TabIndex = 7;
            this.Go_To_Back_Login_Button.Text = "Back";
            this.Go_To_Back_Login_Button.UseVisualStyleBackColor = false;
            this.Go_To_Back_Login_Button.Click += new System.EventHandler(this.Go_To_Back_Login_Button_Click);
            // 
            // Show_Password_CheckBox
            // 
            this.Show_Password_CheckBox.AutoSize = true;
            this.Show_Password_CheckBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Show_Password_CheckBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Password_CheckBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Show_Password_CheckBox.Location = new System.Drawing.Point(155, 362);
            this.Show_Password_CheckBox.Name = "Show_Password_CheckBox";
            this.Show_Password_CheckBox.Size = new System.Drawing.Size(148, 24);
            this.Show_Password_CheckBox.TabIndex = 8;
            this.Show_Password_CheckBox.Text = "Show Password";
            this.Show_Password_CheckBox.UseVisualStyleBackColor = false;
            this.Show_Password_CheckBox.CheckedChanged += new System.EventHandler(this.Show_Password_CheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(155, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ChangePasswordLabel.Location = new System.Drawing.Point(187, 399);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(154, 20);
            this.ChangePasswordLabel.TabIndex = 12;
            this.ChangePasswordLabel.Text = "Forget Password?";
            this.ChangePasswordLabel.Click += new System.EventHandler(this.ChangePasswordLabel_Click);
            // 
            // GoToRegistrationFrom_Lebel
            // 
            this.GoToRegistrationFrom_Lebel.AutoSize = true;
            this.GoToRegistrationFrom_Lebel.BackColor = System.Drawing.Color.Transparent;
            this.GoToRegistrationFrom_Lebel.ForeColor = System.Drawing.Color.Navy;
            this.GoToRegistrationFrom_Lebel.Location = new System.Drawing.Point(168, 585);
            this.GoToRegistrationFrom_Lebel.Name = "GoToRegistrationFrom_Lebel";
            this.GoToRegistrationFrom_Lebel.Size = new System.Drawing.Size(173, 20);
            this.GoToRegistrationFrom_Lebel.TabIndex = 13;
            this.GoToRegistrationFrom_Lebel.Text = "Create New Account";
            this.GoToRegistrationFrom_Lebel.Click += new System.EventHandler(this.GoToRegistrationFrom_Lebel_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 649);
            this.Controls.Add(this.GoToRegistrationFrom_Lebel);
            this.Controls.Add(this.ChangePasswordLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Show_Password_CheckBox);
            this.Controls.Add(this.Go_To_Back_Login_Button);
            this.Controls.Add(this.User_Login_Button);
            this.Controls.Add(this.User_Password_TextBox);
            this.Controls.Add(this.Username_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login_User_PictureBox);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Login_User_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Login_User_PictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.TextBox User_Password_TextBox;
        private System.Windows.Forms.Button User_Login_Button;
        private System.Windows.Forms.Button Go_To_Back_Login_Button;
        private System.Windows.Forms.CheckBox Show_Password_CheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ChangePasswordLabel;
        private System.Windows.Forms.Label GoToRegistrationFrom_Lebel;
    }
}