using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using TodoApp;

namespace TodoApp
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(!Validation())
            {
                return;
            }

            AddUser();
        }

        private void AddUser()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO users
                       (FullName, username, password)
                   VALUES
                       (@FullName, @username, @password);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful.",
                                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearFields();
                            conn.Close();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customer:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Registration",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required.", "Registration",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required.", "Registration",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtReenter.Text))
            {
                MessageBox.Show("Please Re-Enter your password.", "Registration",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReenter.Focus();
                return false;
            }

            return true;
        }

        public void ClearFields()
        {
            txtFullName.Clear();
            txtPassword.Clear();
            txtReenter.Clear();
            txtUsername.Clear();
            txtFullName.Focus();
        }

        private void CheckPasswords(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReenter.Text))
            {
                lblPasswordStatus.Text = "";
                return;
            }

            if (txtPassword.Text == txtReenter.Text)
            {
                lblPasswordStatus.Text = "✔ Passwords match";
                lblPasswordStatus.ForeColor = Color.Green;
            }
            else
            {
                lblPasswordStatus.Text = "❌ Passwords do not match";
                lblPasswordStatus.ForeColor = Color.Red;
            }
        }
    }
}
