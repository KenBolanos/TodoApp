namespace TodoApp
{
    partial class MyAnalytics
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
            lblEvaluation = new Label();
            lblTask = new Label();
            lblMonthly = new Label();
            lblMy = new Label();
            btnBack = new Button();
            lblEval = new Label();
            lblDoneUndone = new Label();
            lblMonthlyTask = new Label();
            plotDone = new ScottPlot.WinForms.FormsPlot();
            plotMonthly = new ScottPlot.WinForms.FormsPlot();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Moccasin;
            splitContainer1.Panel1.Controls.Add(lblEvaluation);
            splitContainer1.Panel1.Controls.Add(lblTask);
            splitContainer1.Panel1.Controls.Add(lblMonthly);
            splitContainer1.Panel1.Controls.Add(lblMy);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Aqua;
            splitContainer1.Panel2.Controls.Add(btnBack);
            splitContainer1.Panel2.Controls.Add(lblEval);
            splitContainer1.Panel2.Controls.Add(lblDoneUndone);
            splitContainer1.Panel2.Controls.Add(lblMonthlyTask);
            splitContainer1.Panel2.Controls.Add(plotDone);
            splitContainer1.Panel2.Controls.Add(plotMonthly);
            splitContainer1.Size = new Size(970, 569);
            splitContainer1.SplitterDistance = 323;
            splitContainer1.TabIndex = 0;
            // 
            // lblEvaluation
            // 
            lblEvaluation.AutoSize = true;
            lblEvaluation.Font = new Font("Stencil", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEvaluation.Location = new Point(3, 347);
            lblEvaluation.Name = "lblEvaluation";
            lblEvaluation.Size = new Size(314, 56);
            lblEvaluation.TabIndex = 3;
            lblEvaluation.Text = "EVALUATION";
            // 
            // lblTask
            // 
            lblTask.AutoSize = true;
            lblTask.Font = new Font("Stencil", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTask.Location = new Point(68, 261);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(145, 56);
            lblTask.TabIndex = 2;
            lblTask.Text = "TASK";
            // 
            // lblMonthly
            // 
            lblMonthly.AutoSize = true;
            lblMonthly.Font = new Font("Stencil", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthly.Location = new Point(32, 169);
            lblMonthly.Name = "lblMonthly";
            lblMonthly.Size = new Size(246, 56);
            lblMonthly.TabIndex = 1;
            lblMonthly.Text = "MONTHLY";
            // 
            // lblMy
            // 
            lblMy.AutoSize = true;
            lblMy.Font = new Font("Stencil", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMy.Location = new Point(101, 70);
            lblMy.Name = "lblMy";
            lblMy.Size = new Size(91, 56);
            lblMy.TabIndex = 0;
            lblMy.Text = "MY";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightCoral;
            btnBack.Location = new Point(534, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 36);
            btnBack.TabIndex = 5;
            btnBack.Text = "<- Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblEval
            // 
            lblEval.AutoSize = true;
            lblEval.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEval.Location = new Point(49, 51);
            lblEval.Name = "lblEval";
            lblEval.Size = new Size(0, 26);
            lblEval.TabIndex = 4;
            // 
            // lblDoneUndone
            // 
            lblDoneUndone.AutoSize = true;
            lblDoneUndone.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoneUndone.Location = new Point(49, 329);
            lblDoneUndone.Name = "lblDoneUndone";
            lblDoneUndone.Size = new Size(305, 37);
            lblDoneUndone.TabIndex = 3;
            lblDoneUndone.Text = "Done and Undone";
            // 
            // lblMonthlyTask
            // 
            lblMonthlyTask.AutoSize = true;
            lblMonthlyTask.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthlyTask.Location = new Point(49, 89);
            lblMonthlyTask.Name = "lblMonthlyTask";
            lblMonthlyTask.Size = new Size(471, 37);
            lblMonthlyTask.TabIndex = 2;
            lblMonthlyTask.Text = "MONTHLY TASKS EVALUATION";
            // 
            // plotDone
            // 
            plotDone.Location = new Point(49, 369);
            plotDone.Name = "plotDone";
            plotDone.Size = new Size(582, 188);
            plotDone.TabIndex = 1;
            // 
            // plotMonthly
            // 
            plotMonthly.Location = new Point(49, 129);
            plotMonthly.Name = "plotMonthly";
            plotMonthly.Size = new Size(582, 188);
            plotMonthly.TabIndex = 0;
            // 
            // MyAnalytics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 569);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            Name = "MyAnalytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyAnalytics";
            Load += MyAnalytics_Load;
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
        private Label lblTask;
        private Label lblMonthly;
        private Label lblMy;
        private Label lblEvaluation;
        private Label lblDoneUndone;
        private Label lblMonthlyTask;
        private ScottPlot.WinForms.FormsPlot plotDone;
        private ScottPlot.WinForms.FormsPlot plotMonthly;
        private Label lblEval;
        private Button btnBack;
    }
}