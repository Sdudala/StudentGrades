namespace StudentGrades
{
    partial class GradeSummaryForm
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
            this.gradeSummary = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Physics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chemistry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OverallGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gradeSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeSummary
            // 
            this.gradeSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Grade});
            this.gradeSummary.Location = new System.Drawing.Point(160, 34);
            this.gradeSummary.Name = "gradeSummary";
            this.gradeSummary.Size = new System.Drawing.Size(372, 131);
            this.gradeSummary.TabIndex = 0;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Overall Grade";
            this.Grade.Name = "Grade";
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(242, 199);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(177, 39);
            this.view.TabIndex = 1;
            this.view.Text = "View All Grades";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // Student
            // 
            this.Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Math,
            this.Physics,
            this.Chemistry,
            this.OverallGrade});
            this.Student.Location = new System.Drawing.Point(80, 267);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(545, 71);
            this.Student.TabIndex = 2;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Student Name";
            this.FullName.Name = "FullName";
            // 
            // Math
            // 
            this.Math.HeaderText = "Math";
            this.Math.Name = "Math";
            // 
            // Physics
            // 
            this.Physics.HeaderText = "Physics";
            this.Physics.Name = "Physics";
            // 
            // Chemistry
            // 
            this.Chemistry.HeaderText = "Chemistry";
            this.Chemistry.Name = "Chemistry";
            // 
            // OverallGrade
            // 
            this.OverallGrade.HeaderText = "Overall Grade";
            this.OverallGrade.Name = "OverallGrade";
            // 
            // GradeSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 375);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.view);
            this.Controls.Add(this.gradeSummary);
            this.Name = "GradeSummaryForm";
            this.Text = "Grade Summary Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gradeSummary;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.DataGridView Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Math;
        private System.Windows.Forms.DataGridViewTextBoxColumn Physics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chemistry;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverallGrade;
    }
}

