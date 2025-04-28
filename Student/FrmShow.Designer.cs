namespace Student
{
    partial class FrmShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShow));
            groupBox1 = new GroupBox();
            btsearch = new Button();
            listView1 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            txtSearch = new TextBox();
            rdbStudentID = new RadioButton();
            rdbName = new RadioButton();
            button3 = new Button();
            btStudent = new Button();
            btmenu = new Button();
            btback = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btsearch);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(rdbStudentID);
            groupBox1.Controls.Add(rdbName);
            groupBox1.Location = new Point(32, 101);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1383, 587);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลนักศึกษา";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btsearch
            // 
            btsearch.Location = new Point(491, 73);
            btsearch.Name = "btsearch";
            btsearch.Size = new Size(114, 35);
            btsearch.TabIndex = 25;
            btsearch.Text = "ค้นหา";
            btsearch.UseVisualStyleBackColor = true;
            btsearch.Click += btsearch_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader2, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.GridLines = true;
            listView1.Location = new Point(24, 133);
            listView1.Name = "listView1";
            listView1.Size = new Size(1335, 416);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "รหัสนักศึกษา";
            columnHeader3.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ชื่อ";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "นามสกุล";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "คณะ";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "สาขา";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 250;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ชั้นปี";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "สถานะ";
            columnHeader8.Width = 90;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(37, 77);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(436, 27);
            txtSearch.TabIndex = 7;
            // 
            // rdbStudentID
            // 
            rdbStudentID.AutoSize = true;
            rdbStudentID.Location = new Point(151, 29);
            rdbStudentID.Margin = new Padding(3, 4, 3, 4);
            rdbStudentID.Name = "rdbStudentID";
            rdbStudentID.Size = new Size(163, 24);
            rdbStudentID.TabIndex = 2;
            rdbStudentID.TabStop = true;
            rdbStudentID.Text = "ค้นหาด้วยรหัสนักศึกษา";
            rdbStudentID.UseVisualStyleBackColor = true;
            rdbStudentID.CheckedChanged += rdbStudentID_CheckedChanged;
            // 
            // rdbName
            // 
            rdbName.AutoSize = true;
            rdbName.Location = new Point(37, 29);
            rdbName.Margin = new Padding(3, 4, 3, 4);
            rdbName.Name = "rdbName";
            rdbName.Size = new Size(105, 24);
            rdbName.TabIndex = 1;
            rdbName.TabStop = true;
            rdbName.Text = "ค้นหาด้วยชื่อ";
            rdbName.UseVisualStyleBackColor = true;
            rdbName.CheckedChanged += rdbName_CheckedChanged;
            // 
            // button3
            // 
            button3.Location = new Point(1446, 608);
            button3.Name = "button3";
            button3.Size = new Size(136, 64);
            button3.TabIndex = 22;
            button3.Text = "ออกจากระบบ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btStudent
            // 
            btStudent.Location = new Point(1446, 257);
            btStudent.Name = "btStudent";
            btStudent.Size = new Size(136, 88);
            btStudent.TabIndex = 21;
            btStudent.Text = "เพื่มและลบ";
            btStudent.UseVisualStyleBackColor = true;
            btStudent.Click += btStudent_Click;
            // 
            // btmenu
            // 
            btmenu.Location = new Point(1446, 130);
            btmenu.Name = "btmenu";
            btmenu.Size = new Size(136, 88);
            btmenu.TabIndex = 20;
            btmenu.Text = "เมนู";
            btmenu.UseVisualStyleBackColor = true;
            btmenu.Click += btmenu_Click;
            // 
            // btback
            // 
            btback.Location = new Point(11, 21);
            btback.Name = "btback";
            btback.Size = new Size(131, 41);
            btback.TabIndex = 24;
            btback.Text = "ย้อนกลับ";
            btback.UseVisualStyleBackColor = true;
            btback.Click += btback_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH SarabunPSK", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(605, 21);
            label2.Name = "label2";
            label2.Size = new Size(289, 62);
            label2.TabIndex = 54;
            label2.Text = "แสดงข้อมูลนักศึกษา";
            // 
            // FrmShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1696, 717);
            Controls.Add(label2);
            Controls.Add(btback);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(btStudent);
            Controls.Add(btmenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmShow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowData - SystemStudents";
            Load += FrmShow_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private TextBox txtSearch;
        private RadioButton rdbStudentID;
        private RadioButton rdbName;
        private Button button3;
        private Button btStudent;
        private Button btmenu;
        private Button btback;
        private Button btsearch;
        private Label label2;
    }
}