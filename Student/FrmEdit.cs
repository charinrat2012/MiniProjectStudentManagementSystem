// FrmEdit.cs
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Student
{
    public partial class FrmEdit : Form
    {
        public string[] UpdatedStudentData { get; private set; } = new string[7];
        private UserData _currentUser;

        // Constructor ที่รับ UserData และ studentData
        public FrmEdit(UserData user, string[] studentData)
        {
            InitializeComponent();
            _currentUser = user;
            // คุณสามารถใช้ _currentUser ในหน้านี้ได้ ถ้าต้องการ
            // เช่น ตรวจสอบสิทธิ์การแก้ไขของผู้ใช้
            // if (_currentUser.Role != "Admin")
            // {
            //     tbStudentID.Enabled = false; // ไม่อนุญาตให้แก้ไขรหัสนักศึกษา
            // }
            // MessageBox.Show($"ผู้ใช้ที่กำลังแก้ไข: {_currentUser.FirstName}");

            // แสดงข้อมูลเดิมในฟอร์มหากมี studentData
            if (studentData != null && studentData.Length >= 7)
            {
                tbStudentID.Text = studentData[0] ?? "";
                tbFirstName.Text = studentData[1] ?? "";
                tbLastName.Text = studentData[2] ?? "";
                tbFaculty.Text = studentData[3] ?? "";
                tbmajor.Text = studentData[4] ?? "";
                tbYear.Text = studentData[5] ?? "";
                cbstatus.SelectedItem = studentData[6] ?? "ปกติ";
            }

            // เชื่อมโยงอีเวนต์ Click ของปุ่มบันทึกกับเมธอด btnSave_Click
            this.btnsave.Click += new EventHandler(this.btnSave_Click);
        }

        // Constructor เดิม (อาจจำเป็นถ้ามีการเรียก Form นี้จากที่อื่น)
        public FrmEdit(string[] studentData)
        {
            InitializeComponent();

            // แสดงข้อมูลเดิมในฟอร์มหากมี studentData
            if (studentData != null && studentData.Length >= 7)
            {
                tbStudentID.Text = studentData[0] ?? "";
                tbFirstName.Text = studentData[1] ?? "";
                tbLastName.Text = studentData[2] ?? "";
                tbFaculty.Text = studentData[3] ?? "";
                tbmajor.Text = studentData[4] ?? "";
                tbYear.Text = studentData[5] ?? "";
                cbstatus.SelectedItem = studentData[6] ?? "ปกติ";
            }

            // เชื่อมโยงอีเวนต์ Click ของปุ่มบันทึกกับเมธอด btnSave_Click
            this.btnsave.Click += new EventHandler(this.btnSave_Click);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdatedStudentData = new string[]
            {
                tbStudentID.Text.Trim(),
                tbFirstName.Text.Trim(),
                tbLastName.Text.Trim(),
                tbFaculty.Text.Trim(),
                tbmajor.Text.Trim(),
                tbYear.Text.Trim(),
                cbstatus.SelectedItem?.ToString() ?? "ปกติ"
            };

            if (UpdatedStudentData.Any(string.IsNullOrEmpty))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btback_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private void FrmEdit_Load(object sender, EventArgs e)
        {

        }

        private void FrmEdit_Load_1(object sender, EventArgs e)
        {

        }
    }
}