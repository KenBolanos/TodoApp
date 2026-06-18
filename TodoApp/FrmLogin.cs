using MySql.Data.MySqlClient;
using TodoApp;

namespace TodoApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    string login = @"SELECT usersID, FullName FROM users
                                     WHERE username = @username AND password = @password;";

                    using (var cmd = new MySqlCommand(login, conn)) 
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        using (var read = cmd.ExecuteReader()) 
                        {
                            if (read.Read())
                            {
                                UserSession.UserID = Convert.ToInt32(read["usersID"]);
                                UserSession.FullName = read["FullName"].ToString();

                                MessageBox.Show(
                                    "Login Successful.",
                                    "Login Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                FrmTodoLists frm = new FrmTodoLists();
                                frm.Show();
                                this.Hide();

                                txtUsername.Clear();
                                txtPassword.Clear();
                                
                                conn.Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Invalid username or password.\nPlease try again.",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                txtPassword.Clear();
                                txtPassword.Focus();

                                //closing connection after error
                                conn.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database error:\n" + ex.Message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required.", "Registration",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required.", "Registration",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            return true;
        }

        public void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            frm.ShowDialog();
        }

        public void btnExit_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
    }
}
