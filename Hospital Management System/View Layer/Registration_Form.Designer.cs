namespace Hospital_Management_System.View_Layer
{
    partial class Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.SinginButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.TermsAndConditionCheckBox = new System.Windows.Forms.CheckBox();
            this.UserRegistrationUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserRegistrationPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserRegistrationConfirmPTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 87);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Registration ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SinginButton
            // 
            this.SinginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SinginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SinginButton.ForeColor = System.Drawing.Color.White;
            this.SinginButton.Location = new System.Drawing.Point(113, 412);
            this.SinginButton.Name = "SinginButton";
            this.SinginButton.Size = new System.Drawing.Size(284, 41);
            this.SinginButton.TabIndex = 3;
            this.SinginButton.Text = "Sign In";
            this.SinginButton.UseVisualStyleBackColor = false;
            this.SinginButton.Click += new System.EventHandler(this.SinginButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Red;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(113, 468);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(284, 41);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TermsAndConditionCheckBox
            // 
            this.TermsAndConditionCheckBox.AutoSize = true;
            this.TermsAndConditionCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.TermsAndConditionCheckBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.TermsAndConditionCheckBox.Location = new System.Drawing.Point(95, 372);
            this.TermsAndConditionCheckBox.Name = "TermsAndConditionCheckBox";
            this.TermsAndConditionCheckBox.Size = new System.Drawing.Size(320, 24);
            this.TermsAndConditionCheckBox.TabIndex = 6;
            this.TermsAndConditionCheckBox.Text = "Agree all the terms and Conditions";
            this.TermsAndConditionCheckBox.UseVisualStyleBackColor = false;
            this.TermsAndConditionCheckBox.CheckedChanged += new System.EventHandler(this.TermsAndConditionCheckBox_CheckedChanged);
            // 
            // UserRegistrationUsernameTextBox
            // 
            this.UserRegistrationUsernameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserRegistrationUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserRegistrationUsernameTextBox.Location = new System.Drawing.Point(108, 161);
            this.UserRegistrationUsernameTextBox.Multiline = true;
            this.UserRegistrationUsernameTextBox.Name = "UserRegistrationUsernameTextBox";
            this.UserRegistrationUsernameTextBox.Size = new System.Drawing.Size(284, 27);
            this.UserRegistrationUsernameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(104, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username:";
            // 
            // UserRegistrationPasswordTextBox
            // 
            this.UserRegistrationPasswordTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserRegistrationPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserRegistrationPasswordTextBox.Location = new System.Drawing.Point(108, 236);
            this.UserRegistrationPasswordTextBox.Multiline = true;
            this.UserRegistrationPasswordTextBox.Name = "UserRegistrationPasswordTextBox";
            this.UserRegistrationPasswordTextBox.Size = new System.Drawing.Size(284, 27);
            this.UserRegistrationPasswordTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(108, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password:";
            // 
            // UserRegistrationConfirmPTextBox
            // 
            this.UserRegistrationConfirmPTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserRegistrationConfirmPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserRegistrationConfirmPTextBox.Location = new System.Drawing.Point(108, 310);
            this.UserRegistrationConfirmPTextBox.Multiline = true;
            this.UserRegistrationConfirmPTextBox.Name = "UserRegistrationConfirmPTextBox";
            this.UserRegistrationConfirmPTextBox.Size = new System.Drawing.Size(284, 27);
            this.UserRegistrationConfirmPTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(104, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Confirm Password:";
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 583);
            this.Controls.Add(this.UserRegistrationConfirmPTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserRegistrationPasswordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserRegistrationUsernameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TermsAndConditionCheckBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SinginButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SinginButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.CheckBox TermsAndConditionCheckBox;
        private System.Windows.Forms.TextBox UserRegistrationUsernameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserRegistrationPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserRegistrationConfirmPTextBox;
        private System.Windows.Forms.Label label5;
    }
}