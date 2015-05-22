using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    public class Student
    {
        private String id;
        private String name;
        private List<Assignment> assignmentList;

        public Student()
        {
            assignmentList = new List<Assignment>();
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Assignment> AssignmentList
        {
            get { return assignmentList; }
            set { assignmentList = value; }
        }


        public float getCumulativeGrade()
        {
            int totalSum = 0;
            float cumulativeGrade = 0;
            foreach (Assignment assignment in assignmentList)
            {
                totalSum += assignment.Grade;
            }
            cumulativeGrade = (float)totalSum / assignmentList.Count;
            return cumulativeGrade;

        }

        public override string ToString()
        {
            return id.ToString();
        }
    }
}
