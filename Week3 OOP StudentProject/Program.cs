using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_OOP_StudentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student("Baby Turtle", "babyturtle1@gmail.com", 1234567890);
            newStudent.DisplayStudentContactInfo();

        }
    }
}
