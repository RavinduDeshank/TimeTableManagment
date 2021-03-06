namespace TimeTableManagment.Forms
{
    partial class SubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectForm));
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numTuteHr = new System.Windows.Forms.NumericUpDown();
            this.numLecHr = new System.Windows.Forms.NumericUpDown();
            this.numLabHr = new System.Windows.Forms.NumericUpDown();
            this.numEvoHr = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSem = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblSub = new System.Windows.Forms.DataGridView();
            this.labelSub = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSubCode = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtDept = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtView = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTuteHr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLecHr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLabHr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEvoHr)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subject Name:";
            // 
            // txtSubName
            // 
            this.txtSubName.Location = new System.Drawing.Point(182, 65);
            this.txtSubName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(172, 20);
            this.txtSubName.TabIndex = 1;
            this.txtSubName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSubName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Offered Year:";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbYear.Location = new System.Drawing.Point(182, 115);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(118, 21);
            this.cmbYear.TabIndex = 3;
            this.cmbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbYear_KeyPress);
            this.cmbYear.Validating += new System.ComponentModel.CancelEventHandler(this.cmbYear_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of Lecture hours: (Hr)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of Lab hours:(Hr)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Subject Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Offered Semester:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Number of Tutorial hours:(Hr)";
            // 
            // numTuteHr
            // 
            this.numTuteHr.Location = new System.Drawing.Point(452, 162);
            this.numTuteHr.Margin = new System.Windows.Forms.Padding(2);
            this.numTuteHr.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTuteHr.Name = "numTuteHr";
            this.numTuteHr.Size = new System.Drawing.Size(45, 20);
            this.numTuteHr.TabIndex = 6;
            this.numTuteHr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTuteHr_KeyPress);
            // 
            // numLecHr
            // 
            this.numLecHr.Location = new System.Drawing.Point(182, 162);
            this.numLecHr.Margin = new System.Windows.Forms.Padding(2);
            this.numLecHr.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numLecHr.Name = "numLecHr";
            this.numLecHr.Size = new System.Drawing.Size(45, 20);
            this.numLecHr.TabIndex = 5;
            this.numLecHr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numLecHr_KeyPress);
            // 
            // numLabHr
            // 
            this.numLabHr.Location = new System.Drawing.Point(182, 209);
            this.numLabHr.Margin = new System.Windows.Forms.Padding(2);
            this.numLabHr.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numLabHr.Name = "numLabHr";
            this.numLabHr.Size = new System.Drawing.Size(45, 20);
            this.numLabHr.TabIndex = 7;
            this.numLabHr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numLabHr_KeyPress);
            // 
            // numEvoHr
            // 
            this.numEvoHr.Location = new System.Drawing.Point(452, 209);
            this.numEvoHr.Margin = new System.Windows.Forms.Padding(2);
            this.numEvoHr.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numEvoHr.Name = "numEvoHr";
            this.numEvoHr.Size = new System.Drawing.Size(45, 20);
            this.numEvoHr.TabIndex = 8;
            this.numEvoHr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numEvoHr_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 193);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Number of Evoluation hours:(Hr)";
            // 
            // cmbSem
            // 
            this.cmbSem.FormattingEnabled = true;
            this.cmbSem.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbSem.Location = new System.Drawing.Point(452, 115);
            this.cmbSem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSem.Name = "cmbSem";
            this.cmbSem.Size = new System.Drawing.Size(145, 21);
            this.cmbSem.TabIndex = 4;
            this.cmbSem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSem_KeyPress);
            this.cmbSem.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSem_Validating);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tblSub);
            this.panel1.Location = new System.Drawing.Point(140, 247);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 282);
            this.panel1.TabIndex = 25;
            // 
            // tblSub
            // 
            this.tblSub.AllowUserToAddRows = false;
            this.tblSub.AllowUserToDeleteRows = false;
            this.tblSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSub.Location = new System.Drawing.Point(44, 54);
            this.tblSub.Margin = new System.Windows.Forms.Padding(2);
            this.tblSub.Name = "tblSub";
            this.tblSub.ReadOnly = true;
            this.tblSub.RowHeadersWidth = 51;
            this.tblSub.RowTemplate.Height = 24;
            this.tblSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblSub.Size = new System.Drawing.Size(635, 180);
            this.tblSub.TabIndex = 0;
            this.tblSub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSub_CellClick);
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub.Location = new System.Drawing.Point(390, 8);
            this.labelSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(141, 26);
            this.labelSub.TabIndex = 0;
            this.labelSub.Text = "Add Subject";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtSubCode
            // 
            this.txtSubCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSubCode.Location = new System.Drawing.Point(486, 64);
            this.txtSubCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubCode.MaxLength = 4;
            this.txtSubCode.Name = "txtSubCode";
            this.txtSubCode.Size = new System.Drawing.Size(74, 20);
            this.txtSubCode.TabIndex = 28;
            this.txtSubCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubCode_KeyPress);
            this.txtSubCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtSubCode_Validating);
            // 
            // txtDept
            // 
            this.txtDept.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDept.Location = new System.Drawing.Point(452, 64);
            this.txtDept.Margin = new System.Windows.Forms.Padding(2);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(31, 20);
            this.txtDept.TabIndex = 2;
            this.txtDept.Text = "IT/SE";
            this.toolTip1.SetToolTip(this.txtDept, "Enter Department Eg:- IT/IE/SE");
            this.txtDept.Enter += new System.EventHandler(this.txtDept_Enter);
            this.txtDept.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDept_KeyPress);
            this.txtDept.Leave += new System.EventHandler(this.txtDept_Leave);
            this.txtDept.Validating += new System.ComponentModel.CancelEventHandler(this.txtDept_Validating);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(726, 200);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete the SSubject Details");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(726, 201);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 33);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnClear, "To Clear all fields");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(624, 200);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 33);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit the Details");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(624, 200);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 33);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSubmit, "Submit the Subject Details");
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtView
            // 
            this.txtView.BackColor = System.Drawing.Color.LightGray;
            this.txtView.Location = new System.Drawing.Point(452, 64);
            this.txtView.Margin = new System.Windows.Forms.Padding(2);
            this.txtView.Name = "txtView";
            this.txtView.ReadOnly = true;
            this.txtView.Size = new System.Drawing.Size(109, 20);
            this.txtView.TabIndex = 29;
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(941, 531);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtSubCode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbSem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numEvoHr);
            this.Controls.Add(this.numLabHr);
            this.Controls.Add(this.numLecHr);
            this.Controls.Add(this.numTuteHr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSub);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SubjectForm";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTuteHr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLecHr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLabHr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEvoHr)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numTuteHr;
        private System.Windows.Forms.NumericUpDown numLecHr;
        private System.Windows.Forms.NumericUpDown numLabHr;
        private System.Windows.Forms.NumericUpDown numEvoHr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tblSub;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtSubCode;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtView;
    }
}