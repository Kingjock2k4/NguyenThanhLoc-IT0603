namespace Code_Login
{
    partial class FormProgramming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgramming));
            this.Lv_Student = new System.Windows.Forms.ListView();
            this.Dangxuat = new System.Windows.Forms.Button();
            this.txt_Thoat = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.rdtMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.rdtFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lv_Student
            // 
            this.Lv_Student.HideSelection = false;
            this.Lv_Student.Location = new System.Drawing.Point(240, -2);
            this.Lv_Student.Margin = new System.Windows.Forms.Padding(2);
            this.Lv_Student.Name = "Lv_Student";
            this.Lv_Student.Size = new System.Drawing.Size(562, 402);
            this.Lv_Student.TabIndex = 11;
            this.Lv_Student.UseCompatibleStateImageBehavior = false;
            this.Lv_Student.SelectedIndexChanged += new System.EventHandler(this.Lv_Student_SelectedIndexChanged);
            // 
            // Dangxuat
            // 
            this.Dangxuat.Location = new System.Drawing.Point(145, 408);
            this.Dangxuat.Name = "Dangxuat";
            this.Dangxuat.Size = new System.Drawing.Size(87, 31);
            this.Dangxuat.TabIndex = 17;
            this.Dangxuat.Text = "LOG OUT";
            this.Dangxuat.UseVisualStyleBackColor = true;
            this.Dangxuat.Click += new System.EventHandler(this.Dangxuat_Click);
            // 
            // txt_Thoat
            // 
            this.txt_Thoat.Location = new System.Drawing.Point(19, 408);
            this.txt_Thoat.Name = "txt_Thoat";
            this.txt_Thoat.Size = new System.Drawing.Size(87, 31);
            this.txt_Thoat.TabIndex = 17;
            this.txt_Thoat.Text = "EXIT";
            this.txt_Thoat.UseVisualStyleBackColor = true;
            this.txt_Thoat.Click += new System.EventHandler(this.txt_Thoat_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.HotPink;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(429, 10);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(106, 35);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Up
            // 
            this.Up.BackColor = System.Drawing.Color.Yellow;
            this.Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Up.Location = new System.Drawing.Point(230, 9);
            this.Up.Margin = new System.Windows.Forms.Padding(2);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(106, 35);
            this.Up.TabIndex = 7;
            this.Up.Text = "Update";
            this.Up.UseVisualStyleBackColor = false;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.Up);
            this.panel2.Location = new System.Drawing.Point(240, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 42);
            this.panel2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdtMale
            // 
            this.rdtMale.AutoSize = true;
            this.rdtMale.BackColor = System.Drawing.Color.Transparent;
            this.rdtMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtMale.Location = new System.Drawing.Point(88, 305);
            this.rdtMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdtMale.Name = "rdtMale";
            this.rdtMale.Size = new System.Drawing.Size(52, 17);
            this.rdtMale.TabIndex = 13;
            this.rdtMale.TabStop = true;
            this.rdtMale.Text = "Male";
            this.rdtMale.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Math Score";
            // 
            // txtMathScore
            // 
            this.txtMathScore.Location = new System.Drawing.Point(22, 226);
            this.txtMathScore.Margin = new System.Windows.Forms.Padding(2);
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(176, 20);
            this.txtMathScore.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "BirthDay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "StudentName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search By StudentName";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(18, 362);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(213, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(22, 281);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(176, 20);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(23, 176);
            this.txtStudentCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(175, 20);
            this.txtStudentCode.TabIndex = 1;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(22, 78);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(176, 20);
            this.txtStudentName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.Dangxuat);
            this.panel1.Controls.Add(this.txt_Thoat);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.dtpBirthDay);
            this.panel1.Controls.Add(this.rdtFemale);
            this.panel1.Controls.Add(this.rdtMale);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMathScore);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtStudentCode);
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 458);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(62, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 40);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(23, 127);
            this.dtpBirthDay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(175, 20);
            this.dtpBirthDay.TabIndex = 15;
            // 
            // rdtFemale
            // 
            this.rdtFemale.AutoSize = true;
            this.rdtFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdtFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtFemale.Location = new System.Drawing.Point(159, 304);
            this.rdtFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdtFemale.Name = "rdtFemale";
            this.rdtFemale.Size = new System.Drawing.Size(65, 17);
            this.rdtFemale.TabIndex = 14;
            this.rdtFemale.TabStop = true;
            this.rdtFemale.Text = "Female";
            this.rdtFemale.UseVisualStyleBackColor = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(24, 306);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 13);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student Code";
            // 
            // FormProgramming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lv_Student);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormProgramming";
            this.Text = "FormProgramming";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Lv_Student;
        private System.Windows.Forms.Button Dangxuat;
        private System.Windows.Forms.Button txt_Thoat;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rdtMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMathScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.RadioButton rdtFemale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}