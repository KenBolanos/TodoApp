namespace TodoApp
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
            splitContainer1 = new SplitContainer();
            lblName = new Label();
            lblPasswordStatus = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblReenter = new Label();
            txtReenter = new TextBox();
            btnBack = new Button();
            btnRegister = new Button();
            lblTitle = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Maroon;
            splitContainer1.Panel1.Controls.Add(lblName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.AntiqueWhite;
            splitContainer1.Panel2.Controls.Add(lblPasswordStatus);
            splitContainer1.Panel2.Controls.Add(lblFullName);
            splitContainer1.Panel2.Controls.Add(txtFullName);
            splitContainer1.Panel2.Controls.Add(lblReenter);
            splitContainer1.Panel2.Controls.Add(txtReenter);
            splitContainer1.Panel2.Controls.Add(btnBack);
            splitContainer1.Panel2.Controls.Add(btnRegister);
            splitContainer1.Panel2.Controls.Add(lblTitle);
            splitContainer1.Panel2.Controls.Add(lblPassword);
            splitContainer1.Panel2.Controls.Add(lblUsername);
            splitContainer1.Panel2.Controls.Add(txtPassword);
            splitContainer1.Panel2.Controls.Add(txtUsername);
            splitContainer1.Size = new Size(589, 582);
            splitContainer1.SplitterDistance = 196;
            splitContainer1.TabIndex = 18;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblName.Location = new Point(24, 231);
            lblName.Name = "lblName";
            lblName.Size = new Size(149, 46);
            lblName.TabIndex = 0;
            lblName.Text = "C# APP";
            // 
            // lblPasswordStatus
            // 
            lblPasswordStatus.AutoSize = true;
            lblPasswordStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPasswordStatus.Location = new Point(100, 341);
            lblPasswordStatus.Name = "lblPasswordStatus";
            lblPasswordStatus.Size = new Size(0, 25);
            lblPasswordStatus.TabIndex = 29;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(70, 164);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(79, 20);
            lblFullName.TabIndex = 28;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(155, 157);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(198, 27);
            txtFullName.TabIndex = 27;
            // 
            // lblReenter
            // 
            lblReenter.AutoSize = true;
            lblReenter.Location = new Point(15, 304);
            lblReenter.Name = "lblReenter";
            lblReenter.Size = new Size(134, 20);
            lblReenter.TabIndex = 26;
            lblReenter.Text = "Re-Enter Password:";
            // 
            // txtReenter
            // 
            txtReenter.Location = new Point(155, 301);
            txtReenter.Name = "txtReenter";
            txtReenter.PasswordChar = '*';
            txtReenter.Size = new Size(198, 27);
            txtReenter.TabIndex = 25;
            txtReenter.TextChanged += CheckPasswords;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.ForeColor = Color.Red;
            btnBack.Location = new Point(334, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(42, 39);
            btnBack.TabIndex = 24;
            btnBack.Text = "X";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkTurquoise;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Location = new Point(37, 381);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(316, 49);
            btnRegister.TabIndex = 23;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(71, 76);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(268, 43);
            lblTitle.TabIndex = 22;
            lblTitle.Text = "REGISTER NOW";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(76, 253);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 21;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(71, 208);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 20;
            lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(155, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(198, 27);
            txtPassword.TabIndex = 19;
            txtPassword.TextChanged += CheckPasswords;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(155, 201);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(198, 27);
            txtUsername.TabIndex = 18;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 581);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegister";
            Load += FrmRegister_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblReenter;
        private TextBox txtReenter;
        private Button btnBack;
        private Button btnRegister;
        private Label lblTitle;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblName;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblPasswordStatus;
    }
}