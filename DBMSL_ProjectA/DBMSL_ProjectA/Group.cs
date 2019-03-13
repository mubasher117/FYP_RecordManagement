using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSL_ProjectA
{
    class Group
    {
        private int groupId;
        private DateTime createdOn;
        private List<Student> groupStudents = new List<Student>();


        public int GroupId { get => groupId; set => groupId = value; }
        public DateTime CreatedOn { get => createdOn; set => createdOn = value; }

        public void AddGroupStudent(Student student)
        {
            groupStudents.Add(student);
        }
        public List<Student> GetGroupStudents()
        {
            return groupStudents;
        }
    }
}
