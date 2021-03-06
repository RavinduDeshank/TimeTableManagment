namespace TimeTableManagment.Forms
{
    partial class RoomForm
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
            this.StudentYearComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conSeccheckBox = new System.Windows.Forms.CheckBox();
            this.subGroupcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fillRoomcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clearDetailsBtn = new System.Windows.Forms.Button();
            this.roomAllocatebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupIDcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.semcomboBox = new System.Windows.Forms.ComboBox();
            this.lblsessionDet = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lecSessionlabel = new System.Windows.Forms.Label();
            this.tuteSessionlabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentYearComboBox
            // 
            this.StudentYearComboBox.FormattingEnabled = true;
            this.StudentYearComboBox.Items.AddRange(new object[] {
            "Y1",
            "Y2",
            "Y3",
            "Y4"});
            this.StudentYearComboBox.Location = new System.Drawing.Point(83, 53);
            this.StudentYearComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.StudentYearComboBox.Name = "StudentYearComboBox";
            this.StudentYearComboBox.Size = new System.Drawing.Size(104, 21);
            this.StudentYearComboBox.TabIndex = 10;
            this.StudentYearComboBox.SelectedIndexChanged += new System.EventHandler(this.StudentYearComboBox_SelectedIndexChanged);
            this.StudentYearComboBox.Click += new System.EventHandler(this.StudentYearComboBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Year:";
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(220, 102);
            this.subjectComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(104, 21);
            this.subjectComboBox.TabIndex = 12;
            this.subjectComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectComboBox_SelectedIndexChanged);
            this.subjectComboBox.Click += new System.EventHandler(this.subjectComboBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select Subject:";
            // 
            // conSeccheckBox
            // 
            this.conSeccheckBox.AutoSize = true;
            this.conSeccheckBox.Location = new System.Drawing.Point(83, 152);
            this.conSeccheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.conSeccheckBox.Name = "conSeccheckBox";
            this.conSeccheckBox.Size = new System.Drawing.Size(130, 17);
            this.conSeccheckBox.TabIndex = 13;
            this.conSeccheckBox.Text = "Consecutive Sessions";
            this.conSeccheckBox.UseVisualStyleBackColor = true;
            this.conSeccheckBox.CheckedChanged += new System.EventHandler(this.conSeccheckBox_CheckedChanged);
            // 
            // subGroupcomboBox
            // 
            this.subGroupcomboBox.FormattingEnabled = true;
            this.subGroupcomboBox.Location = new System.Drawing.Point(83, 222);
            this.subGroupcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.subGroupcomboBox.Name = "subGroupcomboBox";
            this.subGroupcomboBox.Size = new System.Drawing.Size(104, 21);
            this.subGroupcomboBox.TabIndex = 15;
            this.subGroupcomboBox.Click += new System.EventHandler(this.sessionTagcomboBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select Sub Group:";
            // 
            // fillRoomcomboBox
            // 
            this.fillRoomcomboBox.FormattingEnabled = true;
            this.fillRoomcomboBox.Location = new System.Drawing.Point(262, 222);
            this.fillRoomcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.fillRoomcomboBox.Name = "fillRoomcomboBox";
            this.fillRoomcomboBox.Size = new System.Drawing.Size(104, 21);
            this.fillRoomcomboBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Select Room:";
            // 
            // clearDetailsBtn
            // 
            this.clearDetailsBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.clearDetailsBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.clearDetailsBtn.Image = global::TimeTableManagment.Properties.Resources.icons8_erase_48;
            this.clearDetailsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearDetailsBtn.Location = new System.Drawing.Point(661, 222);
            this.clearDetailsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearDetailsBtn.Name = "clearDetailsBtn";
            this.clearDetailsBtn.Size = new System.Drawing.Size(98, 33);
            this.clearDetailsBtn.TabIndex = 22;
            this.clearDetailsBtn.Text = "Clear";
            this.clearDetailsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearDetailsBtn.UseVisualStyleBackColor = false;
            this.clearDetailsBtn.Click += new System.EventHandler(this.clearDetailsBtn_Click);
            // 
            // roomAllocatebtn
            // 
            this.roomAllocatebtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.roomAllocatebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.roomAllocatebtn.Image = global::TimeTableManagment.Properties.Resources.icons8_add_new_64;
            this.roomAllocatebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomAllocatebtn.Location = new System.Drawing.Point(531, 222);
            this.roomAllocatebtn.Margin = new System.Windows.Forms.Padding(2);
            this.roomAllocatebtn.Name = "roomAllocatebtn";
            this.roomAllocatebtn.Size = new System.Drawing.Size(107, 33);
            this.roomAllocatebtn.TabIndex = 19;
            this.roomAllocatebtn.Text = "Allocate";
            this.roomAllocatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roomAllocatebtn.UseVisualStyleBackColor = false;
            this.roomAllocatebtn.Click += new System.EventHandler(this.roomAllocatebtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(83, 303);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 217);
            this.panel2.TabIndex = 23;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 16);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(652, 188);
            this.dataGridView2.TabIndex = 11;
            // 
            // groupIDcomboBox
            // 
            this.groupIDcomboBox.FormattingEnabled = true;
            this.groupIDcomboBox.Location = new System.Drawing.Point(220, 52);
            this.groupIDcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupIDcomboBox.Name = "groupIDcomboBox";
            this.groupIDcomboBox.Size = new System.Drawing.Size(104, 21);
            this.groupIDcomboBox.TabIndex = 25;
            this.groupIDcomboBox.Click += new System.EventHandler(this.groupIDcomboBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Select Group ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Select Semester:";
            // 
            // semcomboBox
            // 
            this.semcomboBox.FormattingEnabled = true;
            this.semcomboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.semcomboBox.Location = new System.Drawing.Point(84, 102);
            this.semcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.semcomboBox.Name = "semcomboBox";
            this.semcomboBox.Size = new System.Drawing.Size(104, 21);
            this.semcomboBox.TabIndex = 27;
            this.semcomboBox.SelectedIndexChanged += new System.EventHandler(this.semcomboBox_SelectedIndexChanged);
            // 
            // lblsessionDet
            // 
            this.lblsessionDet.AutoSize = true;
            this.lblsessionDet.Location = new System.Drawing.Point(454, 33);
            this.lblsessionDet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsessionDet.Name = "lblsessionDet";
            this.lblsessionDet.Size = new System.Drawing.Size(141, 13);
            this.lblsessionDet.TabIndex = 28;
            this.lblsessionDet.Text = "Consecutive Session Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Lecture";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(616, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tutorial";
            // 
            // lecSessionlabel
            // 
            this.lecSessionlabel.AutoSize = true;
            this.lecSessionlabel.Location = new System.Drawing.Point(482, 90);
            this.lecSessionlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lecSessionlabel.Name = "lecSessionlabel";
            this.lecSessionlabel.Size = new System.Drawing.Size(0, 13);
            this.lecSessionlabel.TabIndex = 31;
            // 
            // tuteSessionlabel
            // 
            this.tuteSessionlabel.AutoSize = true;
            this.tuteSessionlabel.Location = new System.Drawing.Point(644, 90);
            this.tuteSessionlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tuteSessionlabel.Name = "tuteSessionlabel";
            this.tuteSessionlabel.Size = new System.Drawing.Size(0, 13);
            this.tuteSessionlabel.TabIndex = 32;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(941, 531);
            this.Controls.Add(this.tuteSessionlabel);
            this.Controls.Add(this.lecSessionlabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblsessionDet);
            this.Controls.Add(this.semcomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupIDcomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.clearDetailsBtn);
            this.Controls.Add(this.roomAllocatebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fillRoomcomboBox);
            this.Controls.Add(this.subGroupcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.conSeccheckBox);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentYearComboBox);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomForm";
            this.Text = "Assign Rooms For A Session";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StudentYearComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox conSeccheckBox;
        private System.Windows.Forms.ComboBox subGroupcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fillRoomcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearDetailsBtn;
        private System.Windows.Forms.Button roomAllocatebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox groupIDcomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox semcomboBox;
        private System.Windows.Forms.Label lblsessionDet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lecSessionlabel;
        private System.Windows.Forms.Label tuteSessionlabel;
    }
}