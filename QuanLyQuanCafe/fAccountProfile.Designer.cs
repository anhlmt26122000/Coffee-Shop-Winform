namespace QuanLyQuanCafe
{
    partial class fAccountProfile
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
            panel3 = new Panel();
            txbUsername = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            txbDisplayName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txbPassword = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbNewPassword = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbReEnterNewPassword = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(txbUsername);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 39);
            panel3.TabIndex = 1;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(146, 7);
            txbUsername.Name = "txbUsername";
            txbUsername.ReadOnly = true;
            txbUsername.Size = new Size(339, 23);
            txbUsername.TabIndex = 1;
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
            // panel1
            // 
            panel1.Controls.Add(txbDisplayName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 39);
            panel1.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(146, 7);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(339, 23);
            txbDisplayName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên hiển thị :";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbPassword);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(499, 39);
            panel2.TabIndex = 3;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(146, 7);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(339, 23);
            txbPassword.TabIndex = 1;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 11);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu :";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPassword);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(499, 39);
            panel4.TabIndex = 4;
            // 
            // txbNewPassword
            // 
            txbNewPassword.Location = new Point(146, 7);
            txbNewPassword.Name = "txbNewPassword";
            txbNewPassword.Size = new Size(339, 23);
            txbNewPassword.TabIndex = 1;
            txbNewPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 11);
            label4.Name = "label4";
            label4.Size = new Size(121, 19);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới :";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReEnterNewPassword);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 208);
            panel5.Name = "panel5";
            panel5.Size = new Size(499, 39);
            panel5.TabIndex = 5;
            // 
            // txbReEnterNewPassword
            // 
            txbReEnterNewPassword.Location = new Point(146, 7);
            txbReEnterNewPassword.Name = "txbReEnterNewPassword";
            txbReEnterNewPassword.Size = new Size(339, 23);
            txbReEnterNewPassword.TabIndex = 1;
            txbReEnterNewPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 11);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(355, 253);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(436, 253);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(528, 286);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAccountProfile";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private TextBox txbUsername;
        private Label label2;
        private Panel panel1;
        private TextBox txbDisplayName;
        private Label label1;
        private Panel panel2;
        private TextBox txbPassword;
        private Label label3;
        private Panel panel4;
        private TextBox txbNewPassword;
        private Label label4;
        private Panel panel5;
        private TextBox txbReEnterNewPassword;
        private Label label5;
        private Button btnUpdate;
        private Button btnExit;
    }
}