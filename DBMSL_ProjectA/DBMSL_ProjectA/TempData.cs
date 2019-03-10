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
        private static ArrayList students = new ArrayList();

        public static ArrayList GetStudents (){ return students; }
        public static void SetStudents(ArrayList newStudents)
        {
            students.Clear();
            students = newStudents;

        }
    }
}
