namespace TodoApp
{
    partial class FrmTodoLists
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
            dgvLists = new DataGridView();
            Done = new DataGridViewCheckBoxColumn();
            TaskID = new DataGridViewTextBoxColumn();
            TaskName = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            btnBack = new Button();
            btnAdd = new Button();
            btnDone = new Button();
            btnDelete = new Button();
            lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLists).BeginInit();
            SuspendLayout();
            // 
            // dgvLists
            // 
            dgvLists.AllowUserToAddRows = false;
            dgvLists.AllowUserToDeleteRows = false;
            dgvLists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLists.Columns.AddRange(new DataGridViewColumn[] { Done, TaskID, TaskName, DueDate, Priority });
            dgvLists.Location = new Point(12, 106);
            dgvLists.Name = "dgvLists";
            dgvLists.RowHeadersVisible = false;
            dgvLists.RowHeadersWidth = 51;
            dgvLists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLists.Size = new Size(704, 341);
            dgvLists.TabIndex = 0;
            dgvLists.CellContentClick += dgvLists_CellContentClick;
            dgvLists.CellDoubleClick += dgvLists_CellDoubleClick;
            dgvLists.SelectionChanged += dgvList_SelectionChanged;
            // 
            // Done
            // 
            Done.FlatStyle = FlatStyle.Flat;
            Done.HeaderText = "Done";
            Done.MinimumWidth = 6;
            Done.Name = "Done";
            Done.Resizable = DataGridViewTriState.True;
            Done.SortMode = DataGridViewColumnSortMode.Automatic;
            Done.Width = 60;
            // 
            // TaskID
            // 
            TaskID.HeaderText = "Task ID";
            TaskID.MinimumWidth = 6;
            TaskID.Name = "TaskID";
            TaskID.Width = 125;
            // 
            // TaskName
            // 
            TaskName.HeaderText = "Task Name";
            TaskName.MinimumWidth = 6;
            TaskName.Name = "TaskName";
            TaskName.Width = 250;
            // 
            // DueDate
            // 
            DueDate.HeaderText = "Due Date";
            DueDate.MinimumWidth = 6;
            DueDate.Name = "DueDate";
            DueDate.Width = 150;
            // 
            // Priority
            // 
            Priority.HeaderText = "Priority";
            Priority.MinimumWidth = 6;
            Priority.Name = "Priority";
            Priority.Width = 115;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 73);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search for a specific task";
            txtSearch.Size = new Size(439, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Location = new Point(602, 64);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(114, 36);
            btnBack.TabIndex = 2;
            btnBack.Text = "<- Logout";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSeaGreen;
            btnAdd.Location = new Point(38, 470);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 45);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Task";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.YellowGreen;
            btnDone.Location = new Point(204, 470);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(120, 45);
            btnDone.TabIndex = 4;
            btnDone.Text = "Mark as Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Yellow;
            btnDelete.Location = new Point(380, 470);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 45);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Task";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(12, 18);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 28);
            lblWelcome.TabIndex = 6;
            // 
            // FrmTodoLists
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(726, 528);
            Controls.Add(lblWelcome);
            Controls.Add(btnDelete);
            Controls.Add(btnDone);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Controls.Add(txtSearch);
            Controls.Add(dgvLists);
            Name = "FrmTodoLists";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Todo Lists";
            Load += FrmTodoLists_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLists).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLists;
        private TextBox txtSearch;
        private Button btnBack;
        private Button btnAdd;
        private Button btnDone;
        private Button btnDelete;
        private Label lblWelcome;
        private DataGridViewCheckBoxColumn Done;
        private DataGridViewTextBoxColumn TaskID;
        private DataGridViewTextBoxColumn TaskName;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn Priority;
    }
}