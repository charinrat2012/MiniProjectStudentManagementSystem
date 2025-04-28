// FrmShow.cs
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student
{
    public partial class FrmShow : Form
    {
        private UserData _currentUser;
        private FrmMainMenu _mainMenuForm;

        // Constructor ที่รับ UserData และ FrmMainMenu
        public FrmShow(UserData user, FrmMainMenu mainMenuForm)
        {
            InitializeComponent();
            _currentUser = user;
            _mainMenuForm = mainMenuForm;
        }

        // Constructor เดิม (อาจจำเป็น)
        public FrmShow()
        {
            InitializeComponent();
        }

        private void FrmShow_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("StudentID", "รหัสนักศึกษา");
            listView1.Columns.Add("FirstName", "ชื่อ");
            listView1.Columns.Add("LastName", "นามสกุล");
            listView1.Columns.Add("Faculty", "คณะ");
            listView1.Columns.Add("Major", "สาขา");
            listView1.Columns.Add("Year", "ชั้นปี");
            listView1.Columns.Add("Status", "สถานะ");

            LoadStudentData();
        }

        private void btmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainMenuForm.Show();
        }


        private void btStudent_Click(object sender, EventArgs e)
        {
            // แก้ไข: ส่ง _currentUser ไปยัง FrmManageStudent
            FrmManageStudent manageStudentForm = new FrmManageStudent(_currentUser);
            manageStudentForm.StudentDataUpdated += OnStudentDataUpdated;
            this.Hide();
            manageStudentForm.ShowDialog();
            this.Show();
        }

        private void btback_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainMenuForm.Show();
        }

        private void LoadStudentData()
        {
            string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Students";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    listView1.Items.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["StudentID"].ToString());
                        item.SubItems.Add(row["FirstName"].ToString());
                        item.SubItems.Add(row["LastName"].ToString());
                        item.SubItems.Add(row["Faculty"].ToString());
                        item.SubItems.Add(row["Major"].ToString());
                        item.SubItems.Add(row["Year"].ToString());
                        item.SubItems.Add(row["Status"].ToString());
                        listView1.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
            }
        }

        private void OnStudentDataUpdated(string[] updatedStudentData)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == updatedStudentData[0])
                {
                    item.SubItems[1].Text = updatedStudentData[1];
                    item.SubItems[2].Text = updatedStudentData[2];
                    item.SubItems[3].Text = updatedStudentData[3];
                    item.SubItems[4].Text = updatedStudentData[4];
                    item.SubItems[5].Text = updatedStudentData[5];
                    item.SubItems[6].Text = updatedStudentData[6];
                    break;
                }
            }
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string searchText = txtSearch.Text.Trim();
                    string query = "";

                    if (rdbName.Checked)
                    {
                        query = "SELECT * FROM Students WHERE FirstName LIKE @search";
                    }
                    else if (rdbStudentID.Checked)
                    {
                        query = "SELECT * FROM Students WHERE StudentID LIKE @search";
                    }
                    else
                    {
                        MessageBox.Show("กรุณาเลือกวิธีค้นหา", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    SqlDataReader reader = cmd.ExecuteReader();

                    listView1.Items.Clear();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["StudentID"].ToString());
                            item.SubItems.Add(reader["FirstName"].ToString());
                            item.SubItems.Add(reader["LastName"].ToString());
                            item.SubItems.Add(reader["Faculty"].ToString());
                            item.SubItems.Add(reader["Major"].ToString());
                            item.SubItems.Add(reader["Year"].ToString());
                            item.SubItems.Add(reader["Status"].ToString());
                            listView1.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลที่ค้นหา", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // ไม่จำเป็นต้องใส่อะไร
        }

        private void rdbStudentID_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}