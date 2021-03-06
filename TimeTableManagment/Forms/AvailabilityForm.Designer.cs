namespace TimeTableManagment.Forms
{
    partial class AvailabilityForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailabilityForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sessionDetailslabel = new System.Windows.Forms.Label();
            this.endTimecomboBox = new System.Windows.Forms.ComboBox();
            this.startTimecomboBox = new System.Windows.Forms.ComboBox();
            this.labelLec = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.loadSessioncomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.daycomboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.combo_endTime = new System.Windows.Forms.ComboBox();
            this.combo_startTime = new System.Windows.Forms.ComboBox();
            this.clearDetailsBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roomAvailabilityTable = new System.Windows.Forms.DataGridView();
            this.detailDeleteBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.detailsEditBtn = new System.Windows.Forms.Button();
            this.roomSelectComboBox = new System.Windows.Forms.ComboBox();
            this.detailsAddBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomAvailabilityTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(941, 531);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.BurlyWood;
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.sessionDetailslabel);
            this.metroTabPage1.Controls.Add(this.endTimecomboBox);
            this.metroTabPage1.Controls.Add(this.startTimecomboBox);
            this.metroTabPage1.Controls.Add(this.labelLec);
            this.metroTabPage1.Controls.Add(this.label15);
            this.metroTabPage1.Controls.Add(this.button1);
            this.metroTabPage1.Controls.Add(this.label7);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.comboBox3);
            this.metroTabPage1.Controls.Add(this.loadSessioncomboBox);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.button2);
            this.metroTabPage1.Controls.Add(this.button4);
            this.metroTabPage1.Controls.Add(this.button3);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 8;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(933, 489);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Availability";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(33, 240);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 180);
            this.panel1.TabIndex = 59;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(585, 148);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Session Details";
            // 
            // sessionDetailslabel
            // 
            this.sessionDetailslabel.AutoSize = true;
            this.sessionDetailslabel.Location = new System.Drawing.Point(663, 80);
            this.sessionDetailslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sessionDetailslabel.MaximumSize = new System.Drawing.Size(375, 81);
            this.sessionDetailslabel.MinimumSize = new System.Drawing.Size(75, 81);
            this.sessionDetailslabel.Name = "sessionDetailslabel";
            this.sessionDetailslabel.Size = new System.Drawing.Size(75, 81);
            this.sessionDetailslabel.TabIndex = 57;
            // 
            // endTimecomboBox
            // 
            this.endTimecomboBox.FormattingEnabled = true;
            this.endTimecomboBox.Items.AddRange(new object[] {
            "9.00",
            "9.30",
            "10.00",
            "10.30",
            "11.00",
            "11.30",
            "12.00",
            "12.30",
            "13.00",
            "13.30",
            "14.00",
            "14.30",
            "15.00",
            "15.30",
            "16.00",
            "16.30",
            "17.00",
            "17.30",
            "18.00",
            "18.30",
            "19.00"});
            this.endTimecomboBox.Location = new System.Drawing.Point(436, 81);
            this.endTimecomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endTimecomboBox.Name = "endTimecomboBox";
            this.endTimecomboBox.Size = new System.Drawing.Size(92, 21);
            this.endTimecomboBox.TabIndex = 56;
            // 
            // startTimecomboBox
            // 
            this.startTimecomboBox.FormattingEnabled = true;
            this.startTimecomboBox.Items.AddRange(new object[] {
            "8.00",
            "8.30",
            "9.00",
            "9.30",
            "10.00",
            "10.30",
            "11.00",
            "11.30",
            "12.00",
            "12.30",
            "13.00",
            "13.30",
            "14.00",
            "14.30",
            "15.00",
            "15.30",
            "16.00",
            "16.30",
            "17.00",
            "17.30",
            "18.00",
            "18.30",
            "19.00"});
            this.startTimecomboBox.Location = new System.Drawing.Point(311, 80);
            this.startTimecomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startTimecomboBox.Name = "startTimecomboBox";
            this.startTimecomboBox.Size = new System.Drawing.Size(92, 21);
            this.startTimecomboBox.TabIndex = 55;
            this.startTimecomboBox.SelectedIndexChanged += new System.EventHandler(this.startTimecomboBox_SelectedIndexChanged);
            // 
            // labelLec
            // 
            this.labelLec.AutoSize = true;
            this.labelLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLec.Location = new System.Drawing.Point(318, 7);
            this.labelLec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLec.Name = "labelLec";
            this.labelLec.Size = new System.Drawing.Size(245, 26);
            this.labelLec.TabIndex = 54;
            this.labelLec.Text = "Add Unavailable Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(282, 7);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(308, 26);
            this.label15.TabIndex = 53;
            this.label15.Text = "Edit/Delete Unvailable Time";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(305, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 52;
            this.button1.Text = "Submit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "End Time";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Start Time";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBox3.Location = new System.Drawing.Point(32, 148);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(225, 21);
            this.comboBox3.TabIndex = 47;
            this.comboBox3.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox3_Validating);
            // 
            // loadSessioncomboBox
            // 
            this.loadSessioncomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loadSessioncomboBox.FormattingEnabled = true;
            this.loadSessioncomboBox.Location = new System.Drawing.Point(32, 81);
            this.loadSessioncomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadSessioncomboBox.Name = "loadSessioncomboBox";
            this.loadSessioncomboBox.Size = new System.Drawing.Size(225, 21);
            this.loadSessioncomboBox.TabIndex = 46;
            this.loadSessioncomboBox.SelectedIndexChanged += new System.EventHandler(this.loadSessioncomboBox_SelectedIndexChanged);
            this.loadSessioncomboBox.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox2_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, -27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 26);
            this.label2.TabIndex = 44;
            this.label2.Text = "Edit/Delete Student";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(417, 155);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 33);
            this.button2.TabIndex = 43;
            this.button2.Text = " Reset";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(530, 155);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 33);
            this.button4.TabIndex = 42;
            this.button4.Text = "Delete";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(305, 154);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 33);
            this.button3.TabIndex = 41;
            this.button3.Text = "Edit";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Select Session";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.BurlyWood;
            this.metroTabPage2.Controls.Add(this.label13);
            this.metroTabPage2.Controls.Add(this.daycomboBox);
            this.metroTabPage2.Controls.Add(this.label12);
            this.metroTabPage2.Controls.Add(this.label11);
            this.metroTabPage2.Controls.Add(this.combo_endTime);
            this.metroTabPage2.Controls.Add(this.combo_startTime);
            this.metroTabPage2.Controls.Add(this.clearDetailsBtn);
            this.metroTabPage2.Controls.Add(this.panel2);
            this.metroTabPage2.Controls.Add(this.detailDeleteBtn);
            this.metroTabPage2.Controls.Add(this.label10);
            this.metroTabPage2.Controls.Add(this.detailsEditBtn);
            this.metroTabPage2.Controls.Add(this.roomSelectComboBox);
            this.metroTabPage2.Controls.Add(this.detailsAddBtn);
            this.metroTabPage2.Controls.Add(this.label9);
            this.metroTabPage2.Controls.Add(this.label8);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 8;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(933, 489);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Room Availability";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(495, 81);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = " Select Day:";
            // 
            // daycomboBox
            // 
            this.daycomboBox.FormattingEnabled = true;
            this.daycomboBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.daycomboBox.Location = new System.Drawing.Point(566, 81);
            this.daycomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.daycomboBox.Name = "daycomboBox";
            this.daycomboBox.Size = new System.Drawing.Size(92, 21);
            this.daycomboBox.TabIndex = 25;
            this.daycomboBox.SelectedIndexChanged += new System.EventHandler(this.daycomboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 84);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = " End Time :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(126, 84);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "StartTime :";
            // 
            // combo_endTime
            // 
            this.combo_endTime.FormattingEnabled = true;
            this.combo_endTime.Items.AddRange(new object[] {
            "9.00",
            "9.30",
            "10.00",
            "10.30",
            "11.00",
            "11.30",
            "12.00",
            "12.30",
            "13.00",
            "13.30",
            "14.00",
            "14.30",
            "15.00",
            "15.30",
            "16.00",
            "16.30",
            "17.00",
            "17.30",
            "18.00",
            "18.30",
            "19.00"});
            this.combo_endTime.Location = new System.Drawing.Point(369, 81);
            this.combo_endTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo_endTime.Name = "combo_endTime";
            this.combo_endTime.Size = new System.Drawing.Size(92, 21);
            this.combo_endTime.TabIndex = 22;
            // 
            // combo_startTime
            // 
            this.combo_startTime.FormattingEnabled = true;
            this.combo_startTime.Items.AddRange(new object[] {
            "8.00",
            "8.30",
            "9.00",
            "9.30",
            "10.00",
            "10.30",
            "11.00",
            "11.30",
            "12.00",
            "12.30",
            "13.00",
            "13.30",
            "14.00",
            "14.30",
            "15.00",
            "15.30",
            "16.00",
            "16.30",
            "17.00",
            "17.30",
            "18.00",
            "18.30",
            "19.00"});
            this.combo_startTime.Location = new System.Drawing.Point(188, 81);
            this.combo_startTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo_startTime.Name = "combo_startTime";
            this.combo_startTime.Size = new System.Drawing.Size(92, 21);
            this.combo_startTime.TabIndex = 21;
            // 
            // clearDetailsBtn
            // 
            this.clearDetailsBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.clearDetailsBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.clearDetailsBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearDetailsBtn.Image")));
            this.clearDetailsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearDetailsBtn.Location = new System.Drawing.Point(658, 173);
            this.clearDetailsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearDetailsBtn.Name = "clearDetailsBtn";
            this.clearDetailsBtn.Size = new System.Drawing.Size(98, 33);
            this.clearDetailsBtn.TabIndex = 20;
            this.clearDetailsBtn.Text = "Clear";
            this.clearDetailsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearDetailsBtn.UseVisualStyleBackColor = false;
            this.clearDetailsBtn.Click += new System.EventHandler(this.clearDetailsBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.roomAvailabilityTable);
            this.panel2.Location = new System.Drawing.Point(50, 238);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 206);
            this.panel2.TabIndex = 19;
            // 
            // roomAvailabilityTable
            // 
            this.roomAvailabilityTable.AllowUserToAddRows = false;
            this.roomAvailabilityTable.AllowUserToDeleteRows = false;
            this.roomAvailabilityTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomAvailabilityTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roomAvailabilityTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomAvailabilityTable.Location = new System.Drawing.Point(23, 16);
            this.roomAvailabilityTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roomAvailabilityTable.Name = "roomAvailabilityTable";
            this.roomAvailabilityTable.ReadOnly = true;
            this.roomAvailabilityTable.RowHeadersWidth = 51;
            this.roomAvailabilityTable.RowTemplate.Height = 24;
            this.roomAvailabilityTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomAvailabilityTable.Size = new System.Drawing.Size(585, 176);
            this.roomAvailabilityTable.TabIndex = 11;
            this.roomAvailabilityTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomAvailabilityTable_CellClick);
            // 
            // detailDeleteBtn
            // 
            this.detailDeleteBtn.BackColor = System.Drawing.Color.IndianRed;
            this.detailDeleteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.detailDeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("detailDeleteBtn.Image")));
            this.detailDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detailDeleteBtn.Location = new System.Drawing.Point(560, 173);
            this.detailDeleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailDeleteBtn.Name = "detailDeleteBtn";
            this.detailDeleteBtn.Size = new System.Drawing.Size(98, 33);
            this.detailDeleteBtn.TabIndex = 19;
            this.detailDeleteBtn.Text = "Delete";
            this.detailDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.detailDeleteBtn.UseVisualStyleBackColor = false;
            this.detailDeleteBtn.Click += new System.EventHandler(this.detailDeleteBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 131);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = " Select Room :";
            // 
            // detailsEditBtn
            // 
            this.detailsEditBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.detailsEditBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.detailsEditBtn.Image = ((System.Drawing.Image)(resources.GetObject("detailsEditBtn.Image")));
            this.detailsEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detailsEditBtn.Location = new System.Drawing.Point(462, 173);
            this.detailsEditBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailsEditBtn.Name = "detailsEditBtn";
            this.detailsEditBtn.Size = new System.Drawing.Size(98, 33);
            this.detailsEditBtn.TabIndex = 18;
            this.detailsEditBtn.Text = "Edit";
            this.detailsEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.detailsEditBtn.UseVisualStyleBackColor = false;
            this.detailsEditBtn.Click += new System.EventHandler(this.detailsEditBtn_Click);
            // 
            // roomSelectComboBox
            // 
            this.roomSelectComboBox.FormattingEnabled = true;
            this.roomSelectComboBox.Location = new System.Drawing.Point(129, 146);
            this.roomSelectComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roomSelectComboBox.Name = "roomSelectComboBox";
            this.roomSelectComboBox.Size = new System.Drawing.Size(195, 21);
            this.roomSelectComboBox.TabIndex = 5;
            // 
            // detailsAddBtn
            // 
            this.detailsAddBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.detailsAddBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.detailsAddBtn.Image = ((System.Drawing.Image)(resources.GetObject("detailsAddBtn.Image")));
            this.detailsAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detailsAddBtn.Location = new System.Drawing.Point(363, 173);
            this.detailsAddBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailsAddBtn.Name = "detailsAddBtn";
            this.detailsAddBtn.Size = new System.Drawing.Size(98, 33);
            this.detailsAddBtn.TabIndex = 17;
            this.detailsAddBtn.Text = "Add";
            this.detailsAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.detailsAddBtn.UseVisualStyleBackColor = false;
            this.detailsAddBtn.Click += new System.EventHandler(this.detailsAddBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = " Select Time :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(312, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Select the Unavailable Time For a Room";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 531);
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AvailabilityForm";
            this.Text = "Availability";
            this.Load += new System.EventHandler(this.AvailabilityForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomAvailabilityTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox loadSessioncomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelLec;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox roomSelectComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView roomAvailabilityTable;
        private System.Windows.Forms.Button clearDetailsBtn;
        private System.Windows.Forms.Button detailDeleteBtn;
        private System.Windows.Forms.Button detailsEditBtn;
        private System.Windows.Forms.Button detailsAddBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combo_endTime;
        private System.Windows.Forms.ComboBox combo_startTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox startTimecomboBox;
        private System.Windows.Forms.ComboBox endTimecomboBox;
        private System.Windows.Forms.Label sessionDetailslabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox daycomboBox;
    }
}