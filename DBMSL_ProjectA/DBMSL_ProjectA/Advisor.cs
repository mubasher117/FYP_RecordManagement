using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSL_ProjectA
{
    class Advisor
    {
        private int AdvisorId;
        private int PersonId;
        private Student basicDetails = new Student();
        private int role;
        private int designation;
        private int salary;

        public int Designation { get => designation; set => designation = value; }
        public int Salary { get => salary; set => salary = value; }
        public int AdvisorId1 { get => AdvisorId; set => AdvisorId = value; }
        public int PersonId1 { get => PersonId; set => PersonId = value; }
        public int Role { get => role; set => role = value; }
        internal Student BasicDetails { get => basicDetails; set => basicDetails = value; }
    }
}
