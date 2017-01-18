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
        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }
        public string University
        {
            get { return this.university; }
            set { this.university = value; }
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
        public Student()
        {
            this.full_name = "Jane Doe";
            this.course = "no courses yet";
            this.subject = "no subject yet";
            this.university = "undefined university";
            this.email = "janedoe@email.com";
            this.phone_number = 0000000000;
        }

        public Student(string fullname)
        {
            this.full_name = fullname;
        }

        public Student(string fullname, string email, int phonenumber)
        {
            this.email = email;
            this.phone_number = phonenumber;
            this.full_name = fullname;
        }

        public Student (string course, string subject, string university)
        {
            this.course = course;
            this.subject = subject;
            this.university = university;
        }

        public Student (string fullname, string course, string subject, string university, string email, int phonenumber)
        {
            this.email = email;
            this.phone_number = phonenumber;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.full_name = fullname;
        }

        //methods
        public void DisplayStudentContactInfo()
        {
            Console.WriteLine("The students name is " + full_name + ", and email address is " + email + ", and phone number is " + phone_number + ".");
        }
    }
}
