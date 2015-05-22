using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    public class StudentList : System.Collections.IEnumerable
    {

        private static StudentList studentList;
        private List<Student> students;

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public static StudentList getInstance()
        {
            if (studentList == null)
            {
                studentList = new StudentList();
            }
            return studentList;
        }

        private StudentList()
        {
            PopulateStudents();
        }

        private void PopulateStudents()
        {
            students = new List<Student>();
            string[] studentName = new string[5] { "Joe Davis", "Dan Hazel", "Seth Rogen", "John Bucchanan", "Ethan Hunt" };
            string[] assignmentName = new string[3] { "Math", "Physics", "Chemistry" };
            int studentId = 0;

            Student student;
            Assignment assign;
            Random random = new Random();

            for (int i = 0; i < studentName.Length; i++)
            {
                student = new Student();
                student.Name = studentName[i];
                student.Id = "NUID" + studentId;
                for (int j = 0; j < assignmentName.Length; j++)
                {
                    assign = new Assignment();
                    assign.Name = assignmentName[j];
                    assign.Grade = random.Next(50, 101);
                    student.AssignmentList.Add(assign);
                }
                students.Add(student);
                studentId++;
            }

        }

        public System.Collections.IEnumerator GetEnumerator()
        {

            foreach (Student student in students)
            {
                yield return student;
            }
        }
    }
}
