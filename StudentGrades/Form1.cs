using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGrades
{
    public partial class GradeSummaryForm : Form
    {
        private StudentList studentList;

        public GradeSummaryForm()
        {
            InitializeComponent();
            studentList = StudentList.getInstance();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Student student in studentList)
            {
                gradeSummary.Rows.Add(new object[] { student, student.Name, student.getCumulativeGrade() });
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
             Int32 selectedRowCount = gradeSummary.Rows.GetRowCount(DataGridViewElementStates.Selected);
            bool badSelection = false;
            if (selectedRowCount == 0)
            {
                MessageBox.Show("Select atleast one row");
                badSelection = true;
            }
            else if (selectedRowCount > 1)
            {
                MessageBox.Show("Select only one row");
                badSelection = true;
            }

            if (badSelection == true)
            {
                Student.Rows.Clear();
                return;
            }
           
            Student student = (Student)gradeSummary.CurrentRow.Cells[0].Value;

            if (student == null)
            {
                MessageBox.Show("Select a valid row");
                Student.Rows.Clear();
                return;
            }
            Student.Rows.Clear();
            Student.Rows.Add(new object[] { student.Name, student.AssignmentList[0].Grade, 
                                            student.AssignmentList[1].Grade, student.AssignmentList[2].Grade,
                                            student.getCumulativeGrade() });
            

        
        }
    }
}
