using MySql.Data.MySqlClient;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using TodoApp;

namespace TodoApp
{
    public partial class MyAnalytics : Form
    {
        public MyAnalytics()
        {
            InitializeComponent();
        }

        private void MyAnalytics_Load(object sender, EventArgs e)
        {
            MonthlyEvaluation();
            DoneUndone();
            UpdatePerformanceLabel();
        }

        private void UpdatePerformanceLabel()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT SUM(CASE WHEN Done = 1 THEN 1 ELSE 0 END) AS TasksDone,
                                  COUNT(*) AS TotalTasks
                           FROM   todolists
                           WHERE  usersID = @user;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", UserSession.UserID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                long tasksDone = reader.GetInt64("TasksDone");
                                long totalTasks = reader.GetInt64("TotalTasks");

                                double performance = totalTasks > 0 ? (double)tasksDone / totalTasks * 100.0 : 0;

                                lblEval.Text = $"Monthly Evaluation Percentage: {performance:F1}%";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating performance:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MonthlyEvaluation()
        {
            try
            {
                var months = new List<string>();
                var done = new List<double>();

                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT DATE_FORMAT(DueDate, '%Y-%m') AS DueDate,
                                  COUNT(Done) AS MonthlyDone
                           FROM   todolists
                           WHERE  Done = 1 AND usersID = @user
                           GROUP  BY DueDate
                           ORDER  BY MIN(DueDate);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", UserSession.UserID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime parsed = DateTime.ParseExact(reader.GetString("DueDate"), "yyyy-MM", CultureInfo.InvariantCulture);
                                months.Add(parsed.ToString("MMMM yyyy", CultureInfo.InvariantCulture));
                                done.Add(reader.GetInt64("MonthlyDone"));
                            }
                        }
                    }
                }

                plotMonthly.Plot.Clear();

                double[] values = done.ToArray();

                double[] positions = new double[months.Count];
                for (int i = 0; i < months.Count; i++) positions[i] = i;

                var linePlot = plotMonthly.Plot.Add.Scatter(positions, values);

                plotMonthly.Plot.Axes.Bottom.SetTicks(positions, months.ToArray());

                plotMonthly.Plot.Title("Monthly Evaluation (Tasks Done)");
                plotMonthly.Plot.YLabel("EVALUATION");
                plotMonthly.Plot.XLabel("Month");

                plotMonthly.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading monthly evaluation chart:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoneUndone()
        {
            try
            {
                int done = 0;
                int uncomplete = 0;

                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT Done, COUNT(*) AS DoneCount
                           FROM   todolists
                           WHERE usersID = @user
                           GROUP  BY Done;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", UserSession.UserID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int status = reader.GetInt32("Done");
                                int count = reader.GetInt32("DoneCount");

                                if (status == 1) done = count;
                                if (status == 0) uncomplete = count;
                            }
                        }
                    }
                }

                plotDone.Plot.Clear();

                double[] values = { done, uncomplete };
                string[] labels = { "Done", "Uncomplete" };

                var pie = plotDone.Plot.Add.Pie(values);
                for (int i = 0; i < pie.Slices.Count; i++)
                {
                    pie.Slices[i].Label = labels[i];
                }

                plotDone.Plot.Title("Done vs Uncomplete Tasks");
                plotDone.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Done/Uncomplete chart:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
