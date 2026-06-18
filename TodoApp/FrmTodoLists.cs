using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Falcon;
using TodoApp;

namespace TodoApp
{
    public partial class FrmTodoLists : Form
    {

        public FrmTodoLists()
        {
            InitializeComponent();
            dgvListView();
        }

        private int _selectedTaskID = 0;

        private void FrmTodoLists_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + UserSession.FullName;

            debounce = new System.Windows.Forms.Timer();
            debounce.Interval = 500; //by ms
            debounce.Tick += debounceTimer_Tick;

            LoadTask();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (logout == DialogResult.Yes)
            {
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Close();
            }
        }

        public void LoadTask()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    string data = @"SELECT taskID, Done, TaskName, DueDate, Priority
                                FROM todolists
                                WHERE usersID = @usersID
                                ORDER BY DueDate ASC";

                    using (var cmd = new MySqlCommand(data, conn))
                    {
                        cmd.Parameters.AddWithValue("@usersID", UserSession.UserID);

                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgvLists.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Tasks:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLists.CurrentRow == null) return;

            var idCell = dgvLists.CurrentRow.Cells["TaskID"].Value;

            if (idCell != null && int.TryParse(idCell.ToString(), out int id))
            {
                _selectedTaskID = id;
            }
        }

        private void dgvListView()
        {
            dgvLists.AutoGenerateColumns = false;
            dgvLists.Columns["Done"].DataPropertyName = "Done";
            dgvLists.Columns["TaskID"].DataPropertyName = "taskID";
            dgvLists.Columns["TaskName"].DataPropertyName = "TaskName";
            dgvLists.Columns["DueDate"].DataPropertyName = "DueDate";
            dgvLists.Columns["Priority"].DataPropertyName = "Priority";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (_selectedTaskID == 0)
            {
                MessageBox.Show("Please select a task first.",
                                "No Selection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int taskID = Convert.ToInt32(dgvLists.CurrentRow.Cells["TaskID"].Value);

            ToggleTask(taskID);
        }

        private void dgvLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLists.Columns["Done"].Index &&
                e.RowIndex >= 0)
            {
                int taskID = Convert.ToInt32(
                    dgvLists.Rows[e.RowIndex].Cells["TaskID"].Value);

                ToggleTask(taskID);
            }
        }

        private void ToggleTask(int taskID)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE todolists
                           SET Done = NOT Done
                           WHERE taskID = @taskID
                           AND usersID = @usersID";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@taskID", taskID);
                        cmd.Parameters.AddWithValue("@usersID", UserSession.UserID);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadTask(); // Refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating task:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private System.Windows.Forms.Timer debounce;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            debounce.Stop();
            debounce.Start();
        }

        private void debounceTimer_Tick(object? sender, EventArgs e)
        {
            debounce.Stop();

            string search = txtSearch.Text.Trim();

            //same logic with the search button but now it will be automatically will be triggered
            if (string.IsNullOrEmpty(search))
            {
                LoadTask();
            }
            else
            {
                Search(search);
            }
        }

        private void Search(string search)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT taskID, Done, TaskName, DueDate, Priority
                                   FROM todolists
                                   WHERE usersID = @usersID
                                   AND (
                                        TaskName LIKE @search
                                        OR Priority LIKE @search
                                        OR DATE_FORMAT(DueDate, '%Y-%m-%d') LIKE @search
                                   )
                                   ORDER BY DueDate ASC";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@usersID", UserSession.UserID);
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                        using (var ad = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            ad.Fill(dt);

                            dgvLists.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Searching Tasks:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvLists_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int taskID = Convert.ToInt32(dgvLists.CurrentRow.Cells["TaskID"].Value);

            using (AddTasks frm = new AddTasks(taskID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadTask();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLists.CurrentRow == null)
            {
                MessageBox.Show("Please select a task first.");
                return;
            }

            int taskID = Convert.ToInt32(
                dgvLists.CurrentRow.Cells["TaskID"].Value);

            DeleteTask(taskID);
        }

        private void DeleteTask(int taskID)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this task?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = @"DELETE FROM todolists
                           WHERE taskID = @taskID
                           AND usersID = @usersID";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@taskID", taskID);
                        cmd.Parameters.AddWithValue("@usersID", UserSession.UserID);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Task deleted successfully.",
                                            "Deleted",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            LoadTask();

                            // Reset selected task
                            _selectedTaskID = 0;
                        }
                        else
                        {
                            MessageBox.Show("Task not found or you don't have permission to delete it.",
                                            "Delete Failed",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting task:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddTasks frm = new AddTasks())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadTask();
                }
            }
        }
    }
}
