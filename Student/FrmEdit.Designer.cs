namespace Student
{
    partial class FrmEdit
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdit));
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            btback = new Button();
            label3 = new Label();
            tbLastName = new TextBox();
            cbstatus = new ComboBox();
            tbYear = new TextBox();
            tbmajor = new TextBox();
            tbFaculty = new TextBox();
            tbFirstName = new TextBox();
            tbStudentID = new TextBox();
            btnsave = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 335);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 49;
            label6.Text = "สถานะ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 297);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 48;
            label7.Text = "ชั้นปี :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 264);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 46;
            label4.Text = "สาขา :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 231);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 44;
            label5.Text = "คณะ :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 165);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 41;
            label1.Text = "ชื่อ :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(90, 129);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 39;
            label8.Text = "รหัสนักศึกษา :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH SarabunPSK", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(222, 28);
            label2.Name = "label2";
            label2.Size = new Size(174, 62);
            label2.TabIndex = 53;
            label2.Text = "แก้ไขข้อมูล";
            // 
            // btback
            // 
            btback.Location = new Point(482, 12);
            btback.Name = "btback";
            btback.Size = new Size(131, 41);
            btback.TabIndex = 54;
            btback.Text = "ย้อนกลับ";
            btback.UseVisualStyleBackColor = true;
            btback.Click += btback_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 197);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 55;
            label3.Text = "นามสกุล :";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(188, 195);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(259, 27);
            tbLastName.TabIndex = 62;
            // 
            // cbstatus
            // 
            cbstatus.FormattingEnabled = true;
            cbstatus.Items.AddRange(new object[] { "ปกติ", "รอพิจารณา", "ลาออก", "จบการศึกษา" });
            cbstatus.Location = new Point(188, 331);
            cbstatus.Name = "cbstatus";
            cbstatus.Size = new Size(259, 28);
            cbstatus.TabIndex = 61;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(188, 293);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(259, 27);
            tbYear.TabIndex = 60;
            // 
            // tbmajor
            // 
            tbmajor.Location = new Point(188, 261);
            tbmajor.Name = "tbmajor";
            tbmajor.Size = new Size(259, 27);
            tbmajor.TabIndex = 59;
            // 
            // tbFaculty
            // 
            tbFaculty.Location = new Point(188, 228);
            tbFaculty.Name = "tbFaculty";
            tbFaculty.Size = new Size(259, 27);
            tbFaculty.TabIndex = 58;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(188, 163);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(259, 27);
            tbFirstName.TabIndex = 57;
            // 
            // tbStudentID
            // 
            tbStudentID.Location = new Point(188, 129);
            tbStudentID.Name = "tbStudentID";
            tbStudentID.Size = new Size(259, 27);
            tbStudentID.TabIndex = 56;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(240, 378);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(131, 41);
            btnsave.TabIndex = 63;
            btnsave.Text = "บันทึก";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnSave_Click;
            // 
            // FrmEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(625, 451);
            Controls.Add(btnsave);
            Controls.Add(tbLastName);
            Controls.Add(cbstatus);
            Controls.Add(tbYear);
            Controls.Add(tbmajor);
            Controls.Add(tbFaculty);
            Controls.Add(tbFirstName);
            Controls.Add(tbStudentID);
            Controls.Add(label3);
            Controls.Add(btback);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label8);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit - SystemStudents";
            Load += FrmEdit_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label label8;
        private Label label2;
        private Button btback;
        private Label label3;
        private TextBox tbLastName;
        private ComboBox cbstatus;
        private TextBox tbYear;
        private TextBox tbmajor;
        private TextBox tbFaculty;
        private TextBox tbFirstName;
        private TextBox tbStudentID;
        private Button btnsave;
    }
}
