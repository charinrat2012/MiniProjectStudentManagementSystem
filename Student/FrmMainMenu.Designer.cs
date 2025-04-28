namespace Student
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            btLogout = new Button();
            lblLastName = new Label();
            label2 = new Label();
            btshow = new Button();
            btStudent = new Button();
            btback = new Button();
            lblName = new Label();
            lblEmail = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btLogout
            // 
            btLogout.BackColor = Color.Red;
            btLogout.Font = new Font("AngsanaUPC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogout.ForeColor = SystemColors.Window;
            btLogout.Location = new Point(406, 456);
            btLogout.Margin = new Padding(3, 4, 3, 4);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(94, 47);
            btLogout.TabIndex = 31;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = false;
            btLogout.Click += btLogout_Click;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = SystemColors.HotTrack;
            lblLastName.Location = new Point(120, 413);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(246, 45);
            lblLastName.TabIndex = 29;
            lblLastName.Text = "นามสกุล : XXXXXXXXX";
            // 
            // label2
            // 
            label2.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(217, 12);
            label2.Name = "label2";
            label2.Size = new Size(194, 89);
            label2.TabIndex = 27;
            label2.Text = "Menu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btshow
            // 
            btshow.BackColor = Color.Salmon;
            btshow.Font = new Font("AngsanaUPC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btshow.ForeColor = SystemColors.Window;
            btshow.Location = new Point(333, 157);
            btshow.Margin = new Padding(3, 4, 3, 4);
            btshow.Name = "btshow";
            btshow.Size = new Size(146, 165);
            btshow.TabIndex = 26;
            btshow.Text = "แสดงข้อมูล";
            btshow.UseVisualStyleBackColor = false;
            btshow.Click += btshow_Click;
            // 
            // btStudent
            // 
            btStudent.BackColor = Color.Orange;
            btStudent.Font = new Font("AngsanaUPC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btStudent.ForeColor = SystemColors.Window;
            btStudent.Location = new Point(513, 157);
            btStudent.Margin = new Padding(3, 4, 3, 4);
            btStudent.Name = "btStudent";
            btStudent.Size = new Size(149, 165);
            btStudent.TabIndex = 25;
            btStudent.Text = "เพิ่มและลบข้อมูล";
            btStudent.UseVisualStyleBackColor = false;
            btStudent.Click += btStudent_Click;
            // 
            // btback
            // 
            btback.Location = new Point(22, 23);
            btback.Name = "btback";
            btback.Size = new Size(113, 41);
            btback.TabIndex = 32;
            btback.Text = "ย้อนกลับ";
            btback.UseVisualStyleBackColor = true;
            btback.Click += btback_Click;
            // 
            // lblName
            // 
            lblName.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.HotTrack;
            lblName.Location = new Point(120, 368);
            lblName.Name = "lblName";
            lblName.Size = new Size(173, 45);
            lblName.TabIndex = 33;
            lblName.Text = "ชื่อ : XXXXXX  ";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.HotTrack;
            lblEmail.Location = new Point(120, 459);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(246, 45);
            lblEmail.TabIndex = 34;
            lblEmail.Text = "Email: XXXXXXXXXXXX";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("AngsanaUPC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(130, 157);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(146, 165);
            button1.TabIndex = 35;
            button1.Text = "ลงทะเบียน";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(707, 619);
            Controls.Add(button1);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(btback);
            Controls.Add(btLogout);
            Controls.Add(lblLastName);
            Controls.Add(label2);
            Controls.Add(btshow);
            Controls.Add(btStudent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu - SystemStudents";
            Load += FrmMainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btLogout;
        private Label lbFullName;
        private PictureBox pictureBox2;
        private Label label2;
        private Button button3;
        private Button btStudent;
        private Button button2;
        private Button btshow;
        private Button btback;
        private Label label1;
        private Label label3;
        private Label lblLastName;
        private Label lblName;
        private Label lblEmail;
        private Button button1;
    }
}