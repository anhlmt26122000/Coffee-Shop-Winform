namespace QuanLyQuanCafe
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            panel3 = new Panel();
            txbUsername = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbPassword = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 167);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(415, 96);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(317, 96);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbUsername);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(8, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 39);
            panel3.TabIndex = 0;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(146, 7);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(339, 23);
            txbUsername.TabIndex = 1;
            txbUsername.Text = "admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 11);
            label2.Name = "label2";
            label2.Size = new Size(134, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập :";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbPassword);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(8, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(499, 39);
            panel2.TabIndex = 0;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(146, 11);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(339, 23);
            txbPassword.TabIndex = 0;
            txbPassword.Text = "admin";
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 0;
            label1.Text = "Mật khẩu :";
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(537, 149);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += Login_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txbUsername;
        private Panel panel3;
        private TextBox txbPassword;
        private Label label2;
        private Button btnExit;
        private Button btnLogin;
    }
}
