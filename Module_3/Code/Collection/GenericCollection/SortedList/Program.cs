using System;
using System.Collections.Generic;

namespace SortedList
{
    class Student
    {
        SortedList<int, string> data = new SortedList<int, string>();

        #region Constructor
        public Student(SortedList<int, string> studentData)
        {
            this.data = studentData;
        }
        #endregion Constructor

        #region Get Studnet Data
        public SortedList<int, string> getStudents()
        {
            return this.data;
        }
        #endregion Get Studnet Data
    }

    class Program
    {
        static void Main(string[] args)
        {
            //sortedlist has key and value.
            //below we have created sortedlist.
            SortedList<int, string> student = new SortedList<int, string>();

            //we can add data using add method.
            student.Add(1, "Keyur Adhyaru");
            student.Add(2, "Om Joshi");
            student.Add(3, "Parth Jethani");

            //class object created.
            var objStudent = new Student(student);
            var studentData = objStudent.getStudents();

            foreach (var i in studentData)
            {
                Console.WriteLine("Key is - {0} And Value is - {1}", i.Key, i.Value);
            }
        }
    }
}
