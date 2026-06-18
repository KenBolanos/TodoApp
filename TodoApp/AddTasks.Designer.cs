namespace TodoApp
{
    partial class AddTasks
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
            dtpDueDate = new DateTimePicker();
            txtTaskName = new TextBox();
            cmbPriority = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            lblTaskName = new Label();
            lblDueDate = new Label();
            lblPrio = new Label();
            SuspendLayout();
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(127, 144);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 0;
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(127, 85);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(250, 27);
            txtTaskName.TabIndex = 1;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cmbPriority.Location = new Point(127, 207);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(151, 28);
            cmbPriority.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DeepSkyBlue;
            btnSave.Location = new Point(31, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 51);
            btnSave.TabIndex = 3;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Khaki;
            btnCancel.Location = new Point(262, 283);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 51);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(130, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(148, 35);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "ADD TASK";
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(23, 88);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(83, 20);
            lblTaskName.TabIndex = 6;
            lblTaskName.Text = "Task Name:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(31, 149);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(75, 20);
            lblDueDate.TabIndex = 7;
            lblDueDate.Text = "Due Date:";
            // 
            // lblPrio
            // 
            lblPrio.AutoSize = true;
            lblPrio.Location = new Point(47, 210);
            lblPrio.Name = "lblPrio";
            lblPrio.Size = new Size(59, 20);
            lblPrio.TabIndex = 8;
            lblPrio.Text = "Priority:";
            // 
            // AddTasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(411, 389);
            Controls.Add(lblPrio);
            Controls.Add(lblDueDate);
            Controls.Add(lblTaskName);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbPriority);
            Controls.Add(txtTaskName);
            Controls.Add(dtpDueDate);
            Name = "AddTasks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Tasks";
            Load += AddTasks_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDueDate;
        private TextBox txtTaskName;
        private ComboBox cmbPriority;
        private Button btnSave;
        private Button btnCancel;
        private Label lblTitle;
        private Label lblTaskName;
        private Label lblDueDate;
        private Label lblPrio;
    }
}