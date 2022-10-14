using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    public class Student : IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }
        // compare for the sorting the list with any column
        public int CompareTo(Student other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
        }
    }
    public class CompareStudents : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }

    public class TestStudent
    {
        static void Main()
        {
            Student s1 = new Student { Sid = 1, Name = "Ajay", Class = 10, Marks = 575.00f };
            Student s2 = new Student { Sid = 2, Name = "stuart", Class = 10, Marks = 535.00f };
            Student s3 = new Student { Sid = 3, Name = "Williams", Class = 10, Marks = 592.00f };
            Student s4 = new Student { Sid = 4, Name = "Venkat", Class = 10, Marks = 453.00f };
            Student s5 = new Student { Sid = 5, Name = "David", Class = 10, Marks = 512.00f };
            Student s6 = new Student { Sid = 6, Name = "John", Class = 10, Marks = 498.00f };
            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6 };
            //by using icoparer
            CompareStudents obj = new CompareStudents();
            students.Sort(obj);
            //by icompareble
            //students.Sort();
            //for reverse order use
            //students.Reverse();
            foreach (Student S in students)
            {
                Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);
            }
            Console.ReadLine();
        }
    }
}
