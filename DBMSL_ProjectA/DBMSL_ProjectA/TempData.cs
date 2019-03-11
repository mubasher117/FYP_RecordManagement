using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DBMSL_ProjectA
{
    class TempData
    {
        private static List<Student> students = new List<Student>();
        private static List<Student> CurrentGroupStudents = new List<Student>();

        public static void SetStudents(List<Student> newStudents)
        {
            students.Clear();
            students = newStudents;

        }
        public static List<Student> GetGroupStudents()
        {
            return CurrentGroupStudents;
        }
        public static void add_GroupStudent(Student s)
        {
            CurrentGroupStudents.Add(s);
        }
        public static void Clear_GroupStudents()
        {
            CurrentGroupStudents.Clear();
        }
    }
}
