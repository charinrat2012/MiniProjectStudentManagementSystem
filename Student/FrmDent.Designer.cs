namespace Student
{
    partial class FrmDent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDent));
            lbMajor = new Label();
            lblFaculty = new Label();
            lblYear = new Label();
            btsearch = new Button();
            tbnSearchStudent = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            btDelete = new Button();
            btClear = new Button();
            dataGridView3 = new DataGridView();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btSeve = new Button();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            btOK = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            btback = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lbMajor
            // 
            lbMajor.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMajor.Location = new Point(492, 101);
            lbMajor.Name = "lbMajor";
            lbMajor.Size = new Size(266, 39);
            lbMajor.TabIndex = 39;
            lbMajor.Text = " : XXXXXXXX";
            lbMajor.Click += lbMajor_Click;
            // 
            // lblFaculty
            // 
            lblFaculty.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFaculty.Location = new Point(291, 101);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(205, 39);
            lblFaculty.TabIndex = 38;
            lblFaculty.Text = " : XXXXXXXX";
            lblFaculty.Click += lblFaculty_Click;
            // 
            // lblYear
            // 
            lblYear.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYear.Location = new Point(702, 101);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(90, 39);
            lblYear.TabIndex = 37;
            lblYear.Text = " :  X";
            // 
            // btsearch
            // 
            btsearch.Location = new Point(336, 52);
            btsearch.Name = "btsearch";
            btsearch.Size = new Size(114, 29);
            btsearch.TabIndex = 36;
            btsearch.Text = "ค้นหา";
            btsearch.UseVisualStyleBackColor = true;
            btsearch.Click += btsearch_Click_1;
            // 
            // tbnSearchStudent
            // 
            tbnSearchStudent.Location = new Point(125, 52);
            tbnSearchStudent.Margin = new Padding(3, 4, 3, 4);
            tbnSearchStudent.Name = "tbnSearchStudent";
            tbnSearchStudent.Size = new Size(205, 27);
            tbnSearchStudent.TabIndex = 35;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(149, 101);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(136, 39);
            lblLastName.TabIndex = 34;
            lblLastName.Text = " : XXXXXXXX";
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(8, 101);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(135, 39);
            lblFirstName.TabIndex = 33;
            lblFirstName.Text = " : XXXXXXXX";
            // 
            // btDelete
            // 
            btDelete.Location = new Point(367, 331);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(119, 48);
            btDelete.TabIndex = 43;
            btDelete.Text = "แก้ไข";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(192, 331);
            btClear.Name = "btClear";
            btClear.Size = new Size(119, 48);
            btClear.TabIndex = 42;
            btClear.Text = "เสร็จสิ้น";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.GridColor = SystemColors.InfoText;
            dataGridView3.Location = new Point(21, 37);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(678, 276);
            dataGridView3.TabIndex = 41;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(19, 43);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 276);
            dataGridView1.TabIndex = 45;
            // 
            // Column1
            // 
            Column1.HeaderText = "ลง";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.SortMode = DataGridViewColumnSortMode.Automatic;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "รหัสวิชา";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "ชื่อวิชา";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "หน่วยกิต";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "เวลา";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // btSeve
            // 
            btSeve.Location = new Point(711, 79);
            btSeve.Name = "btSeve";
            btSeve.Size = new Size(99, 45);
            btSeve.TabIndex = 48;
            btSeve.Text = "บันทึก";
            btSeve.UseVisualStyleBackColor = true;
            btSeve.Click += btSeve_Click_1;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.Location = new Point(21, 37);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(678, 216);
            dataGridView2.TabIndex = 47;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ลง";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "รหัสวิชา";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "ชื่อวิชา";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "หน่วยกิต";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "เวลา";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // btOK
            // 
            btOK.Location = new Point(709, 52);
            btOK.Name = "btOK";
            btOK.Size = new Size(99, 41);
            btOK.TabIndex = 52;
            btOK.Text = "ตกลง";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // label1
            // 
            label1.Font = new Font("TH Sarabun New", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(758, 19);
            label1.Name = "label1";
            label1.Size = new Size(207, 39);
            label1.TabIndex = 53;
            label1.Text = "ลงทะเบียน";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbnSearchStudent);
            groupBox1.Controls.Add(lblFirstName);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(btsearch);
            groupBox1.Controls.Add(lblYear);
            groupBox1.Controls.Add(lblFaculty);
            groupBox1.Controls.Add(lbMajor);
            groupBox1.Location = new Point(408, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(834, 156);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "ค้นหารายชื่อนักศึกษาที่จะลงทะเบียน";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 51);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 55;
            label2.Text = "รหัสนักศึกษา";
            // 
            // btback
            // 
            btback.Location = new Point(24, 27);
            btback.Name = "btback";
            btback.Size = new Size(131, 41);
            btback.TabIndex = 56;
            btback.Text = "ย้อนกลับ";
            btback.UseVisualStyleBackColor = true;
            btback.Click += btback_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(btSeve);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(35, 265);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(834, 355);
            groupBox2.TabIndex = 59;
            groupBox2.TabStop = false;
            groupBox2.Text = "รายวิชา";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Controls.Add(btOK);
            groupBox3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(35, 627);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(834, 289);
            groupBox3.TabIndex = 60;
            groupBox3.TabStop = false;
            groupBox3.Text = "รายวิชาที่เลือก";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView3);
            groupBox4.Controls.Add(btDelete);
            groupBox4.Controls.Add(btClear);
            groupBox4.Location = new Point(889, 275);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(727, 425);
            groupBox4.TabIndex = 61;
            groupBox4.TabStop = false;
            groupBox4.Text = "รายวิชาที่ลงทะเบียน";
            // 
            // FrmDent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1718, 929);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btback);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CourseRegistration - SystemStudents";
            Load += FrmDent_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbMajor;
        private Label lblFaculty;
        private Label lblYear;
        private Button btsearch;
        private TextBox tbnSearchStudent;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btDelete;
        private Button btClear;
        private DataGridView dataGridView3;
        private DataGridView dataGridView1;
        private Button btSeve;
        private DataGridView dataGridView2;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewCheckBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button btOK;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button btback;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}