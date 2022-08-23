namespace Hospital_Management_System.View_Layer
{
    partial class Doctor_Manage_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_Manage_Room));
            this.Search_Room_Manage_TextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Room_Manage_GroupBox = new System.Windows.Forms.GroupBox();
            this.RoomCostTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomNOTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomPatientIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RoomTypeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomLogouButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Room_Back_Button = new System.Windows.Forms.Button();
            this.Room_Manage_DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Room_Manage_GroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Room_Manage_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_Room_Manage_TextBox
            // 
            this.Search_Room_Manage_TextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search_Room_Manage_TextBox.Location = new System.Drawing.Point(528, 99);
            this.Search_Room_Manage_TextBox.Name = "Search_Room_Manage_TextBox";
            this.Search_Room_Manage_TextBox.Size = new System.Drawing.Size(404, 29);
            this.Search_Room_Manage_TextBox.TabIndex = 49;
            this.Search_Room_Manage_TextBox.TextChanged += new System.EventHandler(this.Search_Room_Manage_TextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(450, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 50;
            this.label13.Text = "Search:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Room Details: ";
            // 
            // Room_Manage_GroupBox
            // 
            this.Room_Manage_GroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Room_Manage_GroupBox.Controls.Add(this.label7);
            this.Room_Manage_GroupBox.Controls.Add(this.RoomCostTextBox);
            this.Room_Manage_GroupBox.Controls.Add(this.label6);
            this.Room_Manage_GroupBox.Controls.Add(this.RoomNOTextBox);
            this.Room_Manage_GroupBox.Controls.Add(this.label5);
            this.Room_Manage_GroupBox.Controls.Add(this.RoomPatientIDTextBox);
            this.Room_Manage_GroupBox.Controls.Add(this.label4);
            this.Room_Manage_GroupBox.Controls.Add(this.RoomTypeTextBox);
            this.Room_Manage_GroupBox.Controls.Add(this.label3);
            this.Room_Manage_GroupBox.Controls.Add(this.RoomIDTextBox);
            this.Room_Manage_GroupBox.Controls.Add(this.label2);
            this.Room_Manage_GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Room_Manage_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_Manage_GroupBox.Location = new System.Drawing.Point(0, 77);
            this.Room_Manage_GroupBox.Name = "Room_Manage_GroupBox";
            this.Room_Manage_GroupBox.Size = new System.Drawing.Size(428, 472);
            this.Room_Manage_GroupBox.TabIndex = 48;
            this.Room_Manage_GroupBox.TabStop = false;
            // 
            // RoomCostTextBox
            // 
            this.RoomCostTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.RoomCostTextBox.Location = new System.Drawing.Point(132, 287);
            this.RoomCostTextBox.Name = "RoomCostTextBox";
            this.RoomCostTextBox.Size = new System.Drawing.Size(267, 26);
            this.RoomCostTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Room Cost:";
            // 
            // RoomNOTextBox
            // 
            this.RoomNOTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.RoomNOTextBox.Location = new System.Drawing.Point(132, 192);
            this.RoomNOTextBox.Name = "RoomNOTextBox";
            this.RoomNOTextBox.Size = new System.Drawing.Size(267, 26);
            this.RoomNOTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Room No:";
            // 
            // RoomPatientIDTextBox
            // 
            this.RoomPatientIDTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.RoomPatientIDTextBox.Location = new System.Drawing.Point(132, 336);
            this.RoomPatientIDTextBox.Name = "RoomPatientIDTextBox";
            this.RoomPatientIDTextBox.Size = new System.Drawing.Size(267, 26);
            this.RoomPatientIDTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Patient ID:";
            // 
            // RoomTypeTextBox
            // 
            this.RoomTypeTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.RoomTypeTextBox.Location = new System.Drawing.Point(132, 237);
            this.RoomTypeTextBox.Name = "RoomTypeTextBox";
            this.RoomTypeTextBox.Size = new System.Drawing.Size(267, 26);
            this.RoomTypeTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Type:";
            // 
            // RoomIDTextBox
            // 
            this.RoomIDTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.RoomIDTextBox.Location = new System.Drawing.Point(132, 144);
            this.RoomIDTextBox.Name = "RoomIDTextBox";
            this.RoomIDTextBox.Size = new System.Drawing.Size(267, 26);
            this.RoomIDTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room ID:";
            // 
            // RoomLogouButton
            // 
            this.RoomLogouButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomLogouButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RoomLogouButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomLogouButton.Location = new System.Drawing.Point(888, 3);
            this.RoomLogouButton.Name = "RoomLogouButton";
            this.RoomLogouButton.Size = new System.Drawing.Size(136, 63);
            this.RoomLogouButton.TabIndex = 5;
            this.RoomLogouButton.Text = "Logout";
            this.RoomLogouButton.UseVisualStyleBackColor = false;
            this.RoomLogouButton.Click += new System.EventHandler(this.RoomLogouButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RoomLogouButton);
            this.panel1.Controls.Add(this.Room_Back_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 551);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 71);
            this.panel1.TabIndex = 47;
            // 
            // Room_Back_Button
            // 
            this.Room_Back_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Room_Back_Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Room_Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_Back_Button.Location = new System.Drawing.Point(746, 3);
            this.Room_Back_Button.Name = "Room_Back_Button";
            this.Room_Back_Button.Size = new System.Drawing.Size(136, 63);
            this.Room_Back_Button.TabIndex = 0;
            this.Room_Back_Button.Text = "Back";
            this.Room_Back_Button.UseVisualStyleBackColor = false;
            this.Room_Back_Button.Click += new System.EventHandler(this.Room_Back_Button_Click);
            // 
            // Room_Manage_DataGridView
            // 
            this.Room_Manage_DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Room_Manage_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Room_Manage_DataGridView.Location = new System.Drawing.Point(450, 141);
            this.Room_Manage_DataGridView.Name = "Room_Manage_DataGridView";
            this.Room_Manage_DataGridView.Size = new System.Drawing.Size(562, 356);
            this.Room_Manage_DataGridView.TabIndex = 46;
            this.Room_Manage_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Room_Manage_DataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1030, 80);
            this.label1.TabIndex = 45;
            this.label1.Text = "Room Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doctor_Manage_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1029, 622);
            this.Controls.Add(this.Search_Room_Manage_TextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Room_Manage_GroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Room_Manage_DataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Doctor_Manage_Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor_Manage_Room";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Doctor_Manage_Room_FormClosing);
            this.Room_Manage_GroupBox.ResumeLayout(false);
            this.Room_Manage_GroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Room_Manage_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search_Room_Manage_TextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Room_Manage_GroupBox;
        private System.Windows.Forms.TextBox RoomCostTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RoomNOTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RoomPatientIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RoomTypeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoomIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RoomLogouButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Room_Back_Button;
        private System.Windows.Forms.DataGridView Room_Manage_DataGridView;
        private System.Windows.Forms.Label label1;
    }
}