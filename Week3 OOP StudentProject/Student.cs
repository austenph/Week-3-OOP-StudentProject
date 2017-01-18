using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_OOP_StudentProject
{
    class Student
    {
        //fields
        private string full_name;
        private string course;
        private string subject;
        private string university;
        private string email;
        private int phone_number;

        //properties
        public string FullName
        {
            get { return this.full_name; }
            set { this.full_name = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int PhoneNumber
        {
            get { return this.phone_number; }
            set { this.phone_number = value; }
        }

        //constructors
        public Student ( )
        {
            this.full_name = "Jane Doe";
            this.course = "no courses yet";
            this.subject = "no subject yet";
            this.university = "undefined university";
            this.email = "janedoe@email.com";
            this.phone_number = "000-000-0000";
                }

        public Student (string course, string subject, string university)
        {
            this.course = course;
            this.subject = subject;
            this.university = university;
        }

        //methods
    }
}
