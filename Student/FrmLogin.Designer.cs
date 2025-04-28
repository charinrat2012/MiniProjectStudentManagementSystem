namespace Student
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lbLognew = new Label();
            btLog = new Button();
            tbPass = new TextBox();
            label3 = new Label();
            tbEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbLognew
            // 
            lbLognew.Font = new Font("Angsana New", 12F, FontStyle.Bold, GraphicsUnit.Point, 222);
            lbLognew.ForeColor = SystemColors.MenuHighlight;
            lbLognew.Location = new Point(393, 263);
            lbLognew.Name = "lbLognew";
            lbLognew.Size = new Size(106, 23);
            lbLognew.TabIndex = 17;
            lbLognew.Text = "...ลงทะเบียนใหม่";
            lbLognew.Click += lbLognew_Click;
            // 
            // btLog
            // 
            btLog.BackColor = Color.Lime;
            btLog.Font = new Font("AngsanaUPC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLog.ForeColor = SystemColors.Window;
            btLog.Location = new Point(258, 235);
            btLog.Name = "btLog";
            btLog.Size = new Size(129, 51);
            btLog.TabIndex = 16;
            btLog.Text = "เข้าสู่ระบบ";
            btLog.UseVisualStyleBackColor = false;
            btLog.Click += btnLogin_Click;
            // 
            // tbPass
            // 
            tbPass.ForeColor = SystemColors.ActiveCaptionText;
            tbPass.Location = new Point(223, 174);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(248, 23);
            tbPass.TabIndex = 15;
            tbPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Font = new Font("Angsana New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(117, 174);
            label3.Name = "label3";
            label3.Size = new Size(100, 34);
            label3.TabIndex = 14;
            label3.Text = "Password :";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(223, 122);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(248, 23);
            tbEmail.TabIndex = 13;
            // 
            // label2
            // 
            label2.Font = new Font("Angsana New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(127, 114);
            label2.Name = "label2";
            label2.Size = new Size(67, 34);
            label2.TabIndex = 12;
            label2.Text = "Email :";
            // 
            // label1
            // 
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(244, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 67);
            label1.TabIndex = 11;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(635, 338);
            Controls.Add(lbLognew);
            Controls.Add(btLog);
            Controls.Add(tbPass);
            Controls.Add(label3);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - SystemStudents";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbLognew;
        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}