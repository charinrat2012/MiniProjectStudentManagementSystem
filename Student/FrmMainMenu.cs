using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student
{
    public partial class FrmMainMenu : Form
    {
        private UserData _currentUser;
        private UserData _loggedInUser;

        string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";


        // Constructor ที่รับข้อมูลผู้ใช้
        public FrmMainMenu(UserData loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
        }

        



        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            if (_loggedInUser != null)
            {
                lblName.Text = _loggedInUser.FirstName;
                lblLastName.Text = _loggedInUser.LastName;
                lblEmail.Text = _loggedInUser.Email;
            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            string[] studentData = { "ID", "FirstName", "LastName", "Faculty", "Major", "Year", "Status" };
            FrmEdit editForm = new FrmEdit(_loggedInUser, studentData); // ส่ง _loggedInUser
            editForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            editForm.Show();
        }

        private void btshow_Click(object sender, EventArgs e)
        {
            // แก้ไขตรงนี้: เรียก Constructor ที่รับ _loggedInUser และ this
            FrmShow frmShow = new FrmShow(_loggedInUser, this);
            frmShow.FormClosed += (s, args) => this.Show();
            this.Hide();
            frmShow.Show();
        }

        private void btStudent_Click(object sender, EventArgs e)
        {
            FrmManageStudent frmManageStudent = new FrmManageStudent(_loggedInUser); // ส่ง _loggedInUser
            frmManageStudent.FormClosed += (s, args) => this.Show();
            this.Hide();
            frmManageStudent.Show();
        }

        private void btback_Click(object sender, EventArgs e)
        {
            FrmLogin loginForm = new FrmLogin();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            FrmLogin loginForm = new FrmLogin();
            this.Hide();
            DialogResult result = loginForm.ShowDialog();
            this.Show(); // แสดง FrmMainMenu อีกครั้งหลังจาก FrmLogin ปิด

            // ตรวจสอบ DialogResult ของ FrmLogin
            if (result != DialogResult.OK) // ถ้าไม่ใช่ DialogResult.OK (เช่น Cancel หรือปิด)
            {
                this.Close(); // ปิด FrmMainMenu
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        // ฟังก์ชันสำหรับดึงข้อมูลนักเรียนจากฐานข้อมูล (ตัวอย่าง)
        private DataTable GetStudentsData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT StudentID, FirstName, LastName, Faculty, Major, Year, Status FROM Students"; // ปรับ Query ตามต้องการ
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"เกิดข้อผิดพลาดในการดึงข้อมูลนักเรียน: {ex.Message}");
                }
            }
            return dt;
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDent frmDent = new FrmDent(this); // หรืออาจจะไม่ต้องส่ง 'this' ขึ้นอยู่กับ Constructor ของ FrmDent
            this.Hide(); // ซ่อน FrmMainMenu
            frmDent.ShowDialog();

            // หลังจาก FrmDent ปิด (ถ้าต้องการให้ทำอะไรต่อ)
            this.Show();


        }
    }

    public class UserData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] ProfileImage { get; set; }
    }
}