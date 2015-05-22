using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    public class Assignment
    {

        private String name;
        private int grade;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }
}
