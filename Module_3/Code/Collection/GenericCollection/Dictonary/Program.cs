using System;
using System.Collections.Generic;

namespace Dictonary
{
    class Student
    {
        Dictionary<int, string> data = new Dictionary<int, string>();

        #region Constructor
        public Student(Dictionary<int, string> studentData)
        {
            this.data = studentData;
        }
        #endregion Constructor

        #region Get Studnet Data
        public Dictionary<int,string> getStudents()
        {
            return this.data;
        }
        #endregion Get Studnet Data
    }
    class Program
    {
        static void Main(string[] args)
        {
            //dictionary has key and value.
            //below we have created Dictionary.
            Dictionary<int, string> student = new Dictionary<int, string>();
            
            //we can add data using add method.
            student.Add(1, "Keyur Adhyaru");
            student.Add(2, "Om Joshi");
            student.Add(3, "Parth Jethani");

            //class object created.
            var objStudent = new Student(student);
            var studentData = objStudent.getStudents();

            foreach(var i in studentData)
            {
                Console.WriteLine("Key is - {0} And Value is - {1}", i.Key, i.Value);
            }

        }
    }
}
