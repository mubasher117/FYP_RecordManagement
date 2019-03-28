using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;

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

        public int PersonId
        {
            get => personId; set => personId = value;
        }
        public int StudentId { get => studentId; set => studentId = value; }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z ]+$"))
                {
                
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException();
                }
                
            }
        }
        public string LastName
        {
            get => lastName; set {
                if (Regex.IsMatch(value, @"^[a-zA-Z ]+$"))
            {

                lastName = value;
            }
            else
            {
                throw new ArgumentException();
            }
            }
        }
        public string RegistrationNo
        {
            get => registrationNo; set { 
            if (Regex.IsMatch(value, @"^[0-9]{4}-[A-Z]{2}-[0-9]{1,3}$"))
            {

                registrationNo = value;
            }
            else
            {
                throw new ArgumentException();
            }
            }
        }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set {
                try
                {
                    MailAddress m = new MailAddress(value);

                    email = value;
                }
                catch (FormatException)
                {
                    throw new ArgumentException();
                }

                email = value;
            } }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public int Gender { get => gender; set => gender = value; }
    }
}
