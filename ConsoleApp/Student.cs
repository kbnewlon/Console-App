using System;
namespace ConsoleApp
{
    public class Student
    {

        public string name;
        public string major;
        public double gpa;

        public Student(string aname, string amajor, double agpa)
        {
            name = aname;
            major = amajor;
            gpa = agpa;
        }

        public bool HasHonors()
        {
            if(gpa >= 3.5)
            {
                return true;
            }return false;
        }
    }
}
