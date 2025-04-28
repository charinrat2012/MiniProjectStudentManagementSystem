using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student
{
    public partial class FrmManageStudent : Form
    {
        public event Action<string[]> StudentDataUpdated;
        private UserData _currentUser; // เพิ่ม Field สำหรับเก็บ UserData

        // Constructor เดิม (ไม่มี Parameter)
        public FrmManageStudent()
        {
            InitializeComponent();
        }

        // Constructor ใหม่ (รับ UserData) **<-- เพิ่มตรงนี้**
        public FrmManageStudent(UserData user)
        {
            InitializeComponent();
            _currentUser = user;
            // คุณสามารถใช้ _currentUser ในหน้านี้ได้ ถ้าต้องการ
            // เช่น ตรวจสอบสิทธิ์การใช้งานของผู้ใช้
            // MessageBox.Show($"ผู้ใช้ปัจจุบัน: {_currentUser.FirstName}");
        }

        private void FrmManageStudent_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadStudentData();
        }

        private void SetupDataGridView()
        {
            if (dgvStudents.Columns.Count == 0)
            {
                dgvStudents.Columns.Add("StudentID", "รหัสนักศึกษา");
                dgvStudents.Columns.Add("FirstName", "ชื่อ");
                dgvStudents.Columns.Add("LastName", "นามสกุล");
                dgvStudents.Columns.Add("Faculty", "คณะ");
                dgvStudents.Columns.Add("Major", "สาขา");
                dgvStudents.Columns.Add("Year", "ชั้นปี");
                dgvStudents.Columns.Add("Status", "สถานะ");
            }
        }

        private void LoadStudentData()
        {
            dgvStudents.Rows.Clear();
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

                    foreach (DataRow row in dt.Rows)
                    {
                        dgvStudents.Rows.Add(
                            row["StudentID"].ToString(),
                            row["FirstName"].ToString(),
                            row["LastName"].ToString(),
                            row["Faculty"].ToString(),
                            row["Major"].ToString(),
                            row["Year"].ToString(),
                            row["Status"].ToString()
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbStudentID.Text) || string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbLastName.Text) || string.IsNullOrWhiteSpace(tbFaculty.Text) ||
                string.IsNullOrWhiteSpace(tbmajor.Text) || string.IsNullOrWhiteSpace(tbYear.Text) ||
                cbstatus.SelectedItem == null)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";



            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Students (StudentID, FirstName, LastName, Faculty, Major, Year, Status) " +
                                           "VALUES (@StudentID, @FirstName, @LastName, @Faculty, @Major, @Year, @Status)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", tbStudentID.Text.Trim());
                    cmd.Parameters.AddWithValue("@FirstName", tbFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", tbLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Faculty", tbFaculty.Text.Trim());
                    cmd.Parameters.AddWithValue("@Major", tbmajor.Text.Trim());
                    cmd.Parameters.AddWithValue("@Year", tbYear.Text.Trim());
                    cmd.Parameters.AddWithValue("@Status", cbstatus.SelectedItem?.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");

                    // เคลียร์ค่าใน TextBox และ ComboBox หลังจากบันทึก
                    tbStudentID.Clear();
                    tbFirstName.Clear();
                    tbLastName.Clear();
                    tbFaculty.Clear();
                    tbmajor.Clear();
                    tbYear.Clear();
                    cbstatus.SelectedIndex = -1; // ยกเลิกการเลือกใน ComboBox

                    LoadStudentData(); // โหลดข้อมูลใหม่เพื่อแสดงใน DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message);
                }
            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var row = dgvStudents.SelectedRows[0];
                string[] studentData = new string[7];
                for (int i = 0; i < 7; i++)
                {
                    studentData[i] = row.Cells[i].Value?.ToString();
                }

                // แก้ไขตรงนี้: ส่ง _currentUser ไปด้วย
                FrmEdit editForm = new FrmEdit(_currentUser, studentData);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateStudentInDatabase(editForm.UpdatedStudentData);
                    LoadStudentData(); // รีเฟรชข้อมูลใน DataGridView
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกนักศึกษาเพื่อต้องการแก้ไขข้อมูล");
            }
        }

        private void UpdateStudentInDatabase(string[] data)
        {
            string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";



            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Students SET FirstName=@FirstName, LastName=@LastName, Faculty=@Faculty, " +
                                           "Major=@Major, Year=@Year, Status=@Status WHERE StudentID=@StudentID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", data[0]);
                    cmd.Parameters.AddWithValue("@FirstName", data[1]);
                    cmd.Parameters.AddWithValue("@LastName", data[2]);
                    cmd.Parameters.AddWithValue("@Faculty", data[3]);
                    cmd.Parameters.AddWithValue("@Major", data[4]);
                    cmd.Parameters.AddWithValue("@Year", data[5]);
                    cmd.Parameters.AddWithValue("@Status", data[6]);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating data: " + ex.Message);
                }
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                string studentID = dgvStudents.SelectedRows[0].Cells[0].Value?.ToString();
                DialogResult result = MessageBox.Show("คุณแน่ใจหรือไม่ว่าต้องการลบข้อมูลนี้?", "ยืนยัน", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";



                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM Students WHERE StudentID=@StudentID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@StudentID", studentID);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว");
                            LoadStudentData(); // รีเฟรชข้อมูลใน DataGridView
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting data: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่จะลบ");
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // ไม่ได้ใช้งาน
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";



            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string searchText = tbsearch1.Text.Trim();
                    string query = "";

                    if (radioName.Checked)
                    {
                        query = "SELECT StudentID, FirstName, LastName, Faculty, Major, Year, Status FROM Students WHERE FirstName LIKE @search";
                    }
                    else if (radioId.Checked)
                    {
                        query = "SELECT StudentID, FirstName, LastName, Faculty, Major, Year, Status FROM Students WHERE StudentID LIKE @search";
                    }
                    else
                    {
                        MessageBox.Show("กรุณาเลือกวิธีค้นหา", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    SqlDataReader reader = cmd.ExecuteReader();

                    dgvStudents.Rows.Clear();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = reader["StudentID"].ToString() });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = reader["FirstName"].ToString() });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = reader["LastName"].ToString() });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = reader["Faculty"].ToString() });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = reader["Major"].ToString() });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = reader["Year"].ToString() });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = reader["Status"].ToString() });
                            dgvStudents.Rows.Add(row);
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