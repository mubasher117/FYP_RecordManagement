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
        public static void SetStudents(List<Student> newStudents)
        {
            students.Clear();
            students = newStudents;

        }
    }
}
