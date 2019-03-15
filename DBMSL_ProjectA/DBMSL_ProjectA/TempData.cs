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
        private static Advisor currentAdvisor;
        private static Student currentStudent;
        private static int currentGroupId;
        private static Project currentProject;
        private static int currentRole;
        
        public static int CurrentGroupId { get => currentGroupId; set => currentGroupId = value; }
        internal static Advisor CurrentAdvisor { get => currentAdvisor; set => currentAdvisor = value; }
        internal static Student CurrentStudent { get => currentStudent; set => currentStudent = value; }
        internal static Project CurrentProject { get => currentProject; set => currentProject = value; }
        public static int CurrentRole { get => currentRole; set => currentRole = value; }

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