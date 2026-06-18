namespace TodoApp
{
    partial class frmLogin
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            label1 = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            btnExit = new Button();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(155, 221);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(198, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(155, 277);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(198, 27);
            txtPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(71, 228);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(76, 280);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 261);
            label1.Name = "label1";
            label1.Size = new Size(184, 43);
            label1.TabIndex = 4;
            label1.Text = "WELCOME";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SpringGreen;
            btnLogin.Location = new Point(55, 342);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(325, 49);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkTurquoise;
            btnRegister.Location = new Point(55, 412);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(325, 49);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(389, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(44, 28);
            btnExit.TabIndex = 7;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 139);
            label2.Name = "label2";
            label2.Size = new Size(358, 43);
            label2.TabIndex = 8;
            label2.Text = "LOGIN INFORMATION";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Bisque;
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Gainsboro;
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(btnExit);
            splitContainer1.Panel2.Controls.Add(txtUsername);
            splitContainer1.Panel2.Controls.Add(btnRegister);
            splitContainer1.Panel2.Controls.Add(txtPassword);
            splitContainer1.Panel2.Controls.Add(btnLogin);
            splitContainer1.Panel2.Controls.Add(lblUsername);
            splitContainer1.Panel2.Controls.Add(lblPassword);
            splitContainer1.Size = new Size(671, 616);
            splitContainer1.SplitterDistance = 223;
            splitContainer1.TabIndex = 8;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 616);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Information";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Label label1;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnExit;
        private Label label2;
        private SplitContainer splitContainer1;
    }
}
