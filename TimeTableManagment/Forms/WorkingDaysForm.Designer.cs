namespace TimeTableManagment.Forms
{
    partial class WorkingDaysForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.check_mon = new System.Windows.Forms.CheckBox();
            this.check_tue = new System.Windows.Forms.CheckBox();
            this.check_wed = new System.Windows.Forms.CheckBox();
            this.check_thurs = new System.Windows.Forms.CheckBox();
            this.check_fri = new System.Windows.Forms.CheckBox();
            this.check_sat = new System.Windows.Forms.CheckBox();
            this.check_sun = new System.Windows.Forms.CheckBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.numericUpDown1WorkingDays = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1WorkingHours = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1WorkingDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1WorkingHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of working days per week";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select the working days";
            // 
            // check_mon
            // 
            this.check_mon.AutoSize = true;
            this.check_mon.Location = new System.Drawing.Point(186, 136);
            this.check_mon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_mon.Name = "check_mon";
            this.check_mon.Size = new System.Drawing.Size(64, 17);
            this.check_mon.TabIndex = 3;
            this.check_mon.Text = "Monday";
            this.check_mon.UseVisualStyleBackColor = true;
            // 
            // check_tue
            // 
            this.check_tue.AutoSize = true;
            this.check_tue.Location = new System.Drawing.Point(254, 136);
            this.check_tue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_tue.Name = "check_tue";
            this.check_tue.Size = new System.Drawing.Size(67, 17);
            this.check_tue.TabIndex = 4;
            this.check_tue.Text = "Tuesday";
            this.check_tue.UseVisualStyleBackColor = true;
            // 
            // check_wed
            // 
            this.check_wed.AutoSize = true;
            this.check_wed.Location = new System.Drawing.Point(325, 136);
            this.check_wed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_wed.Name = "check_wed";
            this.check_wed.Size = new System.Drawing.Size(83, 17);
            this.check_wed.TabIndex = 5;
            this.check_wed.Text = "Wednesday";
            this.check_wed.UseVisualStyleBackColor = true;
            this.check_wed.CheckedChanged += new System.EventHandler(this.check_wed_CheckedChanged);
            // 
            // check_thurs
            // 
            this.check_thurs.AutoSize = true;
            this.check_thurs.Location = new System.Drawing.Point(412, 136);
            this.check_thurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_thurs.Name = "check_thurs";
            this.check_thurs.Size = new System.Drawing.Size(70, 17);
            this.check_thurs.TabIndex = 6;
            this.check_thurs.Text = "Thursday";
            this.check_thurs.UseVisualStyleBackColor = true;
            // 
            // check_fri
            // 
            this.check_fri.AutoSize = true;
            this.check_fri.Location = new System.Drawing.Point(486, 136);
            this.check_fri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_fri.Name = "check_fri";
            this.check_fri.Size = new System.Drawing.Size(54, 17);
            this.check_fri.TabIndex = 7;
            this.check_fri.Text = "Friday";
            this.check_fri.UseVisualStyleBackColor = true;
            // 
            // check_sat
            // 
            this.check_sat.AutoSize = true;
            this.check_sat.Location = new System.Drawing.Point(187, 161);
            this.check_sat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_sat.Name = "check_sat";
            this.check_sat.Size = new System.Drawing.Size(68, 17);
            this.check_sat.TabIndex = 8;
            this.check_sat.Text = "Saturday";
            this.check_sat.UseVisualStyleBackColor = true;
            // 
            // check_sun
            // 
            this.check_sun.AutoSize = true;
            this.check_sun.Location = new System.Drawing.Point(255, 161);
            this.check_sun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_sun.Name = "check_sun";
            this.check_sun.Size = new System.Drawing.Size(62, 17);
            this.check_sun.TabIndex = 9;
            this.check_sun.Text = "Sunday";
            this.check_sun.UseVisualStyleBackColor = true;
            this.check_sun.CheckedChanged += new System.EventHandler(this.check_sun_CheckedChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_add.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_add.Image = global::TimeTableManagment.Properties.Resources.icons8_add_new_64;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(529, 243);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(98, 33);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Submit";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.submit__Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(678, 186);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(142, 302);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 204);
            this.panel1.TabIndex = 12;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_edit.Image = global::TimeTableManagment.Properties.Resources.icons8_edit_property_64;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(501, 243);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(98, 33);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "Edit";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_delete.Image = global::TimeTableManagment.Properties.Resources.icons8_delete_64;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(620, 243);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 33);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1WorkingDays
            // 
            this.numericUpDown1WorkingDays.Location = new System.Drawing.Point(160, 73);
            this.numericUpDown1WorkingDays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1WorkingDays.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1WorkingDays.Name = "numericUpDown1WorkingDays";
            this.numericUpDown1WorkingDays.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1WorkingDays.TabIndex = 15;
            // 
            // numericUpDown1WorkingHours
            // 
            this.numericUpDown1WorkingHours.DecimalPlaces = 2;
            this.numericUpDown1WorkingHours.Location = new System.Drawing.Point(460, 73);
            this.numericUpDown1WorkingHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1WorkingHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1WorkingHours.Name = "numericUpDown1WorkingHours";
            this.numericUpDown1WorkingHours.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1WorkingHours.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Enter the number of working hours per day";
            // 
            // WorkingDaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(941, 531);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1WorkingHours);
            this.Controls.Add(this.numericUpDown1WorkingDays);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.check_sun);
            this.Controls.Add(this.check_sat);
            this.Controls.Add(this.check_fri);
            this.Controls.Add(this.check_thurs);
            this.Controls.Add(this.check_wed);
            this.Controls.Add(this.check_tue);
            this.Controls.Add(this.check_mon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WorkingDaysForm";
            this.Text = "Working Days";
            this.Load += new System.EventHandler(this.WorkingDaysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1WorkingDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1WorkingHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_mon;
        private System.Windows.Forms.CheckBox check_tue;
        private System.Windows.Forms.CheckBox check_wed;
        private System.Windows.Forms.CheckBox check_thurs;
        private System.Windows.Forms.CheckBox check_fri;
        private System.Windows.Forms.CheckBox check_sat;
        private System.Windows.Forms.CheckBox check_sun;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.NumericUpDown numericUpDown1WorkingDays;
        private System.Windows.Forms.NumericUpDown numericUpDown1WorkingHours;
        private System.Windows.Forms.Label label3;
    }
}