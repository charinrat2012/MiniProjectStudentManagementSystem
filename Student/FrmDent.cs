using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;



namespace Student
{
    public partial class FrmDent : Form


    {
        private FrmMainMenu mainMenuForm;
        private User _loggedInUser; // สมมติว่า _loggedInUser เป็นคลาส User
        private Form _parentForm;   // หรือชนิดของ Form หลักของคุณ
        public FrmDent(FrmMainMenu menu)
        {
            InitializeComponent();
            mainMenuForm = menu;
        }

        private void FrmDent_Load(object sender, EventArgs e)
        {
            // ไม่โหลดข้อมูลวิชาในตอนเริ่ม ให้โหลดเมื่อค้นหานักศึกษาแล้วเท่านั้น
        }

        private void ClearStudentInfo()
        {
            lblFirstName.Text = "";
            lblLastName.Text = "";
            lblYear.Text = "";
            lblFaculty.Text = "";
            lbMajor.Text = "";
        }

        private void btsearch_Click_1(object sender, EventArgs e)
        {
            string studentID = tbnSearchStudent.Text.Trim();

            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("กรุณาป้อนรหัสนักศึกษา", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearStudentInfo();
                return;
            }

            string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT FirstName, LastName, Year, Faculty, Major FROM Students WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lblFirstName.Text = reader["FirstName"].ToString();
                        lblLastName.Text = reader["LastName"].ToString();
                        lblYear.Text = reader["Year"].ToString();
                        lblFaculty.Text = reader["Faculty"].ToString();
                        lbMajor.Text = reader["Major"].ToString();

                        reader.Close(); // ปิดก่อนโหลดข้อมูลใหม่
                        LoadCourseData(); // โหลดวิชาหลังจากพบข้อมูลนักศึกษา
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลนักศึกษาด้วยรหัสนี้", "ผลการค้นหา", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearStudentInfo();
                        dataGridView1.DataSource = null; // ล้างตารางวิชา
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearStudentInfo();
                }
            }
        }

        private void LoadCourseData()
        {
            string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CourseCode, CourseName, Credits, Time FROM RegisCourse";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // เคลียร์ก่อน
                    dataGridView1.Columns.Clear();
                    dataGridView1.Rows.Clear();

                    // สร้าง Checkbox column
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    chk.HeaderText = "เลือก";
                    chk.Name = "chkSelect";
                    dataGridView1.Columns.Add(chk);

                    // สร้างคอลัมน์อื่น ๆ
                    dataGridView1.Columns.Add("CourseCode", "รหัสวิชา");
                    dataGridView1.Columns.Add("CourseName", "ชื่อวิชา");
                    dataGridView1.Columns.Add("Credits", "หน่วยกิต");
                    dataGridView1.Columns.Add("Time", "เวลา");

                    // เพิ่มข้อมูลใน rows
                    foreach (DataRow row in dt.Rows)
                    {
                        dataGridView1.Rows.Add(false, row["CourseCode"], row["CourseName"], row["Credits"], row["Time"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด:\n" + ex.Message);
                }
            }
        }


        private void Click(object sender, DataGridViewCellEventArgs e)
        {
            // ถ้าคุณมี Event อะไรเพิ่มเติมในอนาคตให้เขียนตรงนี้
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btSeve_Click_1(object sender, EventArgs e)
        {
            // เคลียร์ข้อมูลเก่าใน dataGridView2
            dataGridView2.Rows.Clear();

            // เคลียร์คอลัมน์ใน dataGridView2
            dataGridView2.Columns.Clear();

            // เพิ่มคอลัมน์ให้สามารถติ๊กเลือกได้ใน dataGridView2
            DataGridViewCheckBoxColumn chkSelectColumn = new DataGridViewCheckBoxColumn();
            chkSelectColumn.HeaderText = "เลือก";
            chkSelectColumn.Name = "chkSelect"; // ชื่อคอลัมน์เพื่อใช้ในการอ้างอิง
            dataGridView2.Columns.Add(chkSelectColumn);

            // เพิ่มคอลัมน์ข้อมูลวิชา
            dataGridView2.Columns.Add("CourseCode", "รหัสวิชา");
            dataGridView2.Columns.Add("CourseName", "ชื่อวิชา");
            dataGridView2.Columns.Add("Credits", "หน่วยกิต");
            dataGridView2.Columns.Add("Time", "เวลา");

            bool hasSelected = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // เช็คว่า checkbox ถูกติ๊กใน dataGridView1
                if (row.Cells["chkSelect"].Value != null && Convert.ToBoolean(row.Cells["chkSelect"].Value) == true)
                {
                    string code = row.Cells["CourseCode"].Value?.ToString();
                    string name = row.Cells["CourseName"].Value?.ToString();
                    string credits = row.Cells["Credits"].Value?.ToString();
                    string time = row.Cells["Time"].Value?.ToString();

                    // เพิ่มข้อมูลใน dataGridView2
                    dataGridView2.Rows.Add(false, code, name, credits, time); // ใส่ค่าเริ่มต้น false ให้คอลัมน์ checkbox
                    hasSelected = true;
                }
            }

            if (!hasSelected)
            {
                MessageBox.Show("กรุณาเลือกวิชาก่อนกดบันทึก", "ไม่มีวิชา", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void btOK_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string studentID = tbnSearchStudent.Text.Trim(); // เปลี่ยนเป็น string ไม่แปลง int

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["chkSelect"].Value) == true)
                        {
                            string courseCode = row.Cells["CourseCode"].Value.ToString();
                            string courseName = row.Cells["CourseName"].Value.ToString();
                            int credits = Convert.ToInt32(row.Cells["Credits"].Value);
                            string time = row.Cells["Time"].Value.ToString();

                            // เช็คการลงทะเบียนซ้ำ
                            string checkQuery = "SELECT COUNT(*) FROM StudentCourseSelection WHERE StudentID = @StudentID AND CourseCode = @CourseCode";
                            SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                            checkCommand.Parameters.AddWithValue("@StudentID", studentID);
                            checkCommand.Parameters.AddWithValue("@CourseCode", Convert.ToInt32(courseCode));

                            int count = (int)checkCommand.ExecuteScalar(); // คำนวณจำนวนการลงทะเบียนซ้ำ

                            if (count > 0)
                            {
                                MessageBox.Show($"คุณได้ลงทะเบียนวิชา {courseName} ไปแล้ว!", "การลงทะเบียนซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                // หากไม่มีการลงทะเบียนซ้ำ ให้ทำการบันทึกข้อมูลใหม่
                                string query = "INSERT INTO StudentCourseSelection (StudentID, CourseCode, CourseName, Credits, Time) " +
                                               "VALUES (@StudentID, @CourseCode, @CourseName, @Credits, @Time)";

                                SqlCommand command = new SqlCommand(query, connection);
                                command.Parameters.AddWithValue("@StudentID", studentID);
                                command.Parameters.AddWithValue("@CourseCode", Convert.ToInt32(courseCode)); // เพราะใน DB เป็น int
                                command.Parameters.AddWithValue("@CourseName", courseName);
                                command.Parameters.AddWithValue("@Credits", credits);
                                command.Parameters.AddWithValue("@Time", time);

                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("บันทึกข้อมูลสำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSelectedCoursesToGridView3();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LoadSelectedCoursesToGridView3()
        {
            string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";

            string studentID = tbnSearchStudent.Text.Trim();


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    connection.Open();

                    string query = "SELECT CourseCode, CourseName, Credits, Time FROM StudentCourseSelection WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Debug: เช็กว่ามีข้อมูลหรือไม่
                    MessageBox.Show("ข้อมูลที่พบ: " + dt.Rows.Count + " แถว", "Debug");

                    dataGridView3.DataSource = dt;


                    // กำหนดสีพื้นหลัง/ตัวอักษรให้อ่านง่าย
                    dataGridView3.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView3.DefaultCellStyle.BackColor = Color.White;
                    dataGridView3.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                    dataGridView3.DefaultCellStyle.SelectionForeColor = Color.Black;

                    dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                    dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                    dataGridView3.EnableHeadersVisualStyles = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูล: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string studentID = tbnSearchStudent.Text.Trim();

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["chkSelect"].Value) == true)
                        {
                            string courseCode = row.Cells["CourseCode"].Value.ToString();

                            // ใช้คำสั่ง DELETE แทน INSERT
                            string deleteQuery = "DELETE FROM StudentCourseSelection WHERE StudentID = @StudentID AND CourseCode = @CourseCode";

                            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                            deleteCommand.Parameters.AddWithValue("@StudentID", studentID);
                            deleteCommand.Parameters.AddWithValue("@CourseCode", Convert.ToInt32(courseCode));

                            deleteCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("ลบข้อมูลสำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSelectedCoursesToGridView3();

                    ClearCourseSelection(); // เคลียร์ checkbox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการลบข้อมูล: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearCourseSelection()
        {
            // เคลียร์การเลือก CheckBox ทุกแถวใน dataGridView2
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["chkSelect"] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    checkBoxCell.Value = false; // ตั้งค่าให้ทุกช่อง CheckBox เป็น false
                }
            }
        }
        //+--------------------------
        private void ClearAllData()
        {
            // เคลียร์ TextBox สำหรับค้นหานักศึกษา
            tbnSearchStudent.Clear();

            // เคลียร์ Label ข้อมูลนักศึกษา
            lblFirstName.Text = "";
            lblLastName.Text = "";
            lblYear.Text = "";
            lblFaculty.Text = "";
            lbMajor.Text = "";

            // เคลียร์ข้อมูลใน DataGridView1 (แสดงรายวิชา)
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // เคลียร์ข้อมูลใน DataGridView2 (วิชาที่เลือกไว้)
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            // เคลียร์ข้อมูลใน DataGridView3 (วิชาที่ลงทะเบียนแล้ว)
            dataGridView3.DataSource = null;
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            // เคลียร์ TextBox ของการค้นหานักศึกษา (กรณี tbnSearchStudent เป็น TextBox สำหรับค้นหานักศึกษา)
            tbnSearchStudent.Clear();

            // เคลียร์ DataGridView ที่ใช้แสดงวิชา (เช่น dataGridView2 ที่ใช้สำหรับการเลือกวิชา)
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["chkSelect"] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    checkBoxCell.Value = false; // ตั้งค่าให้ช่องเลือกวิชาเป็น false
                }
            }

            // เคลียร์ DataGridView ที่แสดงข้อมูลวิชาที่ลงทะเบียน (เช่น dataGridView3)
            dataGridView3.DataSource = null;
            dataGridView2.DataSource = null;
            // หากมีการตั้งค่าฟิลด์อื่นๆ ที่ต้องการเคลียร์ สามารถเพิ่มการล้างค่าได้ที่นี่
            // ตัวอย่าง: ถ้ามีการแสดงผลที่เกี่ยวข้องกับการลงทะเบียน
            // lblStatus.Text = "";

            MessageBox.Show("ข้อมูลถูกเคลียร์เรียบร้อยแล้ว", "เคลียร์ข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAllData();
        }

        private void btback_Click(object sender, EventArgs e)
        {
            this.Close(); // หรือ this.Hide();
            mainMenuForm.Show();

        }

        private void FrmDent_Load_1(object sender, EventArgs e)
        {

        }

        private void lblFaculty_Click(object sender, EventArgs e)
        {

        }

        private void lbMajor_Click(object sender, EventArgs e)
        {

        }
    }
}