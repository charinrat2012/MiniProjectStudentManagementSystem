namespace Student
{
    partial class FrmManageStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageStudent));
            groupBox3 = new GroupBox();
            button3 = new Button();
            btdelete = new Button();
            groupBox2 = new GroupBox();
            label9 = new Label();
            tbLastName = new TextBox();
            cbstatus = new ComboBox();
            btedit = new Button();
            btsave = new Button();
            label6 = new Label();
            label7 = new Label();
            tbYear = new TextBox();
            label4 = new Label();
            tbmajor = new TextBox();
            label5 = new Label();
            tbFaculty = new TextBox();
            label2 = new Label();
            tbFirstName = new TextBox();
            label1 = new Label();
            tbStudentID = new TextBox();
            groupBox1 = new GroupBox();
            dgvStudents = new DataGridView();
            btsearch = new Button();
            tbsearch1 = new TextBox();
            radioId = new RadioButton();
            radioName = new RadioButton();
            btback = new Button();
            label3 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(btdelete);
            groupBox3.Location = new Point(1191, 528);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(441, 128);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(246, 43);
            button3.Name = "button3";
            button3.Size = new Size(136, 43);
            button3.TabIndex = 16;
            button3.Text = "ออกจากระบบ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btdelete
            // 
            btdelete.Location = new Point(29, 43);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(136, 43);
            btdelete.TabIndex = 15;
            btdelete.Text = "ลบข้อมูล";
            btdelete.UseVisualStyleBackColor = true;
            btdelete.Click += btdelete_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(tbLastName);
            groupBox2.Controls.Add(cbstatus);
            groupBox2.Controls.Add(btedit);
            groupBox2.Controls.Add(btsave);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbYear);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbmajor);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tbFaculty);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tbFirstName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tbStudentID);
            groupBox2.Location = new Point(1191, 120);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(441, 395);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "เพื่มข้อมูล";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 133);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 17;
            label9.Text = "นามสกุล :";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(134, 131);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(259, 27);
            tbLastName.TabIndex = 16;
            // 
            // cbstatus
            // 
            cbstatus.FormattingEnabled = true;
            cbstatus.Items.AddRange(new object[] { "ปกติ", "รอพิจารณา", "ลาออก", "จบการศึกษา" });
            cbstatus.Location = new Point(134, 267);
            cbstatus.Name = "cbstatus";
            cbstatus.Size = new Size(259, 28);
            cbstatus.TabIndex = 15;
            // 
            // btedit
            // 
            btedit.Location = new Point(246, 323);
            btedit.Name = "btedit";
            btedit.Size = new Size(136, 43);
            btedit.TabIndex = 14;
            btedit.Text = "แก้ไข";
            btedit.UseVisualStyleBackColor = true;
            btedit.Click += btedit_Click;
            // 
            // btsave
            // 
            btsave.Location = new Point(29, 323);
            btsave.Name = "btsave";
            btsave.Size = new Size(136, 43);
            btsave.TabIndex = 10;
            btsave.Text = "บันทึก";
            btsave.UseVisualStyleBackColor = true;
            btsave.Click += btsave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 267);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 13;
            label6.Text = "สถานะ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 233);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 11;
            label7.Text = "ชั้นปี :";
            // 
            // tbYear
            // 
            tbYear.Location = new Point(134, 229);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(259, 27);
            tbYear.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 200);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 9;
            label4.Text = "สาขา :";
            // 
            // tbmajor
            // 
            tbmajor.Location = new Point(134, 196);
            tbmajor.Name = "tbmajor";
            tbmajor.Size = new Size(259, 27);
            tbmajor.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 167);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 7;
            label5.Text = "คณะ :";
            // 
            // tbFaculty
            // 
            tbFaculty.Location = new Point(134, 163);
            tbFaculty.Name = "tbFaculty";
            tbFaculty.Size = new Size(259, 27);
            tbFaculty.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 101);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 3;
            label2.Text = "ชื่อ :";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(134, 97);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(259, 27);
            tbFirstName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 68);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "รหัสนักศึกษา :";
            // 
            // tbStudentID
            // 
            tbStudentID.Location = new Point(134, 64);
            tbStudentID.Name = "tbStudentID";
            tbStudentID.Size = new Size(259, 27);
            tbStudentID.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvStudents);
            groupBox1.Controls.Add(btsearch);
            groupBox1.Controls.Add(tbsearch1);
            groupBox1.Controls.Add(radioId);
            groupBox1.Controls.Add(radioName);
            groupBox1.Location = new Point(41, 120);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1132, 536);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลนักศึกษา";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgvStudents
            // 
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column7, Column3, Column4, Column5, Column6 });
            dgvStudents.Location = new Point(23, 140);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(1078, 371);
            dgvStudents.TabIndex = 16;
            // 
            // btsearch
            // 
            btsearch.Location = new Point(495, 75);
            btsearch.Name = "btsearch";
            btsearch.Size = new Size(93, 29);
            btsearch.TabIndex = 15;
            btsearch.Text = "ค้นหา";
            btsearch.UseVisualStyleBackColor = true;
            btsearch.Click += btsearch_Click;
            // 
            // tbsearch1
            // 
            tbsearch1.Location = new Point(37, 77);
            tbsearch1.Margin = new Padding(3, 4, 3, 4);
            tbsearch1.Name = "tbsearch1";
            tbsearch1.Size = new Size(436, 27);
            tbsearch1.TabIndex = 7;
            // 
            // radioId
            // 
            radioId.AutoSize = true;
            radioId.Location = new Point(151, 29);
            radioId.Margin = new Padding(3, 4, 3, 4);
            radioId.Name = "radioId";
            radioId.Size = new Size(163, 24);
            radioId.TabIndex = 2;
            radioId.TabStop = true;
            radioId.Text = "ค้นหาด้วยรหัสนักศึกษา";
            radioId.UseVisualStyleBackColor = true;
            // 
            // radioName
            // 
            radioName.AutoSize = true;
            radioName.Location = new Point(37, 29);
            radioName.Margin = new Padding(3, 4, 3, 4);
            radioName.Name = "radioName";
            radioName.Size = new Size(105, 24);
            radioName.TabIndex = 1;
            radioName.TabStop = true;
            radioName.Text = "ค้นหาด้วยชื่อ";
            radioName.UseVisualStyleBackColor = true;
            // 
            // btback
            // 
            btback.Location = new Point(1444, 29);
            btback.Name = "btback";
            btback.Size = new Size(131, 41);
            btback.TabIndex = 55;
            btback.Text = "ย้อนกลับ";
            btback.UseVisualStyleBackColor = true;
            btback.Click += btback_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TH SarabunPSK", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(513, 29);
            label3.Name = "label3";
            label3.Size = new Size(363, 62);
            label3.TabIndex = 57;
            label3.Text = "เพื่มและลบข้อมูลนักศึกษา";
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "รหัสนักศึกษา";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "ชื่อ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "นามสกุล";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "คณะ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "สาขา";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "ชั้นปี";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "สถานะ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // FrmManageStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1678, 695);
            Controls.Add(label3);
            Controls.Add(btback);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmManageStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageStudent - SystemStudents";
            Load += FrmManageStudent_Load;
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private Button button3;
        private Button btdelete;
        private GroupBox groupBox2;
        private Button btedit;
        private Button btsave;
        private Label label6;
        private Label label7;
        private TextBox tbYear;
        private Label label4;
        private TextBox tbmajor;
        private Label label5;
        private TextBox tbFaculty;
        private Label label3;
        private TextBox textBox4;
        private Label label2;
        private TextBox tbFirstName;
        private Label label1;
        private TextBox tbStudentID;
        private GroupBox groupBox1;
        private TextBox tbsearch1;
        private RadioButton radioId;
        private RadioButton radioName;
        private Button btback;
        private Button btsearch;
        private ComboBox cbstatus;
        private DataGridView dgvStudents;
        private Label label9;
        private TextBox tbLastName;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}