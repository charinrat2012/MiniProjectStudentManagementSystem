namespace Student
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            btnew = new Button();
            btim = new Button();
            pictureBox1 = new PictureBox();
            tbPass = new TextBox();
            tbPassWo = new TextBox();
            tbphone = new TextBox();
            tbemail = new TextBox();
            tbfirstname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btback = new Button();
            btno = new Button();
            label7 = new Label();
            tblastname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnew
            // 
            btnew.BackColor = Color.MediumSpringGreen;
            btnew.Font = new Font("AngsanaUPC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnew.ForeColor = SystemColors.Window;
            btnew.Location = new Point(265, 351);
            btnew.Name = "btnew";
            btnew.Size = new Size(147, 63);
            btnew.TabIndex = 37;
            btnew.Text = "ลงทะเบียน";
            btnew.UseVisualStyleBackColor = false;
            btnew.Click += btnew_Click;
            // 
            // btim
            // 
            btim.Location = new Point(833, 236);
            btim.Name = "btim";
            btim.Size = new Size(41, 23);
            btim.TabIndex = 36;
            btim.Text = "......";
            btim.TextAlign = ContentAlignment.MiddleLeft;
            btim.UseVisualStyleBackColor = true;
            btim.Click += btim_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(648, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 172);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(310, 258);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(248, 23);
            tbPass.TabIndex = 34;
            // 
            // tbPassWo
            // 
            tbPassWo.Location = new Point(310, 294);
            tbPassWo.Name = "tbPassWo";
            tbPassWo.Size = new Size(248, 23);
            tbPassWo.TabIndex = 33;
            // 
            // tbphone
            // 
            tbphone.Location = new Point(310, 218);
            tbphone.Name = "tbphone";
            tbphone.Size = new Size(248, 23);
            tbphone.TabIndex = 32;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(310, 184);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(248, 23);
            tbemail.TabIndex = 31;
            // 
            // tbfirstname
            // 
            tbfirstname.Location = new Point(310, 106);
            tbfirstname.Name = "tbfirstname";
            tbfirstname.Size = new Size(248, 23);
            tbfirstname.TabIndex = 30;
            // 
            // label6
            // 
            label6.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(167, 290);
            label6.Name = "label6";
            label6.Size = new Size(163, 34);
            label6.TabIndex = 29;
            label6.Text = "ยืนยันรหัสผ่าน :";
            // 
            // label5
            // 
            label5.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(167, 254);
            label5.Name = "label5";
            label5.Size = new Size(88, 34);
            label5.TabIndex = 28;
            label5.Text = "รหัสผ่าน :";
            // 
            // label4
            // 
            label4.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(167, 206);
            label4.Name = "label4";
            label4.Size = new Size(120, 34);
            label4.TabIndex = 27;
            label4.Text = "เบอร์โทรศัพท์ :";
            // 
            // label3
            // 
            label3.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(167, 170);
            label3.Name = "label3";
            label3.Size = new Size(71, 34);
            label3.TabIndex = 26;
            label3.Text = "อีเมล :";
            // 
            // label1
            // 
            label1.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(167, 101);
            label1.Name = "label1";
            label1.Size = new Size(120, 34);
            label1.TabIndex = 25;
            label1.Text = "ชื่อ :";
            // 
            // label2
            // 
            label2.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(301, 9);
            label2.Name = "label2";
            label2.Size = new Size(295, 67);
            label2.TabIndex = 24;
            label2.Text = "Register";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btback
            // 
            btback.Location = new Point(19, 15);
            btback.Margin = new Padding(3, 2, 3, 2);
            btback.Name = "btback";
            btback.Size = new Size(115, 31);
            btback.TabIndex = 39;
            btback.Text = "ย้อนกลับ";
            btback.UseVisualStyleBackColor = true;
            btback.Click += btback_Click;
            // 
            // btno
            // 
            btno.BackColor = Color.Crimson;
            btno.Font = new Font("AngsanaUPC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btno.ForeColor = SystemColors.Window;
            btno.Location = new Point(484, 351);
            btno.Name = "btno";
            btno.Size = new Size(147, 63);
            btno.TabIndex = 40;
            btno.Text = "ยกเลิก";
            btno.UseVisualStyleBackColor = false;
            btno.Click += btno_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(167, 136);
            label7.Name = "label7";
            label7.Size = new Size(120, 34);
            label7.TabIndex = 41;
            label7.Text = "นามสกุล :";
            // 
            // tblastname
            // 
            tblastname.Location = new Point(310, 141);
            tblastname.Name = "tblastname";
            tblastname.Size = new Size(248, 23);
            tblastname.TabIndex = 42;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(906, 471);
            Controls.Add(tblastname);
            Controls.Add(label7);
            Controls.Add(btno);
            Controls.Add(btback);
            Controls.Add(btnew);
            Controls.Add(btim);
            Controls.Add(pictureBox1);
            Controls.Add(tbPass);
            Controls.Add(tbPassWo);
            Controls.Add(tbphone);
            Controls.Add(tbemail);
            Controls.Add(tbfirstname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register - SystemStudents";
            Load += FrmRegister_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnew;
        private Button btim;
        private PictureBox pictureBox1;
        private TextBox tbPass;
        private TextBox tbPassWo;
        private TextBox tbphone;
        private TextBox tbemail;
        private TextBox tbfullname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btback;
        private Button btno;
        private Label label7;
        private TextBox tblastname;
        private TextBox tbfirstname;
    }
}