namespace Hospital_Management_System.View_Layer
{
    partial class Doctor_Department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_Department));
            this.label13 = new System.Windows.Forms.Label();
            this.Department_Manage_DataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.DepartmentNameManageTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DepartmentManageIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_Department_Manage_TextBox = new System.Windows.Forms.TextBox();
            this.ManageDepartmentGroupBox = new System.Windows.Forms.GroupBox();
            this.DepartmentLogouButton = new System.Windows.Forms.Button();
            this.Room_Back_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Department_Manage_DataGridView)).BeginInit();
            this.ManageDepartmentGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(461, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 48;
            this.label13.Text = "Search:";
            // 
            // Department_Manage_DataGridView
            // 
            this.Department_Manage_DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Department_Manage_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Department_Manage_DataGridView.Location = new System.Drawing.Point(468, 171);
            this.Department_Manage_DataGridView.Name = "Department_Manage_DataGridView";
            this.Department_Manage_DataGridView.Size = new System.Drawing.Size(458, 348);
            this.Department_Manage_DataGridView.TabIndex = 46;
            this.Department_Manage_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Department_Manage_DataGridView_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Department Details:";
            // 
            // DepartmentNameManageTextBox
            // 
            this.DepartmentNameManageTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DepartmentNameManageTextBox.Location = new System.Drawing.Point(182, 265);
            this.DepartmentNameManageTextBox.Name = "DepartmentNameManageTextBox";
            this.DepartmentNameManageTextBox.Size = new System.Drawing.Size(244, 29);
            this.DepartmentNameManageTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department Name: ";
            // 
            // DepartmentManageIDTextBox
            // 
            this.DepartmentManageIDTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DepartmentManageIDTextBox.Location = new System.Drawing.Point(182, 207);
            this.DepartmentManageIDTextBox.Name = "DepartmentManageIDTextBox";
            this.DepartmentManageIDTextBox.Size = new System.Drawing.Size(244, 29);
            this.DepartmentManageIDTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Department ID: ";
            // 
            // Search_Department_Manage_TextBox
            // 
            this.Search_Department_Manage_TextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search_Department_Manage_TextBox.Location = new System.Drawing.Point(539, 101);
            this.Search_Department_Manage_TextBox.Name = "Search_Department_Manage_TextBox";
            this.Search_Department_Manage_TextBox.Size = new System.Drawing.Size(341, 29);
            this.Search_Department_Manage_TextBox.TabIndex = 47;
            this.Search_Department_Manage_TextBox.TextChanged += new System.EventHandler(this.Search_Department_Manage_TextBox_TextChanged);
            // 
            // ManageDepartmentGroupBox
            // 
            this.ManageDepartmentGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ManageDepartmentGroupBox.Controls.Add(this.label4);
            this.ManageDepartmentGroupBox.Controls.Add(this.DepartmentNameManageTextBox);
            this.ManageDepartmentGroupBox.Controls.Add(this.label3);
            this.ManageDepartmentGroupBox.Controls.Add(this.DepartmentManageIDTextBox);
            this.ManageDepartmentGroupBox.Controls.Add(this.label2);
            this.ManageDepartmentGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageDepartmentGroupBox.Location = new System.Drawing.Point(-3, 87);
            this.ManageDepartmentGroupBox.Name = "ManageDepartmentGroupBox";
            this.ManageDepartmentGroupBox.Size = new System.Drawing.Size(450, 478);
            this.ManageDepartmentGroupBox.TabIndex = 45;
            this.ManageDepartmentGroupBox.TabStop = false;
            // 
            // DepartmentLogouButton
            // 
            this.DepartmentLogouButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentLogouButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DepartmentLogouButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLogouButton.Location = new System.Drawing.Point(819, 5);
            this.DepartmentLogouButton.Name = "DepartmentLogouButton";
            this.DepartmentLogouButton.Size = new System.Drawing.Size(106, 63);
            this.DepartmentLogouButton.TabIndex = 10;
            this.DepartmentLogouButton.Text = "Logout";
            this.DepartmentLogouButton.UseVisualStyleBackColor = false;
            this.DepartmentLogouButton.Click += new System.EventHandler(this.DepartmentLogouButton_Click);
            // 
            // Room_Back_Button
            // 
            this.Room_Back_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Room_Back_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Room_Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_Back_Button.Location = new System.Drawing.Point(707, 5);
            this.Room_Back_Button.Name = "Room_Back_Button";
            this.Room_Back_Button.Size = new System.Drawing.Size(106, 63);
            this.Room_Back_Button.TabIndex = 9;
            this.Room_Back_Button.Text = "Back";
            this.Room_Back_Button.UseVisualStyleBackColor = false;
            this.Room_Back_Button.Click += new System.EventHandler(this.Room_Back_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.Room_Back_Button);
            this.panel1.Controls.Add(this.DepartmentLogouButton);
            this.panel1.Location = new System.Drawing.Point(-3, 564);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 71);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(943, 87);
            this.label1.TabIndex = 43;
            this.label1.Text = "Department";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doctor_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(934, 634);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Search_Department_Manage_TextBox);
            this.Controls.Add(this.ManageDepartmentGroupBox);
            this.Controls.Add(this.Department_Manage_DataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Doctor_Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor_Department";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Doctor_Department_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Department_Manage_DataGridView)).EndInit();
            this.ManageDepartmentGroupBox.ResumeLayout(false);
            this.ManageDepartmentGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView Department_Manage_DataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DepartmentNameManageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DepartmentManageIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Search_Department_Manage_TextBox;
        private System.Windows.Forms.GroupBox ManageDepartmentGroupBox;
        private System.Windows.Forms.Button DepartmentLogouButton;
        private System.Windows.Forms.Button Room_Back_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}