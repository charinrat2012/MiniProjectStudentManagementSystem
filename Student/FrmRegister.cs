using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Student
{
    public partial class FrmRegister : Form
    {
        private string imagePath; // เก็บ path รูปภาพโปรไฟล์

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            // เมื่อโหลด Form
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            // ตรวจสอบการกรอกข้อมูล
            if (string.IsNullOrWhiteSpace(tbfirstname.Text) ||
                string.IsNullOrWhiteSpace(tblastname.Text) ||
                string.IsNullOrWhiteSpace(tbemail.Text) ||
                string.IsNullOrWhiteSpace(tbphone.Text) ||
                string.IsNullOrWhiteSpace(tbPass.Text) ||
                string.IsNullOrWhiteSpace(tbPassWo.Text))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบความถูกต้องของอีเมล
            if (!tbemail.Text.Contains("@"))
            {
                MessageBox.Show("อีเมลไม่ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ตรวจสอบเบอร์โทรศัพท์
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbphone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("เบอร์โทรต้องมี 10 หลัก", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ตรวจสอบรหัสผ่าน
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbPass.Text, @"^\d{7,}$"))
            {
                MessageBox.Show("รหัสผ่านต้องเป็นตัวเลขอย่างน้อย 7 หลัก", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ตรวจสอบรหัสผ่านทั้งสองช่อง
            if (tbPass.Text != tbPassWo.Text)
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // เข้ารหัสรหัสผ่าน
            string hashedPassword = HashPassword(tbPass.Text);

            // Connection string ของฐานข้อมูล (แก้ไขให้ตรงกับของคุณ)
            string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";



            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // คำสั่ง SQL สำหรับบันทึกข้อมูลผู้ใช้ (รวม ProfileImagePath)
                    string query = "INSERT INTO Users (FirstName, LastName, Email, Phone, Password, ProfileImagePath) " +
                                   "VALUES (@FirstName, @LastName, @Email, @Phone, @Password, @ProfileImagePath)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // เติมค่า Parameter
                        cmd.Parameters.AddWithValue("@FirstName", tbfirstname.Text);
                        cmd.Parameters.AddWithValue("@LastName", tblastname.Text);
                        cmd.Parameters.AddWithValue("@Email", tbemail.Text);
                        cmd.Parameters.AddWithValue("@Phone", tbphone.Text);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@ProfileImagePath", string.IsNullOrEmpty(imagePath) ? (object)DBNull.Value : imagePath);

                        // ทำการ Execute คำสั่ง SQL
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("ลงทะเบียนสำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmLogin loginForm = new FrmLogin(tbemail.Text, tbPass.Text); // ส่ง Email และ Password
                            loginForm.Show();
                            this.Close(); // ปิดฟอร์มสมัครสมาชิก
                        }
                        else
                        {
                            MessageBox.Show("เกิดข้อผิดพลาดในการลงทะเบียน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        // ถ้าอีเมลหรือเบอร์โทรซ้ำ (สมมติว่ามี Unique Index ในฐานข้อมูล)
                        MessageBox.Show("อีเมลหรือเบอร์โทรซ้ำกับผู้ใช้งานอื่น", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("ข้อผิดพลาดจากฐานข้อมูล: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ฟังก์ชันสำหรับเข้ารหัสรหัสผ่าน
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // ปุ่มเลือกภาพโปรไฟล์
        private void btim_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "เลือกไฟล์รูปภาพ";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                imagePath = openFileDialog.FileName;
            }
        }

        // ปุ่มยกเลิก
        private void btno_Click(object sender, EventArgs e)
        {
            tbfirstname.Clear();
            tblastname.Clear();
            tbemail.Clear();
            tbphone.Clear();
            tbPass.Clear();
            tbPassWo.Clear();
            pictureBox1.Image = null;
            imagePath = null;

            // กลับไปหน้า Login โดยไม่ส่งค่า
            FrmLogin loginForm = new FrmLogin();
            loginForm.Show();
            this.Close();
        }

        // กลับไปหน้าล็อกอิน
        private void btback_Click(object sender, EventArgs e)
        {
            FrmLogin loginForm = new FrmLogin();
            this.Hide();
            loginForm.Show();
        }

        private void FrmRegister_Load_1(object sender, EventArgs e)
        {

        }
    }
}