using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSL_ProjectA
{
    class Student
    {
        private int personId;
        private int studentId;
        private string firstName;
        private string lastName;
        private string registrationNo;
        private string contact;
        private string email;
        private DateTime dateOfBirth;
        private int gender;

        public int PersonId { get => personId; set => personId = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string RegistrationNo { get => registrationNo; set => registrationNo = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public int Gender { get => gender; set => gender = value; }
    }
}
