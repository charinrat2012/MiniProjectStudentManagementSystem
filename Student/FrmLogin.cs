using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class FrmLogin : Form
    {
        private string registeredEmail;
        private string registeredPassword;

        public FrmLogin()
        {
            InitializeComponent();
        }

        public FrmLogin(string email, string password)
        {
            InitializeComponent();
            registeredEmail = email;
            registeredPassword = password;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(registeredEmail))
            {
                tbEmail.Text = registeredEmail;
            }
            if (!string.IsNullOrEmpty(registeredPassword))
            {
                tbPass.Text = registeredPassword;
            }

            tbPass.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string password = tbPass.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("กรุณากรอกอีเมลและรหัสผ่าน", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashedPasswordToCheck = HashPassword(password);
            UserData loggedInUser = AuthenticateUser(email, hashedPasswordToCheck);

            if (loggedInUser != null)
            {
                MessageBox.Show("เข้าสู่ระบบสำเร็จ!", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMainMenu mainForm = new FrmMainMenu(loggedInUser); // ส่งข้อมูลผู้ใช้ไปที่ FrmMainMenu
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ฟังก์ชันสำหรับตรวจสอบผู้ใช้และดึงข้อมูลจากฐานข้อมูล
        private UserData AuthenticateUser(string email, string hashedPassword)
        {
            UserData user = null;
            string connectionString = "Data Source=LAPTOP-ETJ21CED\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT FirstName, LastName, Email FROM Users WHERE Email = @Email AND Password = @Password"; // ดึง FirstName, LastName, Email
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new UserData
                                {
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Email = reader["Email"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการล็อกอิน: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return user;
        }

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

        private void lbLognew_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRegister registerForm = new FrmRegister();
                this.Hide();
                registerForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการเปิดหน้าสมัครสมาชิก: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}